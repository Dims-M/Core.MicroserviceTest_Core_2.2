using Calabonga.AspNetCore.MicroserviceTest.Data.ModelConfigurations.Base;
using Calabonga.AspNetCore.MicroserviceTest.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calabonga.AspNetCore.MicroserviceTest.Data.ModelConfigurations
{
    /// <summary>
    /// Конфигурация(настройки) модели. <see cref="Calabonga.AspNetCore.MicroserviceTest.Models.Category"/>
    /// Entity Type Configuration for entity Person
    /// </summary>
    public class CatalogModelConfiguration : IdentityModelConfigurationBase<Models.Category>
    {
        //добавить новые свойства в категорию
        protected override void AddBuilder(EntityTypeBuilder<Category> builder)
        {
            builder.Property(x=> x.Name).HasMaxLength(50).IsRequired() ; // Свойства новйго обекта. Длина имени 50 сим. И имя обязательно должно быть заполненно
            builder.Property(x => x.Description).HasMaxLength(1024);

            

           // ЗЫ
           //Возвращает объект, который можно использовать для настройки свойства типа сущности.
           // Если указанное свойство еще не является частью модели, оно будет добавлено.
        }

        //Получаем имя таблицы из БД
        protected override string TableName()
        {
            return "Categories"; // возврат имени таблици из БД
        }
    }
}
