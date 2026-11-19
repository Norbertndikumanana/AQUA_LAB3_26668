using AquaApp.Models;
using NHibernate;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;

namespace AquaApp.Models
{
    // NHibernate "mapping by code": tells NHibernate which table and column
    // each model class and property is stored in. NHibernate creates the
    // tables from these mappings automatically (see NHibernateHelper).

    public class UserMap : ClassMapping<User>
    {
        public UserMap()
        {
            Table("users");
            Lazy(false);
            Id(x => x.UserId, m => { m.Column("user_id"); m.Generator(Generators.Identity); });
            Property(x => x.FullName, m => { m.Column("full_name"); m.Length(100); m.NotNullable(true); });
            Property(x => x.Email, m => { m.Column("email"); m.Length(150); m.NotNullable(true); m.Unique(true); });
            Property(x => x.PasswordHash, m => { m.Column("password_hash"); m.Length(200); m.NotNullable(true); });
            Property(x => x.Role, m => { m.Column("role"); m.Length(20); m.NotNullable(true); });
            Property(x => x.OrganizationName, m => { m.Column("organization_name"); m.Length(150); });
            Property(x => x.Phone, m => { m.Column("phone"); m.Length(30); });
            Property(x => x.IsActive, m => { m.Column("is_active"); m.NotNullable(true); });
            Property(x => x.CreatedAt, m => { m.Column("created_at"); m.NotNullable(true); });
        }
    }

    public class CategoryMap : ClassMapping<Category>
    {
        public CategoryMap()
        {
            Table("categories");
            Lazy(false);
            Id(x => x.CategoryId, m => { m.Column("category_id"); m.Generator(Generators.Identity); });
            Property(x => x.Name, m => { m.Column("name"); m.Length(100); m.NotNullable(true); m.Unique(true); });
            Property(x => x.Description, m => { m.Column("description"); m.Length(300); });
        }
    }

    public class ProjectMap : ClassMapping<Project>
    {
        public ProjectMap()
        {
            Table("projects");
            Lazy(false);
            Id(x => x.ProjectId, m => { m.Column("project_id"); m.Generator(Generators.Identity); });
            Property(x => x.ReferenceNo, m => { m.Column("reference_no"); m.Length(20); m.NotNullable(true); m.Unique(true); });
            Property(x => x.Title, m => { m.Column("title"); m.Length(200); m.NotNullable(true); });
            Property(x => x.Description, m =>
            {
                m.Column(c => { c.Name("description"); c.SqlType("text"); c.NotNullable(true); });
                m.Type(NHibernateUtil.StringClob);
            });
            Property(x => x.Location, m => { m.Column("location"); m.Length(150); m.NotNullable(true); });
            Property(x => x.Budget, m => { m.Column("budget"); m.Precision(18); m.Scale(2); m.NotNullable(true); });
            Property(x => x.Status, m => { m.Column("status"); m.Length(30); m.NotNullable(true); });
            Property(x => x.DecisionReason, m =>
            {
                m.Column(c => { c.Name("decision_reason"); c.SqlType("text"); });
                m.Type(NHibernateUtil.StringClob);
            });
            Property(x => x.IsArchived, m => { m.Column("is_archived"); m.NotNullable(true); });
            Property(x => x.SubmittedAt, m => { m.Column("submitted_at"); m.NotNullable(true); });
            Property(x => x.UpdatedAt, m => { m.Column("updated_at"); m.NotNullable(true); });

            ManyToOne(x => x.Category, m =>
            {
                m.Column("category_id"); m.NotNullable(true); m.ForeignKey("fk_projects_category");
                m.Lazy(LazyRelation.NoLazy); m.Fetch(FetchKind.Join);
            });
            ManyToOne(x => x.Organization, m =>
            {
                m.Column("organization_id"); m.NotNullable(true); m.ForeignKey("fk_projects_organization");
                m.Lazy(LazyRelation.NoLazy); m.Fetch(FetchKind.Join);
            });
            ManyToOne(x => x.Reviewer, m =>
            {
                m.Column("reviewer_id"); m.ForeignKey("fk_projects_reviewer");
                m.Lazy(LazyRelation.NoLazy); m.Fetch(FetchKind.Join);
            });
        }
    }

    public class ProjectDocumentMap : ClassMapping<ProjectDocument>
    {
        public ProjectDocumentMap()
        {
            Table("project_documents");
            Lazy(false);
            Id(x => x.DocumentId, m => { m.Column("document_id"); m.Generator(Generators.Identity); });
            Property(x => x.FileName, m => { m.Column("file_name"); m.Length(260); m.NotNullable(true); });
            Property(x => x.FilePath, m => { m.Column("file_path"); m.Length(500); m.NotNullable(true); });
            Property(x => x.UploadedAt, m => { m.Column("uploaded_at"); m.NotNullable(true); });
            ManyToOne(x => x.Project, m =>
            {
                m.Column("project_id"); m.NotNullable(true); m.ForeignKey("fk_documents_project");
                m.Lazy(LazyRelation.NoLazy);
            });
        }
    }

    public class ReviewCommentMap : ClassMapping<ReviewComment>
    {
        public ReviewCommentMap()
        {
            Table("review_comments");
            Lazy(false);
            Id(x => x.CommentId, m => { m.Column("comment_id"); m.Generator(Generators.Identity); });
            Property(x => x.Type, m => { m.Column("type"); m.Length(20); m.NotNullable(true); });
            Property(x => x.Text, m =>
            {
                m.Column(c => { c.Name("text"); c.SqlType("text"); c.NotNullable(true); });
                m.Type(NHibernateUtil.StringClob);
            });
            Property(x => x.CreatedAt, m => { m.Column("created_at"); m.NotNullable(true); });
            ManyToOne(x => x.Project, m =>
            {
                m.Column("project_id"); m.NotNullable(true); m.ForeignKey("fk_comments_project");
                m.Lazy(LazyRelation.NoLazy);
            });
            ManyToOne(x => x.Author, m =>
            {
                m.Column("user_id"); m.NotNullable(true); m.ForeignKey("fk_comments_user");
                m.Lazy(LazyRelation.NoLazy); m.Fetch(FetchKind.Join);
            });
        }
    }
}
