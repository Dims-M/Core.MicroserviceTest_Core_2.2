//using Calabonga.AspNetCore.MicroserviceTest.Models;
using Calabonga.AspNetCore.MicroserviceTest.Web.Controllers;
using Calabonga.AspNetCore.MicroserviceTest.Web.Infrastructure.Mappers.Base;
using Calabonga.AspNetCore.MicroserviceTest.Web.Infrastructure.ViewModels.LogViewModels;
using Calabonga.PagedListLiteCore;
using Calabonga.EntityFrameworkCore.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//using CategoryViewModel = Calabonga.AspNetCore.MicroserviceTest.Web.Controllers.CategoryViewModel;


namespace Calabonga.AspNetCore.MicroserviceTest.Web.Infrastructure.Mappers
{
    /// <summary>
    /// Настройки Map, Словаря 
    /// </summary>
    public class CategoryMapperConfiguration : MapperConfigurationBase
    {
        /// <summary>
        /// 
        /// </summary>
        public CategoryMapperConfiguration()
        {

        CreateMap<Models.Category, Controllers.CategoryViewModel>();
        CreateMap<Models.Category, CategoryUpdateViewModel>();

            CreateMap<EntityFrameworkCore.UnitOfWork.IPagedList<Models.Category>, EntityFrameworkCore.UnitOfWork.IPagedList<Controllers.CategoryViewModel>>()
                .ConvertUsing<PagedListConverter<Models.Category, Controllers.CategoryViewModel>>();
}
    }
}
