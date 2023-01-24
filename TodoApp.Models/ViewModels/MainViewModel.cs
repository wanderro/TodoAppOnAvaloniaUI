using System.Collections.ObjectModel;

namespace TodoApp.Models.ViewModels;

public class MainViewModel : BaseViewModel
{
    public ObservableCollection<TaskModel> Tasks { get; }

    public TaskModel? CurrentTask { get; set; }

    public MainViewModel(IDataService dataService)
    {
        Tasks = new ObservableCollection<TaskModel>(dataService.GetTasks());
        
        CurrentTask = Tasks.FirstOrDefault();
    }

    public void AddTask()
    {
       Tasks.Add(new TaskModel()
       {
           Header = "New Task"
       });

       CurrentTask = Tasks.LastOrDefault();
    }
}