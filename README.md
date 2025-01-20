# Library-Management-System
# Library Management System

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

## How to Use
1. Clone the repository:
   ```bash
   git clone https://github.com/YourUsername/Library-Management-System.git
   cd Library-Management-System
2. Open the solution in Visual Studio.
3. Run the application.
## Project Structure
- Program.cs: Contains the entry point and main logic for user interaction.
- User.cs: Defines a base class for common user properties and methods.
- Librarian.cs: Implements librarian-specific actions like adding and removing books.
- Customer.cs: Implements customer-specific actions like borrowing and returning books.
- Library.cs: Manages the library's inventory of books.
