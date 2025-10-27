using GenericRepository;
using TrAdresılIlce.Domain.Entities;
using TrAdresılIlce.Domain.Repositories;
using TrAdresılIlce.Infrastructure.Context;

namespace TrAdresılIlce.Infrastructure.Repositories;

internal sealed class DistrictRepository : Repository<District, ApplicationDbContext>, IDistrictRepository
{
    public DistrictRepository(ApplicationDbContext context) : base(context)
    {

    }
}
