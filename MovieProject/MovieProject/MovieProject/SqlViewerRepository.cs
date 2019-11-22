using System;
using DataAccess;
using MovieProject.Models;
using MovieProject.DataDelegates.ViewerDelegates;
namespace MovieProject
{
    public class SqlViewerRepository : IViewerRepository
    {
        private readonly SqlCommandExecutor executor;

        public SqlViewerRepository(string connectionString)
        {
            executor = new SqlCommandExecutor(connectionString);
        }

        public Viewer FetchViewer(int viewerId)
        {
            var d = new FetchViewer(viewerId);
            return executor.ExecuteReader(d);
        }

        public Viewer RetrieveViewerOnEmail(string email)
        {
            var d = new RetrieveViewerOnEmailDataDelegate(email);
            return executor.ExecuteReader(d);
        }

        public Viewer RetrieveViewerOnName(string name)
        {
            var d = new RetrieveViewerOnNameDataDelegate(name);
            return executor.ExecuteReader(d);
        }

        public Viewer RetrieveViewerOnGender(string gender)
        {
            var d = new RetrieveViewerOnGenderDataDelegate(gender);
            return executor.ExecuteReader(d);
        }
    }
}
