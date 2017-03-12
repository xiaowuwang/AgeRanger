// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DefaultRegistry.cs" company="Web Advanced">
// Copyright 2012 Web Advanced (www.webadvanced.com)
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0

// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace AgeRanger.WebAPI.DependencyResolution {
    using Core.Interfaces;
    using Core.Services;
    using Data;
    using StructureMap.Configuration.DSL;
    using StructureMap.Graph;
    using System.Data.Entity;

    public class DefaultRegistry : Registry {
        #region Constructors and Destructors

        public DefaultRegistry() {
            Scan(
                scan => {
                    scan.TheCallingAssembly();
                    scan.WithDefaultConventions();
                    scan.AssemblyContainingType<PersonRepository>(); // Data
                    scan.AssemblyContainingType<AgeGroupRepository>(); // Data
                });
            // Configure EF
            For<DbContext>().Use<AgeRangerContext>();

            For<IPersonService>().Use<PersonService>();

            // important to set properties on web forms
            Policies.SetAllProperties(prop => prop.OfType<IPersonService>());
        }

        #endregion
    }
}