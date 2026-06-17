# 🏪 MiniStore BackOffice

> A hands-on learning project built **step by step alongside the course instructor** throughout the **Advanced Programming (CS-1036)** course. Each feature added to this app directly reflects a new concept taught in class.

-----

## 📚 Course Information

|Field           |Details                                                       |
|----------------|--------------------------------------------------------------|
|**Course**      |Advanced Programming                                          |
|**Course Code** |CS-1036                                                       |
|**Purpose**     |In-class learning project (built incrementally with professor)|
|**Technology**  |C# .NET · WinForms · ADO.NET                                  |
|**Architecture**|Layered Architecture (Core + UI)                              |

-----

## 🎯 What Is This?

**MiniStore BackOffice** is not a standalone project — it is the **central learning vehicle of the entire course**. Throughout the semester, every new concept taught in CS-1036 was immediately applied by extending this application. From basic C# classes, to interfaces, to ADO.NET database services, to async programming — it was all built live, in class, one layer at a time.

By the end of the course, the app had evolved into a fully structured WinForms desktop application for managing store customers and products.

-----

## 🏗️ Solution Structure

```
Solution 'MiniStore_BackOffice'
│
├── 📦 App.Core                  ← Class Library (Business Logic)
│   ├── Contracts/               ← Interfaces taught during DI & abstraction lectures
│   ├── Models/                  ← Domain models (Customer, Product, etc.)
│   ├── Services/                ← DB Service implementations
│   │   ├── DBCustomerService.cs
│   │   └── DBProductService.cs
│   └── Utilities/               ← Helper/utility classes
│
├── 🖥️ App.WindowApp             ← WinForms UI Project (Startup)
│   ├── Forms/                   ← WinForms dialog and pop-up forms
│   ├── View/                    ← Main application views/screens
│   ├── App.config               ← Connection strings & app settings
│   └── Program.cs               ← Application entry point
│
└── 📁 App.WinForm (unloaded)    ← Earlier version kept for reference
```

-----

## 📖 How the Course Was Taught

The professor introduced each topic in theory, then immediately demonstrated it by adding that feature to MiniStore. Students followed along and built the same thing. This is the progression:

### Stage 1 — C# Fundamentals & OOP

- Classes, objects, properties, constructors
- Introduced `Customer` and `Product` model classes in `App.Core/Models/`

### Stage 2 — Layered Architecture

- Why we separate UI from logic
- Created `App.Core` as a separate class library
- `App.WindowApp` references `App.Core` — UI never touches the DB directly

### Stage 3 — Interfaces & Contracts

- Learned **why interfaces matter** for loose coupling
- Defined `ICustomerService` and `IProductService` in `App.Core/Contracts/`

```csharp
public interface ICustomerService
{
    List<Customer> GetAll();
    Customer GetById(int id);
    void Add(Customer customer);
    void Update(Customer customer);
    void Delete(int id);
}
```

### Stage 4 — ADO.NET & Database Services

- Connected to SQL Server using raw ADO.NET (no ORM)
- Built `DBCustomerService` and `DBProductService` in `App.Core/Services/`
- Practiced `SqlConnection`, `SqlCommand`, `SqlDataReader`

```csharp
public class DBCustomerService : ICustomerService
{
    private readonly string _connectionString;

    public DBCustomerService(string connectionString)
    {
        _connectionString = connectionString;
    }

    public List<Customer> GetAll()
    {
        var customers = new List<Customer>();
        using var conn = new SqlConnection(_connectionString);
        using var cmd = new SqlCommand("SELECT * FROM Customers", conn);
        conn.Open();
        var reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            customers.Add(new Customer
            {
                Id = (int)reader["Id"],
                Name = reader["Name"].ToString()
            });
        }
        return customers;
    }
}
```

### Stage 5 — WinForms UI

- Built the desktop interface using Windows Forms
- Connected forms to services via constructor injection
- Used `DataGridView`, buttons, and input forms to interact with DB data

### Stage 6 — Exception Handling

- Wrapped all DB calls in `try-catch-finally`
- Handled `SqlException`, invalid input, and connection failures gracefully

### Stage 7 — Async / Await

- Refactored DB calls to be non-blocking using `async/await`
- Kept the UI responsive during long database operations

```csharp
public async Task<List<Customer>> GetAllAsync()
{
    using var conn = new SqlConnection(_connectionString);
    await conn.OpenAsync();
    // ...
}
```

-----

## 🛠️ Technologies Used

|Technology       |Purpose                                       |
|-----------------|----------------------------------------------|
|**C# (.NET)**    |Core programming language                     |
|**WinForms**     |Desktop UI framework                          |
|**ADO.NET**      |Low-level database access (taught before ORMs)|
|**SQL Server**   |Relational database backend                   |
|**Visual Studio**|IDE used throughout the course                |
|**Git**          |Version control                               |

-----

## ⚙️ Setup & Run

1. **Clone the repo**
   
   ```bash
   git clone <your-repo-url>
   ```
1. **Update the connection string** in `App.WindowApp/App.config`:
   
   ```xml
   <connectionStrings>
     <add name="DefaultConnection"
          connectionString="Server=YOUR_SERVER;Database=MiniStoreDB;Integrated Security=True;"
          providerName="System.Data.SqlClient" />
   </connectionStrings>
   ```
1. Open `MiniStore_BackOffice.sln` in Visual Studio and press **F5**.

-----

## 👨‍💻 Author

**Abdul Samad** 
BS Computer Science  
Advanced Programming — CS-1036


