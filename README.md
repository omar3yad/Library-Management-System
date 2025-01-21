# Library-Management-System

This project is a simple console-based Library Management System that allows users to manage books, borrow and return them. It includes functionality for librarians and regular users with distinct roles.

## Features
- **Librarian Actions**:
  - Add books to the library.
  - Remove books from the library. 
  - View all books in the library.

- **User Actions**:
  - Borrow books.
  - Return borrowed books.
  - View all books in the library.

## Technologies
- Language: C#
- Framework: .NET Framework

## Project Structure
- Program.cs: Contains the entry point and main logic for user interaction.
- User.cs: Defines a base class for common user properties and methods.
- Librarian.cs: Implements librarian-specific actions like adding and removing books.
- Customer.cs: Implements customer-specific actions like borrowing and returning books.
- Library.cs: Manages the library's inventory of books.
