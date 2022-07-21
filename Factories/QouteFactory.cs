using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using coursework.Model;

namespace coursework.Factories
{
    public class QouteFactory
    {
        public Quote Create(DateTime dateTime, float open, float high, float low, float close)
        {
            Quote quote = new Quote
            {
                DateTime = dateTime,
                Open = open,
                High = high,
                Low = low,
                Close = close
            };
            return quote;
        }
    }
}
