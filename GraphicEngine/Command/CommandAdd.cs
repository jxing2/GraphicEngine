using GraphicEngine.DrawingObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicEngine.Command
{
    public class CommandAdd : Command
    {
        public GraphItem item { get; set; }
        public override void Redo()
        {
            if (item.Parent == null || item.Parent.Children.Contains(item))
                return;
            item.Parent.Children.Add(item);
        }

        public override void Undo()
        {
            if (item == null || item.Parent == null)
                return;
            item.Parent.Children.Remove(item);
        }
    }
}
