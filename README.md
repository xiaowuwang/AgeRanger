The solution AgeRanger include follow projects:

1.AgeRanger.Core
2.AgeRanger.Data
3.AgeRanger.SinglePage (AgeRanger Web Form application)
4.AgeRanger.WebAPI  (AgeRanger WebAPI Service application)http://localhost:49559/person/AllWithAgeGroup

[{"Id":3,"FirstName":"lunanzi","LastName":"wang","Age":26,"PersonAgeGroup":"Almost thirty"},{"Id":14,"FirstName":"kama","LastName":"sing","Age":25,"PersonAgeGroup":"Almost thirty"},{"Id":2,"FirstName":"keke","LastName":"hu","Age":47,"PersonAgeGroup":"Very adult"},{"Id":4,"FirstName":"steve","LastName":"wang","Age":30,"PersonAgeGroup":"Very adult"},{"Id":10,"FirstName":"benny","LastName":"deng","Age":48,"PersonAgeGroup":"Very adult"},{"Id":1,"FirstName":"xiaowu","LastName":"wang","Age":53,"PersonAgeGroup":"Kinda old"},{"Id":5,"FirstName":"steven","LastName":"Hu","Age":58,"PersonAgeGroup":"Kinda old"},{"Id":6,"FirstName":"c","LastName":"cu","Age":59,"PersonAgeGroup":"Kinda old"},{"Id":7,"FirstName":"fan","LastName":"zhang","Age":59,"PersonAgeGroup":"Kinda old"},{"Id":9,"FirstName":"liufang","LastName":"zhou","Age":55,"PersonAgeGroup":"Kinda old"},{"Id":11,"FirstName":"hao","LastName":"zheng","Age":65,"PersonAgeGroup":"Kinda old"},{"Id":12,"FirstName":"hao","LastName":"zheng","Age":67,"PersonAgeGroup":"Kinda old"},{"Id":8,"FirstName":"dongchun","LastName":"sun","Age":75,"PersonAgeGroup":"Old"},{"Id":13,"FirstName":"steve","LastName":"sun","Age":77,"PersonAgeGroup":"Old"},{"Id":18,"FirstName":"jingtao","LastName":"hu","Age":75,"PersonAgeGroup":"Old"},{"Id":15,"FirstName":"Zedong","LastName":"Mao","Age":125,"PersonAgeGroup":"Crazy ancient"},{"Id":16,"FirstName":"Enlai","LastName":"Zhou","Age":120,"PersonAgeGroup":"Crazy ancient"},{"Id":17,"FirstName":"Enlai","LastName":"Zhou","Age":120,"PersonAgeGroup":"Crazy ancient"},{"Id":21,"FirstName":"jieshi","LastName":"jiang","Age":130,"PersonAgeGroup":"Crazy ancient"},{"Id":19,"FirstName":"zi","LastName":"kong","Age":2500,"PersonAgeGroup":"Vampire"},{"Id":20,"FirstName":"zi","LastName":"meng","Age":2100,"PersonAgeGroup":"Vampire"}]

I make it with DDD and onion architecture in mind.  The Core Tier compiles independently. Data tier are dependent on Core tier,  SinglePage and WebAPI were dependent on Core Tier and Data Tier.

The AgeRanger have implemented all the requirements and also start a project to do unit tests.

Data tier, SinglePage and WebAPI all NuGet follow packages:

EntityFramework
System.Data.SQLite
System.Data.SQLite.Core
System.Data.SQLite.EF6
System.Data.SQLite.Linq

SinglePage and WebAPI NuGet StructureMap as Dependent Injection container.

The solution use JustMock for Unit Tests.

AgeRanger have good architecture, will very easy to migrate it to SQL Server.

connectionString="Data Source=C:\AgeRangerDB\AgeRanger.db;foreign keys=true" providerName="System.Data.SQLite"

hard code connection for now, so database must locate at C:\AgeRangerDB\AgeRanger.db;

Sample WebAPI json results as follows:

[{"Id":3,"FirstName":"lun","LastName":"wang","Age":26,"PersonAgeGroup":"Almost thirty"},{"Id":14,"FirstName":"kama","LastName":"sing","Age":25,"PersonAgeGroup":"Almost thirty"},{"Id":2,"FirstName":"keke","LastName":"hu","Age":47,"PersonAgeGroup":"Very adult"},{"Id":4,"FirstName":"steve","LastName":"wang","Age":30,"PersonAgeGroup":"Very adult"},{"Id":10,"FirstName":"benny","LastName":"deng","Age":48,"PersonAgeGroup":"Very adult"},{"Id":1,"FirstName":"xiaowu","LastName":"wang","Age":53,"PersonAgeGroup":"Kinda old"},{"Id":5,"FirstName":"steven","LastName":"Hu","Age":58,"PersonAgeGroup":"Kinda old"},{"Id":6,"FirstName":"c","LastName":"cu","Age":59,"PersonAgeGroup":"Kinda old"},{"Id":7,"FirstName":"fan","LastName":"zhang","Age":59,"PersonAgeGroup":"Kinda old"},{"Id":9,"FirstName":"liufang","LastName":"zhou","Age":55,"PersonAgeGroup":"Kinda old"},{"Id":11,"FirstName":"hao","LastName":"zheng","Age":65,"PersonAgeGroup":"Kinda old"},{"Id":12,"FirstName":"hao","LastName":"zheng","Age":67,"PersonAgeGroup":"Kinda old"},{"Id":8,"FirstName":"dongchun","LastName":"sun","Age":75,"PersonAgeGroup":"Old"},{"Id":13,"FirstName":"steve","LastName":"sun","Age":77,"PersonAgeGroup":"Old"},{"Id":18,"FirstName":"jingtao","LastName":"hu","Age":75,"PersonAgeGroup":"Old"},{"Id":15,"FirstName":"Zedong","LastName":"Mao","Age":125,"PersonAgeGroup":"Crazy ancient"},{"Id":16,"FirstName":"Enlai","LastName":"Zhou","Age":120,"PersonAgeGroup":"Crazy ancient"},{"Id":17,"FirstName":"Enlai","LastN