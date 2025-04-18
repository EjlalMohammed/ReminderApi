
using System.ComponentModel.DataAnnotations;

namespace Domain.Entity
{
    public class BaseNameEntity : BaseEntity
    {
        [MaxLength(50, ErrorMessage = "الاسم  يجب ألا يتجاوز 50 حرف.")]
        public required string Name { get; set; }
    }
}
