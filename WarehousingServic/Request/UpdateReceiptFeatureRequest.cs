using System.ComponentModel.DataAnnotations;

namespace WarehousingServic.Request
{
    public class UpdateReceiptFeatureRequest
    {

        public DateTime DateOfReceipt { get; set; }


        public int ProductId { get; set; }


        public int NumberOfProduct { get; set; }


        public int PriceOfProduct { get; set; }


        public int TotalPrice { get; set; }


        public int InventoryIncrease { get; set; }
    }
}
