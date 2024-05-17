using System;
using LibGit2Sharp;

namespace ManageSource.BLL
{
    public class RepositoryManager
    {
        public void CloneRepository(string url, string path)
        {
            try
            {
                Repository.Clone(url, path);
            }
            catch (Exception ex)
            {
                // Handle any errors that occur during the clone process
                throw new Exception("Clone failed", ex);
            }
        }
    }
}
