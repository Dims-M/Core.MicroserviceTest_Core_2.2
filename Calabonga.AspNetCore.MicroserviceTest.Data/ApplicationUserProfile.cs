using System;
using Calabonga.AspNetCore.MicroserviceTest.Models.Base;

namespace Calabonga.AspNetCore.MicroserviceTest.Data
{
    /// <summary>
    /// Represent person with login information (ApplicationUser)
    /// </summary>
    public class ApplicationUserProfile : Auditable
    {
        /// <summary>
        /// Account <see cref="Data.ApplicationUser"/>
        /// </summary>
        public Guid ApplicationUserId { get; set; }

        /// <summary>
        /// Account
        /// </summary>
        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}
