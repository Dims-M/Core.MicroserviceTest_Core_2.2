using AutoMapper;
using Calabonga.AspNetCore.MicroserviceTest.Data;
using Calabonga.AspNetCore.MicroserviceTest.Models;
using Calabonga.AspNetCore.MicroserviceTest.Web.Controllers.Base;
using Calabonga.AspNetCore.MicroserviceTest.Web.Infrastructure.QueryParams;
using Calabonga.AspNetCore.MicroserviceTest.Web.Infrastructure.Services;
using Calabonga.AspNetCore.MicroserviceTest.Web.Infrastructure.Settings;
using Calabonga.AspNetCore.MicroserviceTest.Web.Infrastructure.ViewModels.LogViewModels;
using Calabonga.EntityFrameworkCore.UnitOfWork;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calabonga.AspNetCore.MicroserviceTest.Web.Controllers
{
    /// <summary>
    ///Контроллер Лога . 
    /// </summary>
    public class LogController : ReadOnlyController<Log, LogViewModel, PagedListQueryParams>
    {
        /// <summary>
        /// Конструктор по умолчанию.
        /// </summary>
        /// <param name="mapper"></param>
        /// <param name="options"></param>
        /// <param name="unitOfWork"></param>
        /// <param name="accountService"></param>
        public LogController(IMapper mapper, IOptions<CurrentAppSettings> options, IUnitOfWork<ApplicationDbContext, ApplicationUser, ApplicationRole> unitOfWork, IAccountService accountService) 
             : base(mapper, options, unitOfWork, accountService)
        {
        }
    }
}
