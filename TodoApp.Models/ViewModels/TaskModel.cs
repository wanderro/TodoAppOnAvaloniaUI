namespace TodoApp.Models.ViewModels;

public class TaskModel : BaseViewModel
{
    public string Header { get; set; }

    public string? Description { get; set; }

    public bool IsDone { get; set; }
}