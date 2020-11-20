using Domain.Commands;
using System;

namespace Domain.ViewModel
{
    public class TaskVm
    {
        public Guid Id { get; set; }
        public string Subject { get; set; }
        public Guid AssignedMemberId { get; set; }
        public MemberVm AssignedMember { get; set; }
        public bool IsComplete { get; set; }

        public UpdateTaskCommand ToUpdateCommand()
        {
            throw new NotImplementedException();
        }
    }
}
