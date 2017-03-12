using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AgeRanger.Core.Interfaces;
using AgeRanger.Core.Services;
using Telerik.JustMock;
using AgeRanger.Core.Model;
using System.Collections.Generic;

namespace AgeRanger.UnitTests.Core
{
    [TestClass]
    public class PersonService_ListPersonShould
    {
        [TestMethod]
        public void RetrunListFromRepository()
        {
            var mockPersonRepository   = Mock.Create<IPersonRepository>();
            var mockAgeGroupRepository = Mock.Create<IAgeGroupRepository>();
            var myPersonService = new PersonService(mockPersonRepository, mockAgeGroupRepository);
            var result = myPersonService.ListPerson();
            Mock.Assert(() => mockPersonRepository.ListPerson(), Occurs.Once());
            Assert.IsInstanceOfType(result, typeof(IEnumerable<Person>));
        }
    }
}
