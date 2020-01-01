using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Calabonga.AspNetCore.MicroserviceTest.Data;
using Calabonga.AspNetCore.MicroserviceTest.Models;
using Calabonga.AspNetCore.MicroserviceTest.Web.Controllers.Base;
using Calabonga.AspNetCore.MicroserviceTest.Web.Infrastructure.Factories.Base;
using Calabonga.AspNetCore.MicroserviceTest.Web.Infrastructure.Managers.Base;
using Calabonga.AspNetCore.MicroserviceTest.Web.Infrastructure.QueryParams;
using Calabonga.AspNetCore.MicroserviceTest.Web.Infrastructure.Services;
using Calabonga.AspNetCore.MicroserviceTest.Web.Infrastructure.Settings;
using Calabonga.AspNetCore.MicroserviceTest.Web.Infrastructure.ViewModels;
using Calabonga.EntityFrameworkCore.UnitOfWork;
using Microsoft.Extensions.Options;

namespace Calabonga.AspNetCore.MicroserviceTest.Web.Controllers
{
    /// <summary>
    /// Контроллер для работы с категориями
    /// </summary>
    public class CategoriesController : WritableController<Category, CategoryCreateViewModel, CategoryUpdateViewModel, CategoryViewModel, PagedListQueryParams>
    {
        //Конструктор по умолчанию
        public CategoriesController(IEntityManager<Category, CategoryCreateViewModel, CategoryUpdateViewModel> entityManager, IOptions<CurrentAppSettings> options, IUnitOfWork<ApplicationDbContext, ApplicationUser, ApplicationRole> unitOfWork, IAccountService accountService) 
            : base(entityManager, options, unitOfWork, accountService)
        {
        }
    }

    public class CategoryViewModel : ViewModelBase
    {
    }

    public class CategoryUpdateViewModel : ViewModelBase
    {
    }

    public class CategoryCreateViewModel : IViewModel
    {
    }
}
