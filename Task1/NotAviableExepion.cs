using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Threading.Tasks;

namespace Task1
{
    public class NotAviableExepion : Exception
    {
        public NotAviableExepion()
        {

        }

        public NotAviableExepion(string message) : base(message)
        {
           
        }
    }
}