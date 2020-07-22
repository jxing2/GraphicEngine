using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicEngine.DrawingObject
{
    public class DText : BaseDrawingObject
    {
        public string Words { set; get; }

        public Font MyFont { set; get; }
        public override void Draw(Graphics graphics)
        {
            if (matrix != null)
                graphics.Transform = matrix;
            if(MyFont == null)
            {
                MyFont = new Font("宋体", 10F);
            }
            graphics.DrawString(Words, MyFont, MyBrush, X, Y);
            graphics.ResetTransform();
        }

        public override void DrawOnMove(Point point)
        {
            X = point.X;
            Y = point.Y;
        }
    }
}
