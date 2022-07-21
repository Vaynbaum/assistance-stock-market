using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coursework.Exeptions
{
    class AddMarketException : Exception
    {
        public AddMarketException(string message)
        : base(message)
        { }
    }
}
