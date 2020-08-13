using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicEngine.DrawingObject
{
    public class DPath : GraphItem
    {

        private Stack<Point> points = new Stack<Point>();

        private bool hasConfirmed = false;
        public GraphicsPath MyPath { get; set; }





        /// <summary>
        /// 
        /// </summary>
        /// <param name="graphics"></param>
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
            if (MyPath == null) {
                MyPath = new GraphicsPath();
            }
            Point[] pointArr = points.ToArray();
            if (pointArr.Length == 0)
            {
                return;
            }
            else if (pointArr.Length == 1)
            {
                return;
            }
            else
            {
                if (pointArr.Length == 2)
                {
                    if (MyPen == null)
                    {
                        MyPen = new Pen(MyBrush);
                    }
                    graphics.DrawLine(MyPen, pointArr[0], pointArr[1]);
                }
                else
                {
                    MyPath.Reset();
                    MyPath.AddClosedCurve(pointArr, 0F);
                    graphics.FillPath(MyBrush, MyPath);
                }
            }
        }

        public void ConfirmPoint(Point point)
        {
            hasConfirmed = true;
            DrawOnMove(point);
        }

        public void FinishDraw(Point point)
        {
            hasConfirmed = true;
            DrawOnMove(point);
            if (points.Count < 3) { 
                
            }
        }

        public override void DrawOnMove(Point point)
        {
            if (points.Count == 0) {
                initPointsStack();
            }

            if (!hasConfirmed && points.Count > 1) {
                points.Pop();
            }
            points.Push(point);
            hasConfirmed = false;
        }

        private void initPointsStack() {
            points.Push(new Point(X, Y));
        }

        public override bool IsContain(Point point)
        {
            throw new NotImplementedException();
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
