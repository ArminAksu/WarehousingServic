using System.ComponentModel.DataAnnotations;

namespace WarehousingServic.Request
{
    public class ReceiptFeatureRequest
    {
        [Required(ErrorMessage = "تاریخ رسید را وارد کنید")]
        [StringLength(100)]
        public DateTime DateOfReceipt { get; set; }

        [Required(ErrorMessage = "آیدی کالا")]
        [StringLength(100)]
        public int ProductId { get; set; }

        [Required(ErrorMessage = "تعداد کالا وارد کنید")]
        [StringLength(100)]
        public int NumberOfProduct { get; set; }

        [Required(ErrorMessage = "قیمت کالا را وارد کنید")]
        [StringLength(100)]
        public int PriceOfProduct { get; set; }

        [Required(ErrorMessage = "قیمت کل رسید")]
        [StringLength(100)]
        public int TotalPrice { get; set; }

        
        [StringLength(100)]
        public int InventoryIncrease { get; set; }
    }
}
