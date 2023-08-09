using System.ComponentModel.DataAnnotations;

namespace WarehousingServic.Request
{
    public class DeleteProductGroupRequest
    {
        [StringLength(100, ErrorMessage = "حداکثر 100 کارکتر وارد کنید")]
        [MinLength(100, ErrorMessage = "نام را 100 کارکتر وارد کنید")]
        public string name { get; set; }

        [StringLength(100, ErrorMessage = "حداکثر 100 کارکتر وارد کنید")]
        [MinLength(100, ErrorMessage = "گروه والد را 100 کارکتر وارد کنید")]
        public string ParentGroupe { get; set; }

        [StringLength(100, ErrorMessage = "حداکثر 100 کارکتر وارد کنید")]
        [MinLength(100, ErrorMessage = "آیدی گروه کالا را 100 کارکتر وارد کنید")]
        public int ProductGroupCode { get; set; }
    }
}
