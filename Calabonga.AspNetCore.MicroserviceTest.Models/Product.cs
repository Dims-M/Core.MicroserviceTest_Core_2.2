
using Calabonga.AspNetCore.MicroserviceTest.Models.Base;
using System;

namespace Calabonga.AspNetCore.MicroserviceTest.Models
{
    /// <summary>
    ///Обьект для описания конкретного продукта
    /// </summary>
  public  class Product : Auditable 
    {
        /// <summary>
        /// Имя продукта.
        /// Name Product
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Описание товара
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Уникальный номер Guid(id) каталога
        /// </summary>
        public Guid CatalogId { get; set; }

        /// <summary>
        /// Свойство каталога. Для работы с экземпляром класса
        /// </summary>
        public virtual Catalog Catalog { get; set; }


         /// <summary>
         // Цена товара.
        //  Price product
        /// </summary>
        public int Price { get; set; }

    }
}
