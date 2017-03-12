using AgeRanger.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeRanger.Core.Interfaces
{
    public interface IPersonRepository
    {
        void Create(string firstName, string lastName, int age);
        IEnumerable<Person> ListPerson();
        Person GetPersonByName(string name);
        void Edit(Person person);

    }
}
