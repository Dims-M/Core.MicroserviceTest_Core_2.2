using Calabonga.AspNetCore.MicroserviceTest.Models.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Calabonga.AspNetCore.MicroserviceTest.Data.ModelConfigurations.Base
{
    /// <summary>
    /// Модель базовой конфигурации проверки и аудита
    /// Audit-able Model Configuration base
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class IdentityModelConfigurationBase<T> : IEntityTypeConfiguration<T> where T : Identity
    {
        public void Configure(EntityTypeBuilder<T> builder)
        {
            builder.ToTable(TableName());
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).IsRequired();

            AddBuilder(builder);
        }

        /// <summary>
        /// Добавить пользовательские свойства 
        /// Add custom properties for your entity
        /// </summary>
        /// <param name="builder"></param>
        protected abstract void AddBuilder(EntityTypeBuilder<T> builder);

        /// <summary>
        /// Имя таблицы
        /// Table name
        /// </summary>
        /// <returns></returns>
        protected abstract string TableName();
    }
}