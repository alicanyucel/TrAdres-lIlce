using TrAdres�lIlce.Domain.Abstractions;

namespace TrAdres�lIlce.Domain.Entities
{
    public sealed class Province : Entity<int>
    {
        public string Name { get; set; } = null!;
        public int CountryId { get; set; }
        public Country Country { get; set; } = null!;
        public ICollection<District> Districts { get; } = new List<District>();
    }
}
