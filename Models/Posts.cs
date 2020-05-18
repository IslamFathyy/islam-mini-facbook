using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Facbook.Models
{
    public class Posts
    {
        public Posts()
        {
            Attachment = new HashSet<Attachment>();
            Likes = new HashSet<Likes>();
        }
        [Key]

        public int PostsId { get; set; }
        public string PostBody { get; set; }
        public DateTime? PostDate { get; set; }
        public bool? IsDeleted { get; set; }
        public bool? HasAttachment { get; set; }
        public bool Isliked { get; set; } = false;
        public string UserId { get; set; }
        [NotMapped]
        public List<IFormFile> photos { get; set; }
        public virtual Users User { get; set; }
        public virtual ICollection<Attachment> Attachment { get; set; }
        public virtual ICollection<Likes> Likes { get; set; }
    }
}
