using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicEngine.DrawingObject
{
    public abstract class BaseDrawingObject
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Pen MyPen { get; set; }
        public Brush MyBrush { get; set; }
        public int Z { get; set; }

        public System.Drawing.Drawing2D.Matrix matrix { get; set; }


        /// <summary>
        /// 正常绘图
        /// </summary>
        /// <param name="graphics"></param>
        public abstract void Draw(Graphics graphics, Matrix mtx);

        /// <summary>
        /// 绘图(在鼠标移动中)
        /// </summary>
        /// <param name="graphics"></param>
        /// <param name="point"></param>
        public abstract void DrawOnMove(Point point);

    }
}
