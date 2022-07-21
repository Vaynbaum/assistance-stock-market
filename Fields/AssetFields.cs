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
    public class AbbreviationAssetField : Field
    {
        public AbbreviationAssetField()
        {
            NameType = Properties.Resources.AbbreviationAssetNameType;
        }

        public override FilterRule CreateRule(ILogExp expression)
        {
            fRule = new AbbreviationAssetRule(new StrFieldExpr(expression));
            return fRule;
        }

        public override string GetValue(object obj)
        {
            return (obj as Asset).Abbreviation;
        }
    }

    public class CountryAssetField : Field
    {
        public CountryAssetField()
        {
            NameType = Properties.Resources.CountryAssetNameType;
        }

        public override FilterRule CreateRule(ILogExp expression)
        {
            fRule = new CountryAssetRule(new StrFieldExpr(expression));
            return fRule;
        }

        public override string GetValue(object obj)
        {
            return (obj as Asset).Country;
        }
    }

    public class CurrencyAssetField : Field
    {
        public CurrencyAssetField()
        {
            NameType = Properties.Resources.CurrenyAssetNameType;
        }

        public override FilterRule CreateRule(ILogExp expression)
        {
            fRule = new CurrencyAssetRule(new StrFieldExpr(expression));
            return fRule;
        }

        public override string GetValue(object obj)
        {
            return (obj as Asset).Currency;
        }
    }

    public class InstrumentAssetField : Field
    {
        public InstrumentAssetField()
        {
            NameType = Properties.Resources.InstrumentAssetNameType;
        }

        public override FilterRule CreateRule(ILogExp expression)
        {
            fRule = new InstrumentAssetRule(new StrFieldExpr(expression));
            return fRule;
        }

        public override string GetValue(object obj)
        {
            return (obj as Asset).InstrumentName;
        }
    }

    public class TypeNameAssetField : Field
    {
        public TypeNameAssetField()
        {
            NameType = Properties.Resources.NameTypeAssetNameType;
        }

        public override FilterRule CreateRule(ILogExp expression)
        {
            fRule = new TypeNameAssetRule(new StrFieldExpr(expression));
            return fRule;
        }

        public override string GetValue(object obj)
        {
            return (obj as Asset).Type;
        }
    }
}
