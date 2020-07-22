using GraphicEngine.DrawingObject;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GraphicEngine
{
    public class Canvas
    {
        Color ForeColor = Color.White;
        
        Graphics g;

        public Canvas(Graphics g, Color ForeColor) {
            this.ForeColor = ForeColor;
            this.g = g;
            
        }

        ArrayList drawingObjects = new ArrayList();
        Queue queue = new Queue();

        public void AddDrawingObject(BaseDrawingObject obj) {
            queue.Enqueue(obj);
        }

        public void MoveTmpToNormal() {
            while (queue.Count > 0)
            {
                drawingObjects.Add(queue.Dequeue());
            }
        }

        public void Draw() {
            //g.Clear(ForeColor);
            Bitmap bitmap = new Bitmap(700, 700);
            var tmpG = Graphics.FromImage(bitmap);
            MoveTmpToNormal();
            foreach (BaseDrawingObject obj in drawingObjects)
            {
                tmpG.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                obj.Draw(tmpG);
            }
            BufferedGraphicsContext ctx = new BufferedGraphicsContext();
            BufferedGraphics graphBuffer = ctx.Allocate(g, new Rectangle(0, 0, 700, 700));
            Graphics diaplayGraphic = graphBuffer.Graphics;
            diaplayGraphic.Clear(ForeColor);
            diaplayGraphic.DrawImage(bitmap, 0, 0);
            graphBuffer.Render();
            graphBuffer.Dispose();
            ctx.Invalidate();
            ctx.Dispose();
        }
    }
}
