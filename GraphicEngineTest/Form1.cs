using GraphicEngine;
using GraphicEngine.DrawingObject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicEngineTest
{
    public partial class Form1 : Form
    {
        Canvas canvas = null;
        BaseDrawingObject currentDrawingObj = null;
        public Form1()
        {
            InitializeComponent();

            //canvas = new Canvas(panel1.BackColor);
            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true);


        }
        DEllipse ellipse;

        private void bt_ellipse_Click(object sender, EventArgs e)
        {
            ellipse = new DEllipse
            {
                MyBrush = new SolidBrush(Color.FromArgb(128, Color.DarkOrchid)),
                //X = e.Location.X,
                //Y = e.Location.Y,
                Width = 20,
                Height = 20
            };
            paintPanel1.inputTmp = ellipse;
        }

        private void bt_select_Click(object sender, EventArgs e)
        {
            paintPanel1.inputTmp = null;
        }

        private void bt_rect_Click(object sender, EventArgs e)
        {
            DRectangle rect = new DRectangle
            {
                MyBrush = new SolidBrush(Color.FromArgb(128, Color.DarkOrchid)),
                //X = e.Location.X,
                //Y = e.Location.Y,
                Width = 20,
                Height = 20
            };
            paintPanel1.inputTmp = rect;
        }

        private void paintPanel1_MouseClick(object sender, MouseEventArgs e)
        {
            //base(sender, e);
            

        }

        private void bt_txt_Click(object sender, EventArgs e)
        {
            DText txt = new DText
            {
                MyBrush = new SolidBrush(Color.FromArgb(128, Color.DarkOrchid)),
                Words = tb_txt.Text
                //X = e.Location.X,
                //Y = e.Location.Y,
            };
            paintPanel1.inputTmp = txt;
        }

        private void bt_line_Click(object sender, EventArgs e)
        {
            DLine txt = new DLine
            {
                MyBrush = new SolidBrush(Color.FromArgb(128, Color.DarkOrchid))
                //X = e.Location.X,
                //Y = e.Location.Y,
            };
            paintPanel1.inputTmp = txt;
        }

        private void bt_path_Click(object sender, EventArgs e)
        {
            DPath path = new DPath
            {
                MyBrush = new SolidBrush(Color.FromArgb(128, Color.DarkOrchid))
                //X = e.Location.X,
                //Y = e.Location.Y,
            };
            paintPanel1.inputTmp = path;
        }
    }
}
