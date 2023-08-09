using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WarehousingServic.Entity
{
    public class JwtFeilds
    {
        [Key]
        public string token { get; set; }
        public string user_name { get; set; }
        public int expire_time { get; set; }


    }
}
