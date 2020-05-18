using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Facbook.Models;
namespace Facbook.ViewModell
{
    public class PostAttachmentVm
    {
        public PostAttachmentVm()
        {
            Attachment = new HashSet<Attachment>();
            posts = new HashSet<Posts>();

        }
        public  ICollection<Attachment> Attachment { get; set; }
        public ICollection<Posts> posts { get; set; }

      



    }
}
