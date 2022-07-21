using coursework.Controllers.Filter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coursework.Filter
{
    public class StrFieldExpr
    {
        private ILogExp logExp;
        public object FilterValue { get; set; }
        public StrFieldExpr(ILogExp expression)
        {
            logExp = expression;
        }
        public bool Compare(string firmValue)
        {
            if (FilterValue.Equals(""))
                return true;
            return logExp.Compare(FilterValue.ToString(), firmValue);
        }
    }
}
