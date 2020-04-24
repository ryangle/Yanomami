using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Repositories;

namespace Yanomami
{
    public class CustomerAppServcie : YanomamiAppService
    {
        public CustomerAppServcie(IRepository<Customer, Guid> repository)
            : base(repository)
        {

        }
    }
}
