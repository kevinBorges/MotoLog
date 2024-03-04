using MotoLog.Business.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotoLog.Business.Interfaces.Respository
{
    public interface IMotoRepository : IRepository<Moto>
    {
        //criar metodos especificos exemplo moto e h
        Task<bool> PlateIsExists(string plate);
    }
}
