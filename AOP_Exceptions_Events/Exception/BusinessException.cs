using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOP_Exceptions_Events.Exception
{
    class BusinessException : SystemException
    {
        public BusinessException(string message, SystemException innerException) : base(message, innerException)
        {
        }
    }
}
