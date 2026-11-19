using AquaApp.Models;
using NHibernate.Linq;

namespace AquaApp.Controllers
{
    public class DocumentRepository
    {
        public List<ProjectDocument> GetByProject(int projectId)
        {
            return NHibernateHelper.Read(s =>
                s.Query<ProjectDocument>()
                 .Where(d => d.Project.ProjectId == projectId)
                 .OrderBy(d => d.UploadedAt)
                 .ToList());
        }

        public ProjectDocument GetById(int documentId)
        {
            return NHibernateHelper.Read(s => s.Get<ProjectDocument>(documentId));
        }

        /// <summary>Saves a document row for an existing project.</summary>
        public void Add(int projectId, string fileName, string filePath)
        {
            NHibernateHelper.Write(s => s.Save(new ProjectDocument
            {
                Project = s.Get<Project>(projectId),
                FileName = fileName,
                FilePath = filePath,
                UploadedAt = DateTime.Now
            }));
        }

        public void Delete(int documentId)
        {
            NHibernateHelper.Write(s => s.Delete(s.Get<ProjectDocument>(documentId)));
        }
    }
}
