using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAnot.Models
{
    public class Category:BaseEntity
    {
        [Column (TypeName ="nvarchar(15)")]
        [Required]
        public string CategoryName { get; set; }

        [Column (TypeName ="ntext")]
        public string Description { get; set; }

        public  virtual List<Product> Products { get; set; }
    }
}
