using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenericRepository;
using MediatR;
using Microsoft.EntityFrameworkCore;
using TrAdresılIlce.Application.Constant;
using TrAdresılIlce.Domain.Entities;
using TrAdresılIlce.Domain.Repositories;
using TS.Result;

namespace TrAdresılIlce.Application.Features.Districts.SetDistricts
{
    public sealed class SetDistrictCommandHandler : IRequestHandler<SetDistrictCommand, Result<string>>
    {
        private readonly IDistrictRepository _districtRepository;
        private readonly IProvinceRepository _provinceRepository;
        private readonly IUnitOfWork _unitOfWork;

        public SetDistrictCommandHandler(IDistrictRepository districtRepository, IProvinceRepository provinceRepository, IUnitOfWork unitOfWork)
        {
            _districtRepository = districtRepository;
            _provinceRepository = provinceRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<Result<string>> Handle(SetDistrictCommand request, CancellationToken cancellationToken)
        {
            // If any district exists, skip seeding to avoid duplicates
            var anyDistrict = await _districtRepository.GetAll().AnyAsync(cancellationToken);
            if (anyDistrict)
                return Result<string>.Succeed("İlçeler zaten ekli.");

            // Build explicit-id districts in the insertion order (start from 1)
            var provinces = await _provinceRepository.GetAll().Select(p => new { p.Id, p.Name }).ToListAsync(cancellationToken);
            if (provinces.Count == 0)
                return Result<string>.Failure("Önce illeri ekleyin.");

            var nameToId = provinces.ToDictionary(p => p.Name, p => p.Id, StringComparer.OrdinalIgnoreCase);

            var districts = new List<District>();
            var idCounter = 1;
            foreach (var (provinceIndex, districtName) in DistrictConstant.Districts)
            {
                var provinceName = ProvinceConstant.Provinces[provinceIndex - 1];
                if (!nameToId.TryGetValue(provinceName, out var provinceId))
                    continue;

                districts.Add(new District { Id = idCounter++, ProvinceId = provinceId, Name = districtName });
            }

            var db = (DbContext)_unitOfWork;
            using var tx = await db.Database.BeginTransactionAsync(cancellationToken);
            try
            {
                await db.Database.ExecuteSqlRawAsync("SET IDENTITY_INSERT [Districts] ON;", cancellationToken);
                await _districtRepository.AddRangeAsync(districts, cancellationToken);
                await _unitOfWork.SaveChangesAsync(cancellationToken);
                await db.Database.ExecuteSqlRawAsync("SET IDENTITY_INSERT [Districts] OFF;", cancellationToken);
                await tx.CommitAsync(cancellationToken);
            }
            catch (Exception ex)
            {
                await tx.RollbackAsync(cancellationToken);
                return Result<string>.Failure($"Hata: {ex.Message}");
            }

            return Result<string>.Succeed("İlçeler başarıyla eklendi.");
        }
    }
}
