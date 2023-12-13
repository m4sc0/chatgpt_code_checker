using Masco.ProjectManagement.Interfaces;
using Masco.ProjectManagement.Enums;

namespace Masco.ProjectManagement.Tasks;

public class Task : ITask
{
    public TaskDetails TaskDetails { get; set; }
    public List<ITask> SubTasks { get; set; }

    public Task(TaskDetails taskDetails)
    {
        TaskDetails = taskDetails;
        SubTasks = new List<ITask>();
    }

    public void AddSubTask(ITask task)
    {
        SubTasks.Add(task);
    }

    public void UpdateStatus(Status status)
    {
        TaskStatus.UpdateStatus(status);
    }

    public TaskDetails GetTaskDetails()
    {
        return TaskDetails;
    }

    public TaskStatus GetStatus()
    {
        return TaskStatus;
    }
}
