# Coders' Grill Restaurant Webpage

## Description

Coders' Grill is a web application that serves as a restaurant landing page. It has been written in C# and has been built using ASP.NET Core and Entity Framework Core. MVC is the backend architecture of choice and has been used for managing and displaying text content in a structured way. Through a Content Management System, administrators are able to create, edit, and manage text content on this website.

## Requirements

- .NET SDK **v8.0** or newer
- SQL Server or another supported database provider
- A code editor (i.e. Visual Studio Code or Visual Studio)

## Instructions

**Installation**

Clone this repository by running this command in your terminal:

```
git clone https://github.com/shaquillekiragu/coders-grill-restaurant-webpage.git
```

Next, you'll need to open the cloned repository locally. Run:

```
code coders-grill-restaurant-webpage
```

**Setup**

To install all the required dependencies, run:

```
dotnet restore
```

Edit the **appsettings.json** file to set the connection string for your database:

```
"ConnectionStrings": {
  "DefaultConnection": "Server=your_server;Database=your_database;User Id=your_user;Password=your_password;"
}
```

To apply the existing migrations to your local database run:

```
dotnet ef database update
```

**Running**

To run this project once installed and setup, run:

```
dotnet run
```

Thank you for engaging with this project, I hope you enjoy it.
