using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Yanomami
{
    public class CustomerDto : EntityDto<Guid>
    {
        public string Name { get; set; }
    }
}
