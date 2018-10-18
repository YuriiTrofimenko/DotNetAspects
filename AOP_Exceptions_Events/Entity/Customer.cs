using AOP_Exceptions_Events.Aspects.ExceptionsA;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOP_Exceptions_Events.Entity
{
    /* 1 */

    class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [PrintException]
        public void StoreName(string path)
        {
            File.WriteAllText(path, string.Format( "{0} {1}", this.FirstName, this.LastName ) );
            //int x = 0, y = 0, z = 0;
            //z = x / y;
        }
    }

    /* 2 */

    /*//[PrintExceptionAttribute(typeof(IOException))]
    [PrintExceptionAttribute(typeof(UnauthorizedAccessException))]
    class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //[PrintException(typeof(IOException))]
        public void StoreName(string path)
        {
            File.WriteAllText(path, string.Format("{0} {1}", this.FirstName, this.LastName));
            //int x = 0, y = 0, z = 0;
            //z = x / y;
        }

    }*/

    /* 3 */

    /*class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [BusinesssExceptionAttribute]
        public void StoreName(string path)
        {
            File.WriteAllText(path, string.Format("{0} {1}", this.FirstName, this.LastName));
            //int x = 0, y = 0, z = 0;
            //z = x / y;
        }

    }*/
}
