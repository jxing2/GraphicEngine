﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicEngine.DrawingObject
{
    public class DLine : BaseDrawingObject
    {

        public int X2 { get; set; }
        public int Y2 { get; set; }

        public override void Draw(Graphics graphics, Matrix mtx)
        {
            if (matrix != null && mtx != null)
            {
                var tmpMatrix = matrix.Clone();
                tmpMatrix.Multiply(mtx, MatrixOrder.Prepend);
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
            graphics.ResetTransform();
        }

        public override void DrawOnMove(Point point)
        {
            X2 = point.X;
            Y2 = point.Y;
        }
    }
}
