using coursework.Controllers.Managers;
using System.Collections.Generic;

namespace coursework.Controllers.Filter
{
    public class FilterContr
    {
        private List<FilterRule> filters;
        private Manager _manager;
        private List<object> _allItems;

        public FilterContr(Manager manager, List<object> allItems)
        {
            filters = new List<FilterRule>();
            _manager = manager;
            _allItems = allItems;
        }

        public void AddRule(FilterRule rule)
        {
            filters.Add(rule);
        }

        public void ApplyFilter()
        {
            _manager.ClearItems();
            foreach (object item in _allItems)
            {
                int cntPerform = 0;
                foreach (FilterRule rule in filters)
                {
                    if (rule.ObjRespond(item))
                    {
                        cntPerform++;
                    }
                }
                if (cntPerform == filters.Count)
                {
                    _manager.AddItem(item);
                }
            }
        }
    }
}
