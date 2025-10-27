using System.ComponentModel.DataAnnotations;

namespace TrAdresılIlce.Domain.Abstractions
{
    public abstract class Entity<TKey>
    {
        [Key]
        public TKey Id { get; set; } = default!;
        protected Entity()
        {
            if (typeof(TKey) == typeof(Guid))
            {
                Id = (TKey)(object)Guid.NewGuid();
            }
        }
    }
}
