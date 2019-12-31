using System;
using Calabonga.AspNetCore.MicroserviceTest.Models.Base;

namespace Calabonga.AspNetCore.MicroserviceTest.Models
{
    /// <summary>
    /// Обьект логирования Logs. Для записи в БД
    /// </summary>
    public class Log : Identity
    {
        public DateTime CreatedAt { get; set; }

        public string Logger { get; set; }

        public string Level { get; set; }

        public string Message { get; set; }

        public string ThreadId { get; set; }

        public string ExceptionMessage { get; set; }
    }
}
