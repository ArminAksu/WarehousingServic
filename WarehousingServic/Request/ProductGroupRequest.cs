using System.ComponentModel.DataAnnotations;

namespace WarehousingServic.Request
{
    public class ProductGroupRequest
    {
        [Required(ErrorMessage = "نام را وارد کنید")]
        [StringLength(100)]
        public string name { get; set; }

        [Required(ErrorMessage = "گروه والد را وارد کنید")]
        [StringLength(100)]
        public string ParentGroupe { get; set; }

        [Required(ErrorMessage = "کد گروه کالا را وارد کنید")]
        [StringLength(100)]
        public int ProductGroupCode { get; set; }
    }
}
