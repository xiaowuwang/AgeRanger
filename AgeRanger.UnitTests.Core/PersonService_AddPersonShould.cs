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
    public class PersonService_AddPersonShould
    {
        [TestMethod]
        public void CreatePerson()
        {
            var mockPersonRepository = Mock.Create<IPersonRepository>();
            var mockAgeGroupRepository = Mock.Create<IAgeGroupRepository>();
            var myPersonService = new PersonService(mockPersonRepository, mockAgeGroupRepository);
            myPersonService.Add("","",1);
            Mock.Assert(() => mockPersonRepository.Create(Arg.IsAny<string>(), Arg.IsAny<string>(), Arg.IsAny<int>()), Occurs.Once());
        }
    }
}

