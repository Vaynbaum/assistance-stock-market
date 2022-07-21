using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coursework.Controllers.Filter
{
    public class LogExpEnum : IEnumerator<Type>
    {
        private Dictionary<string, Type> logExps = new Dictionary<string, Type>();
        private int position = -1;
        public Type Current
        {
            get
            {
                if (position < 0 || position > logExps.Count)
                    throw new IndexOutOfRangeException();
                return logExps[logExps.Keys.ElementAt(position)];
            }
        }

        object IEnumerator.Current => Current;

        public void Dispose()
        {
            logExps.Clear();
            Reset();
        }

        public bool MoveNext()
        {
            if (position < logExps.Count - 1)
            {
                position++;
                return true;
            }
            Reset();
            return false;
        }

        public void Reset()
        {
            position = -1;
        }

        public void Add(string key, Type value)
        {
            logExps.Add(key, value);
        }

        public Type this[string index] => logExps[index];
    }
}
