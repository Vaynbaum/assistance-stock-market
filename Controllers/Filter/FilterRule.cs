using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coursework.Controllers.Filter
{
    public abstract class FilterRule
    {
        public abstract object FilterVal { set; }
        public abstract bool ObjRespond(object obj);
    }
}
