using coursework.Fields;
using coursework.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coursework.Controllers.Managers
{
    public class AssetManager : Manager
    {
        private List<object> _assets { get; set; }
        public override List<Field> Fields { get; protected set;  }

        public override List<object> Item { get => _assets; }

        public AssetManager(List<Field> fields)
        {
            _assets = new List<object>();
            Fields = fields;
        }
        public override void AddItem(object obj)
        {
            _assets.Add(obj as Asset);
        }

        public override void ClearItems()
        {
            _assets.Clear();
        }
    }
}
