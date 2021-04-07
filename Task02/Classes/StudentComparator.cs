using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Classes
{

    // Note: name, surname, datebirth etc. can be duplicated except those unique properties like
    // number or email
    class StudentComparator : IEqualityComparer<Student>
    {
        public bool Equals(Student x, Student y)
        {
            return StringComparer
                .InvariantCultureIgnoreCase
                .Equals($"{x.Number} {x.Email}",
                $"{y.Number} {y.Email}");
        }

        public int GetHashCode([DisallowNull] Student obj)
        {
            return StringComparer
                .CurrentCultureIgnoreCase
                .GetHashCode($"{obj.Number} {obj.Email}");
        }
    }
}
