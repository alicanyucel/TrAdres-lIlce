using TrAdres�lIlce.Domain.Abstractions;

namespace TrAdres�lIlce.Domain.Entities
{
    public sealed class District : Entity<int>
    {
        public string Name { get; set; } = null!;

        public int ProvinceId { get; set; }
        public Province Province { get; set; } = null!;
    }
}
