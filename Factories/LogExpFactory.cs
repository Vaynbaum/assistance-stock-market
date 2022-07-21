using coursework.Controllers.Filter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static coursework.Controllers.Filter.ExpEQ;

namespace coursework.Factories
{
   public class LogExpFactory
    {
        private LogExpEnum expEnum;

        public LogExpFactory()
        {
            expEnum = new LogExpEnum();
            expEnum.Add(Properties.Resources.WordEquallyFilter, new ExpEQ().GetType());
            expEnum.Add(Properties.Resources.WordNotEquallyFilter, new ExpNoEQ().GetType());
            expEnum.Add(Properties.Resources.WordContainFilter, new ExpContains().GetType());
            expEnum.Add(Properties.Resources.WordNotContainFilter, new ExpNoContains().GetType());
        }
        public LogExpEnum ExpEnum
        {
            get => expEnum;
        }

        public ILogExp Create(string logExp)
        {
            return Activator.CreateInstance(expEnum[logExp]) as ILogExp;
        }
    }
}
