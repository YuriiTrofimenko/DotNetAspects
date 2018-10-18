using PostSharp.Aspects;
using PostSharp.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AOP_Exceptions_Events.Aspects.ExceptionsA
{
    /* 1 */

    [PSerializable]
    class PrintExceptionAttribute : OnExceptionAspect
    {
        public override void OnException(MethodExecutionArgs args)
        {
            Console.WriteLine("Поймали: " + args.Exception.Message);
            
            //Console.WriteLine("Поймали");
            args.FlowBehavior = FlowBehavior.Return;
        }
    }

    /* 2 */

    /*[PSerializable]
    public class PrintExceptionAttribute : OnExceptionAspect
    {
        Type type;

        public PrintExceptionAttribute() : this(typeof(Exception))
        {
        }

        public PrintExceptionAttribute(Type type)
            : base()
        {
            this.type = type;
        }

        // Method invoked at build time.
        // Should return the type of exceptions to be handled. 
        public override Type GetExceptionType(MethodBase method)
        {
            return this.type;
        }


        public override void OnException(MethodExecutionArgs args)
        {
            Console.WriteLine("Поймали: " + args.Exception.Message);
            args.FlowBehavior = FlowBehavior.Return;
            args.ReturnValue = -1;
        }
    }*/
}
