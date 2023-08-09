using System.ComponentModel.DataAnnotations;

namespace WarehousingServic.Request
{
    public class DeleteProductFeatureRequest
    {
        [StringLength(100, ErrorMessage = "حداکثر 100 کارکتر وارد کنید")]
        [MinLength(100, ErrorMessage = "نام را 100 کارکتر وارد کنید")]
        public string Name { get; set; }

        [StringLength(100, ErrorMessage = "حداکثر 100 کارکتر وارد کنید")]
        [MinLength(100, ErrorMessage = "گروه کالا آیدی 100 کارکتر وارد کنید")]
        public int ProductGroupId { get; set; }

        [StringLength(100, ErrorMessage = "حداکثر 100 کارکتر وارد کنید")]
        [MinLength(100, ErrorMessage = "قیمت را 100 کارکتر وارد کنید")]
        public int Price { get; set; }

        [StringLength(100, ErrorMessage = "حداکثر 100 کارکتر وارد کنید")]
        [MinLength(100, ErrorMessage = "تاریخ انقضا را 100 کارکتر وارد کنید")]
        public DateTime ExpirationData { get; set; }
    }
}
