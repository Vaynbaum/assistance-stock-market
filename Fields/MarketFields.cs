using coursework.Controllers.Filter;
using coursework.Filter;
using coursework.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coursework.Fields
{
    public class AbbreviationMarketField : Field
    {
        public AbbreviationMarketField()
        {
            NameType = Properties.Resources.AbbreviationMarketNameType;
        }

        public override FilterRule CreateRule(ILogExp expression)
        {
            fRule = new AbbreviationMarketRule(new StrFieldExpr(expression));
            return fRule;
        }

        public override string GetValue(object obj)
        {
            return (obj as Market).Abbreviation;
        }
    }

    public class CountryMarketField : Field
    {
        public CountryMarketField()
        {
            NameType = Properties.Resources.CountryMarketNameType;
        }

        public override FilterRule CreateRule(ILogExp expression)
        {
            fRule = new CountryMarketRule(new StrFieldExpr(expression));
            return fRule;
        }
        public override string GetValue(object obj)
        {
            return (obj as Market).Country;
        }
    }

    public class MicMarketField : Field
    {
        public MicMarketField()
        {
            NameType = Properties.Resources.MICMarketNameType;
        }
        public override FilterRule CreateRule(ILogExp expression)
        {
            fRule = new MICMarketRule(new StrFieldExpr(expression));
            return fRule;
        }
        public override string GetValue(object obj)
        {
            return (obj as Market).MIC;
        }
    }

    public class TimezoneMarketField : Field
    {
        public TimezoneMarketField()
        {
            NameType = Properties.Resources.TimezoneMarketNameType;
        }
        public override FilterRule CreateRule(ILogExp expression)
        {
            fRule = new TimezoneMarketRule(new StrFieldExpr(expression));
            return fRule;
        }
        public override string GetValue(object obj)
        {
            return (obj as Market).Timezone;
        }
    }
}
