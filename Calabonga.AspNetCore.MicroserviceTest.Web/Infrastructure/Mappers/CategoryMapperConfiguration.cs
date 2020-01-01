using Calabonga.AspNetCore.MicroserviceTest.Models;
using Calabonga.AspNetCore.MicroserviceTest.Web.Infrastructure.Mappers.Base;
using Calabonga.AspNetCore.MicroserviceTest.Web.Infrastructure.ViewModels.LogViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calabonga.AspNetCore.MicroserviceTest.Web.Infrastructure.Mappers
{
    /// <summary>
    /// Настройки Map, Словаря 
    /// </summary>
    public class CategoryMapperConfiguration : MapperConfigurationBase
    {

        CreateMap<Category, LogViewModel>();

            CreateMap<IPagedList<Log>, IPagedList<LogViewModel>>()
                .ConvertUsing<PagedListConverter<Log, LogViewModel>>();

    }
}
