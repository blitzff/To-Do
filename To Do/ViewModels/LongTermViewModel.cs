using To_Do.Services;
using To_Do.Shared;

namespace To_Do.ViewModels;

public class LongTermViewModel : ToDoBaseViewModel
{
    public LongTermViewModel(IToDoTaskService service) : base("��������", service, TaskType.LONGTERM)
    {
    }
}