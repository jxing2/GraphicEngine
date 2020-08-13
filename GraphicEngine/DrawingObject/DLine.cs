using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicEngine.DrawingObject
{
    public class DLine : GraphItem
    {

        public int X2 { get; set; }
        public int Y2 { get; set; }

        public const double DELTA = 1.5D;





        internal override void OnDraw(Graphics graphics, Matrix mtx)
        {
            //int tmpX = X + Transform.X;
            //int tmpY = Y + Transform.Y;
            //int tmpX2 = X2 + Transform.X;
            //int tmpY2 = Y2 + Transform.Y;
            int tmpX = X ;
            int tmpY = Y ;
            int tmpX2 = X2 ;
            int tmpY2 = Y2 ;
            
            graphics.Transform = Matrix;
            //if (matrix != null && mtx != null)
            //{
            //    var tmpMatrix = matrix.Clone();
            //    tmpMatrix.Multiply(mtx, MatrixOrder.Prepend);
            //    graphics.Transform = tmpMatrix;
            //}
            //else if (mtx != null)
            //{
            //    graphics.Transform = mtx;
            //}
            //else if (matrix != null)
            //{
            //    graphics.Transform = matrix;
            //}
            if (MyPen == null && MyBrush != null) {
                MyPen = new Pen(MyBrush);
            }
            graphics.DrawLine(MyPen, tmpX, tmpY, tmpX2, tmpY2);
            if (Selected)
            {
                graphics.DrawEllipse(MyPen, tmpX - CAP_SIZE / 2, tmpY - CAP_SIZE / 2, CAP_SIZE, CAP_SIZE);
                graphics.DrawEllipse(MyPen, tmpX2 - CAP_SIZE / 2, tmpY2 - CAP_SIZE / 2, CAP_SIZE, CAP_SIZE);
            }
        }


        /// <summary>
        /// 点到直线的距离 
        /// 过点（x1,y1）和点（x2,y2）的直线方程为：KX -Y + (x2y1 - x1y2)/(x2-x1) = 0
        /// 设直线斜率为K = (y2-y1)/(x2-x1),C=(x2y1 - x1y2)/(x2-x1)
        /// 点P(x0, y0)到直线AX + BY +C =0DE 距离为：d=|Ax0 + By0 + C|/sqrt(A* A + B* B)
        /// 点（x3,y3）到经过点（x1,y1）和点（x2,y2）的直线的最短距离为：
        /// distance = |K* x3 - y3 + C|/sqrt(K* K + 1)
        /// </summary>
        /// <param name="pt1">直线的点1</param>
        /// <param name="pt2">直线的点2</param>
        /// <param name="pt3">目标点</param>
        /// <returns></returns>
        public static double GetMinDistance(int pt1X, int pt1Y, int pt2X, int pt2Y, Point pt3)
        {
            double dis = 0;
            if (pt1X == pt2X)
            {
                dis = Math.Abs(pt3.X - pt1X);
                return dis;
            }
            double lineK = (double)(pt2Y - pt1Y) / (pt2X - pt1X);
            double lineC = (double)(pt2X * pt1Y - pt1X * pt2Y) / (pt2X - pt1X);
            dis = Math.Abs(lineK * pt3.X - pt3.Y + lineC) / (Math.Sqrt(lineK * lineK + 1));
            return dis;
        }




        public override void DrawOnMove(Point point)
        {
            X2 = point.X;
            Y2 = point.Y;
        }

        public override bool IsContain(Point point)
        {
            ClickPoint[0] = point;
            TransformPoint(ClickPoint);
            double res = GetMinDistance(X, Y, X2, Y2, ClickPoint[0]);
            //MessageBox.Show(res + "");
            if (res < DELTA)
                return true;
            return false;
        }

        public override void Move(Point point, Point vector)
        {
            ClickPoint[0] = point;
            TransformPoint(ClickPoint);
            int xDiff = X2 - X;
            int yDiff = Y2 - Y;
            X = ClickPoint[0].X + vector.X;
            Y = ClickPoint[0].Y + vector.Y;
            
            X2 = X + xDiff;
            Y2 = Y + yDiff;
        }

        public override Point GetDiff(Point point)
        {
            Point[] points = new Point[1] { point };
            TransformPoint(points);
            var tmpPoint = new Point(X - points[0].X, Y - points[0].Y);
            return tmpPoint;
            //return new Point(X - point.X, Y - point.Y);
        }
    }
}
