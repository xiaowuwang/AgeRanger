using AgeRanger.Core.Interfaces;
using AgeRanger.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgeRanger.Core.Model;

namespace AgeRanger.Data
{
    public class PersonRepository : IPersonRepository
    {
        private readonly AgeRangerContext _context;

        public PersonRepository(AgeRangerContext context)
        {
            _context = context;
        }

        public void Add(string FirstName, string LastName, int Age)
        {
            throw new NotImplementedException();
        }

        public void Create(string firstName, string lastName, int age)
        {
            var newPerson = new Person();

            newPerson.FirstName = firstName;
            newPerson.LastName  = lastName;
            newPerson.Age = age;
            this._context.Persons.Add(newPerson);
            this._context.SaveChanges();
        }

        public void Edit(Person person)
        {
            _context.Persons.Attach(person);
            var entry = _context.Entry(person);
            entry.State = System.Data.Entity.EntityState.Modified;
            _context.SaveChanges();
        }

        public Person GetPersonByName(string name)
        {
            return _context.Persons
                          .Where(p => (p.FirstName == name)||(p.LastName == name))
                          .Select(p => p).FirstOrDefault();
        }

        public IEnumerable<Person> ListPerson()
        {
            return _context.Persons.ToList();
        }

    }
}
