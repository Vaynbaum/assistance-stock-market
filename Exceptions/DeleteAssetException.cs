using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coursework.Exceptions
{
    public class DeleteAssetException : Exception
    {
        public DeleteAssetException(string message)
      : base(message)
        { }
    }
}
