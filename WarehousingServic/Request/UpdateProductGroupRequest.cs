using System.ComponentModel.DataAnnotations;

namespace WarehousingServic.Request
{
    public class UpdateProductGroupRequest
    {

        public string name { get; set; }


        public string ParentGroupe { get; set; }

        public int ProductGroupCode { get; set; }
    }
}
