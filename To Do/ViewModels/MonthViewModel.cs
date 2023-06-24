using AutoMapper;
using To_Do.Services;
using To_Do.Shared;

namespace To_Do.ViewModels;

internal class MonthViewModel : ToDoBaseViewModel
{
    public MonthViewModel(IToDoTaskService service, IMapper mapper) 
        : base("������", service, TaskType.MONTH, mapper)
    {

    }

}