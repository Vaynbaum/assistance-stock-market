using coursework.Filter;
using coursework.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coursework.Controllers.Filter
{
    public class AbbreviationAssetRule : FilterRule
    {
        private StrFieldExpr fieldExpr;
        public override object FilterVal
        {
            set => fieldExpr.FilterValue = value;
        }

        public AbbreviationAssetRule(StrFieldExpr fieldExpr)
        {
            this.fieldExpr = fieldExpr;
        }

        public override bool ObjRespond(object obj)
        {
            return fieldExpr.Compare((obj as Asset).Abbreviation);
        }
    }

    public class CountryAssetRule : FilterRule
    {
        private StrFieldExpr fieldExpr;
        public override object FilterVal
        {
            set => fieldExpr.FilterValue = value;
        }

        public CountryAssetRule(StrFieldExpr fieldExpr)
        {
            this.fieldExpr = fieldExpr;
        }

        public override bool ObjRespond(object obj)
        {
            return fieldExpr.Compare((obj as Asset).Country);
        }
    }

    public class CurrencyAssetRule : FilterRule
    {
        private StrFieldExpr fieldExpr;
        public override object FilterVal
        {
            set => fieldExpr.FilterValue = value;
        }

        public CurrencyAssetRule(StrFieldExpr fieldExpr)
        {
            this.fieldExpr = fieldExpr;
        }

        public override bool ObjRespond(object obj)
        {
            return fieldExpr.Compare((obj as Asset).Currency);
        }
    }

    public class InstrumentAssetRule : FilterRule
    {
        private StrFieldExpr fieldExpr;
        public override object FilterVal
        {
            set => fieldExpr.FilterValue = value;
        }

        public InstrumentAssetRule(StrFieldExpr fieldExpr)
        {
            this.fieldExpr = fieldExpr;
        }

        public override bool ObjRespond(object obj)
        {
            return fieldExpr.Compare((obj as Asset).InstrumentName);
        }
    }

    public class TypeNameAssetRule : FilterRule
    {
        private StrFieldExpr fieldExpr;
        public override object FilterVal
        {
            set => fieldExpr.FilterValue = value;
        }

        public TypeNameAssetRule(StrFieldExpr fieldExpr)
        {
            this.fieldExpr = fieldExpr;
        }

        public override bool ObjRespond(object obj)
        {
            return fieldExpr.Compare((obj as Asset).Type);
        }
    }
}
