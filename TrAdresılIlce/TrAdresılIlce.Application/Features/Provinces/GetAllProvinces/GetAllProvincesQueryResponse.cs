namespace TrAdresýlIlce.Application.Features.Provinces.GetAllProvinces;

public sealed record GetAllProvincesQueryResponse(
    int Id,
    string Name,
    int CountryId
);
