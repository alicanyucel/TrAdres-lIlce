using GenericRepository;
using TrAdresılIlce.Domain.Entities;

namespace TrAdresılIlce.Domain.Repositories;

public interface ICountryRepository : IRepository<Country>
{
    Task<List<Country>> GetAllAsync(CancellationToken cancellationToken = default);
    Task<bool> ExistsAsync(string name, string? code, CancellationToken cancellationToken = default);
}
