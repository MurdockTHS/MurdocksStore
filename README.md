# ECommerce Project

Walkthrough from Adam Freeman's book Pro ASP.NET Core 3 

dotnet new globaljson --sdk-version 3.1.101 --output MurdocksStore/ElectronicProducts  
dotnet new web --no-https --output MurdocksStore/ElectronicProducts --framework netcoreapp3.1  
dotnet new sln -o MurdocksStore  
dotnet sln MurdocksStore add MurdocksStore/ElectronicProducts   
dotnet new xunit -o MurdocksStore/ElectronicProducts.Tests --framework netcoreapp3.1  
dotnet sln MurdocksStore add MurdocksStore/ElectronicProducts.Tests   
dotnet add MurdocksStore/ElectronicProducts.Tests reference MurdocksStore/ElectronicProducts   

### First Screenshot
![First Screenshot](https://github.com/MurdockTHS/MurdocksStore/blob/master/murdocks1.PNG)

### Questions:
* What is Entity Framework?
  * Entity Framework is an object-relational mapper (O/RM) that enables .NET developers to work with a database using .NET objects. It eliminates the need for most of the data-access code that developers usually need to write.
* What is a Connection String?
  * Connection strings used by the Entity Framework contain information used to connect to the underlying ADO.NET data provider that supports the Entity Framework. They also contain information about the required model and mapping files.
* What is a Database Context?
  * DbContext is the primary class that is responsible for interacting with the database. It is responsible for the following activities: Querying, Change Tracking, Persisting Data, Caching, Manage Relationship and Object Materialization.
* What is a Model Repository?
  * The Model repository is a relational database that stores the metadata for projects and folders.
* Migration vs Scaffolding?
  * 
* Seeding the database?
  * 
