namespace TodoApp.Models.ViewModels;

public interface IDataService
{
    IEnumerable<TaskModel> GetTasks();
}