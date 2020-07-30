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

        private void bt_rotate_Click(object sender, EventArgs e)
        {
            string rotate_str = tb_rotate.Text;
            string rotate_x_str = tb_rotate_x.Text;
            string rotate_y_str = tb_rotate_y.Text;
            int rotate = int.Parse(rotate_str);
            int rotate_x = int.Parse(rotate_x_str);
            int rotate_y = int.Parse(rotate_y_str);
            var matrix = paintPanel1.GetMatrix();
            if (matrix == null)
                matrix = new System.Drawing.Drawing2D.Matrix();
            matrix.RotateAt(rotate, new PointF(rotate_x, rotate_y));
            paintPanel1.SetMatrix(matrix);
        }

        private void bt_scale_Click(object sender, EventArgs e)
        {
            string scale_x_str = tb_scale_x.Text;
            string scale_y_str = tb_scale_y.Text;
            float scale_x = int.Parse(scale_x_str);
            float scale_y = int.Parse(scale_y_str);
            var matrix = paintPanel1.GetMatrix();
            if (matrix == null)
                matrix = new System.Drawing.Drawing2D.Matrix();
            matrix.Scale(scale_x/100, scale_y/100);
            paintPanel1.SetMatrix(matrix);
        }

        private void bt_all_move_Click(object sender, EventArgs e)
        {
            string move_x_str = tb_all_move_x.Text;
            string move_y_str = tb_all_move_y.Text;
            float move_x = int.Parse(move_x_str);
            float move_y = int.Parse(move_y_str);
            var matrix = paintPanel1.GetMatrix();
            if (matrix == null)
                matrix = new System.Drawing.Drawing2D.Matrix();
            matrix.Translate(move_x, move_y);
            paintPanel1.SetMatrix(matrix);
        }
    }
}
