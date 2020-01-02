using System;

namespace Calabonga.AspNetCore.MicroserviceTest.Web.Infrastructure.ViewModels.LogViewModels
{
    /// <summary>
    /// Вывод моделей ViewModel
    /// Log ViewModel
    /// </summary>
    public class LogViewModel : ViewModelBase
    {

        //CategoryViewModel()
        //{}

        /// <summary>
        /// Created at
        /// </summary>
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Logger name
        /// </summary>
        public string Logger { get; set; }

        /// <summary>
        /// Level
        /// </summary>
        public string Level { get; set; }

        /// <summary>
        /// Message text
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Thread ID
        /// </summary>
        public string ThreadId { get; set; }

        /// <summary>
        /// ExceptionMessage
        /// </summary>
        public string ExceptionMessage { get; set; }
    }
}