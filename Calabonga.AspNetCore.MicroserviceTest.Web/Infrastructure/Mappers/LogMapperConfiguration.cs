using Calabonga.AspNetCore.MicroserviceTest.Models;
using Calabonga.AspNetCore.MicroserviceTest.Web.Infrastructure.Mappers.Base;
using Calabonga.AspNetCore.MicroserviceTest.Web.Infrastructure.ViewModels.LogViewModels;
using Calabonga.EntityFrameworkCore.UnitOfWork;

namespace Calabonga.AspNetCore.MicroserviceTest.Web.Infrastructure.Mappers
{
    /// <summary>
    /// Конфигурации маппер для  журналa событий
    /// Mapper Configuration for entity Log
    /// </summary>
    public class LogMapperConfiguration : MapperConfigurationBase
    {
        /// <inheritdoc />
        public LogMapperConfiguration()
        {
            CreateMap<LogCreateViewModel, Log>()
                .ForMember(x => x.Id, o => o.Ignore());

            CreateMap<Log, LogViewModel>();

            CreateMap<IPagedList<Log>, IPagedList<LogViewModel>>()
                .ConvertUsing<PagedListConverter<Log, LogViewModel>>();
        }
    }
}
