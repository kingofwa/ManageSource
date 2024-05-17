namespace ManageSource.Presentation
{
    partial class CheckoutNewBranchForm
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
            label2 = new Label();
            txtLocalNewBranch = new TextBox();
            ccbRemoteBranchs = new ComboBox();
            btnOkeCheckout = new Button();
            btnCloseNewBranch = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 40);
            label1.Name = "label1";
            label1.Size = new Size(171, 20);
            label1.TabIndex = 0;
            label1.Text = "Checkout remote branch";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 94);
            label2.Name = "label2";
            label2.Size = new Size(156, 20);
            label2.TabIndex = 1;
            label2.Text = "New local ranch name";
            // 
            // txtLocalNewBranch
            // 
            txtLocalNewBranch.Location = new Point(228, 87);
            txtLocalNewBranch.Name = "txtLocalNewBranch";
            txtLocalNewBranch.Size = new Size(395, 27);
            txtLocalNewBranch.TabIndex = 2;
            // 
            // ccbRemoteBranchs
            // 
            ccbRemoteBranchs.FormattingEnabled = true;
            ccbRemoteBranchs.Location = new Point(228, 40);
            ccbRemoteBranchs.Name = "ccbRemoteBranchs";
            ccbRemoteBranchs.Size = new Size(395, 28);
            ccbRemoteBranchs.TabIndex = 3;
            ccbRemoteBranchs.SelectedIndexChanged += ccbRemoteBranchs_SelectedIndexChanged_1;
            // 
            // btnOkeCheckout
            // 
            btnOkeCheckout.Location = new Point(355, 168);
            btnOkeCheckout.Name = "btnOkeCheckout";
            btnOkeCheckout.Size = new Size(131, 29);
            btnOkeCheckout.TabIndex = 4;
            btnOkeCheckout.Text = "OKE";
            btnOkeCheckout.UseVisualStyleBackColor = true;
            btnOkeCheckout.Click += button1_Click;
            // 
            // btnCloseNewBranch
            // 
            btnCloseNewBranch.Location = new Point(492, 168);
            btnCloseNewBranch.Name = "btnCloseNewBranch";
            btnCloseNewBranch.Size = new Size(131, 29);
            btnCloseNewBranch.TabIndex = 0;
            btnCloseNewBranch.Text = "CANCEL";
            btnCloseNewBranch.Click += btnCloseNewBranch_Click;
            // 
            // CheckoutNewBranchForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(636, 209);
            ControlBox = false;
            Controls.Add(btnCloseNewBranch);
            Controls.Add(btnOkeCheckout);
            Controls.Add(ccbRemoteBranchs);
            Controls.Add(txtLocalNewBranch);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CheckoutNewBranchForm";
            Text = "CHECKOUT NEW BRANCH";
            Load += CheckoutNewBranchForm_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtLocalNewBranch;
        private ComboBox ccbRemoteBranchs;
        private Button btnOkeCheckout;
        private Button btnCloseNewBranch;
    }
}