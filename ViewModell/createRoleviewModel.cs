using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Facbook.ViewModell
{
    public class createRoleviewModel
    {
   
        [Required]
        public string RoleName { get; set; }
    }
}
