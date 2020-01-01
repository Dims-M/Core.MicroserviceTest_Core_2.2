using Calabonga.AspNetCore.MicroserviceTest.Data.ModelConfigurations.Base;
using Calabonga.AspNetCore.MicroserviceTest.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calabonga.AspNetCore.MicroserviceTest.Data.ModelConfigurations
{
    /// <summary>
    /// Конфигурация(настройки) модели для БД. <see cref="Calabonga.AspNetCore.MicroserviceTest.Models.Product"/>
    /// </summary>
    public class ProductModelConfiguration : AuditableModelConfigurationBase<Product>
    {
        protected override void AddBuilder(EntityTypeBuilder<Product> builder)
        {
            //указываем нужные свойства
            builder.Property(x => x.Name).HasMaxLength(128).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(1024);
            builder.Property(x => x.Price); // может быть пустой
            builder.Property(x => x.CategoryId).IsRequired(); // может быть пустой

            //Связь один к многим.. У категории может быть много разных товаров
           // builder.HasOne(x => x.Category).WithMany();
        }

        protected override string TableName()
        {
            return "Product";
        }
    }

}
