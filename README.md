# ToDoAPI Server Documentation

This repository contains the code for a server application that provides a service for a separate .NET application. The server is built using C# and Entity Framework Core, and it is designed to manage tasks (ToDos).

## AppDbContext

The `AppDbContext` class represents the database context for the application. It inherits from `DbContext` and is responsible for managing the interaction between the application and the database. It includes a `DbSet` for managing the `ToDo` entities.

## Migrations

The `Migrations` folder contains migration files that define changes to the database schema over time. The initial migration creates the "ToDos" table with columns for "Id" and "ToDoName".

## ToDo Model

The `ToDo` class represents a task entity in the application. It includes properties for the task's unique identifier (`Id`) and its name (`ToDoName`). The `[Key]` attribute is used to denote the property that uniquely identifies the entity.

## API Endpoints

The server exposes several API endpoints for managing tasks:

- **GET** `/api/todo`: Retrieves a list of all tasks from the database.
- **POST** `/api/todo`: Adds a new task to the database.
- **PUT** `/api/todo/{id}`: Updates the name of a task specified by its unique identifier.
- **DELETE** `/api/todo/{id}`: Deletes a task specified by its unique identifier.

## Running the Server

To run the server, make sure you have the required dependencies installed. The application is built using the .NET 7.0 framework. To start the server, execute the following commands in your terminal:

```bash
dotnet build
dotnet run
```
The server will start, and you can access the API endpoints as described above.

Please note that this documentation provides an overview of the ToDoAPI server. For detailed implementation details and specific usage, refer to the code files in this repository.

## Contributing

This is all code from Les Jackson's tutorial [.NET MAUI Step by Step Build](https://www.youtube.com/watch?v=LrZwd-f0M4I)

## Helpful links for reference
[Microsoft MAUI Learning Path](https://learn.microsoft.com/en-us/training/paths/build-apps-with-dotnet-maui/)

[MAUI iOS & Android Confugration](https://learn.microsoft.com/en-us/dotnet/maui/data-cloud/local-web-services)

[NuGet Gallery](https://www.nuget.org/)

[Automated Testing with Insomnia](https://insomnia.rest/product/automated-testing)



