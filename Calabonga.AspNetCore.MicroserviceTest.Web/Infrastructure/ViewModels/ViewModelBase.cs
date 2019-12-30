using System;
using Calabonga.AspNetCore.MicroserviceTest.Models.Base;
using Calabonga.AspNetCore.MicroserviceTest.Web.Infrastructure.Factories.Base;

namespace Calabonga.AspNetCore.MicroserviceTest.Web.Infrastructure.ViewModels
{
    /// <summary>
    /// ViewModelBase for WritableController
    /// </summary>
    public class ViewModelBase : IViewModel, IHaveId
    {
        /// <summary>
        /// Identifier
        /// </summary>
        public Guid Id { get; set; }
    }
}
