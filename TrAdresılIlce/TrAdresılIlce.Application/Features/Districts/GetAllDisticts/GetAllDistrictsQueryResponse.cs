namespace TrAdres�lIlce.Application.Features.Districts.GetAllDisticts;

public sealed record GetAllDistrictsQueryResponse(
    int Id,
    string Name,
    int ProvinceId
);
