using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Facbook.Models
{
    public class Likes
    {
        public int LikesId { get; set; }
        public int? CommentId { get; set; }
        public int? PostId { get; set; }
        public bool IsDeleted { get; set; }
        public string UserId { get; set; }
        
        public virtual Comments Comment { get; set; }
        public virtual Posts Post { get; set; }
        public virtual Users User { get; set; }
    }
}
