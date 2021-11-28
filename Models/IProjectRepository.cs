namespace Bhoomika_Sadashiva_Sprint_I.Models
{
    public interface IProjectRepository
    {
        List<Project> GetAllProjects();
        Project GetProjectById(int id);
        Project AddProject(Project project);
        void UpdateProject(Project project);
        void DeleteProject(int id);
    }
}
