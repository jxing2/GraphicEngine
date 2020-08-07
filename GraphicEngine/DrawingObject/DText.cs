using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicEngine.DrawingObject
{
    public class DText : GraphItem
    {
        public string Words { set; get; }

        public Font MyFont { set; get; }
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
            if (MyFont == null)
            {
                MyFont = new Font("宋体", 10F);
            }
            graphics.DrawString(Words, MyFont, MyBrush, X, Y);
        }

        public override void DrawOnMove(Point point)
        {
            X = point.X;
            Y = point.Y;
        }

        public override bool IsContain(Point point)
        {
            throw new NotImplementedException();
        }
    }
}
