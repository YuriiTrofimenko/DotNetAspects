using AOP_Exceptions_Events.Exception;
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
    [PSerializable]
    public sealed class BusinesssExceptionAttribute : OnExceptionAspect
    {
        public override void OnException(MethodExecutionArgs args)
        {
            //args.FlowBehavior = FlowBehavior.Return;
            args.FlowBehavior = FlowBehavior.ThrowException;
            args.Exception = new BusinessException("Bad Arguments", new SystemException("One or more arguments were null."));
        }
    }
}
