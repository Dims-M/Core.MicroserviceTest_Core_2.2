using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Calabonga.AspNetCore.MicroserviceTest.Core.Exceptions;
using Calabonga.AspNetCore.MicroserviceTest.Data;
using Calabonga.AspNetCore.MicroserviceTest.Models;
using Calabonga.AspNetCore.MicroserviceTest.Web.Controllers.Base;
using Calabonga.AspNetCore.MicroserviceTest.Web.Infrastructure.Factories.Base;
using Calabonga.AspNetCore.MicroserviceTest.Web.Infrastructure.Managers.Base;
using Calabonga.AspNetCore.MicroserviceTest.Web.Infrastructure.QueryParams;
using Calabonga.AspNetCore.MicroserviceTest.Web.Infrastructure.Services;
using Calabonga.AspNetCore.MicroserviceTest.Web.Infrastructure.Settings;
using Calabonga.AspNetCore.MicroserviceTest.Web.Infrastructure.Validations.Base;
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
        //Конструктор 


        /// <summary>
        /// //Конструктор
        /// </summary>
        /// <param name="entityManager"></param>
        /// <param name="options"></param>
        /// <param name="unitOfWork"></param>
        /// <param name="accountService"></param>
        public CategoriesController(IEntityManager<Category, CategoryCreateViewModel, CategoryUpdateViewModel> entityManager, IOptions<CurrentAppSettings> options, IUnitOfWork<ApplicationDbContext, ApplicationUser, ApplicationRole> unitOfWork, IAccountService accountService) 
            : base(entityManager, options, unitOfWork, accountService)
        {
        }
    }

    /// <summary>
    /// // Calabonga: update summary (2019-06-01 02:05 CategoriesController)
    /// </summary>
    public class CategoryManager : EntityManager<Category, CategoryCreateViewModel, CategoryUpdateViewModel>
    {
        /// <inheritdoc />
        public CategoryManager(IMapper mapper, IViewModelFactory<Category, CategoryCreateViewModel, CategoryUpdateViewModel> viewModelFactory, IEntityValidator<Category> validator)
        : base(mapper, viewModelFactory, validator)
    {
    }
    }


    /// <summary>
    /// 
    /// </summary>
    public class CategoryViewModel : ViewModelBase
    {
    }
    /// <summary>
    /// 
    /// </summary>
    public class CategoryUpdateViewModel : ViewModelBase
    {
    }
    /// <summary>
    /// 
    /// </summary>
    public class CategoryCreateViewModel : IViewModel
    {

    }

    /// <summary>
    /// Класс для проверки сущностей Категории 
    /// </summary>
    public class CategoryValidator : EntityValidator<Category>

    {/// <summary>
    /// 
    /// </summary>
    /// <param name="factory"></param>
        public CategoryValidator(IRepositoryFactory factory) 
            : base(factory)
        {
        }
    }

    /// <summary>
    /// Обноо CategoryViewModelFactory
    /// </summary>
    public class CategoryViewModelFactory : ViewModelFactory<Category, CategoryCreateViewModel, CategoryUpdateViewModel>
    {
        public readonly IUnitOfWork<ApplicationDbContext, ApplicationUser, ApplicationRole> _unitOfWork;
        private readonly IMapper _mapper;

        //Конструктор по умолчанию
        /// <summary>
        /// gfnyu
        /// </summary>
        /// <param name="mapper">Поставщик конфигурации для выполнения Ьфз(карт)</param>
        /// <param name="unitOfWork"></param>
        public CategoryViewModelFactory(
            IMapper mapper,
            IUnitOfWork<ApplicationDbContext,ApplicationUser,ApplicationRole> unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        

        /// <summary>
        /// Создание вьюхи катергории из панели управления свагера
        /// </summary>
        /// <returns></returns>
        public override CategoryCreateViewModel GenerateForCreate()
        {
            return new CategoryCreateViewModel();
        }

        /// <summary>
        /// Обновлнеие вьюхи по id из панели управления свагера
        /// Запрос по idсущностью  из базы данных
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public override CategoryUpdateViewModel GenerateForUpdate(Guid id)
        {
            //Соединяемся с таблицой  в БД. и дергаем их бд iD
            var category = _unitOfWork.GetRepository<Category>().GetFirstOrDefault(predicate: x => x.Id == id) ;

            if (category == null)
            {   //выбиваем ошибку самодельную(переопределенную)  NullException
                throw new MicroserviceArgumentNullException();
            }
           // var viewModel = _mapper.Map<CategoryUpdateViewModel>(category);

            return   _mapper.Map<CategoryUpdateViewModel>(category); // CategoryUpdateViewModel();
        }
    }

}
