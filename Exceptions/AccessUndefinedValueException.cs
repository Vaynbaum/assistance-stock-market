using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coursework.Exeptions
{
    public class AccessUndefinedValueException : Exception
    {
        public AccessUndefinedValueException(string message)
            : base(message) { }
    }
}
