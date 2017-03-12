using AgeRanger.Core.Interfaces;
using AgeRanger.Core.Services;
using AgeRanger.Data;
using StructureMap;
using System;
using System.Data.Entity;

namespace AgeRanger.SinglePage
{
    public static class StructureMapBootStrap
    {
        public static IContainer Configure()
        {

            var container = new Container(c =>
            {
                c.Scan(x =>
                {
                    x.TheCallingAssembly();
                    x.WithDefaultConventions();
                    x.AssemblyContainingType<PersonRepository>(); // Data
                    x.AssemblyContainingType<AgeGroupRepository>(); // Data

                });

                // Configure EF
                c.For<DbContext>().Use<AgeRangerContext>();
               
                c.For<IPersonService>().Use<PersonService>();

                // important to set properties on web forms
                c.Policies.SetAllProperties(prop => prop.OfType<IPersonService>());
            });
            return container;
        }
    }
}