using System.ComponentModel.DataAnnotations;

namespace WarehousingServic.Request
{
    public class InsertRemittanceFeatureRequest
    {
        [Required]
        [StringLength(100)]
        public DateTime DateOfRemittance { get; set; }

        [Required]
        [StringLength(100)]
        public int ProductId { get; set; }

        [Required]
        [StringLength(100)]
        public int PriceProduct { get; set; }

        [Required]
        [StringLength(100)]
        public int NumderProduct { get; }

        [Required]
        [StringLength(100)]
        public int InventoryReduction { get; set; }
    }
}
