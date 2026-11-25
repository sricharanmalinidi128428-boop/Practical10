# Practical 10: Student Management REST API

A small ASP.NET Core API demonstrating project structure, middleware, controllers, and REST CRUD routes. The data is kept in a static in-memory list, so no database or extra NuGet packages are needed. It resets when the API restarts.

## Run in Visual Studio

1. Open `Practical10.sln`.
2. Set `StudentManagementApi` as the startup project if needed.
3. Press **Ctrl+F5**. The API starts at `http://localhost:5180`.
4. Open `StudentManagementApi/StudentManagementApi.http` and use **Send Request** above each request.

## Routes

| Method | Route | Action |
| --- | --- | --- |
| GET | `/api/students` | List all students |
| GET | `/api/students/1` | Get one student |
| POST | `/api/students` | Add a student |
| PUT | `/api/students/1` | Update a student |
| DELETE | `/api/students/1` | Delete a student |

`Middleware/RequestLoggingMiddleware.cs` logs each request method, path, status code, and time. `Controllers/StudentsController.cs` contains the API operations.
