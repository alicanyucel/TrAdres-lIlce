using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore;
using TrAdresılIlce.Domain.Repositories;

namespace TrAdresılIlce.Application.Features.Provinces.GetAllProvinces
{
    public sealed class GetAllProvincesQueryHandler : IRequestHandler<GetAllProvincesQuery, List<GetAllProvincesQueryResponse>>
    {
        private readonly IProvinceRepository _provinceRepository;

        public GetAllProvincesQueryHandler(IProvinceRepository provinceRepository)
        {
            _provinceRepository = provinceRepository;
        }

        public async Task<List<GetAllProvincesQueryResponse>> Handle(GetAllProvincesQuery request, CancellationToken cancellationToken)
        {
            var provinces = await _provinceRepository.GetAll().ToListAsync(cancellationToken);
            return provinces.Select(p => new GetAllProvincesQueryResponse(p.Id, p.Name, p.CountryId)).ToList();
        }
    }
}
