using System;

namespace Calabonga.AspNetCore.MicroserviceTest.Models.Base
{
    /// <summary>
    /// Индефикаторы 
    /// Identifier
    /// </summary>
    public abstract class Identity : IHaveId
    {
        /// <summary>
        /// Индефикаторы 
        /// Identifier
        /// </summary>
        public Guid Id { get; set; }
    }
}
