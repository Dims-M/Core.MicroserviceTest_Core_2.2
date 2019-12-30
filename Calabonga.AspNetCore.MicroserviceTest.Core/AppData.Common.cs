using System.Collections.Generic;

namespace Calabonga.AspNetCore.MicroserviceTest.Core
{
    /// <summary>
    /// Static data container
    /// Набор констант используемых во всем проекте
    /// </summary>
    public static partial class AppData
    {
        /// <summary>
        /// "Администратор SystemAdministrator"
        /// </summary>
        public const string SystemAdministratorRoleName = "Administrator";

        /// <summary>
        /// "Пользователь BusinessOwner"
        /// </summary>
        public const string CompanyRoleName = "Customer"; // Текущая роль. Покупатель

        /// <summary>
        /// Роли Roles
        /// </summary>
        public static IEnumerable<string> Roles
        {
            get
            {
                yield return SystemAdministratorRoleName;
                yield return CompanyRoleName;
            }
        }

        /// <summary>
        ///Путь интификации IdentityServer4 path
        /// </summary>
        public const string AuthUrl = "/auth";
    }
}
