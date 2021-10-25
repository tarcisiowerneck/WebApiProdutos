using System.ComponentModel.DataAnnotations;

namespace WebApiProdutos.Domain.Entities
{
    public abstract class BaseEntity<TKetType>
    {
        protected BaseEntity(TKetType id = default)
        {
            Id = id;
        }

        [Key]
        public virtual TKetType Id { get; }
    }
}
