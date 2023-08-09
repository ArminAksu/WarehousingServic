using System.ComponentModel.DataAnnotations;

namespace WarehousingServic.Request
{
    public class RemittanceFeature
    {
        [Required(ErrorMessage = "تاریخ حواله را وارد کنید")]
        [StringLength(100)]
        public DateTime DateOfRemittance { get; set; }

        [Required(ErrorMessage = "آیدی کالا را وارد کنید")]
        [StringLength(100)]
        public int ProductId { get; set; }

        [Required(ErrorMessage = "قیمت کالا را وارد کنید")]
        [StringLength(100)]
        public int PriceProduct { get; set; }

        [Required(ErrorMessage = "تعداد کالا را وارد کنید")]
        [StringLength(100)]
        public int NumderProduct { get; }

        
        [StringLength(100)]
        public int InventoryReduction { get; set; }

    }
}
