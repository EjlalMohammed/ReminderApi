using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace Domain.Entity
{
    public abstract class BaseEntity
    {
        public Guid Id { get; set; }
        public required string CreateById { get; set; }
        public Guid? UpdateById { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "تاريخ الإضافة")]
        public DateTime CreateAt { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "تاريخ التعديل")]
        public DateTime UpdateAt { get; set; }
    
        
    }
}
