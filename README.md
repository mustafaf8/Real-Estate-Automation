# Real Estate Automation Suite 🏡

[![.NET](https://img.shields.io/badge/.NET-8-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)](https://dotnet.microsoft.com/)
[![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)](https://docs.microsoft.com/en-us/dotnet/csharp/)
[![Visual Studio](https://img.shields.io/badge/Visual_Studio-2022-5C2D91?style=for-the-badge&logo=visual%20studio&logoColor=white)](https://visualstudio.microsoft.com/)

A comprehensive desktop application built with C# and Windows Forms to streamline property management for real estate agencies. This system provides a complete solution for listing, searching, editing, and exporting property data.

---

## 📖 Table of Contents

- [📌 Project Vision](#-project-vision)
- [✨ Core Features & Modules](#-core-features--modules)
- [🏛️ Architectural Design & Data Flow](#️-architectural-design--data-flow)
- [🛠️ Technology & Libraries](#️-technology--libraries)
- [🗄️ Data Persistence Model](#️-data-persistence-model)
- [🚀 Getting Started](#-getting-started)
  - [Prerequisites](#prerequisites)
  - [Installation & Setup](#installation--setup)
- [🤝 Contributing](#-contributing)

---

## 📌 Project Vision

**Emlak Otomasyon (Real Estate Automation)** was developed to provide a simple yet powerful tool for real estate professionals to manage their property portfolios. The project addresses the need for a standalone, offline-first desktop application that handles the entire lifecycle of a property listing—from initial registration to final sale or rental.

The system is designed with a clear, form-based interface, ensuring a minimal learning curve for users. By centralizing all property information and providing robust search and export capabilities, it aims to enhance productivity and organization within a real estate office.

---

## ✨ Core Features & Modules

The application is composed of several interconnected forms, each serving a distinct purpose in the property management workflow.

-   **Secure User Authentication (`LoginForm`):**
    -   Provides a secure entry point to the system.
    -   User credentials are validated against a local `Users.txt` file.

-   **Main Dashboard (`HomeForm`):**
    -   Acts as the central navigation hub after a successful login.
    -   Provides quick access to all major functionalities of the application.

-   **Property Registration (`NewHouseRegisterForm`):**
    -   A detailed form to add new properties to the system.
    -   Distinguishes between properties for **Sale** (`Satılık`) and for **Rent** (`Kiralık`).
    -   Captures essential details such as location, size, number of rooms, price, and contact information.

-   **Comprehensive Listing Viewer (`HouseRegistrationsForm`):**
    -   Displays all registered properties in a clean, tabular format using a `DataGridView`.
    -   Allows users to view both sale and rental listings.

-   **Advanced Search & Filtering (`FindRegisterForm`):**
    -   Enables users to quickly find specific properties based on various criteria.
    -   A powerful tool for matching client requirements with available listings.

-   **Editing & Deletion (`EditRegistrationsForm`):**
    -   Provides full CRUD (Create, Read, Update, Delete) capabilities.
    -   Users can select a listing to modify its details or remove it from the system entirely.

-   **Export to Excel Functionality:**
    -   A key feature that allows users to export the property listings into an Excel spreadsheet.
    -   Powered by the **EPPlus** library, this is perfect for generating reports, sharing data, or offline analysis.

---

## 🏛️ Architectural Design & Data Flow

The application follows a classic multi-form Windows Forms architecture with a focus on separation of concerns.

1.  **Presentation Layer (UI):**
    -   The user interacts with a series of `Form` classes (e.g., `LoginForm`, `HomeForm`). Each form is responsible for a specific task.
    -   The UI is designed to be intuitive, with standard controls like buttons, text boxes, and data grids.

2.  **Business Logic & Data Models (`ClassKutuphanesi`):**
    -   A separate Class Library project contains the core data models.
    -   A base `Home` class defines common property attributes.
    -   `SaleHome` and `RentHome` classes inherit from `Home` and add specific fields relevant to their type (e.g., sale price vs. monthly rent). This object-oriented approach ensures a clean and extensible data structure.

3.  **Data Access Layer (`SaleRegFunctions.cs`):**
    -   This class acts as a data manager, encapsulating all file I/O operations.
    -   It contains methods for reading from and writing to the `.txt` files, effectively abstracting the data storage mechanism from the rest of the application.

---

## 🛠️ Technology & Libraries

-   **Core Framework:** .NET 8
-   **Programming Language:** C#
-   **User Interface:** Windows Forms (WinForms)
-   **Key External Libraries:**
    -   **EPPlus:** A powerful .NET library for reading and writing Excel files (`.xlsx`). This is used for the "Export to Excel" feature.

---

## 🗄️ Data Persistence Model

Instead of a traditional relational database, this application employs a simple and portable **file-based storage system**. All data is persisted in plain text files located in the application's execution directory.

-   **`Users.txt`:** Stores user login credentials.
-   **`Satılık.txt`:** Contains all data for properties listed for sale.
-   **`Kiralık.txt`:** Contains all data for properties listed for rent.
-   **`Logs/log.txt`:** Records application events and potential errors for debugging purposes.

This approach makes the application highly portable, as it can be run from any directory without needing a database server.

---

## 🚀 Getting Started

To get a local copy up and running, follow these simple steps.

### Prerequisites

-   **Visual Studio:** Visual Studio 2022 is recommended, with the ".NET desktop development" workload installed.
-   **.NET SDK:** .NET 8 SDK.

### Installation & Setup

1.  **Clone the Repository:**
    ```bash
    git clone [https://github.com/your-username/Real-Estate-Automation.git](https://github.com/your-username/Real-Estate-Automation.git)
    cd Real-Estate-Automation
    ```

2.  **Open the Solution in Visual Studio:**
    -   Navigate to the `EmlakOtomasyon` folder.
    -   Open the `emlak.sln` file with Visual Studio 2022.

3.  **Restore Dependencies:**
    -   Visual Studio will automatically restore the NuGet packages (like EPPlus) required for the project. If it fails, right-click the solution in the Solution Explorer and select "Restore NuGet Packages".

4.  **Build the Solution:**
    -   From the top menu, go to `Build` > `Build Solution` or press `Ctrl+Shift+B`.

5.  **Run the Application:**
    -   Press `F5` or click the "Start" button. The `LoginForm` will appear first.
    -   *Note: The application will create its data files (`Kiralık.txt`, `Satılık.txt`, etc.) in the `bin/Debug/net8.0-windows` folder upon first use.*

---

## 🤝 Contributing

Contributions are what make the open-source community an amazing place to learn, inspire, and create. Any contributions you make are **greatly appreciated**.

1.  **Fork** the Project.
2.  Create your Feature Branch (`git checkout -b feature/ExcelReportingEnhancements`).
3.  Commit your Changes (`git commit -m 'Add new reporting features to Excel export'`).
4.  Push to the Branch (`git push origin feature/ExcelReportingEnhancements`).
5.  Open a **Pull Request**.
