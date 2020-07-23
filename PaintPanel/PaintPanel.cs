using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GraphicEngine;
using GraphicEngine.DrawingObject;
using System.Threading;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.IO;

namespace PaintPanel
{
    public partial class PaintPanel : UserControl
    {
        Canvas canvas = null;
        BaseDrawingObject currentDrawingObj = null;
        DText fpsTxt = new DText
        {
            MyFont = new Font("宋体", 10F),
            MyBrush = new SolidBrush(Color.FromArgb(128, Color.DarkOrchid)),
            X = 10,
            Y = 60,
        };
        Graphics g = null;
        Thread childThread = null;
        //volatile int fps = 0;

        public BaseDrawingObject inputTmp = null;

        [DllImport("psapi.dll")]
        private static extern int EmptyWorkingSet(int hProcess);

        public PaintPanel()
        {
            InitializeComponent();

            //this.SetStyle(ControlStyles.UserPaint, true);
            //this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            //this.SetStyle(ControlStyles.DoubleBuffer, true);
            //this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true);
            g = CreateGraphics();
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            canvas = new Canvas(g, this.BackColor);
            canvas.AddDrawingObject(fpsTxt);
            childThread = new Thread(new ThreadStart(Draw));
            childThread.Start();
        }

        private void Draw()
        {
            try
            {
                DateTime beforeDT = DateTime.Now;
                int tick = 0;
                while (true)
                {
                    ++tick;
                    DateTime now = DateTime.Now;
                    if (now.Subtract(beforeDT).TotalMilliseconds >= 1000)
                    {
                        //fps = tick;
                        //lb_fps.Text = tick.ToString();
                        fpsTxt.Words = String.Format("FPS : {0}", tick);
                        tick = 0;
                        beforeDT = now;
                        //CollectGarbage();
                    }
                    canvas.Draw();
                    Thread.Sleep(10);
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(string.Format("{0}\n{1}\n", ex.Message, ex.StackTrace));
                //File.AppendAllText(@"D://error.txt", string.Format("{0}\n{1}\n", ex.Message, ex.StackTrace));
            }
        }

        private void PaintPanel_Load(object sender, EventArgs e)
        {

        }

        ~PaintPanel()
        {
            childThread.Abort();
        }

        private void CollectGarbage()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            EmptyWorkingSet(Process.GetCurrentProcess().Handle.ToInt32());
        }

        private void PaintPanel_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (currentDrawingObj == null && inputTmp != null)
                {
                    inputTmp.X = e.X;
                    inputTmp.Y = e.Y;
                    canvas.AddDrawingObject(inputTmp);
                    currentDrawingObj = inputTmp;
                    inputTmp = null;
                }
                else if (currentDrawingObj is DPath)
                {
                    ((DPath)currentDrawingObj).ConfirmPoint(new Point(e.X, e.Y));
                }
                else
                {
                    currentDrawingObj = null;
                }
            }else if (e.Button == MouseButtons.Right)
            {
                if (currentDrawingObj is DPath)
                {
                    ((DPath) currentDrawingObj).ConfirmPoint(new Point(e.X, e.Y));
                    currentDrawingObj = null;
                }
            }
        }

        private void PaintPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (currentDrawingObj != null)
            {
                currentDrawingObj.DrawOnMove(e.Location);
            }
        }

        private void PaintPanel_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void PaintPanel_Paint(object sender, PaintEventArgs e)
        {
            //canvas.Draw();
        }

        private void fpsTimer_Tick(object sender, EventArgs e)
        {
            //canvas.Draw();
        }


    }
}
