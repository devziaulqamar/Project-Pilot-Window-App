# ProjectPilot

ProjectPilot is a Windows Forms application for managing projects. The application allows users to view, add, edit, and open project folders directly from an Excel file. The project data is loaded from and saved to an Excel file located at `F:\Project Management\Projects.xlsx`.

## Features

- **View Projects**: View a list of projects with their names and links.
- **Add New Project**: Add a new project with a name and link.
- **Edit Project**: Edit the name and link of an existing project.
- **Open Project Folder**: Open the project folder in Windows Explorer.
- **Open Project in VS Code**: Open the project folder in Visual Studio Code.

## Installation

1. **Clone the repository:**

    ```bash
    git clone https://github.com/yourusername/ProjectPilot.git
    cd ProjectPilot
    ```

2. **Open the solution in Visual Studio:**

    Open `ProjectPilot.sln` in Visual Studio.

3. **Install EPPlus:**

    EPPlus is used for reading and writing Excel files. Install it via NuGet Package Manager:

    ```bash
    Install-Package EPPlus
    ```

4. **Build and run the application:**

    Build the solution and run the application from Visual Studio.

## Usage

1. **Load Projects:**

    The application automatically loads project data from the Excel file located at `F:\Project Management\Projects.xlsx` when it starts.

2. **View Projects:**

    The main form displays a DataGridView with project names and links. You can use the action buttons to view or edit projects, and open their folders.

3. **Add New Project:**

    Click the "Add New Project" button to open a form for adding a new project. Enter the project name and link, and click "Save" to add it to the Excel file.

4. **Edit Project:**

    Click the "Edit" button in the DataGridView to open a form for editing the selected project's details. Modify the project name and link, and click "Save" to update the Excel file.

5. **Open Project Folder:**

    Click the "Open Folder" button in the DataGridView to open the project folder in Windows Explorer.

6. **Open Project in VS Code:**

    Click the "View" button in the DataGridView to open the project folder in Visual Studio Code.

## Contributing

Contributions are welcome! If you have ideas for improvements or new features, feel free to fork the repository and submit a pull request.

### Steps to Contribute:

1. **Fork the repository.**
2. **Create a new branch:**

    ```bash
    git checkout -b feature/YourFeature
    ```

3. **Make your changes.**
4. **Commit your changes:**

    ```bash
    git commit -m 'Add some feature'
    ```

5. **Push to the branch:**

    ```bash
    git push origin feature/YourFeature
    ```

6. **Open a pull request.**

### License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.

## Contact

If you have any questions or feedback, please feel free to contact me at [your-email@example.com](mailto:your-email@example.com).

