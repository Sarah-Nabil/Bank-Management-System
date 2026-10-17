# 🏦 Bank Management System

## 📖 Project Overview

Bank Management System is a desktop application developed using C# and .NET Framework 4.7 with Windows Forms.

The system simulates essential banking operations, including client management, user administration, deposits, withdrawals, money transfers, currency exchange, and login activity tracking.

It follows a **3-Tier Architecture** to separate the Presentation Layer, Business Logic Layer, and Data Access Layer, making the application easier to organize and maintain.

---

## ⚙️ Features

### 👥 Clients Management

- Add, view, update, and delete client records
- Manage client account information
- View and manage client balances

### 👤 Users Management

- Add, view, update, and delete system users
- Assign roles and permissions to users
- Manage user account status
- Control access to application modules and operations

### 💳 Banking Transactions

- Deposit money into client accounts
- Withdraw money from client accounts
- Transfer money between accounts
- View transfer logs and transaction records
- Display individual and total account balances

### 💱 Currency Management & Exchange

- View and search available currencies
- Display currency codes, names, and exchange rates
- Convert amounts between selected currencies
- Calculate conversions using rates stored in the database

### 🔐 Authentication & Login Records

- User login and logout
- Track login and logout activity
- Record activity timestamps, where configured
- Secure password storage using PBKDF2 hashing

### 🛡️ Authorization & Permissions

- Role-based access control
- Module-level permissions for clients, users, transactions, currency exchange, and login records
- Action-level permissions for Add, Update, and Delete operations
- Restrict access according to assigned permissions and user roles

---

## 🏗️ Architecture

The project follows a **3-Tier Architecture**:

- **Presentation Layer:** Windows Forms interface and user interactions
- **Business Logic Layer:** Business rules, validations, and application operations
- **Data Access Layer:** Database communication using ADO.NET and stored procedures

A separate utilities project contains shared helper classes and supporting functionality.

---

## 🛠️ Technologies Used

- **Language:** C#
- **Framework:** .NET Framework 4.7
- **Desktop UI:** Windows Forms (WinForms)
- **Database:** Microsoft SQL Server
- **Data Access:** ADO.NET
- **Database Logic:** SQL Stored Procedures
- **Architecture:** 3-Tier Architecture
- **Security:** PBKDF2 Password Hashing and Role-Based Access Control
- **IDE:** Visual Studio

---

## 🗄️ Database Setup

The repository includes a SQL Server database backup file:

`DataBase/BANKDB.bak`

### Using the Backup File (.bak)

1. Install Microsoft SQL Server and SQL Server Management Studio (SSMS).
2. Open SSMS and connect to your SQL Server instance.
3. Right-click **Databases** and select **Restore Database**.
4. Select **Device**, then browse to `DataBase/BANKDB.bak`.
5. Restore the database and verify its name.
6. Configure the application's connection string to match your local SQL Server instance.

---

## 📦 Project Structure

```text
Bank-Management-System/
│
├── Bank/
│   ├── Bank.sln
│   ├── Forms
│   ├── Properties
│   └── Resources
│
├── BankBusinessLayer/
│   └── Business Logic Classes
│
├── BankDataLayer/
│   └── Data Access Classes
│
├── Bank_Utilities/
│   └── Shared Utilities and Helpers
│
├── DataBase/
│   └── BANKDB.bak
│
├── .gitignore
└── README.md
```

---

## 🚀 Getting Started

1. Clone or download this repository.
2. Restore the database using the provided backup file.
3. Update the database connection settings for your local environment.
4. Open `Bank/Bank.sln` in Visual Studio.
5. Restore or configure any required project dependencies.
6. Build the solution and run the application.

---

## 🎯 Project Goals

This project demonstrates practical experience with:

- Desktop application development using C# and WinForms
- Working with SQL Server through ADO.NET
- Implementing stored procedures for database operations
- Applying a 3-Tier Architecture
- Managing banking transactions and account balances
- Building authentication and permission-based authorization
- Organizing a multi-project Visual Studio solution

---

**Note:** This project is developed for educational and demonstration purposes. It is not intended for real banking or financial operations.
