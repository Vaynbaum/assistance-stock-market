using coursework.Fields;
using coursework.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coursework.Controllers.Managers
{
    public class MarketManager : Manager
    {
        private List<object> _markets { get; set; }
        public override List<Field> Fields { get; protected set; }
        public override List<object> Item { get => _markets; }

        public MarketManager(List<Field> fields)
        {
            _markets = new List<object>();
            Fields = fields;
        }

        public override void AddItem(object obj)
        {
            _markets.Add(obj as Market);
        }

        public override void ClearItems()
        {
            _markets.Clear();
        }
    }
}
