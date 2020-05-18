using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Facbook.Models
{
    public class Comments
    {
        public Comments()
        {
            Attachment = new HashSet<Attachment>();
            Likes = new HashSet<Likes>();
        }

        public int CommentsID{ get; set; }
        public int Postid { get; set; }
        public string UserId { get; set; }
        public string Body { get; set; }
        public DateTime Date { get; set; }

        public virtual Users User { get; set; }
        public virtual ICollection<Attachment> Attachment { get; set; }
        public virtual ICollection<Likes> Likes { get; set; }
    }
}
