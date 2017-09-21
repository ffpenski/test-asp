using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MvcDocument.Models
{
    public class Document
    {
        public int Id { get; set; }
        public string DocName { get; set; }
        public virtual ICollection<User> Users { get; set; }
        public string Path { get; set; }
    }
    public class DocumentDBContext : DbContext
    {
        public DbSet<Document> Documents { get; set; }
    }
}