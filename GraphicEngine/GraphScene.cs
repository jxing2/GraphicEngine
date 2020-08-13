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
    public class GraphScene
    {
        Color ForeColor = Color.White;
        
        Graphics g;

        BufferedGraphicsContext ctx;
        BufferedGraphics graphBuffer;
        Bitmap bitmap;
        public Matrix matrix ;
        GraphItem root = new DBaseObject();

        public int Width { get; set; }
        public int Height { get; set; }

        public GraphScene(Graphics g, Color ForeColor) {
            this.ForeColor = ForeColor;
            this.g = g;
            Height = 700;
            Width = 700;
            bitmap = new Bitmap(Width, Height);
            root.Children = new ArrayList();
        }

        ArrayList drawingObjects = new ArrayList();
        Queue queue = new Queue();

        public void AddDrawingObject(GraphItem obj) {
            queue.Enqueue(obj);
        }

        public void MoveTmpToNormal() {
            while (queue.Count > 0)
            {
                root.Children.Add(queue.Dequeue());
            }
        }


        

        public void Draw() {
            var tmpG = Graphics.FromImage(bitmap);
            tmpG.Clear(ForeColor);
            MoveTmpToNormal();
            
            tmpG.SmoothingMode = SmoothingMode.AntiAlias;
            foreach (GraphItem obj in root.Children)
            {
                var state = tmpG.Save();
                obj.OnPaint(tmpG, new Rectangle(0, 0, Width, Height), matrix);
                tmpG.Restore(state);
            }
            if (matrix != null)
                matrix.Reset();
            BufferedGraphicsContext ctx = new BufferedGraphicsContext();
            BufferedGraphics graphBuffer = ctx.Allocate(g, new Rectangle(0, 0, Width, Height));
            Graphics diaplayGraphic = graphBuffer.Graphics;
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

        public GraphItem SelectObject(int x, int y)
        {
            Point point = new Point(x, y);
            return GraphItem.Select(point, root);
        }
    }
}
