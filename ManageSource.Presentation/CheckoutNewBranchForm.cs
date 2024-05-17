using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using LibGit2Sharp;
using ManageSource.Presentation.Helper;

namespace ManageSource.Presentation
{
    public partial class CheckoutNewBranchForm : Form
    {
        private string selectedRemoteBranch;
        private TreeView treeViewLocalBranches;
        public CheckoutNewBranchForm(string selectedBranch)
        {
            InitializeComponent();
            LoadBranches();
            selectedRemoteBranch = selectedBranch;
            CenterForms.CenterForm(this);
            treeViewLocalBranches = new TreeView();
        }

        private void LoadBranches()
        {
            string repositoryPath = Settings.Default.RepositoryPath;

            // Tải danh sách các nhánh từ repository
            using (var repo = new Repository(repositoryPath))
            {
                // Lấy danh sách các nhánh và hiển thị chúng trong ComboBox
                foreach (var branch in repo.Branches)
                {
                    ccbRemoteBranchs.Items.Add(branch.FriendlyName);
                }
            }
        }


        // Xử lý sự kiện khi người dùng chọn một nhánh từ ComboBox
        private void comboBoxBranches_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Lấy tên của nhánh được chọn
            string selectedBranch = ccbRemoteBranchs.SelectedItem.ToString();
            // Gán tên nhánh được chọn vào một TextBox hoặc thực hiện các hành động khác
            // Ví dụ:
            // textBoxSelectedBranch.Text = selectedBranch;
        }

        private void CheckoutNewBranchForm_Load_1(object sender, EventArgs e)
        {
            // Thiết lập giá trị cho ComboBox bằng tên nhánh được chọn
            ccbRemoteBranchs.SelectedItem = selectedRemoteBranch;
        }

        private void btnCloseNewBranch_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Phương thức để lấy tên nhánh local tương ứng với nhánh remote được chọn
        private string GetLocalBranchName(string remoteBranchName)
        {
            // Logic để lấy tên nhánh local tương ứng với nhánh remote
            // Trong trường hợp này, chúng ta giả định rằng tên nhánh local sẽ là tên nhánh remote được chọn
            // Bạn có thể thay đổi logic này nếu cần thiết
            return remoteBranchName;
        }

        private void ccbRemoteBranchs_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            // Lấy tên của nhánh remote được chọn từ ComboBox
            string selectedRemoteBranch = ccbRemoteBranchs.SelectedItem.ToString();

            // Lấy tên nhánh local tương ứng với nhánh remote được chọn
            string localBranchName = GetLocalBranchName(selectedRemoteBranch);

            // Đổ tên nhánh local vào TextBox
            txtLocalNewBranch.Text = localBranchName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Lấy tên nhánh từ txtLocalNewBranch
            string newBranchName = txtLocalNewBranch.Text;

            // Tạo nhánh mới ở local repository
            CreateOrUpdateLocalBranch(newBranchName);

            // Cập nhật danh sách nhánh local và hiển thị lại trong TreeView
            UpdateLocalBranchesTreeView();

            // Chọn nhánh mới làm nhánh hiện tại (nổi bật) trong TreeView
            SelectNewBranchInTreeView(newBranchName);
        }

        private void CreateOrUpdateLocalBranch(string branchName)
        {
            string repositoryPath = Settings.Default.RepositoryPath;

            using (var repo = new Repository(repositoryPath))
            {
                Branch existingBranch = repo.Branches[branchName];

                if (existingBranch != null)
                {
                    // Nhánh đã tồn tại, checkout sang nhánh đó
                    Commands.Checkout(repo, existingBranch);

                    // Cập nhật danh sách commit và kích hoạt commit mới nhất của nhánh trên MainForm
                    MainForm mainForm = Application.OpenForms.OfType<MainForm>().FirstOrDefault();
                    if (mainForm != null)
                    {
                        mainForm.UpdateCommitsAndActivateLatestCommit(existingBranch);
                    }
                }
                else
                {
                    // Tạo nhánh mới
                    repo.Branches.Add(branchName, repo.Branches["HEAD"].Tip);
                    Commands.Checkout(repo, branchName);

                    // Cập nhật danh sách commit và kích hoạt commit mới nhất của nhánh trên MainForm
                    MainForm mainForm = Application.OpenForms.OfType<MainForm>().FirstOrDefault();
                    if (mainForm != null)
                    {
                        mainForm.UpdateCommitsAndActivateLatestCommit(repo.Branches[branchName]);
                    }
                }
            }

            // Đóng form sau khi đã cập nhật xong
            this.Close();
        }


        // Phương thức để cập nhật danh sách nhánh local và hiển thị lại trong TreeView
        // Phương thức để cập nhật danh sách nhánh local và hiển thị lại trong TreeView
        private void UpdateLocalBranchesTreeView()
        {
            treeViewLocalBranches.Nodes.Clear();

            string repositoryPath = Settings.Default.RepositoryPath;

            using (var repo = new Repository(repositoryPath))
            {
                foreach (var branch in repo.Branches)
                {
                    if (IsLocalBranch(branch))
                    {
                        TreeNode node = treeViewLocalBranches.Nodes.Add(branch.FriendlyName);
                        if (branch.IsCurrentRepositoryHead)
                        {
                            node.NodeFont = new Font(treeViewLocalBranches.Font, FontStyle.Bold);
                        }
                    }
                }
            }
        }

        // Phương thức để kiểm tra xem một nhánh có phải là nhánh local hay không
        private bool IsLocalBranch(Branch branch)
        {
            // Kiểm tra xem tên nhánh có bắt đầu bằng "refs/heads/" hay không
            // Nhánh local thường có dạng này
            return branch.FriendlyName.StartsWith("refs/heads/");
        }


        // Phương thức để chọn nhánh mới làm nhánh hiện tại (nổi bật) trong TreeView
        private void SelectNewBranchInTreeView(string branchName)
        {
            foreach (TreeNode node in treeViewLocalBranches.Nodes)
            {
                if (node.Text == branchName)
                {
                    treeViewLocalBranches.SelectedNode = node;
                    break;
                }
            }
        }
    }

}