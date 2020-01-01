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
        public DbSet<Category> Categories { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public DbSet<Product> Products { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        #endregion


        #region System

        public DbSet<Log> Logs { get; set; }

        public DbSet<ApplicationUserProfile> Profiles { get; set; }
      
        #endregion
    }
}