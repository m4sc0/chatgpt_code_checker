using Masco.ProjectManagement.Enums;

namespace Masco.ProjectManagement.Interfaces;

public record ProjectDetails(string ProjectName, int ProjectID, string ProjectDescription, DateTime Start, DateTime End, Status status = Status.NotStarted);

public interface IProject
{
    ProjectDetails ProjectDetails { get; set; }
    void AddTask(ITask task);
    void RemoveTask(int id);
}
