# ProductApp

IT-MoviesApp-RazorPages
simple class project to introduce ASP.Net Core Web App(Razor pages) to students

Dotnet CLI Commands
=========Dependencies Installation===============

dotnet add package Microsoft.EntityFrameworkCore.SQLite

dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design

dotnet add package Microsoft.EntityFrameworkCore.Design

dotnet add package Microsoft.EntityFrameworkCore.SqlServer

==========Generate Razor Pages===================

dotnet tool install --global dotnet-aspnet-codegenerator

dotnet aspnet-codegenerator razorpage -m Movie -dc MoviesContext -udl -outDir Pages/Movies -- referenceScriptLibraries

========create and run migrations===============

dotnet ef migrations add InitialCreate

dotnet ef database update
