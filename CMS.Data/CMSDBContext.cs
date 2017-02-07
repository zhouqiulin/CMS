using System;
using Microsoft.EntityFrameworkCore;
using CMS.Data.Model.Entity;

namespace CMS.Data
{
    public class CMSDBContext:DbContext
    {
        DbSet<Article> Articles { get; set; }
        DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=ZQL-PC;Initial Catalog=CMS;Integrated Security=True");
        }

    }
}
