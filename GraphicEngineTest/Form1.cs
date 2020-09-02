using GraphicEngine;
using GraphicEngine.Command;
using GraphicEngine.DrawingObject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicEngineTest
{
    public partial class Form1 : Form
    {
        GraphScene canvas = null;
        GraphItem currentDrawingObj = null;
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
                Height = 20,
                Selectable = true
            };
            CommandAdd add = new CommandAdd();
            add.item = ellipse;
            paintPanel1.SetCommand(add);
        }

        private void bt_select_Click(object sender, EventArgs e)
        {
            paintPanel1.SetCommand(null);
        }

        private void bt_rect_Click(object sender, EventArgs e)
        {
            DRectangle rect = new DRectangle
            {
                MyBrush = new SolidBrush(Color.FromArgb(128, Color.DarkOrchid)),
                //X = e.Location.X,
                //Y = e.Location.Y,
                Width = 20,
                Height = 20,
                Selectable = true
            };
            CommandAdd add = new CommandAdd();
            add.item = rect;
            paintPanel1.SetCommand(add);
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
                Words = tb_txt.Text,
                Selectable = true
                //X = e.Location.X,
                //Y = e.Location.Y,
            };
            CommandAdd add = new CommandAdd();
            add.item = txt;
            paintPanel1.SetCommand(add);
        }

        private void bt_line_Click(object sender, EventArgs e)
        {
            DLine line = new DLine
            {
                MyBrush = new SolidBrush(Color.FromArgb(128, Color.DarkOrchid)),
                Selectable = true
                //X = e.Location.X,
                //Y = e.Location.Y,
            };
            CommandAdd add = new CommandAdd();
            add.item = line;
            paintPanel1.SetCommand(add);
        }

        private void bt_path_Click(object sender, EventArgs e)
        {
            DPath path = new DPath
            {
                MyBrush = new SolidBrush(Color.FromArgb(128, Color.DarkOrchid)),
                Selectable = true
                //X = e.Location.X,
                //Y = e.Location.Y,
            };
            CommandAdd add = new CommandAdd();
            add.item = path;
            paintPanel1.SetCommand(add);
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
                matrix = new Matrix();
            matrix.Scale(scale_x/100, scale_y/100);
            paintPanel1.SetMatrix(matrix);
        }

        private void bt_all_move_Click(object sender, EventArgs e)
        {
            string move_x_str = tb_all_move_x.Text;
            string move_y_str = tb_all_move_y.Text;
            float move_x = int.Parse(move_x_str);
            float move_y = int.Parse(move_y_str);
            var newM = new Matrix();
            newM.Translate(move_x, move_y);
            var matrix = paintPanel1.GetMatrix().Clone();
            matrix.Multiply(newM, MatrixOrder.Append);
            paintPanel1.SetMatrix(matrix);
        }
    }
}
