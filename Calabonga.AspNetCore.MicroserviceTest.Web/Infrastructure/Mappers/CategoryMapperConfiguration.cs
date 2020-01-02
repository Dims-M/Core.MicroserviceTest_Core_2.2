using Calabonga.AspNetCore.MicroserviceTest.Models;
using Calabonga.AspNetCore.MicroserviceTest.Web.Controllers;
using Calabonga.AspNetCore.MicroserviceTest.Web.Infrastructure.Mappers.Base;
using Calabonga.AspNetCore.MicroserviceTest.Web.Infrastructure.ViewModels.LogViewModels;
//using Calabonga.PagedListLiteCore;
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

        CreateMap<Category, Controllers.CategoryViewModel>();
        CreateMap<Category, CategoryUpdateViewModel>();

            CreateMap<IPagedList<Category>, IPagedList<Controllers.CategoryViewModel>>()
                .ConvertUsing<PagedListConverter<Category, Controllers.CategoryViewModel>>();
}
    }
}
