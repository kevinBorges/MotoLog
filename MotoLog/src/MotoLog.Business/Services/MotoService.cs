using MotoLog.Business.Entity;
using MotoLog.Business.Entity.Validations;
using MotoLog.Business.Interfaces.Respository;
using MotoLog.Business.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotoLog.Business.Services
{
    public class MotoService : BaseService, IMotoService
    {
        private readonly IMotoRepository _motoRepository;

        public MotoService(IMotoRepository motoRepository,
                            INotifier notifier) : base(notifier) 
        {
            _motoRepository = motoRepository;
        }

        public async Task Insert(Moto moto)
        {
            if (!IsValid(new MotoValidation(), moto)) return;

            if (await _motoRepository.PlateIsExists(moto.Plate)) 
            {
                Notify("Placa já cadastrada no sistema.");
                return;
            }


            await _motoRepository.Insert(moto);
        }

        public async Task Update(Moto moto)
        {
            if (!IsValid(new MotoValidation(), moto)) return;

            //Validacoes
            if (await _motoRepository.PlateIsExists(moto.Plate))
            {
                Notify("Placa já cadastrada no sistema.");
                return;
            }

            await _motoRepository.Update(moto);
        }

        public async Task DeleteById(Guid id)
        {
            await _motoRepository.DeleteById(id);
        }


        public void Dispose()
        {
            _motoRepository?.Dispose();
        }
    }
}
