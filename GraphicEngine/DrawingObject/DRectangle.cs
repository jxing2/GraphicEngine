using GraphicEngine.Interceptors;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicEngine.DrawingObject
{
    public class DRectangle : BaseDrawingObject
    {
        [EllipseInterceptor]
        public int Width { get; set; }



        [EllipseInterceptor]
        public int Height { get; set; }
        
        public override void Draw(Graphics graphics)
        {
            if (matrix != null)
                graphics.Transform = matrix;
            graphics.FillRectangle(MyBrush, X, Y, Width, Height);
            graphics.ResetTransform();
        }

        public override void DrawOnMove(Point point)
        {
            Width = point.X - X;
            Height = point.Y - Y;
        }
    }
}
