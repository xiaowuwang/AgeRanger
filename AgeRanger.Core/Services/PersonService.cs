using AgeRanger.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgeRanger.Core.Model;
using System.Collections;

namespace AgeRanger.Core.Services
{
    public class PersonService : IPersonService
    {
        private readonly IPersonRepository _personRepository;
        private readonly IAgeGroupRepository _ageGroupRepository;

        public PersonService(IPersonRepository personRepository, IAgeGroupRepository ageGroupRepository)
        {
            _personRepository = personRepository;
            _ageGroupRepository = ageGroupRepository;
        }

        public void Add(string FirstName, string LastName, int Age)
        {
            _personRepository.Create(FirstName, LastName, Age);
        }

        public void Edit(Person person)
        {
            _personRepository.Edit(person);
        }

        public AgeGroupPerson GetPersonByName(string name)
        {
            return ListAgeGroupPerson()
                .Where(p => (p.FirstName == name) || (p.LastName == name))
                .Select(p => p).FirstOrDefault();
        }

        public IEnumerable<Person> ListPerson()
        {
            return _personRepository.ListPerson();
        }

        public IEnumerable<AgeGroup> ListAgeGroup()
        {
            return _ageGroupRepository.ListAgeGroup();
        }

        public IEnumerable<AgeGroupPerson> ListAgeGroupPerson()
        {
            var listAgeGroupPerson = new List<AgeGroupPerson>();
            var person = ListPerson();
            var ageGroup = ListAgeGroup();
            foreach (var ag in ageGroup)
            {
                foreach (var p in person)
                {
                    if (p.Age >= ag.MinAge && p.Age < ag.MaxAge)
                    {
                        listAgeGroupPerson.Add( new AgeGroupPerson {  PersonAgeGroup=ag.Description, Id=p.Id, FirstName=p.FirstName, LastName= p.LastName, Age=p.Age } );
                    }
                }
            }
            return listAgeGroupPerson;
        }

    }
}
