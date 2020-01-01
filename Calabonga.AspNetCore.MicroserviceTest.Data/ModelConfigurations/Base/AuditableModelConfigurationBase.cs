using System;
using Calabonga.AspNetCore.MicroserviceTest.Models.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Calabonga.AspNetCore.MicroserviceTest.Data.ModelConfigurations.Base
{
    /// <summary>
    /// базовоя Модель конфигурации проверки и  аудита 
    /// Audit-able Model Configuration base
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class AuditableModelConfigurationBase<T> : IEntityTypeConfiguration<T> where T : Auditable
    {
        public void Configure(EntityTypeBuilder<T> builder)
        {
            builder.ToTable(TableName());
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).IsRequired();

            // audit
           // builder.Property(x => x.CreatedAt).IsRequired().HasConversion(v => v, v => DateTime.SpecifyKind(v, DateTimeKind.Utc)).IsRequired(); настройки времени 
            builder.Property(x => x.CreatedAt).IsRequired().HasConversion(v => v, v => DateTime.SpecifyKind(v, DateTimeKind.Local)).IsRequired();
            builder.Property(x => x.CreatedBy).HasMaxLength(256).IsRequired();
           // builder.Property(x => x.UpdatedAt).HasConversion(v => v.Value, v => DateTime.SpecifyKind(v, DateTimeKind.Utc));
            builder.Property(x => x.UpdatedAt).HasConversion(v => v.Value, v => DateTime.SpecifyKind(v, DateTimeKind.Local));
            builder.Property(x => x.UpdatedBy).HasMaxLength(256);

            AddBuilder(builder);
        }

        /// <summary>
        /// Добавить пользовательские свойства
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