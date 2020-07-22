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
    public class DPath : BaseDrawingObject
    {

        private Stack<Point> points = new Stack<Point>();

        private bool hasConfirmed = false;
        public GraphicsPath MyPath { get; set; }





        /// <summary>
        /// 
        /// </summary>
        /// <param name="graphics"></param>
        public override void Draw(Graphics graphics)
        {
            if (matrix != null)
                graphics.Transform = matrix;
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
            graphics.ResetTransform();
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
    }
}
