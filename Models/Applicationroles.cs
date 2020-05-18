using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Facbook.Models
{
    public class Applicationroles: IdentityRole
    {
        public Applicationroles()
        {

        }
        public Applicationroles(string name)
        {
            this.Name = name;
        }
        public Applicationroles(string name, string describtion) : base(name)
        {
            this.Description = describtion;
        }
        public string Description { get; set; }
    }
}
