using System;

namespace Domain.Commands
{
    public class CreateTaskCommand
    {
        public Guid Id { get; set; }
        public string Subject { get; set; }
        public Guid AssignedMemberId { get; set; }
        public bool IsComplete { get; set; }
    }
}
