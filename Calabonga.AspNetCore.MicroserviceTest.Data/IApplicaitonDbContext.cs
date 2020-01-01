using Calabonga.AspNetCore.MicroserviceTest.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace Calabonga.AspNetCore.MicroserviceTest.Data
{
    /// <summary>
    /// Абстракция для базы данных
    /// Abstraction for Database (EntityFramework)
    /// </summary>
    public interface IApplicationDbContext
    {
        #region Бизнес логика

        /// <summary>
        /// Связь с БД с таблицей котигории 
        /// </summary>
        DbSet<Category> Categories { get; set; }

        /// <summary>
        /// Связь с БД с таблицей товары
        /// </summary>
        DbSet<Product> Products { get; set; }

        #endregion

        #region System

        DbSet<Log> Logs { get; set; }

        DbSet<ApplicationUser> Users { get; set; }

        DbSet<ApplicationUserProfile> Profiles { get; set; }

        DatabaseFacade Database { get; }

        ChangeTracker ChangeTracker { get; }

        DbSet<TEntity> Set<TEntity>() where TEntity : class;

        DbQuery<TQuery> Query<TQuery>() where TQuery : class;

        int SaveChanges();

        #endregion
    }
}