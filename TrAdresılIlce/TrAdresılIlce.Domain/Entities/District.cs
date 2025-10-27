using TrAdres�lIlce.Domain.Abstractions;

namespace TrAdres�lIlce.Domain.Entities
{
    public sealed class District : Entity
    {
        public string Name { get; set; } = null!;

        public Guid ProvinceId { get; set; }
        public Province Province { get; set; } = null!;
    }
}
