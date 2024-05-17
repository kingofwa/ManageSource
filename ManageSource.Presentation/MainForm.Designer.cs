namespace ManageSource.Presentation
{
    partial class MainForm
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
            label1 = new Label();
            dgvCommits = new DataGridView();
            treeViewLocalBranches = new TreeView();
            treeViewRemoteBranches = new TreeView();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCommits).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 108);
            label1.Name = "label1";
            label1.Size = new Size(84, 20);
            label1.TabIndex = 0;
            label1.Text = "BRANCHES";
            // 
            // dgvCommits
            // 
            dgvCommits.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCommits.Location = new Point(269, 140);
            dgvCommits.Name = "dgvCommits";
            dgvCommits.RowHeadersWidth = 51;
            dgvCommits.Size = new Size(1061, 516);
            dgvCommits.TabIndex = 1;
            // 
            // treeViewLocalBranches
            // 
            treeViewLocalBranches.Location = new Point(12, 140);
            treeViewLocalBranches.Name = "treeViewLocalBranches";
            treeViewLocalBranches.Size = new Size(251, 248);
            treeViewLocalBranches.TabIndex = 2;
            // 
            // treeViewRemoteBranches
            // 
            treeViewRemoteBranches.Location = new Point(12, 414);
            treeViewRemoteBranches.Name = "treeViewRemoteBranches";
            treeViewRemoteBranches.Size = new Size(251, 242);
            treeViewRemoteBranches.TabIndex = 3;
            treeViewRemoteBranches.DoubleClick += treeViewRemoteBranches_DoubleClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 391);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 4;
            label2.Text = "REMOTES";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1347, 670);
            Controls.Add(label2);
            Controls.Add(treeViewRemoteBranches);
            Controls.Add(treeViewLocalBranches);
            Controls.Add(dgvCommits);
            Controls.Add(label1);
            Name = "MainForm";
            Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)dgvCommits).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvCommits;
        private TreeView treeViewLocalBranches;
        private TreeView treeViewRemoteBranches;
        private Label label2;
    }
}