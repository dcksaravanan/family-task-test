using System;

namespace Domain.Commands
{
    public class UpdateTaskCommand
    {
        public Guid Id { get; set; }
        public bool IsComplete { get; set; }
        public Guid AssignedMemberId { get; set; }
    }
}
