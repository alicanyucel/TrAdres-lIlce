using GenericRepository;
using TrAdresılIlce.Domain.Entities;
using TrAdresılIlce.Domain.Repositories;
using TrAdresılIlce.Infrastructure.Context;

namespace TrAdresılIlce.Infrastructure.Repositories;

internal sealed class ProvinceRepository : Repository<Province, ApplicationDbContext>, IProvinceRepository
{
    public ProvinceRepository(ApplicationDbContext context) : base(context)
    {

    }
}
