using GraphicEngine.DrawingObject;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
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

        BufferedGraphicsContext ctx;
        BufferedGraphics graphBuffer;
        Bitmap bitmap;
        public Matrix matrix ;

        public int Width { get; set; }
        public int Height { get; set; }

        public Canvas(Graphics g, Color ForeColor) {
            this.ForeColor = ForeColor;
            this.g = g;
            Height = 700;
            Width = 700;
            bitmap = new Bitmap(Width, Height);
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
            var tmpG = Graphics.FromImage(bitmap);
            tmpG.Clear(ForeColor);
            MoveTmpToNormal();
            
            tmpG.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            foreach (BaseDrawingObject obj in drawingObjects)
            {
                if (matrix != null)
                    tmpG.Transform = matrix;
                obj.Draw(tmpG, matrix);
            }
            
            BufferedGraphicsContext ctx = new BufferedGraphicsContext();
            BufferedGraphics graphBuffer = ctx.Allocate(g, new Rectangle(0, 0, Width, Height));
            Graphics diaplayGraphic = graphBuffer.Graphics;
            //diaplayGraphic.Clear(ForeColor);
            //if (matrix != null)
            //    diaplayGraphic.Transform = matrix;
            diaplayGraphic.Clear(ForeColor);
            diaplayGraphic.DrawImage(bitmap, 0, 0);
            
            
            graphBuffer.Render();
            graphBuffer.Dispose();
            ctx.Invalidate();
            ctx.Dispose();
        }

        public void Resize(int width, int height)
        {
            this.Width = width;
            this.Height = height;
            bitmap = new Bitmap(this.Width, this.Height);
        }
    }
}
