
using Calabonga.AspNetCore.MicroserviceTest.Models.Base;
using System.Collections;
using System.Collections.Generic;

namespace Calabonga.AspNetCore.MicroserviceTest.Models
{
 /// <summary>
 /// Обьект для описания продуктов.  
 /// </summary>
    public class Category : Identity //Получаем  Guid Id
    {
        //Имя католога
        /// <summary>
        /// Имя Католога
        /// </summary>
        public string Name { get; set; }


        /// <summary>
        /// Описание католога
        /// </summary>
        public string Description { get; set; }

       /// <summary>
       /// Свойства навигации.
       /// Указываем что в одной котегории можкт быть несколько продуктов
       /// Колекция
       /// </summary>
        public virtual ICollection <Product> Products { get; set; }
    }
}
