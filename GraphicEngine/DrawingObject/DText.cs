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
            if (Matrix != null && mtx != null)
            {
                var tmpMatrix = Matrix.Clone();
                tmpMatrix.Multiply(mtx, MatrixOrder.Append);
                graphics.Transform = tmpMatrix;
            }
            else if (mtx != null)
            {
                graphics.Transform = mtx;
            }
            else if (Matrix != null)
            {
                graphics.Transform = Matrix;
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
            return false;
        }

        public override void Move(Point point, Point vector)
        {
            throw new NotImplementedException();
        }

        public override Point GetDiff(Point point)
        {
            throw new NotImplementedException();
        }
    }
}
