# AQUA – Project Review and Tracking System

**Lab 3 · NDIKUMANA Norbert (26668) · Software Engineering, AUCA**

AQUA is a **desktop application** (C# Windows Forms, .NET 8) for the Rwanda Water Resources Board.
It is not a web app: it runs as a Windows program on your computer.

Organizations submit water projects with documents. A manager assigns a reviewer. The reviewer comments or asks
for more information. The manager approves or rejects the project and archives it.

## Technologies

- C# .NET 8, Windows Forms (desktop)
- PostgreSQL database (`auca1`, created automatically)
- NHibernate (ORM) with the Npgsql driver
- MVC architecture

## Project structure

```
AquaApp/
  Models/       Data classes (User, Category, Project, ProjectDocument, ReviewComment)
  Views/        The 11 forms (screens)
  Controllers/  Validation and business rules
  Data/         Database access (NHibernate, repositories, database setup)
  Helpers/      Password hashing, validation, message boxes
  Program.cs    Start-up
```

## How to run

1. Install **Visual Studio 2022** (.NET desktop development workload) and **PostgreSQL**.
2. Make sure the PostgreSQL user `postgres` has the password set in `AquaApp/Data/DbConfig.cs`
   (`p@ssword2025`), or change it there.
3. Open `AquaApp.sln` and press **F5**. The database and tables are created automatically on first start.

## Test accounts

| Role | Email | Password |
|------|-------|----------|
| Admin | admin@aqua.test | Admin@123 |
| Manager | manager@aqua.test | Manager@123 |
| Reviewer | reviewer@aqua.test | Reviewer@123 |
| Organization | org@aqua.test | Org@12345 |

## Main features

- Sign up and log in with role-based menus (Admin, Manager, Reviewer, Organization)
- Submit, edit and resubmit projects with documents
- Assign reviewers, add comments, request more information
- Approve, reject and archive projects
- Admin manages users and categories (full CRUD)
- Passwords stored as hashes
