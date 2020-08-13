using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {


        /// <summary>
        /// 点到直线的距离 
        /// 过点（x1,y1）和点（x2,y2）的直线方程为：KX -Y + (x2y1 - x1y2)/(x2-x1) = 0
        /// 设直线斜率为K = (y2-y1)/(x2-x1),C=(x2y1 - x1y2)/(x2-x1)
        /// 点P(x0, y0)到直线AX + BY +C =0DE 距离为：d=|Ax0 + By0 + C|/sqrt(A* A + B* B)
        /// 点（x3,y3）到经过点（x1,y1）和点（x2,y2）的直线的最短距离为：
        /// distance = |K* x3 - y3 + C|/sqrt(K* K + 1)
        /// </summary>
        /// <param name="pt1"></param>
        /// <param name="pt2"></param>
        /// <param name="pt3"></param>
        /// <returns></returns>
        public static double GetMinDistance(PointF pt1, PointF pt2, PointF pt3)
        {
            double dis = 0;
            if (pt1.X == pt2.X)
            {
                dis = Math.Abs(pt3.X - pt1.X);
                return dis;
            }
            double lineK = (pt2.Y - pt1.Y) / (pt2.X - pt1.X);
            double lineC = (pt2.X * pt1.Y - pt1.X * pt2.Y) / (pt2.X - pt1.X);
            dis = Math.Abs(lineK * pt3.X - pt3.Y + lineC) / (Math.Sqrt(lineK * lineK + 1));
            return dis;

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

        [TestMethod]
        public void TestMethod1()
        {
            var res = GetMinDistance(new PointF(0, 0), new PointF(0, 100), new PointF(0, 50));
            res = GetMinDistance(new PointF(490, 248), new PointF(671, 428), new PointF(600, 359));
            res = GetMinDistance(490, 248, 671, 428, new Point(600, 359));
            Console.WriteLine(res);
        }



        [TestMethod]
        public void TestMethod2()
        {
            Matrix matrix = new Matrix();
            matrix.Rotate(1);
            Console.WriteLine(matrix.IsIdentity);
            //Console.WriteLine(res);
        }
    }
}
