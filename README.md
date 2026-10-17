

\# Bank Management System



A desktop banking application developed using C#, Windows Forms, .NET Framework 4.7, ADO.NET, and Microsoft SQL Server.



This project demonstrates banking operations, user management, authentication, transaction processing, currency exchange, and permission-based access control using a layered architecture.



\## Features



\### 1. Client Management

\- Add, view, update, and delete client records.

\- Manage client account information.

\- Track client balances.



\### 2. User Management

\- Add, view, update, and delete users.

\- Assign roles and permissions to users.

\- Manage user account status.

\- Control access to application modules and operations.



\### 3. Banking Transactions

\- Deposit money into client accounts.

\- Withdraw money from client accounts.

\- Transfer money between accounts.

\- View transfer logs and transaction records.

\- Track account balances and total balances.



\### 4. Currency Management

\- View available currencies and exchange rates.

\- Search currencies by country name.

\- Display currency codes and names.

\- Convert amounts between currencies using stored exchange rates.



\### 5. Authentication and Login Records

\- User login and logout.

\- Track login and logout records.

\- Record activity timestamps where configured.

\- Store passwords using PBKDF2 password hashing.



\### 6. Authorization and Permissions

\- Role-based access control.

\- Module-level permissions for clients, users, transactions, currency exchange, and login records.

\- Action-level permissions for Add, Update, and Delete operations.

\- Restrict application features according to assigned permissions.



\## Technologies Used



\- \*\*Programming Language:\*\* C#

\- \*\*Framework:\*\* .NET Framework 4.7

\- \*\*User Interface:\*\* Windows Forms (WinForms)

\- \*\*Database:\*\* Microsoft SQL Server

\- \*\*Data Access:\*\* ADO.NET

\- \*\*Database Operations:\*\* SQL Stored Procedures

\- \*\*Architecture:\*\* Three-Tier Architecture

\- \*\*Development Environment:\*\* Visual Studio



\## Project Structure



The solution is organized into the following projects:



\- \*\*Bank:\*\* Presentation Layer — Windows Forms and user interface.

\- \*\*BankBusinessLayer:\*\* Business Logic Layer — application rules and operations.

\- \*\*BankDataLayer:\*\* Data Access Layer — database queries and stored procedure execution.

\- \*\*Bank\_Utilities:\*\* Shared utilities and helper classes.

\- \*\*DataBase:\*\* SQL Server database backup.



\## Database



The repository includes a SQL Server database backup located at:



`DataBase/BANKDB.bak`



To set up the database:



1\. Install Microsoft SQL Server and SQL Server Management Studio (SSMS).

2\. Restore `BANKDB.bak` using SSMS.

3\. Verify the database name and SQL Server instance.

4\. Configure the application's connection string for your local SQL Server.

5\. Open `Bank/Bank.sln` in Visual Studio.

6\. Build the solution and run the application.



\## Architecture



The project separates the presentation, business logic, and data access responsibilities.



\- The Presentation Layer handles forms and user interactions.

\- The Business Logic Layer handles business rules and application operations.

\- The Data Access Layer communicates with SQL Server using ADO.NET and stored procedures.



This separation improves code organization and maintainability.



\## Project Purpose



This is an educational project created to practice C# desktop development, database integration, layered architecture, banking workflows, authentication, and authorization.



\*\*Note:\*\* This project is for learning and demonstration purposes only. It is not intended for real banking or financial operations.



