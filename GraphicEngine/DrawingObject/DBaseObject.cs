using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicEngine.DrawingObject
{
    public class DBaseObject : GraphItem
    {
        public override void DrawOnMove(Point point)
        {
            
        }

        public override Point GetDiff(Point point)
        {
            throw new NotImplementedException();
        }

        public override bool IsContain(Point point)
        {
            return false;
        }

        public override void Move(Point point, Point vector)
        {
            throw new NotImplementedException();
        }

        internal override void OnDraw(Graphics graphics, Matrix mtx)
        {
            
        }
    }
}
