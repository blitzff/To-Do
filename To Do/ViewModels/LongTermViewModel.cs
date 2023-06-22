using AutoMapper;
using To_Do.Services;
using To_Do.Shared;

namespace To_Do.ViewModels;

internal class LongTermViewModel : ToDoBaseViewModel
{
    public LongTermViewModel(IToDoTaskService service, IMapper mapper) 
        : base("��������", service, TaskType.LONGTERM, mapper)
    {
    }

    public override void Initialize()
    {
        throw new System.NotImplementedException();
    }
}