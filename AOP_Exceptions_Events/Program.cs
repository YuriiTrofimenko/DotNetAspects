using AOP_Exceptions_Events.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOP_Exceptions_Events
{
    class Program
    {
        static void Main(string[] args)
        {
            //(new Customer()).StoreName(".");

            (new Customer()).StoreName(null);
        }
    }
}
