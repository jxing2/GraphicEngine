﻿using System;
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
using System.Drawing.Drawing2D;
using System.Security.Cryptography;

namespace PaintPanel
{
    public partial class GraphView : UserControl
    {
        GraphScene scene = null;
        GraphItem currentDrawingObj = null;
        GraphItem currentSelectedObj = null;
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

        public GraphItem inputTmp = null;

        [DllImport("psapi.dll")]
        private static extern int EmptyWorkingSet(int hProcess);

        public GraphView()
        {
            InitializeComponent();

            //this.SetStyle(ControlStyles.UserPaint, true);
            //this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            //this.SetStyle(ControlStyles.DoubleBuffer, true);
            //this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true);
            g = CreateGraphics();
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            scene = new GraphScene(g, this.BackColor);
            scene.AddDrawingObject(fpsTxt);
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
                    scene.Draw();
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

        ~GraphView()
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
            
            Matrix matrix = new Matrix();
            Point[] points = new Point[1];
            points[0] = new Point(e.X, e.Y);
            if (scene.matrix != null)
            {
                matrix = scene.matrix.Clone();
                //if (matrix.IsInvertible) 
                    //matrix.Invert();
            }
            //matrix.TransformPoints(points);
            //MessageBox.Show("point[0] : " + points[0].X + "," + points[0].Y + ", E : " + e.X + "," + e.Y);
            if (e.Button == MouseButtons.Left)
            {
                if (inputTmp == null && currentDrawingObj == null) {
                    if (currentSelectedObj != null)
                    {
                        currentSelectedObj.Selected = false;
                    }
                    currentSelectedObj = scene.SelectObject(points[0].X, points[0].Y);
                    if (currentSelectedObj != null)
                    {
                        currentSelectedObj.Selected = true;
                    }
                }
                if (currentDrawingObj == null && inputTmp != null)
                {
                    inputTmp.X = points[0].X;
                    inputTmp.Y = points[0].Y;
                    //inputTmp.matrix = matrix;
                    scene.AddDrawingObject(inputTmp);
                    currentDrawingObj = inputTmp;
                    inputTmp = null;
                }
                else if (currentDrawingObj is DPath)
                {
                    ((DPath)currentDrawingObj).ConfirmPoint(new Point(points[0].X, points[0].Y));
                }
                else
                {
                    currentDrawingObj = null;
                }
            }
            else if (e.Button == MouseButtons.Right)
            {
                if (currentDrawingObj is DPath)
                {
                    ((DPath) currentDrawingObj).ConfirmPoint(new Point(points[0].X, points[0].Y));
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
            if (currentSelectedObj != null && currentSelectedObj.Selected && e.Button == MouseButtons.Left) {
                currentSelectedObj.Move(e.Location, diff);
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

        public void SetMatrix(Matrix matrix)
        {
            scene.matrix = matrix;
        }
        public Matrix GetMatrix()
        {
            if (scene.matrix == null)
                scene.matrix = new Matrix();
            return scene.matrix;
        }
        
        private void PaintPanel_Resize(object sender, EventArgs e)
        {
            scene.Resize(this.Width, this.Height);
        }

        private void GraphView_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void GraphView_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void GraphView_KeyUp(object sender, KeyEventArgs e)
        {

        }
        Point diff = new Point();
        private void GraphView_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (inputTmp == null && currentDrawingObj == null)
                {
                    if (currentSelectedObj != null)
                    {
                        currentSelectedObj.Selected = false;
                    }
                    currentSelectedObj = scene.SelectObject(e.X, e.Y);
                    if (currentSelectedObj != null)
                    {
                        currentSelectedObj.Selected = true;
                        diff = currentSelectedObj.GetDiff(e.Location);
                    }
                }
            }
        }
    }
}