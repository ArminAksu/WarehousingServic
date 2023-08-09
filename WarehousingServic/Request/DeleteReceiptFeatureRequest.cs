using System.ComponentModel.DataAnnotations;

namespace WarehousingServic.Request
{
    public class DeleteReceiptFeatureRequest
    {
        [StringLength(100, ErrorMessage = "حداکثر 100 کارکتر وارد کنید")]
        [MinLength(100, ErrorMessage = "تاریخ رسید را 100 کارکتر وارد کنید")]
        public DateTime DateOfReceipt { get; set; }

        [StringLength(100, ErrorMessage = "حداکثر 100 کارکتر وارد کنید")]
        [MinLength(100, ErrorMessage = "آیدی کالا را 100 کارکتر وارد کنید")]
        public int ProductId { get; set; }

        [StringLength(100, ErrorMessage = "حداکثر 100 کارکتر وارد کنید")]
        [MinLength(100, ErrorMessage = "نام را 100 کارکتر وارد کنید")]
        public int NumberOfProduct { get; set; }

        [StringLength(100, ErrorMessage = "حداکثر 100 کارکتر وارد کنید")]
        [MinLength(100, ErrorMessage = "قیمت کالا را 100 کارکتر وارد کنید")]
        public int PriceOfProduct { get; set; }

        [StringLength(100, ErrorMessage = "حداکثر 100 کارکتر وارد کنید")]
        [MinLength(100, ErrorMessage = "قیمت کل رسید را 100 کارکتر وارد کنید")]
        public int TotalPrice { get; set; }


        [StringLength(100)]
        public int InventoryIncrease { get; set; }
    }
}
