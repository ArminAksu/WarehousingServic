using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WarehousingServic.Entity
{
    public class ProductGroup
    {
        [Key]
        public int id { get; set; }

        [Required]
        [StringLength(100)]
        public string name { get; set; }

        [Required]
        [StringLength(100)]
        public string ParentGroupe { get; set; }

        [Required]
        [StringLength(100)]
        public int ProductGroupCode { get; set; }

        [ForeignKey(" ProductGroupId")]
        public virtual ReceiptFeature ReceiptFeature{ get; set; }

        [ForeignKey("ProductId")]
        public virtual RemittanceFeature RemittanceFeature{ get; set; }

        [ForeignKey("Price")]
        public virtual ProductFeature ProductFeature { get; set; }
    }
}
