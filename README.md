# API Development Course: Clean Architecture & Azure

## About This Project

This project documents my journey through a comprehensive course focused on building **robust, scalable, and secure RESTful APIs** using **ASP.NET Core 8**, based on **Clean Architecture** principles, and deployed to **Azure**.

The course covers a wide range of topics, including:

- **RESTful API Essentials:** Understanding HTTP, core REST principles, and setting up the development environment.
- **ASP.NET Core 8 Mastery:** Diving into routing, model binding, and HTTP client usage for API foundational elements.
- **Clean Architecture Adoption:** Learning and applying the benefits and principles of Clean Architecture to structure the API for maintainability and flexibility.
- **Infrastructure Setup:** Connecting to MS SQL with Entity Framework and implementing database seeding.
- **Feature Development:** Creating, retrieving, updating, and deleting resources, implementing DTO mapping and validation (Fluent Validation), and organizing code with **Command/Query Responsibility Segregation (CQRS)** using MediatR.
- **API Robustness:** Integrating Serilog for logging, generating automated documentation (Swagger/OpenAPI), and implementing global exception handling.
- **Advanced Topics:** Managing sub-entities, securing the API with **ASP.NET Identity** (authentication, authorization, roles, claims), and optimizing performance with pagination and sorting.
- **Testing & Deployment:** Implementing comprehensive **unit and integration tests**, deploying to **Azure App Service** and **Azure SQL**, and setting up **CI/CD pipelines** for automated deployments.

By the end of this course, the goal is to confidently architect and build production-ready APIs that are secure, maintainable, and scalable.

---

## How to Run This Project Locally

Follow these steps to get the API up and running on your machine:

1.  **Clone the Repository:**
    ```bash
    git clone [repository URL]
    cd [cloned directory] # Navigate into the root of the cloned project
    ```
2.  **Database Setup:**
    - Ensure you have **MS SQL Server** installed and running on your local machine.
    - Update the database **connection string** in `appsettings.json` (or `appsettings.Development.json`) to point to your local SQL Server instance.
3.  **Apply Migrations & Seed Data:**
    Navigate to the project's startup directory (where your `.csproj` file is located, e.g., `src/YourProject.Api`). Then, run:
    ```bash
    dotnet ef database update
    ```
    This command will create the database schema and populate it with any initial seed data.
4.  **Run the API:**
    From the project's startup directory, execute:
    ```bash
    dotnet run
    ```
    The API will typically start on `https://localhost:7001` or `http://localhost:5001`. Check the console output for the exact URL.

---
