using FluentValidation;
using FluentValidation.Results;
using MotoLog.Business.Entity;
using MotoLog.Business.Interfaces.Services;
using MotoLog.Business.Notifications;

namespace MotoLog.Business.Services
{
    public abstract class BaseService
    {
        private readonly INotifier _notifier;

        public BaseService(INotifier notifier)
        {
            _notifier = notifier;
        }

        protected void Notify(ValidationResult validationResult)
        {
            foreach (var item in validationResult.Errors)
            {
                Notify(item.ErrorMessage);
            }
        }

        protected void Notify(string msg) => _notifier.Handle(new Notification(msg));

        protected bool IsValid<TV, TE>(TV validation, TE entidade)
            where TV : AbstractValidator<TE>
            where TE : Base
        {
            var validator = validation.Validate(entidade);

            if (validator.IsValid) return true;

            Notify(validator);

            return false;
        }
    }
}
