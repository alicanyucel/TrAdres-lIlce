using TrAdresýlIlce.Domain.Abstractions;

namespace TrAdresýlIlce.Domain.Entities
{
    public sealed class Province : Entity
    {
        public string Name { get; set; } = null!;
        public Guid CountryId { get; set; }
        public Country Country { get; set; } = null!;
        public ICollection<District> Districts { get; } = new List<District>();
    }
}
