using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibGit2Sharp;

namespace ManageSource.DAL
{
    public class GitRepository
    {
        public void Clone(string url, string path)
        {
            Repository.Clone(url, path);
        }

        public IEnumerable<Commit> GetCommitHistory(string repositoryPath)
        {
            using (var repo = new Repository(repositoryPath))
            {
                return repo.Commits;
            }
        }
    }
}
