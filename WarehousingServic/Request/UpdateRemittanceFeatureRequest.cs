using System.ComponentModel.DataAnnotations;

namespace WarehousingServic.Request
{
    public class UpdateRemittanceFeatureRequest
    {

        public DateTime DateOfRemittance { get; set; }


        public int ProductId { get; set; }


        public int PriceProduct { get; set; }


        public int NumderProduct { get; }


        public int InventoryReduction { get; set; }
    }
}
