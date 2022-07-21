using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coursework.Exeptions
{
    class DeleteQuoteException : Exception
    {
        public DeleteQuoteException(string message)
       : base(message)
        { }
    }
}
