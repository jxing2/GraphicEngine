using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicEngine.DrawingObject
{
    public class DLine : GraphItem
    {

        public int X2 { get; set; }
        public int Y2 { get; set; }

        internal override void OnDraw(Graphics graphics, Matrix mtx)
        {
            if (matrix != null && mtx != null)
            {
                var tmpMatrix = matrix.Clone();
                tmpMatrix.Multiply(mtx, MatrixOrder.Append);
                graphics.Transform = tmpMatrix;
            }
            else if (mtx != null)
            {
                graphics.Transform = mtx;
            }
            else if (matrix != null)
            {
                graphics.Transform = matrix;
            }
            if (MyPen == null && MyBrush != null) {
                MyPen = new Pen(MyBrush);
            }
            graphics.DrawLine(MyPen, X, Y, X2, Y2);
            if (Selected)
            {
                graphics.DrawEllipse(MyPen, X - 1, Y - 1, 2, 2);
                graphics.DrawEllipse(MyPen, X2 - 1, Y2 - 1, 2, 2);
            }
        }



        public override void DrawOnMove(Point point)
        {
            X2 = point.X;
            Y2 = point.Y;
        }

        public override bool IsContain(Point point)
        {
            throw new NotImplementedException();
        }
    }
}
