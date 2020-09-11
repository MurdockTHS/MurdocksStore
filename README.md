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
  * Entity Framework is an ORM that enables developers to work with relational data as domain-specific objects.
* What is a Connection String?
  * Connection string is a string that specifies information about a data source and the means of connecting to it. It is passed in code to an underlying driver or provider in order to initiate the connection.
* What is a Database Context?
  * DbContext is a class provided by Entity Framework to establish connection to database, query the db and close connection.
* What is a Model Repository?
  * The Model repository is a relational database that stores the metadata for projects and folders
* Migration vs Scaffolding?
  * 
* Seeding the database?
  * 
