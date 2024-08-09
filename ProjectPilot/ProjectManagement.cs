
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Windows.Forms;
using OfficeOpenXml;

namespace ProjectPilot
{
    public partial class ProjectManagement : Form
    {
        public ProjectManagement()
        {
            InitializeComponent();
            InitializeDataGridView();
            LoadDataFromExcel(@"F:\Project Management\Projects.xlsx");

            this.CenterToScreen();
        }

        private void InitializeDataGridView()
        {
            dataGridView1.RowHeadersVisible = false;

            // Add buttons in the last columns
            DataGridViewButtonColumn viewButton = new DataGridViewButtonColumn
            {
                Name = "ViewButton",
                HeaderText = "Open Code",
                Text = "Open Code",
                UseColumnTextForButtonValue = true
            };
            dataGridView1.Columns.Add(viewButton);

            DataGridViewButtonColumn openfolder = new DataGridViewButtonColumn
            {
                Name = "OpenFolder",
                HeaderText = "Open Folder",
                Text = "Open Folder",
                UseColumnTextForButtonValue = true
            };
            dataGridView1.Columns.Add(openfolder);


            DataGridViewButtonColumn editButton = new DataGridViewButtonColumn
            {
                Name = "EditButton",
                HeaderText = "Edit",
                Text = "Edit",
                UseColumnTextForButtonValue = true
            };
            dataGridView1.Columns.Add(editButton);

            // Handle button clicks
            dataGridView1.CellContentClick += DataGridView1_CellContentClick;
        }

        private void LoadDataFromExcel(string filePath)
        {
            // Set the license context
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            FileInfo fileInfo = new FileInfo(filePath);
            using (ExcelPackage package = new ExcelPackage(fileInfo))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets[0]; // Get the first worksheet

                // Loop through rows
                for (int row = 2; row <= worksheet.Dimension.End.Row; row++)
                {
                    string projectName = worksheet.Cells[row, 1].Text; // Column A
                    string projectLink = worksheet.Cells[row, 2].Text;  // Column B

                    dataGridView1.Rows.Add(projectName, projectLink);
                }
            }
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                if (e.ColumnIndex == dataGridView1.Columns["ViewButton"].Index)
                {
                    string projectName = row.Cells["ProjectName"].Value?.ToString();
                    string projectLink = row.Cells["ProjectLink"].Value?.ToString();
                    OpenCodeFolder(projectLink);
                }
                else if (e.ColumnIndex == dataGridView1.Columns["EditButton"].Index)
                {
                    string projectName = row.Cells["ProjectName"].Value?.ToString();
                    string projectLink = row.Cells["ProjectLink"].Value?.ToString();

                    AddNewProject addNewProjectForm = new AddNewProject(projectName, projectLink, e.RowIndex);
                    addNewProjectForm.ShowDialog();

                    // Reload data after editing
                    dataGridView1.Rows.Clear();
                    LoadDataFromExcel(@"F:\Project Management\Projects.xlsx");
                }
                else if (e.ColumnIndex == dataGridView1.Columns["OpenFolder"].Index)
                {
                    string projectLink = row.Cells["ProjectLink"].Value?.ToString();
                    OpenFolder(projectLink);
                }
            }
        }


        private void OpenFolder(string project_link)
        {
            try
            {
                Process.Start("explorer.exe", project_link);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to open folder: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void OpenCodeFolder(string project_link)
        {
            string folderPath = project_link;
            string vscodePath = @"C:\Users\Zia ul Qamar\AppData\Local\Programs\Microsoft VS Code\Code.exe";

            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = vscodePath,
                    Arguments = $"\"{folderPath}\"",
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to open folder in VS Code: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void AddNewProject_Click(object sender, EventArgs e)
        {
            AddNewProject addNewProject = new AddNewProject();
            addNewProject.ShowDialog();
        }


        private void OpenChorome_Click(object sender, EventArgs e)
        {
            string chromePath = @"C:\Program Files\Google\Chrome\Application\chrome.exe";
            string profileName = "Default"; // Specify the Chrome profile name here

            // List of URLs to open
            List<string> urls = new List<string>
    {
        "https://www.upwork.com/nx/find-work/",
        "https://www.fiverr.com/users/ziaulqamar1/seller_dashboard",
        "https://mail.google.com/mail/u/0/?tab=rm&ogbl#inbox",
        "https://chatgpt.com/"
    };

            foreach (string url in urls)
            {
                Process.Start(chromePath, $"--profile-directory=\"{profileName}\" {url}");
            }
        }

        //// Path to the Chrome User Data directory
        //string userDataPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), @"Google\Chrome\User Data");

        //if (Directory.Exists(userDataPath))
        //{
        //    var profileDirectories = Directory.GetDirectories(userDataPath, "Profile *")
        //        .Select(Path.GetFileName)
        //        .ToList();

        //    // Add the default profile
        //    profileDirectories.Insert(0, "Default");

        //    // Create a string with all profile names
        //    string profilesList = string.Join(Environment.NewLine, profileDirectories);




        //    // Show the profiles in a message box
        //    MessageBox.Show(profilesList, "Chrome Profiles", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //}
        //else
        //{
        //    MessageBox.Show("Chrome User Data directory not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //}



    }
}