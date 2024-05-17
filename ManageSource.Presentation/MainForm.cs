using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using LibGit2Sharp;
using ManageSource.Presentation.Modal;

namespace ManageSource.Presentation
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }

        public void LoadCommits(string repositoryPath)
        {
            // Load commits into DataGridView
            var commits = GetCommits(repositoryPath);
            dgvCommits.DataSource = commits;
            dgvCommits.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Load branches into TreeViews
            LoadLocalBranches(repositoryPath);
            LoadRemoteBranches(repositoryPath);
        }

        public void UpdateCommitsAndActivateLatestCommit(Branch branch)
        {
            ActivateLatestCommit(branch);
        }

        private void ActivateLatestCommit(Branch branch)
        {
            // Kích hoạt commit mới nhất của nhánh
            Commit latestCommit = branch.Tip;

            // Thực hiện các hành động cần thiết để kích hoạt commit mới nhất
            // Ví dụ:
            // ActivateCommit(latestCommit);
        }

        private List<CommitInfo> GetCommits(string repositoryPath)
        {
            var commitList = new List<CommitInfo>();
            using (var repo = new Repository(repositoryPath))
            {
                foreach (var commit in repo.Commits)
                {
                    commitList.Add(new CommitInfo
                    {
                        Sha = commit.Sha,
                        Author = commit.Author.Name,
                        Message = commit.MessageShort,
                        Date = commit.Author.When.LocalDateTime
                    });
                }
            }
            return commitList;
        }

        private void LoadLocalBranches(string repositoryPath)
        {
            treeViewLocalBranches.Nodes.Clear();

            using (var repo = new Repository(repositoryPath))
            {
                foreach (var branch in repo.Branches)
                {
                    if (branch.IsRemote)
                        continue;

                    TreeNode branchNode = new TreeNode(branch.FriendlyName);
                    treeViewLocalBranches.Nodes.Add(branchNode);
                }
            }
        }

        private void LoadRemoteBranches(string repositoryPath)
        {
            treeViewRemoteBranches.Nodes.Clear();

            using (var repo = new Repository(repositoryPath))
            {
                foreach (var branch in repo.Branches)
                {
                    if (!branch.IsRemote)
                        continue;

                    TreeNode branchNode = new TreeNode(branch.FriendlyName);
                    treeViewRemoteBranches.Nodes.Add(branchNode);
                }
            }
        }

        private void TreeViewLocalBranches_AfterSelect(object sender, TreeViewEventArgs e)
        {
            // Handle node selection event for local branches TreeView
            // You can load commits for the selected branch here
            // For simplicity, let's just display the selected branch name
            MessageBox.Show($"Selected Local Branch: {e.Node.Text}");
        }

        private void TreeViewRemoteBranches_AfterSelect(object sender, TreeViewEventArgs e)
        {
            // Handle node selection event for remote branches TreeView
            // You can load commits for the selected branch here
            // For simplicity, let's just display the selected branch name
            MessageBox.Show($"Selected Remote Branch: {e.Node.Text}");
        }

        private bool IsRemoteBranchNode(TreeNode node)
        {
            // Thực hiện kiểm tra xem node có phải là một nhánh remote hay không
            // Đây là nơi bạn thực hiện logic kiểm tra xem node có phải là nhánh remote hay không
            // Trong trường hợp này, chúng ta giả định rằng tên nhánh remote sẽ bắt đầu bằng "origin/"
            return node.Text.StartsWith("origin/");
        }

        private void treeViewRemoteBranches_DoubleClick(object sender, EventArgs e)
        {
            MouseEventArgs mouseEventArgs = e as MouseEventArgs;

            if (mouseEventArgs != null && mouseEventArgs.Button == MouseButtons.Left && mouseEventArgs.Clicks == 2)
            {
                TreeNode selectedNode = treeViewRemoteBranches.SelectedNode;

                if (selectedNode != null && IsRemoteBranchNode(selectedNode))
                {
                    // Lấy tên nhánh được chọn
                    string selectedBranch = selectedNode.Text;

                    // Hiển thị form CheckoutNewBranchForm và truyền tên nhánh được chọn
                    CheckoutNewBranchForm checkoutForm = new CheckoutNewBranchForm(selectedBranch);
                    checkoutForm.ShowDialog();
                }
            }
        }



    }
}
