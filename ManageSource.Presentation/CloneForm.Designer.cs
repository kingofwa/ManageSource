namespace ManageSource.Presentation
{
    partial class CloneForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtUrlReposetory = new TextBox();
            txtPathFolder = new TextBox();
            btnClone = new Button();
            btnBrowseReposetory = new Button();
            btnBrowsePath = new Button();
            SuspendLayout();
            // 
            // txtUrlReposetory
            // 
            txtUrlReposetory.Location = new Point(42, 30);
            txtUrlReposetory.Name = "txtUrlReposetory";
            txtUrlReposetory.Size = new Size(593, 27);
            txtUrlReposetory.TabIndex = 0;
            // 
            // txtPathFolder
            // 
            txtPathFolder.AccessibleDescription = "";
            txtPathFolder.Location = new Point(42, 107);
            txtPathFolder.Name = "txtPathFolder";
            txtPathFolder.Size = new Size(593, 27);
            txtPathFolder.TabIndex = 1;
            // 
            // btnClone
            // 
            btnClone.Location = new Point(42, 186);
            btnClone.Name = "btnClone";
            btnClone.Size = new Size(94, 29);
            btnClone.TabIndex = 3;
            btnClone.Text = "CLONE";
            btnClone.UseVisualStyleBackColor = true;
            btnClone.Click += btnClone_Click;
            // 
            // btnBrowseReposetory
            // 
            btnBrowseReposetory.Location = new Point(679, 29);
            btnBrowseReposetory.Name = "btnBrowseReposetory";
            btnBrowseReposetory.Size = new Size(105, 28);
            btnBrowseReposetory.TabIndex = 4;
            btnBrowseReposetory.Text = "Browse";
            btnBrowseReposetory.UseVisualStyleBackColor = true;
            btnBrowseReposetory.Click += btnBrowseReposetory_Click;
            // 
            // btnBrowsePath
            // 
            btnBrowsePath.Location = new Point(679, 106);
            btnBrowsePath.Name = "btnBrowsePath";
            btnBrowsePath.Size = new Size(105, 28);
            btnBrowsePath.TabIndex = 5;
            btnBrowsePath.Text = "Browse";
            btnBrowsePath.UseVisualStyleBackColor = true;
            btnBrowsePath.Click += btnBrowsePath_Click;
            // 
            // CloneForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(834, 246);
            Controls.Add(btnBrowsePath);
            Controls.Add(btnBrowseReposetory);
            Controls.Add(btnClone);
            Controls.Add(txtPathFolder);
            Controls.Add(txtUrlReposetory);
            Name = "CloneForm";
            Text = "CloneReposetory";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUrlReposetory;
        private TextBox txtPathFolder;
        private Button btnClone;
        private Button btnBrowseReposetory;
        private Button btnBrowsePath;
    }
}