using coursework.Fields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coursework.Controllers.Managers
{
    public abstract class Manager
    {
        public abstract void ClearItems();
        public abstract void AddItem(object obj);
        public abstract List<object> Item { get; }
        public abstract List<Field> Fields { get; protected set; }
    }
}
