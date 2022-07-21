using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using coursework.Controllers.Filter;

namespace coursework.Fields
{
    public abstract class Field
    {
        public string NameType { get; protected set; }

        public FilterRule fRule { get; protected set; }

        public abstract FilterRule CreateRule(ILogExp expression);
        public abstract string GetValue(object obj);

    }
}
