using AgeRanger.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeRanger.Core.Interfaces
{
    public interface IPersonService
    {
        void Add(string FirstName, string LastName, int Age);
        IEnumerable<Person> ListPerson();

        AgeGroupPerson GetPersonByName(string name);
        void Edit(Person person);

        IEnumerable<AgeGroup> ListAgeGroup();

        IEnumerable<AgeGroupPerson> ListAgeGroupPerson();
    }
}
