using System.ComponentModel.DataAnnotations;

namespace WarehousingServic.Request
{
    public class DeleteRemittanceFeatureRequest
    {
        [StringLength(100, ErrorMessage = "حداکثر 100 کارکتر وارد کنید")]
        [MinLength(100, ErrorMessage = "تاریخ حواله را 100 کارکتر وارد کنید")]
        public DateTime DateOfRemittance { get; set; }

        [StringLength(100, ErrorMessage = "حداکثر 100 کارکتر وارد کنید")]
        [MinLength(100, ErrorMessage = "آیدی کالا را 100 کارکتر وارد کنید")]
        public int ProductId { get; set; }

        [StringLength(100, ErrorMessage = "حداکثر 100 کارکتر وارد کنید")]
        [MinLength(100, ErrorMessage = "قیمت کالا را 100 کارکتر وارد کنید")]
        public int PriceProduct { get; set; }

        [StringLength(100, ErrorMessage = "حداکثر 100 کارکتر وارد کنید")]
        [MinLength(100, ErrorMessage = "تعداد کالا را 100 کارکتر وارد کنید")]
        public int NumderProduct { get; }


        [StringLength(100)]
        public int InventoryReduction { get; set; }
    }
}
