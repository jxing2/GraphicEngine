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
        public Pen MyPen { get; set; }
        public Brush MyBrush { get; set; }
        public int Z { get; set; }

        public bool Selected { get; set; }

        public Matrix matrix { get; set; }


        /// <summary>
        /// 正常绘图
        /// </summary>
        /// <param name="graphics"></param>
        internal abstract void OnDraw(Graphics graphics, Matrix mtx);


        protected void OnPaint(Graphics graphics, int X, int Y, int Width, int Height, Matrix mtx)
        {
        }

        internal void OnPaint(Graphics graphics, Rectangle rect, Matrix mtx)
        {
            OnDraw(graphics, mtx);
            if (Children == null)
                return;
            foreach (GraphItem gi in Children) {
                var state = graphics.Save();
                gi.OnPaint(graphics, rect, mtx);
                graphics.Restore(state);
            }
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

    }
}
