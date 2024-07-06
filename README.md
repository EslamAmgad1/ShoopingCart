# ShoppingCart Project

## Overview

This ShoppingCart project is built using ASP.NET Core MVC and .NET 7. It follows the Repository Pattern & Unit of Work, Dependency Injection, and uses Entity Framework 7 for data access. The project is designed with n-tier architecture and includes several features such as MS Identity for authentication, JQuery Datatables for data handling, Toaster JS for notifications, a dashboard, pagination, sessions management, and payment integration with Stripe.

## Features

- **ASP.NET Core MVC**: Robust MVC framework for building scalable web applications.
- **.NET 7**: Latest version of .NET ensuring performance and productivity improvements.
- **Repository Pattern & Unit of Work**: Efficient data access patterns ensuring separation of concerns.
- **Dependency Injection**: Built-in support for dependency injection for better maintainability and testability.
- **Entity Framework 7**: Modern ORM for database operations.
- **n-tier architecture**: Clear separation of presentation, application, and data access layers.
- **MS Identity**: Comprehensive identity and authentication system.
- **JQuery Datatables**: Dynamic tables for displaying data with pagination, sorting, and search capabilities.
- **Toaster JS**: User-friendly notifications.
- **Dashboard**: Intuitive dashboard for managing the application.
- **Pagination**: Efficient handling of large datasets.
- **Sessions**: User session management.
- **Stripe Payment Integration**: Secure and reliable payment processing.

## Installation

1. **Clone the repository**
    ```bash
    git clone https://github.com/yourusername/ShoppingCart.git
    ```

2. **Navigate to the project directory**
    ```bash
    cd ShoppingCart
    ```

3. **Setup the database**
    - Update the connection string in `appsettings.json` with your SQL Server credentials.
    - Apply migrations to create the database schema.
    ```bash
    dotnet ef database update
    ```

4. **Install the dependencies**
    ```bash
    dotnet restore
    ```

5. **Run the application**
    ```bash
    dotnet run
    ```

## Usage

1. **Access the application**
    - Open your browser and navigate to `http://localhost:5000`.

2. **Admin Dashboard**
    - Access the admin dashboard to manage products, orders, and users.

3. **User Authentication**
    - Register a new account or log in with existing credentials.

4. **Shopping Cart**
    - Browse products, add to cart, and proceed to checkout.

5. **Payment**
    - Complete the payment using Stripe integration.

## Contributing

Contributions are welcome! Please open an issue or submit a pull request for any changes or improvements.

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.
