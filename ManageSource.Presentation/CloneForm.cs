using ManageSource.BLL;
using System;
using System.Windows.Forms;

namespace ManageSource.Presentation
{
    public partial class CloneForm : Form
    {
        private RepositoryManager repositoryManager;

        public CloneForm()
        {
            InitializeComponent();
            repositoryManager = new RepositoryManager();
        }

        private void btnClone_Click(object sender, EventArgs e)
        {
            string url = txtUrlReposetory.Text;
            string path = txtPathFolder.Text;

            if (!string.IsNullOrEmpty(url) && !string.IsNullOrEmpty(path))
            {
                try
                {
                    // Clone repository using RepositoryManager
                    repositoryManager.CloneRepository(url, path);

                    // Save the repository path to settings
                    Settings.Default.RepositoryPath = path;
                    Settings.Default.Save();

                    // Hide the CloneForm
                    this.Hide();

                    // Show the MainForm and load commits
                    MainForm mainForm = new MainForm();
                    mainForm.LoadCommits(path);
                    mainForm.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while cloning the repository: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Please enter both the repository URL and the path to save the repository.");
            }
        }

        private void btnBrowsePath_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                folderBrowserDialog.Description = "Select the directory to save the repository";
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    txtPathFolder.Text = folderBrowserDialog.SelectedPath;
                }
            }
        }

        private void btnBrowseReposetory_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                folderBrowserDialog.Description = "Source path or URL";
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    txtUrlReposetory.Text = folderBrowserDialog.SelectedPath;
                }
            }
        }
    }
}
