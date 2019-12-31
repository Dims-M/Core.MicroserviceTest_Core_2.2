
using Calabonga.AspNetCore.MicroserviceTest.Models.Base;

namespace Calabonga.AspNetCore.MicroserviceTest.Models
{
 /// <summary>
 /// Обьект для описания продуктов.  
 /// </summary>
    public class Catalog : Identity //Получаем  Guid Id
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

    }
}
