using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coursework.Controllers.Filter
{
    public interface ILogExp
    {
        bool Compare<T>(T filterValue, T firmValue) where T : IEquatable<T>, IComparable<T>;
    }
}
