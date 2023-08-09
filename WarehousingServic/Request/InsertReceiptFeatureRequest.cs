using System.ComponentModel.DataAnnotations;

namespace WarehousingServic.Request
{
    public class InsertReceiptFeatureRequest
    {
        [Required]
        [StringLength(100)]
        public DateTime DateOfReceipt { get; set; }

        [Required]
        [StringLength(100)]
        public int ProductId { get; set; }

        [Required]
        [StringLength(100)]
        public int NumberOfProduct { get; set; }

        [Required]
        [StringLength(100)]
        public int PriceOfProduct { get; set; }

        [Required]
        [StringLength(100)]
        public int TotalPrice { get; set; }

        [Required]
        [StringLength(100)]
        public int InventoryIncrease { get; set; }
    }
}
