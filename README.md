# Practical 10: Student Management REST API

## Aim

Build a Student Management REST API using ASP.NET Core. This practical demonstrates a clean project structure, custom middleware, controllers, and REST CRUD operations.

The sample records are stored in memory, so no database or extra NuGet packages are needed. Changes reset when the API restarts.

## Run in Visual Studio

1. Open `Practical10.sln`.
2. Set `StudentManagementApi` as the startup project if needed.
3. Press **Ctrl+F5**. A browser opens the API home page at `http://localhost:5180`.
4. Click **View all students** to see the JSON output, or open `StudentManagementApi/StudentManagementApi.http` and click **Send Request** above a request.

## Routes

| Method | Route | Action |
| --- | --- | --- |
| GET | `/api/students` | List all students |
| GET | `/api/students/1` | Get one student |
| POST | `/api/students` | Add a student |
| PUT | `/api/students/1` | Update a student |
| DELETE | `/api/students/1` | Delete a student |

## Project structure

- `Controllers/StudentsController.cs` contains the REST routes.
- `Middleware/RequestLoggingMiddleware.cs` logs each request and response status.
- `Models/Student.cs` defines and validates a student.
- `Services/StudentService.cs` stores and manages the sample students.
- `StudentManagementApi.http` contains ready-to-run API requests.
