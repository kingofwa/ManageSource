using System;
using System.Windows.Forms;

namespace ManageSource.Presentation
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Check if the repository path is saved in settings
            string repositoryPath = Settings.Default.RepositoryPath;

            if (!string.IsNullOrEmpty(repositoryPath) && System.IO.Directory.Exists(repositoryPath))
            {
                // If a repository path is saved, show MainForm
                MainForm mainForm = new MainForm();
                mainForm.LoadCommits(repositoryPath);
                Application.Run(mainForm);
            }
            else
            {
                // If no repository path is saved, show CloneForm
                Application.Run(new CloneForm());
            }
        }
    }
}
