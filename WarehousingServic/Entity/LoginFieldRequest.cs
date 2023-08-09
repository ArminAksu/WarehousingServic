using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WarehousingServic.Entity
{
    public class LoginFieldRequest
    {
        [Key]
        public string UserName { get; set; }
        public string Password { get; set; }


    }
}
