using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
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
            // Hide row headers for a cleaner look
            dataGridView1.RowHeadersVisible = false;

            // Set alternating row colors for better readability
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;

            // General DataGridView styling
            //dataGridView1.BackgroundColor = Color.White;
            //dataGridView1.GridColor = Color.LightGray;
            dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.LightSteelBlue;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Black;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.EnableHeadersVisualStyles = false;

            // Add button column for "Open Code"
            DataGridViewButtonColumn openCodeButton = new DataGridViewButtonColumn
            {
                Name = "OpenCodeButton",
                HeaderText = "Open Code",
                Text = "Open Code",
                UseColumnTextForButtonValue = true,
                FlatStyle = FlatStyle.Popup
            };
            //openCodeButton.DefaultCellStyle.ForeColor = Color.White;
            //openCodeButton.DefaultCellStyle.BackColor = Color.SteelBlue; // Same blue for all code buttons
            openCodeButton.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns.Add(openCodeButton);

            // Add button column for "Open Folder"
            DataGridViewButtonColumn openFolderButton = new DataGridViewButtonColumn
            {
                Name = "OpenFolderButton",
                HeaderText = "Open Folder",
                Text = "Open Folder",
                UseColumnTextForButtonValue = true,
                FlatStyle = FlatStyle.Popup
            };
            //openFolderButton.DefaultCellStyle.ForeColor = Color.White;
            //openFolderButton.DefaultCellStyle.BackColor = Color.SteelBlue; // Same blue for all folder buttons
            openFolderButton.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns.Add(openFolderButton);

            // Add button column for "Edit"
            DataGridViewButtonColumn editButton = new DataGridViewButtonColumn
            {
                Name = "EditButton",
                HeaderText = "Edit",
                Text = "Edit",
                UseColumnTextForButtonValue = true,
                FlatStyle = FlatStyle.Popup
            };
            //editButton.DefaultCellStyle.ForeColor = Color.White;
            //editButton.DefaultCellStyle.BackColor = Color.SteelBlue; // Same blue for all edit buttons
            editButton.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns.Add(editButton);
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

        private void OpenFolder(string projectLink)
        {
            try
            {
                Process.Start("explorer.exe", projectLink);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to open folder: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OpenCodeFolder(string projectLink)
        {
            string vscodePath = @"C:\Users\Zia ul Qamar\AppData\Local\Programs\Microsoft VS Code\Code.exe";

            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = vscodePath,
                    Arguments = $"\"{projectLink}\"",
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to open folder in VS Code: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddNewProject_Click_1(object sender, EventArgs e)
        {
            AddNewProject addNewProject = new AddNewProject();
            addNewProject.ShowDialog();
        }

        private void OpenChorome_Click_1(object sender, EventArgs e)
        {
            string chromePath = @"C:\Program Files\Google\Chrome\Application\chrome.exe";
            string profileName = "Default";

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

      
    }
}
