using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coursework.Exeptions
{
    class AddQuoteException : Exception
    {
        public AddQuoteException(string message)
       : base(message)
        { }
    }
}
