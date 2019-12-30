using System;

namespace Calabonga.AspNetCore.MicroserviceTest.Models.Base
{
    public interface IHaveId
    {
        /// <summary>
        /// Identifier
        /// </summary>
        Guid Id { get; set; }
    }
}