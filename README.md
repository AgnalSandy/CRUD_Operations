# Customer Management System

A full-stack Customer CRUD (Create, Read, Update, Delete) application built with ASP.NET Core Razor Pages, following Clean Architecture principles.

## 🏗️ Architecture

This project implements **Clean Architecture** pattern with clear separation of concerns across three layers:

- **Core Layer**: Contains business entities and repository interfaces
- **Infrastructure Layer**: Implements data access logic with Entity Framework Core
- **Web Layer**: ASP.NET Core Razor Pages UI with AJAX-based interactions

## 🚀 Technologies

- **Framework**: .NET 8.0
- **Web Framework**: ASP.NET Core Razor Pages
- **ORM**: Entity Framework Core
- **Database**: SQL Server (LocalDB)
- **Authentication**: ASP.NET Core Identity
- **Frontend**: Bootstrap, jQuery, DataTables
- **Pattern**: Repository Pattern with Unit of Work

## ✨ Features

- ✅ Complete CRUD operations for Customer management
- ✅ User authentication and authorization with ASP.NET Core Identity
- ✅ AJAX-based dynamic UI updates without page reloads
- ✅ Responsive design with Bootstrap
- ✅ Data validation (client-side and server-side)
- ✅ Interactive data tables with search and pagination
- ✅ Modal dialogs for create/edit operations
- ✅ Clean Architecture for maintainability and scalability

## 📋 Customer Entity

The application manages customers with the following properties:

- **First Name** (Required, Min 2 characters)
- **Last Name**
- **Email** (Required, Valid email format)
- **Phone Number** (Required)
- **Company**

## 📁 Project Structure

```
Web.sln
│
├── Core/                          # Domain Layer
│   ├── Entities/
│   │   └── Customer.cs           # Customer entity
│   └── Interfaces/
│       ├── IGenRepoAsync.cs      # Generic repository interface
│       ├── ICustRepoAsync.cs     # Customer repository interface
│       └── IUnitOfWork.cs        # Unit of Work pattern interface
│
├── Infrastructure/                # Data Access Layer
│   ├── Data/
│   │   └── ApplicationDbContext.cs  # EF Core DbContext
│   ├── Migrations/               # EF Core migrations
│   └── Repositories/
│       ├── GenRepoAsync.cs       # Generic repository implementation
│       ├── CustRepoAsync.cs      # Customer repository implementation
│       └── UnitOfWork.cs         # Unit of Work implementation
│
└── Web/                           # Presentation Layer
    ├── Pages/                     # Razor Pages
    │   ├── Index.cshtml          # Main customer listing page
    │   ├── _CreateOrEdit.cshtml  # Customer form partial
    │   └── _ViewAll.cshtml       # Customer table partial
    ├── Services/
    │   └── RazorRenderServices.cs # Razor partial rendering service
    └── wwwroot/                   # Static files (CSS, JS, libraries)
```

## 🔧 Prerequisites

Before running this project, ensure you have:

- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0) or later
- [SQL Server LocalDB](https://learn.microsoft.com/en-us/sql/database-engine/configure-windows/sql-server-express-localdb) or SQL Server
- [Visual Studio 2022](https://visualstudio.microsoft.com/) (recommended) or [VS Code](https://code.visualstudio.com/)

## 📦 Installation & Setup

### 1. Clone the repository

```bash
git clone <your-repository-url>
cd Web
```

### 2. Restore NuGet packages

```bash
dotnet restore
```

### 3. Update database connection string (Optional)

Edit `Web/appsettings.json` if you want to use a different database:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=CustomerCRUD;Trusted_Connection=True;MultipleActiveResultSets=true"
  }
}
```

### 4. Apply database migrations

```bash
dotnet ef database update --project Infrastructure --startup-project Web
```

Or using Package Manager Console in Visual Studio:

```powershell
Update-Database
```

### 5. Run the application

```bash
cd Web
dotnet run
```

Or press `F5` in Visual Studio to run with debugging.

The application will be available at:
- HTTPS: `https://localhost:7xxx`
- HTTP: `http://localhost:5xxx`

(Port numbers may vary - check the console output for exact URLs)

## 🎯 Usage

1. **Register/Login**: Create an account or log in to access the system
2. **View Customers**: The main page displays all customers in a data table
3. **Add Customer**: Click the "Create New" button to add a new customer
4. **Edit Customer**: Click the edit icon next to any customer record
5. **Delete Customer**: Click the delete icon to remove a customer
6. **Search & Filter**: Use the DataTables search functionality to find customers

## 🗄️ Database Migrations

To create a new migration after modifying entities:

```bash
dotnet ef migrations add <MigrationName> --project Infrastructure --startup-project Web
```

To update the database:

```bash
dotnet ef database update --project Infrastructure --startup-project Web
```

## 📚 Key Dependencies

- **Microsoft.EntityFrameworkCore** - ORM framework
- **Microsoft.EntityFrameworkCore.SqlServer** - SQL Server provider
- **Microsoft.AspNetCore.Identity.EntityFrameworkCore** - Authentication
- **Microsoft.EntityFrameworkCore.Tools** - EF Core CLI tools
- **Bootstrap** - CSS framework
- **jQuery** - JavaScript library
- **DataTables** - Enhanced HTML tables

## 🔐 Security Features

- Password-based authentication with ASP.NET Core Identity
- Email confirmation required for account activation
- Secure password storage with hashing
- HTTPS enforcement in production
- CSRF protection on forms

## 🛠️ Development

### Build the solution

```bash
dotnet build
```

### Run tests (if available)

```bash
dotnet test
```

### Clean build artifacts

```bash
dotnet clean
```

## 📝 Design Patterns Used

- **Repository Pattern**: Abstracts data access logic
- **Unit of Work Pattern**: Manages database transactions
- **Dependency Injection**: Built-in ASP.NET Core DI container
- **Generic Repository**: Reusable data access methods
- **Service Layer**: Razor rendering service for partial views

## 🤝 Contributing

1. Fork the repository
2. Create a feature branch (`git checkout -b feature/AmazingFeature`)
3. Commit your changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

---

**Happy Coding! 🚀**
