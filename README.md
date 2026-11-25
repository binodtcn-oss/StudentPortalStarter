# StudentPortal: ASP.NET Core MVC Demo (.NET 10)

Training demo for ".NET Framework for Beginners" (Infomax College, 26 Nov 2026).

## Run
1. Install the .NET 10 SDK: https://dotnet.microsoft.com/download
2. In this folder run:
   ```
   dotnet run
   ```
3. Open http://localhost:5080

## What it shows
- Model: `Models/Student.cs` (with validation attributes)
- View: `Views/Students/*.cshtml` (Razor, tag helpers, shared layout)
- Controller: `Controllers/StudentsController.cs` (CRUD actions)
- Routing and DI: `Program.cs`
- Service layer: `Services/` (in-memory; swap for EF Core later)

Note: Client-side validation scripts are omitted for simplicity; server-side validation works via ModelState.
