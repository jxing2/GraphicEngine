using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.Threading;
using GraphicEngine.DrawingObject;
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

        Queue queue = new Queue(2000000);
        ArrayList list = new ArrayList();
        int count = 20000;
        //List<int> list = new List<int>();
        public void ForeachTask()
        {
            try
            {
                //while (true)
                //{
                //    //lock (list)
                //    //{
                //    //    foreach (Object item in list)
                //    //    {
                //    //        if (item.ToString().Equals("0"))
                //    //            continue;
                //    //        Console.WriteLine(item);
                //    //    }
                //    //}
                //    if (list.Count == 30)
                //        break;
                //}

                for(int i = 0; i < count; ++i)
                {
                    if (i % 2 == 0)
                        queue.Enqueue(i);
                }

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void AddTask()
        {
            try
            {
                //int i = 100000;
                for (int i = 0; i < count; ++i)
                {
                    if (i % 2 == 1)
                        queue.Enqueue(i);
                    //Thread.Sleep(1);
                }
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        [TestMethod]
        public void TestThreadSafe()
        {
            ThreadStart ts1 = new ThreadStart(ForeachTask);
            ThreadStart ts2 = new ThreadStart(AddTask);
            Thread thread1 = new Thread(ts1);
            Thread thread2 = new Thread(ts2);
            thread1.Start();
            thread2.Start();
            thread1.Join();
            thread2.Join();
            Console.WriteLine(queue.Count);
        }


        [TestMethod]
        public void TestObjectSet()
        {
            HashSet<GraphItem> set1 = new HashSet<GraphItem>();
            GraphItem item1 = new DLine();
            GraphItem item2 = new DLine();
            set1.Add(item2);
            set1.Add(item1);
            if (set1.Contains(item2))
            {
                Console.WriteLine("Contains");
            }
        }
    }
}
