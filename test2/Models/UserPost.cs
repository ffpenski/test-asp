using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MvcDocument.Models
{
    public class UserPost
    {
        public int Id { get; set; }
        public string PostName { get; set; }
    }
    public class UserPostDBContext : DbContext
    {
        public DbSet<UserPost> UserPosts { get; set; }
    }
}