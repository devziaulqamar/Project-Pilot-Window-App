namespace ProjectPilot
{
    partial class AddNewProject
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ProjectNameLbl = new System.Windows.Forms.Label();
            this.ProjectLinkLbl = new System.Windows.Forms.Label();
            this.ProjectNameInput = new System.Windows.Forms.TextBox();
            this.ProjectLinkInput = new System.Windows.Forms.TextBox();
            this.Save = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ProjectNameLbl
            // 
            this.ProjectNameLbl.AutoSize = true;
            this.ProjectNameLbl.Location = new System.Drawing.Point(12, 22);
            this.ProjectNameLbl.Name = "ProjectNameLbl";
            this.ProjectNameLbl.Size = new System.Drawing.Size(89, 16);
            this.ProjectNameLbl.TabIndex = 0;
            this.ProjectNameLbl.Text = "Project Name";
            // 
            // ProjectLinkLbl
            // 
            this.ProjectLinkLbl.AutoSize = true;
            this.ProjectLinkLbl.Location = new System.Drawing.Point(12, 100);
            this.ProjectLinkLbl.Name = "ProjectLinkLbl";
            this.ProjectLinkLbl.Size = new System.Drawing.Size(76, 16);
            this.ProjectLinkLbl.TabIndex = 1;
            this.ProjectLinkLbl.Text = "Project Link";
            // 
            // ProjectNameInput
            // 
            this.ProjectNameInput.Location = new System.Drawing.Point(12, 48);
            this.ProjectNameInput.Multiline = true;
            this.ProjectNameInput.Name = "ProjectNameInput";
            this.ProjectNameInput.Size = new System.Drawing.Size(374, 37);
            this.ProjectNameInput.TabIndex = 2;
            // 
            // ProjectLinkInput
            // 
            this.ProjectLinkInput.Location = new System.Drawing.Point(12, 122);
            this.ProjectLinkInput.Multiline = true;
            this.ProjectLinkInput.Name = "ProjectLinkInput";
            this.ProjectLinkInput.Size = new System.Drawing.Size(374, 38);
            this.ProjectLinkInput.TabIndex = 3;
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(210, 170);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(84, 33);
            this.Save.TabIndex = 4;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(302, 170);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(84, 33);
            this.CancelBtn.TabIndex = 5;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // AddNewProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 215);
            this.ControlBox = false;
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.ProjectLinkInput);
            this.Controls.Add(this.ProjectNameInput);
            this.Controls.Add(this.ProjectLinkLbl);
            this.Controls.Add(this.ProjectNameLbl);
            this.Name = "AddNewProject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Project";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ProjectNameLbl;
        private System.Windows.Forms.Label ProjectLinkLbl;
        private System.Windows.Forms.TextBox ProjectNameInput;
        private System.Windows.Forms.TextBox ProjectLinkInput;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button CancelBtn;
    }
}
