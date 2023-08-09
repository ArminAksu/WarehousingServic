using System.ComponentModel.DataAnnotations;

namespace WarehousingServic.Request
{
    public class InsertProductGroupRequest
    {
        [Required]
        [StringLength(100)]
        public string name { get; set; }

        [Required]
        [StringLength(100)]
        public string ParentGroupe { get; set; }

        [Required]
        [StringLength(100)]
        public int ProductGroupCode { get; set; }
    }
}
