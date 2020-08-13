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
    public abstract class GraphItem
    {
        public ArrayList Children { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public const int CAP_SIZE = 6;
        public Pen MyPen { get; set; }
        public Brush MyBrush { get; set; }
        public int Z { get; set; }

        public bool Selected { get; set; }

        public Matrix Matrix { get; set; }

        internal Point[] ClickPoint = new Point[1];


        /// <summary>
        /// 正常绘图
        /// </summary>
        /// <param name="graphics"></param>
        internal abstract void OnDraw(Graphics graphics, Matrix mtx);


        //protected void OnPaint(Graphics graphics, int X, int Y, int Width, int Height, Matrix mtx)
        //{
        //}
        internal void TransformPoint(Point[] points) { 
            if(Matrix != null && !Matrix.IsIdentity)
            {
                var tmpM = Matrix.Clone();
                tmpM.Invert();
                tmpM.TransformPoints(points);
            }
        }
        internal void ApplyMatrix(Matrix mtx)
        {
            if (Matrix == null)
            {
                Matrix = new Matrix();
            }
            if (mtx != null && !mtx.IsIdentity)
            {
                Matrix.Multiply(mtx, MatrixOrder.Append);
            }
        }

        internal void OnPaint(Graphics graphics, Rectangle rect, Matrix mtx)
        {
            ApplyMatrix(mtx);
            OnDraw(graphics, mtx);
            if (Children == null)
                return;
            foreach (GraphItem gi in Children) {
                var state = graphics.Save();
                gi.OnPaint(graphics, rect, mtx);
                graphics.Restore(state);
            }
        }

        public static GraphItem Select(Point point, GraphItem root)
        {
            if (root == null) {
                return null;
            }
            if (root.IsContain(point))
                return root;
            if (root.Children == null)
                return null;
            foreach (GraphItem gi in root.Children)
            {
                if(Select(point, gi) != null)
                {
                    return gi;
                }
            }
            return null;
        }


        /// <summary>
        /// 绘图(在鼠标移动中)
        /// </summary>
        /// <param name="graphics"></param>
        /// <param name="point"></param>
        public abstract void DrawOnMove(Point point);


        /// <summary>
        /// 是否点落在图形上
        /// </summary>
        /// <param name="point"></param>
        /// <returns></returns>
        public abstract bool IsContain(Point point);


        /// <summary>
        /// 将图形整体移动 向量 vector 个单位
        /// </summary>
        /// <param name="point"></param>
        public abstract void Move(Point ClickPoint, Point vector);

        /// <summary>
        /// 获取当前点与X, Y 的位移向量
        /// </summary>
        /// <param name="vector"></param>
        /// <returns></returns>
        public abstract Point GetDiff(Point point);

    }
}
