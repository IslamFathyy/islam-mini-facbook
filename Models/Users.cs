using Facbook.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Facbook.Models
{
    public  class Users: IdentityUser
    {
        public Users()
        {
            Comments = new HashSet<Comments>();
            Likes = new HashSet<Likes>();
            Posts = new HashSet<Posts>();
            UserFriend = new HashSet<UserFriend>();
        }
        public string MyUsername { get; set; }
        public string Password { get; set; }
        [NotMapped]
        public IFormFile Photoimg { get; set; }
        [NotMapped]
        public IFormFile Coverimg { get; set; }
        public string Photo { get; set; }
        public string Cover { get; set; }
        public string Bio { get; set; }
        public string Gender { get; set; }
        public bool? Isblocked { get; set; }
        public DateTime? Birthdate { get; set; }
        public string SelectedRole { get; set; }

        public virtual ICollection<Comments> Comments { get; set; }
        public virtual ICollection<Likes> Likes { get; set; }
        public virtual ICollection<Posts> Posts { get; set; }
        public virtual ICollection<UserFriend> UserFriend { get; set; }
    }
}
