using Core;
using Core.Abstractions.Repositories;
using Domain.DataModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace DataLayer
{
    public class TaskRepository : BaseRepository<Guid, Domain.DataModels.Task, TaskRepository>, ITaskRepository
    {
        public TaskRepository(FamilyTaskContext context) : base(context)
        { }



        ITaskRepository IBaseRepository<Guid, Domain.DataModels.Task, ITaskRepository>.NoTrack()
        {
            return base.NoTrack();
        }

        ITaskRepository IBaseRepository<Guid, Domain.DataModels.Task, ITaskRepository>.Reset()
        {
            return base.Reset();
        }
        public virtual async Task<int> ToggleTaskAsync(Guid id, CancellationToken cancellationToken = default)
        {
            var item = await Context.FindAsync<Domain.DataModels.Task>(id);
            if (item == null) throw new NotFoundException<Guid>(typeof(Domain.DataModels.Task).Name, id);
            item.IsComplete = !item.IsComplete;
            var result = Context.Attach(item);
            result.State = EntityState.Modified;

            return await Context.SaveChangesAsync(cancellationToken);
        }

    }
}
