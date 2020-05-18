using System;
using System.Collections.Generic;
using System.Text;
using Facbook.Models;

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Facbook.Data

{
    public class ApplicationDbContext : IdentityDbContext<Users,Applicationroles, string>
    {
        public DbSet<Attachment> attachments { get; set; }
        public DbSet<Comments> Comments { get; set; }
        public DbSet<Likes> Likes { get; set; }
        public DbSet<Posts> posts { get; set; }
        public DbSet<UserFriend> Userfriends { get; set; }
        public DbSet<Users> MyUsers { get; set; }


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

         }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<UserFriend>().HasKey(o => new { o.UserId, o.FriendId });
        }
    }
}
