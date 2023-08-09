using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace WarehousingServic.Entity
{
    public class RemittanceFeature
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public DateTime DateOfRemittance { get; set; }

        [Required]
        [StringLength(100)]
        public int ProductId { get; set; }

        [Required]
        [StringLength(100)]
        public int PriceProduct { get; set;}

        [Required]
        [StringLength(100)]
        public int NumderProduct { get;}

        [Required]
        [StringLength(100)]
        public int InventoryReduction { get;set; }
        public virtual Collection<ProductGroup> ProductGroup { get; set; }
    }
}
