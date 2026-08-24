# Library API

A simple Library Management Web API built with ASP.NET Core and Entity Framework Core.

The project focuses on implementing CRUD operations for books, using DTOs, LINQ, SQL Server, filtering, relationships, and error handling.

## Features

* Get all books
* Get a book by ID
* Get a book by name
* Add a new book
* Update an existing book
* Delete a book
* DTOs for returning book data
* Filtering and validation
* Error handling through filters
* Entity relationships
* SQL Server database integration
* Swagger API documentation

## Technologies

* C#
* ASP.NET Core Web API
* Entity Framework Core
* SQL Server
* LINQ
* Swagger
* DTOs

## API Operations

The API provides the following operations for books:

| Method | Operation        | Description                  |
| ------ | ---------------- | ---------------------------- |
| GET    | Get All Books    | Retrieves all books          |
| GET    | Get Book By ID   | Retrieves a specific book    |
| GET    | Get Book By Name | Retrieves a book by its name |
| POST   | Add Book         | Creates a new book           |
| PUT    | Update Book      | Updates an existing book     |
| DELETE | Delete Book      | Deletes a book               |

## DTOs

The project uses Data Transfer Objects (DTOs) to control the data returned by the API and avoid directly exposing the entity model when retrieving books.

## Filtering & Error Handling

The project includes filtering and filters for handling errors and providing appropriate responses when users send invalid requests.

This helps make the API more organized and provides better feedback when something goes wrong.

## Database

The project uses:

* SQL Server
* Entity Framework Core
* LINQ

Entity Framework Core is used to communicate with the database and perform database operations.

## Swagger

Swagger is included to document and test the API endpoints directly through an interactive interface.

## How to Run

### 1. Clone the repository

```bash
git clone https://github.com/YOUR-USERNAME/YOUR-REPOSITORY.git
```

### 2. Open the project

Open the solution in Visual Studio.

### 3. Configure the database

Update the SQL Server connection string in the project's configuration file with your own database connection.

### 4. Apply migrations

If the project uses Entity Framework Core migrations, update the database using:

```bash
Update-Database
```

### 5. Run the project

Run the application from Visual Studio.

Swagger should open automatically, or you can navigate to the Swagger endpoint provided by the application.

## Project Goal

This project was created as a practical project to apply backend development concepts using ASP.NET Core Web API, Entity Framework Core, SQL Server, LINQ, DTOs, CRUD operations, filtering, and error handling.

## Future Improvements

Some possible improvements for future versions include:

* Authentication and Authorization
* JWT
* Pagination
* More advanced filtering
* Improved validation
* Unit Testing
* Async/Await implementation
* Repository or Service layer
