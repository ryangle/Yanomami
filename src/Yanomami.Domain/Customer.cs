using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Entities.Auditing;

namespace Yanomami
{
    public class Customer : Entity<Guid>, IAggregateRoot<Guid>
    {
        public string Name { get; set; }
    }
}
