using System;
using Microsoft.EntityFrameworkCore;
using CMS.Data.Model.Entity;

namespace CMS.Data
{
    public class CMSDBContext:DbContext
    {
      public  DbSet<Article> Article { get; set; }
      public  DbSet<User> User { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=ZQL-PC;Initial Catalog=CMS;Integrated Security=True");
        }

    }
}
