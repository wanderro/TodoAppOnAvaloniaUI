using System.Collections.Generic;

namespace TodoApp.Models.ViewModels;

public class TestDataService : IDataService
{
    public IEnumerable<TaskModel> GetTasks()
    {
        return new[]
        {
            new TaskModel()
            {
                Header = "Task1",
                IsDone = true
            },
            new TaskModel()
            {
                Header = "Task2"
            }
        };
    }
}