using Calabonga.AspNetCore.MicroserviceTest.Data.Base;
using Calabonga.AspNetCore.MicroserviceTest.Models;
using Microsoft.EntityFrameworkCore;

namespace Calabonga.AspNetCore.MicroserviceTest.Data
{
    /// <summary>
    ///Cdzpm Базs данных 
    /// Database for application
    /// </summary>
    public class ApplicationDbContext : DbContextBase, IApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        #region Бизнес логика
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        #endregion


        #region System

        public DbSet<Category> Logs { get; set; }

        public DbSet<ApplicationUserProfile> Profiles { get; set; }
      
        #endregion
    }
}