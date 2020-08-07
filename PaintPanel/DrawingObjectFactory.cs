using GraphicEngine.DrawingObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintPanel
{
    public class DrawingObjectFactory
    {
        private static List<Type> classArr = new List<Type> { 
            typeof(DEllipse), 
            typeof(DRectangle), 
            typeof(DText)
        };
        public static GraphItem Create(Type type)
        {
            if (classArr.Find((Type t) => type == t) == null) {
                return null;
            }
            return Activator.CreateInstance(type) as GraphItem;
        }
    }
}
