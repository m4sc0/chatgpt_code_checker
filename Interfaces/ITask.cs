using Masco.ProjectManagement.Enums;

namespace Masco.ProjectManagement.Interfaces;

public record TaskDetails(string TaskName, int TaskID, string TaskDescription, DateTime Start, DateTime End, Status status = Status.NotStarted);
public interface ITask
{
    TaskDetails TaskDetails { get; set; }
    void AddSubTask(ITask task);
    void UpdateStatus(Status status);
    TaskDetails GetTaskDetails();
    TaskStatus GetStatus();
}