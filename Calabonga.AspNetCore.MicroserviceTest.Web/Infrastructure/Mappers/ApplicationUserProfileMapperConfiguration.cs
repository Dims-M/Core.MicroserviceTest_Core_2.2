﻿using Calabonga.AspNetCore.MicroserviceTest.Data;
using Calabonga.AspNetCore.MicroserviceTest.Web.Infrastructure.Mappers.Base;
using Calabonga.AspNetCore.MicroserviceTest.Web.Infrastructure.ViewModels.AccountViewModels;

namespace Calabonga.AspNetCore.MicroserviceTest.Web.Infrastructure.Mappers
{
    /// <summary>
    /// Mapper Configuration for entity Person
    /// </summary>
    public class ApplicationUserProfileMapperConfiguration : MapperConfigurationBase
    {
        /// <inheritdoc />
        public ApplicationUserProfileMapperConfiguration()
        {
            CreateMap<RegisterViewModel, ApplicationUserProfile>()
                .ForAllOtherMembers(x => x.Ignore());
        }
    }
}