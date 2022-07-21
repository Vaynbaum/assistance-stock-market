using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coursework.Controllers.Filter
{
    public class ExpEQ : ILogExp
    {
        public bool Compare<T>(T filterValue, T value) where T : IEquatable<T>, IComparable<T>
        {
            return filterValue.Equals(value);
        }

        public class ExpNoEQ : ILogExp
        {
            public bool Compare<T>(T filterValue, T value) where T : IEquatable<T>, IComparable<T>
            {
                return !filterValue.Equals(value);
            }
        }

        public class ExpContains : ILogExp
        {
            public bool Compare<T>(T filterValue, T value) where T : IEquatable<T>, IComparable<T>
            {
                if (filterValue.GetType().Equals(typeof(string)))
                    return value.ToString().Contains(filterValue.ToString());
                throw new ArgumentException("Значение фильтра имеет не тот тип");
            }
        }

        public class ExpNoContains : ILogExp
        {
            public bool Compare<T>(T filterValue, T value) where T : IEquatable<T>, IComparable<T>
            {
                if (filterValue.GetType().Equals(typeof(string)))
                    return !value.ToString().Contains(filterValue.ToString());
                throw new ArgumentException("Значение фильтра имеет не тот тип");
            }
        }
    }


}
