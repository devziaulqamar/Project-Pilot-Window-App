using System;
using System.IO;
using System.Windows.Forms;
using OfficeOpenXml;

namespace ProjectPilot
{
    public partial class AddNewProject : Form
    {
        private string filePath = @"F:\Project Management\Projects.xlsx";
        private int? editRowIndex;

        public AddNewProject(string projectName = "", string projectLink = "", int? rowIndex = null)
        {
            InitializeComponent();
            ProjectNameInput.Text = projectName;
            ProjectLinkInput.Text = projectLink;
            editRowIndex = rowIndex;
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            string projectName = ProjectNameInput.Text;
            string projectLink = ProjectLinkInput.Text;

            if (string.IsNullOrWhiteSpace(projectName) || string.IsNullOrWhiteSpace(projectLink))
            {
                MessageBox.Show("Project Name and Project Link cannot be empty.");
                return;
            }

            if (editRowIndex.HasValue)
            {
                UpdateProjectInExcel(projectName, projectLink, editRowIndex.Value);
            }
            else
            {
                AddProjectToExcel(projectName, projectLink);
            }

            MessageBox.Show("Saved successfully");

            this.Close();
        }

        private void AddProjectToExcel(string projectName, string projectLink)
        {
            FileInfo fileInfo = new FileInfo(filePath);

            // Set the license context
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial; // Or LicenseContext.Commercial

            using (ExcelPackage package = new ExcelPackage(fileInfo))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets[0]; // Get the first worksheet
                int newRow = worksheet.Dimension.End.Row + 1; // Determine the next row

                worksheet.Cells[newRow, 1].Value = projectName; // Column A for Project Name
                worksheet.Cells[newRow, 2].Value = projectLink; // Column B for Project Link

                package.Save(); // Save the changes
            }
        }

        private void UpdateProjectInExcel(string projectName, string projectLink, int rowIndex)
        {
            FileInfo fileInfo = new FileInfo(filePath);

            // Set the license context
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial; // Or LicenseContext.Commercial

            using (ExcelPackage package = new ExcelPackage(fileInfo))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets[0]; // Get the first worksheet

                worksheet.Cells[rowIndex + 2, 1].Value = projectName; // Column A for Project Name
                worksheet.Cells[rowIndex + 2, 2].Value = projectLink; // Column B for Project Link (rowIndex + 2 because Excel rows are 1-based and we skip the header)

                package.Save(); // Save the changes
            }
        }
    }
}
