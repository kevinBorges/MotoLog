using MotoLog.Business.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotoLog.Business.Notifications
{
    public class Notifier : INotifier
    {
        private List<Notification> _notifications;
        public Notifier()
        {
            _notifications = new List<Notification>();
        }
        public List<Notification> GetNotifications() =>  _notifications;
        
        public bool HaveNotification() => _notifications.Any();
        
        public void Handle(Notification notification) => _notifications.Add(notification);
    }
}
