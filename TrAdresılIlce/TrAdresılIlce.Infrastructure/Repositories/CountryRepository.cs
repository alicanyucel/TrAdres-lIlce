using GenericRepository;
using TrAdresılIlce.Domain.Entities;
using TrAdresılIlce.Domain.Repositories;
using TrAdresılIlce.Infrastructure.Context;

internal sealed class CountryRepository : Repository<Country, ApplicationDbContext>, ICountryRepository
{
    public CountryRepository(ApplicationDbContext context) : base(context)
    {
    }

   
}
