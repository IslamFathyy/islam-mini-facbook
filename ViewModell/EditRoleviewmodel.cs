using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Facbook.ViewModell
{
    public class EditRoleviewmodel
    {
        public string Id { get; set; }
        [Required]
        public string RoleName { get; set; }
        public EditRoleviewmodel()
        {
            UserHasRole = new List<string>();
        }
      public  List<string> UserHasRole { set; get; }
    }
}
