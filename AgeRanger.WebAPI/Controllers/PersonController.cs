using AgeRanger.Core.Interfaces;
using AgeRanger.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AgeRanger.WebAPI.Controllers
{
    [RoutePrefix("Person")]
    public class PersonController : ApiController
    {

        private readonly IPersonService _personService;
        public PersonController(IPersonService personService)
        {
            _personService = personService;
        }

        // GET Person/AllPerson
        [HttpGet]
        [Route("AllPerson")]
        public IEnumerable<Person> ListPerson()
        {
            return _personService.ListPerson();
        }

        // GET Person/AllWithAgeGroup
        [HttpGet]
        [Route("AllWithAgeGroup")]
        public IEnumerable<AgeGroupPerson> AllWithAG()
        {
            return _personService.ListAgeGroupPerson();
        }

        // GET Person/AllWithAgeGroup
        [HttpGet]
        [Route("AgeGroup")]
        public IEnumerable<AgeGroup> AgeGroup()
        {
            return _personService.ListAgeGroup();
        }


    }
}
