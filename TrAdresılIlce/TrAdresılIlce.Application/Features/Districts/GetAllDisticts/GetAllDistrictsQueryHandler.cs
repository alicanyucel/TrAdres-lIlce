using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore;
using TrAdresılIlce.Domain.Repositories;

namespace TrAdresılIlce.Application.Features.Districts.GetAllDisticts
{
    public sealed class GetAllDistrictsQueryHandler : IRequestHandler<GetAllDistrictsQuery, List<GetAllDistrictsQueryResponse>>
    {
        private readonly IDistrictRepository _districtRepository;

        public GetAllDistrictsQueryHandler(IDistrictRepository districtRepository)
        {
            _districtRepository = districtRepository;
        }

        public async Task<List<GetAllDistrictsQueryResponse>> Handle(GetAllDistrictsQuery request, CancellationToken cancellationToken)
        {
            var districts = await _districtRepository.GetAll().ToListAsync(cancellationToken);
            return districts.Select(d => new GetAllDistrictsQueryResponse(d.Id, d.Name, d.ProvinceId)).ToList();
        }
    }
}
