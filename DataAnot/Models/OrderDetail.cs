using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAnot.Models
{
    public class OrderDetail : BaseEntity
    {
        [Column(TypeName = "money")]
        public double UnitPrice { get; set; }
        [Column(TypeName = "smallint")]
        public int Quantity { get; set; }
        [Column(TypeName = "real")]
        [Required]
        public int Discount { get; set; }

        public int OrderId { get; set; }
        public  virtual Order Order { get; set; }

        public int ProductId { get; set; }
        public virtual Product Product { get; set; }

    }
}
