using System.ComponentModel.DataAnnotations;

namespace WarehousingServic.Request
{
    public class InsertProductFeatureRequest
    {
        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [StringLength(100)]
        public int ProductGroupId { get; set; }

        [Required]
        [StringLength(100)]
        public int Price { get; set; }

        [Required]
        [StringLength(100)]
        public DateTime ExpirationData { get; set; }
    }
}
