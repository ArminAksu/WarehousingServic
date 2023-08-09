using System.ComponentModel.DataAnnotations;

namespace WarehousingServic.Request
{
    public class ProductFeatureRequest
    {
        [Required(ErrorMessage = "نام را وارد کنید")]
        [StringLength(100)]
        public string Name { get; set; }

        [Required(ErrorMessage = "شناسه گروه آیدی کالا را وارد کنید")]
        [StringLength(100)]
        public int ProductGroupId { get; set; }

        [Required(ErrorMessage = "قیمت را وارد کنید")]
        [StringLength(100)]
        public int Price { get; set; }

        [Required(ErrorMessage = "تاریخ انقضا را وارد کنید")]
        [StringLength(100)]
        public DateTime ExpirationData { get; set; }
    }
}
