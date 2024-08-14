# Coders' Grill Restaurant Webpage

## Description

Coders' Grill is a web application that serves as a dynamic restaurant landing page. Developed using C# with ASP.NET Core and Entity Framework Core, the application leverages the MVC architecture to efficiently manage and display text content in a structured way. Through a Content Management System, administrators are able to create, edit, and manage text content on this website. The application is styled using Foundation CSS, providing a clean, consistent, and responsive design that enhances the user experience. Additionally, the Slick JS framework has been used in order to integrate sliding images, further enriching the visual appeal and interactive elements of the site. To conclude, Coders' Grill combines robust backend functionality with a user-friendly interface to deliver a seamless and engaging web experience.

## Directory Structure

- wwwroot: Contains static files such as CSS stylesheets, JavaScript files, and JPEG images
- Controllers: Contains the MVC controllers that handle HTTP requests
- Data: Contains the database context and seed data
- Models: Contains the data model file establishing the project's data structure
- Views: Contains Razor views used to render HTML responses

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

Edit the **appsettings.json** file to set the connection string for your database, replacing the server and database names in the code below:

```
"ConnectionStrings": {
  "DefaultConnection": "Server=your_server;Database=your_database;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True"
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

Thank you for engaging with this project, I hope you enjoy it!
