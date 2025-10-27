using GenericRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace TrAdresılIlce.Application.Extensions
{
    public static class RepositoryExtensions
    {
        public static async Task<TEntity?> GetByIdAsync<TEntity>(
            this IRepository<TEntity> repository,
            Guid id,
            CancellationToken cancellationToken = default)
            where TEntity : class
        {
            return await repository.GetByExpressionWithTrackingAsync(
                e => EF.Property<Guid>(e, "Id") == id,
                cancellationToken);
        }
        public static async Task<TEntity?> GetByIdAsync<TEntity>(
            this IRepository<TEntity> repository,
            int id,
            CancellationToken cancellationToken = default)
            where TEntity : class
        {
            return await repository.GetByExpressionWithTrackingAsync(
                e => EF.Property<int>(e, "Id") == id,
                cancellationToken);
        }

        public static async Task<List<TEntity>> GetAllAsync<TEntity>(
            this IRepository<TEntity> repository,
            CancellationToken cancellationToken = default)
            where TEntity : class
        {
            return await repository.GetAll().ToListAsync(cancellationToken);
        }

        public static async Task<List<TEntity>> GetListByExpressionAsync<TEntity>(
            this IRepository<TEntity> repository,
            Expression<Func<TEntity, bool>> expression,
            CancellationToken cancellationToken = default)
            where TEntity : class
        {
            return await repository.GetAll()
                .Where(expression)
                .ToListAsync(cancellationToken);
        }

        public static void RemoveRange<TEntity>(
            this IRepository<TEntity> repository,
            IEnumerable<TEntity> entities)
            where TEntity : class
        {
            foreach (var entity in entities)
            {
                repository.Delete(entity);
            }
        }
    }
}