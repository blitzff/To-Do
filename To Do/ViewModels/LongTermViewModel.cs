using AutoMapper;
using To_Do.Services;
using To_Do.Shared;

namespace To_Do.ViewModels;

internal class LongTermViewModel : ToDoBaseViewModel
{
    public LongTermViewModel(IToDoApi service, IMapper mapper) 
        : base("��������", service, TaskType.LONGTERM, mapper)
    {
    }

}