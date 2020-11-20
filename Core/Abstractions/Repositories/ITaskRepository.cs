using Domain.DataModels;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Core.Abstractions.Repositories
{
    public interface ITaskRepository : IBaseRepository<Guid, Domain.DataModels.Task, ITaskRepository>
    {
        Task<int> ToggleTaskAsync(Guid id, CancellationToken cancellationToken = default);
    }
}
