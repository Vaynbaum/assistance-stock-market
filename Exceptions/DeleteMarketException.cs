﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coursework.Exeptions
{
    class DeleteMarketException : Exception
    {
        public DeleteMarketException(string message)
       : base(message)
        { }
    }
}
