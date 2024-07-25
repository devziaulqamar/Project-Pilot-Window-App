namespace ProjectPilot
{
    partial class ProjectManagement
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button AddNewProject;

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
            this.AddNewProject = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ProjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectLink = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // AddNewProject
            // 
            this.AddNewProject.Location = new System.Drawing.Point(12, 12);
            this.AddNewProject.Name = "AddNewProject";
            this.AddNewProject.Size = new System.Drawing.Size(164, 41);
            this.AddNewProject.TabIndex = 0;
            this.AddNewProject.Text = "Add New Project";
            this.AddNewProject.UseVisualStyleBackColor = true;
            this.AddNewProject.Click += new System.EventHandler(this.AddNewProject_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProjectName,
            this.ProjectLink});
            this.dataGridView1.Location = new System.Drawing.Point(12, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(880, 300);
            this.dataGridView1.TabIndex = 1;
            // 
            // ProjectName
            // 
            this.ProjectName.HeaderText = "Project Name";
            this.ProjectName.MinimumWidth = 6;
            this.ProjectName.Name = "ProjectName";
            this.ProjectName.Width = 125;
            // 
            // ProjectLink
            // 
            this.ProjectLink.HeaderText = "Project Link";
            this.ProjectLink.MinimumWidth = 6;
            this.ProjectLink.Name = "ProjectLink";
            this.ProjectLink.Width = 225;
            // 
            // ProjectManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 381);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.AddNewProject);
            this.MaximizeBox = false;
            this.Name = "ProjectManagement";
            this.ShowIcon = false;
            this.Text = "Project Management";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectLink;
    }
}