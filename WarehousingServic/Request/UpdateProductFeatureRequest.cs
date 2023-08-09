using System.ComponentModel.DataAnnotations;

namespace WarehousingServic.Request
{
    public class UpdateProductFeatureRequest
    {

        public string Name { get; set; }


        public int ProductGroupId { get; set; }


        public int Price { get; set; }


        public DateTime ExpirationData { get; set; }
    }
}
