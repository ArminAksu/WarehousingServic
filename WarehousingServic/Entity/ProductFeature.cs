using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace WarehousingServic.Entity
{
    public class ProductFeature
    {
        [Key]
        public int id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [StringLength(100)]
        public int ProductGroupId { get; set; }

        [Required]
        [StringLength(100)]
        public int Price { get; set; }

        [Required]
        [StringLength(100)]
        public DateTime ExpirationData { get; set;}

        public virtual Collection<ProductGroup> ProductGroup { get; set; }
    }
}
