using Masco.ProjectManagement.Interfaces;

namespace Masco.ProjectManagement.Projects;

public class Project : IProject
{
    public ProjectDetails ProjectDetails { get; set; }
    public List<ITask> Tasks { get; set; }
    public Project(string name, int id, string description, DateTime startDate, DateTime endDate)
    {
        ProjectDetails = new ProjectDetails(name, id, description, startDate, endDate);
    }
    public void AddTask(ITask task)
    {
        Tasks.Append(task);
    }

    public void RemoveTask(int id)
    {
        var task = Tasks.FirstOrDefault(t => t.TaskDetails.TaskID == id);
        if (task != null)
        {
            Tasks.Remove(task);
        }
    }
}
