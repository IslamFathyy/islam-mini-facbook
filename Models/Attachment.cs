using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Facbook.Models
{
    public class Attachment
    {
        public int AttachmentId { get; set; }
        public string Url { get; set; }
        public int PostId { get; set; }
        public int? CommentId { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual Comments Comment { get; set; }
        public virtual Posts Post { get; set; }
    }
}
