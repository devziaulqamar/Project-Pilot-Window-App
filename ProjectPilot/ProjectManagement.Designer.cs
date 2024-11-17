namespace ProjectPilot
{
    partial class ProjectManagement
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.GroupBox groupBoxActions;
        private System.Windows.Forms.GroupBox groupBoxProjects;
        private System.Windows.Forms.Button AddNewProject;
        private System.Windows.Forms.Button OpenChorome;
        private System.Windows.Forms.DataGridView dataGridView1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelHeader = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.groupBoxActions = new System.Windows.Forms.GroupBox();
            this.AddNewProject = new System.Windows.Forms.Button();
            this.OpenChorome = new System.Windows.Forms.Button();
            this.groupBoxProjects = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ProjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectLink = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelHeader.SuspendLayout();
            this.groupBoxActions.SuspendLayout();
            this.groupBoxProjects.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panelHeader.Controls.Add(this.labelTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1120, 60);
            this.panelHeader.TabIndex = 0;
            // 
            // labelTitle
            // 
            this.labelTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(0, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(1120, 60);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Project Management";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBoxActions
            // 
            this.groupBoxActions.Controls.Add(this.AddNewProject);
            this.groupBoxActions.Controls.Add(this.OpenChorome);
            this.groupBoxActions.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.groupBoxActions.Location = new System.Drawing.Point(10, 80);
            this.groupBoxActions.Name = "groupBoxActions";
            this.groupBoxActions.Size = new System.Drawing.Size(220, 355);
            this.groupBoxActions.TabIndex = 1;
            this.groupBoxActions.TabStop = false;
            this.groupBoxActions.Text = "Actions";
            // 
            // AddNewProject
            // 
            this.AddNewProject.BackColor = System.Drawing.Color.LightGreen;
            this.AddNewProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddNewProject.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.AddNewProject.Location = new System.Drawing.Point(20, 30);
            this.AddNewProject.Name = "AddNewProject";
            this.AddNewProject.Size = new System.Drawing.Size(180, 40);
            this.AddNewProject.TabIndex = 0;
            this.AddNewProject.Text = "Add New Project";
            this.AddNewProject.UseVisualStyleBackColor = false;
            // 
            // OpenChorome
            // 
            this.OpenChorome.BackColor = System.Drawing.Color.LightBlue;
            this.OpenChorome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenChorome.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.OpenChorome.Location = new System.Drawing.Point(20, 80);
            this.OpenChorome.Name = "OpenChorome";
            this.OpenChorome.Size = new System.Drawing.Size(180, 40);
            this.OpenChorome.TabIndex = 1;
            this.OpenChorome.Text = "Open Chrome";
            this.OpenChorome.UseVisualStyleBackColor = false;
            // 
            // groupBoxProjects
            // 
            this.groupBoxProjects.Controls.Add(this.dataGridView1);
            this.groupBoxProjects.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.groupBoxProjects.Location = new System.Drawing.Point(240, 80);
            this.groupBoxProjects.Name = "groupBoxProjects";
            this.groupBoxProjects.Size = new System.Drawing.Size(874, 355);
            this.groupBoxProjects.TabIndex = 2;
            this.groupBoxProjects.TabStop = false;
            this.groupBoxProjects.Text = "Project List";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProjectName,
            this.ProjectLink});
            this.dataGridView1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dataGridView1.Location = new System.Drawing.Point(10, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(854, 324);
            this.dataGridView1.TabIndex = 0;
            // 
            // ProjectName
            // 
            this.ProjectName.HeaderText = "Project Name";
            this.ProjectName.MinimumWidth = 6;
            this.ProjectName.Name = "ProjectName";
            this.ProjectName.Width = 200;
            // 
            // ProjectLink
            // 
            this.ProjectLink.HeaderText = "Project Link";
            this.ProjectLink.MinimumWidth = 6;
            this.ProjectLink.Name = "ProjectLink";
            this.ProjectLink.Width = 350;
            // 
            // ProjectManagement
            // 
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::ProjectPilot.Properties.Resources._003_subtle_light_pattern_background_texture;
            this.ClientSize = new System.Drawing.Size(1120, 446);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.groupBoxActions);
            this.Controls.Add(this.groupBoxProjects);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ProjectManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Project Management";
            this.panelHeader.ResumeLayout(false);
            this.groupBoxActions.ResumeLayout(false);
            this.groupBoxProjects.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectLink;
    }

}