using System.ComponentModel.DataAnnotations;

namespace TrAdresılIlce.Domain.Abstractions
{
    public abstract class Entity
    {
        [Key]
        public int Id { get; set; }
    }
}
