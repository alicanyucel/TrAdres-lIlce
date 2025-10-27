using GenericRepository;
using Microsoft.EntityFrameworkCore;
using TrAdresılIlce.Domain.Entities;
using TrAdresılIlce.Domain.Repositories;
using TrAdresılIlce.Infrastructure.Context;

namespace TrAdresılIlce.Infrastructure.Repositories;

internal sealed class CountryRepository : Repository<Country, ApplicationDbContext>, ICountryRepository
{
    private readonly ApplicationDbContext _context;

    public CountryRepository(ApplicationDbContext context) : base(context)
    {
        _context = context;
    }

    public async Task<List<Country>> GetAllAsync(CancellationToken cancellationToken = default)
    {
        return await _context.Set<Country>()
            .AsNoTracking()
            .OrderBy(x => x.Name)
            .ToListAsync(cancellationToken);
    }

    public async Task<bool> ExistsAsync(string name, string? code, CancellationToken cancellationToken = default)
    {
        return await _context.Set<Country>()
            .AsNoTracking()
            .AnyAsync(x => x.Name == name || (code != null && x.Code == code), cancellationToken);
    }
}
