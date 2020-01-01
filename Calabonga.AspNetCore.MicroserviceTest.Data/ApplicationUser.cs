using System;
using Microsoft.AspNetCore.Identity;

namespace Calabonga.AspNetCore.MicroserviceTest.Data
{
    /// <summary>
    /// Пользователь по умолчанию для приложения.
    /// Добавление данных профиля для пользователей приложения путем добавления свойств в класс ApplicationUser
    /// Default user for application.
    /// Add profile data for application users by adding properties to the ApplicationUser class
    /// </summary>
    public class ApplicationUser : IdentityUser<Guid>
    {
        /// <summary>
        /// FirstName
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// LastName
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Дополнительная электронная почта для подписок
        /// Additional email for subscriptions
        /// </summary>
        public string AdditionalEmails { get; set; }
    }
}