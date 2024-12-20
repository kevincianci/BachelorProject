# 🖨️ Normal A/S Printing Workflow Streamliner

Welcome to the **Normal A/S Printing Workflow Streamliner** project! This application is designed to streamline the printing workflow at Normal A/S, making it easier to manage print jobs, audit logs, and reports. The project leverages Blazor Server for the frontend and ASP.NET Core for the backend, providing a seamless and efficient user experience.

## 🚀 Features

- **Print Queue Management**: Easily manage and monitor print jobs.
- **Audit Logs**: Track and review actions performed within the application.
- **Report Generation**: Generate and view detailed reports.
- **User Authentication**: Secure access to the application with authentication.
- **Responsive Design**: Optimized for both desktop and mobile devices.

## 📋 Table of Contents

- [Introduction](#-introduction)
- [Features](#-features)
- [Getting Started](#-getting-started)
- [Usage](#-usage)
- [Contributing](#-contributing)
- [License](#-license)

## 🏁 Getting Started

### Prerequisites

Before you begin, ensure you have the following installed:

- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [Visual Studio 2022](https://visualstudio.microsoft.com/vs/) or [Visual Studio Code](https://code.visualstudio.com/)
- [SQLite](https://www.sqlite.org/download.html)

### Installation

1. **Clone the repository**:

    ```sh
    git clone https://github.com/yourusername/normal-printing-workflow.git
    cd normal-printing-workflow
    ```

2. **Set up the database**:

    Run the following commands to apply migrations and update the database:

    ```sh
    dotnet ef migrations add InitialCreate
    dotnet ef database update
    ```

3. **Run the application**:

    ```sh
    dotnet run
    ```

    The application will be available at `https://localhost:5001`.

## 📖 Usage

### Print Queue Management

- Navigate to the **Print Queue** page to view and manage pending print jobs.
- Use the **Cancel** button to remove a print job from the queue.

### Audit Logs

- Navigate to the **Audit Logs** page to view a list of actions performed within the application.
- Use the filter options to narrow down the logs based on specific actions.

### Report Generation

- Navigate to the **Report Generator** page to generate and view detailed reports.
- Click the **Generate New Report** button to create a new report.

### User Authentication

- Log in to access the application's features.
- Use the **Logout** button to securely log out of the application.

## 🤝 Contributing

We welcome contributions to enhance the functionality and usability of this project. To contribute:

1. Fork the repository.
2. Create a new branch (`git checkout -b feature/your-feature-name`).
3. Commit your changes (`git commit -m 'Add some feature'`).
4. Push to the branch (`git push origin feature/your-feature-name`).
5. Open a Pull Request.

## 📄 License

This project is licensed under the MIT License. See the LICENSE file for details.

---

Thank you for using the **Normal A/S Printing Workflow Streamliner**! We hope it makes your printing workflow more efficient and enjoyable. If you have any questions or feedback, please feel free to reach out.