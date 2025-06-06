using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MalekeAshtar.Infrastructure.Persistence
{
    public interface IApplicationDb
    {
        #region Structure

        DbSet<TEntity> Set<TEntity>() where TEntity : class;
        int SaveChanges();

        EntityEntry<TEntity> Entry<TEntity>(TEntity entity)
            where TEntity : class;

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);

        #endregion


    }
}
