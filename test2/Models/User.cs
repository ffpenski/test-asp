using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace MvcDocument.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<UserPost> UserPosts { get; set; }

    }
    public class UserDBContext : DbContext
    {
        public DbSet<User> Users { get; set; }
    }
}