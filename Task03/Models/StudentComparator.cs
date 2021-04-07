using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace Task03.Models
{
    public class StudentComparator : IEqualityComparer<Student>
    {
        public bool Equals(Student x, Student y)
        {
            return StringComparer.InvariantCultureIgnoreCase
                .Equals($"{x.ID}", $"{y.ID}");
        }

        public int GetHashCode([DisallowNull] Student obj)
        {
            return StringComparer.CurrentCultureIgnoreCase
                .GetHashCode($"{obj.ID}");
        }
    }
}
