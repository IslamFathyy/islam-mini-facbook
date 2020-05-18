using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Facbook.Models
{
    public class UserFriend
    {
        [Key]
        [Column(Order=1)]
        public string UserId { get; set; }
        [Key]
        [Column(Order = 2)]
        public string FriendId { get; set; }
        public string IsDeleted { get; set; }

        public virtual Users User { get; set; }
    }
}
