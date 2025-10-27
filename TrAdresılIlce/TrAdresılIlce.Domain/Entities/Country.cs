using TrAdres�lIlce.Domain.Abstractions;

namespace TrAdres�lIlce.Domain.Entities
{
    public sealed class Country : Entity<int>
    {
        public string Name { get; set; } = null!;
        public string? Code { get; set; }

        public ICollection<Province> Provinces { get; } = new List<Province>();
    }
}
