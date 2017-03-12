using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeRanger.Core.Model
{
    public class Person
    {
        public virtual int Id { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }

        public virtual int Age { get; set; }

        public override string ToString()
        {
            return string.Format("[{0}] {1} {2} {3}", Id, FirstName, LastName, Age);
        }
    }
}
