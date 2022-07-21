using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coursework.Exeptions
{
     class SetCurrentAssetException : Exception
    {
        public SetCurrentAssetException(string message)
            : base(message) { }
    }
}
