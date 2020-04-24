using System;
using System.Collections.Generic;
using System.Text;
using Yanomami.Localization;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Yanomami
{
    /* Inherit your application services from this class.
     */
    public abstract class YanomamiAppService : CrudAppService<Customer, CustomerDto, Guid>
    {
        public YanomamiAppService(IRepository<Customer, Guid> repository)
            : base(repository)
        {
            LocalizationResource = typeof(YanomamiResource);
        }
    }
}
