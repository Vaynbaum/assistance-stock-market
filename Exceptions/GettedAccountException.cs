using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coursework.Exceptions
{
    public class GettedAccountException :Exception
    {
        public GettedAccountException(string message)
       : base(message)
        { }
    }
}
