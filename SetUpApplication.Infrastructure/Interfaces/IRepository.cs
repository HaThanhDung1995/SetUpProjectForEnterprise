using System;
using System.Collections.Generic;
using System.Text;

namespace SetUpApplication.Infrastructure.Interfaces
{
    public interface IRepository<T, K> where T : DomainEntity<K>
    {
    }
}
