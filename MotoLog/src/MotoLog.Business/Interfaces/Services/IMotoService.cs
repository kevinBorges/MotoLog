using MotoLog.Business.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotoLog.Business.Interfaces.Services
{
    public interface IMotoService : IDisposable
    {
        Task Insert(Moto moto);
        Task Update(Moto moto);
        Task DeleteById(Guid id);
    }
}
