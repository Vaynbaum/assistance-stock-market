using coursework.Filter;
using coursework.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coursework.Controllers.Filter
{
    public class MICMarketRule : FilterRule
    {
        private StrFieldExpr fieldExpr;
        public override object FilterVal
        {
            set => fieldExpr.FilterValue = value;
        }

        public MICMarketRule(StrFieldExpr fieldExpr)
        {
            this.fieldExpr = fieldExpr;
        }
        public override bool ObjRespond(object obj)
        {
            return fieldExpr.Compare((obj as Market).MIC);
        }
    }

    public class AbbreviationMarketRule : FilterRule
    {
        private StrFieldExpr fieldExpr;
        public override object FilterVal
        {
            set => fieldExpr.FilterValue = value;
        }

        public AbbreviationMarketRule(StrFieldExpr fieldExpr)
        {
            this.fieldExpr = fieldExpr;
        }
        public override bool ObjRespond(object obj)
        {
            return fieldExpr.Compare((obj as Market).Abbreviation);
        }
    }

    public class CountryMarketRule : FilterRule
    {
        private StrFieldExpr fieldExpr;
        public override object FilterVal
        {
            set => fieldExpr.FilterValue = value;
        }

        public CountryMarketRule(StrFieldExpr fieldExpr)
        {
            this.fieldExpr = fieldExpr;
        }
        public override bool ObjRespond(object obj)
        {
            return fieldExpr.Compare((obj as Market).Country);
        }
    }

    public class TimezoneMarketRule : FilterRule
    {
        private StrFieldExpr fieldExpr;
        public override object FilterVal
        {
            set => fieldExpr.FilterValue = value;
        }

        public TimezoneMarketRule(StrFieldExpr fieldExpr)
        {
            this.fieldExpr = fieldExpr;
        }

        public override bool ObjRespond(object obj)
        {
            return fieldExpr.Compare((obj as Market).Timezone);
        }
    }
}
