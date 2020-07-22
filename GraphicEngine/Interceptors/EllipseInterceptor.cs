using AspectInjector.Broker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicEngine.Interceptors
{
    [Aspect(Scope.Global)]
    [Injection(typeof(EllipseInterceptor))]
    public class EllipseInterceptor : Attribute
    {
        [Advice(Kind.Before, Targets = Target.Method)]
        public void OnEntry([Argument(Source.Name)] string name)
        {
            Console.WriteLine($"Entering method {name}");
        }


        //[Advice(Kind.Before, Targets = Target.AnyMember)]
        //public void OnUpdate([Argument(Source.Name)] string name)
        //{
        //    Console.WriteLine($"Entering method {name}");
        //}
    }
}
