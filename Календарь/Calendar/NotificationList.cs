using System;
using System.Collections.Generic;
using System.Linq;

namespace Calendar
{
    [Serializable]
    internal class NotificationList
    {
        // Список напоминаний и праздников.
        private List<NotificationBase> notifications = new List<NotificationBase>();

        // Кол-во напоминаний и праздников.
        public int Count => notifications.Count;

        // Получить i-е напоминание или праздник.
        public NotificationBase this[int index]
        {
            get => notifications[index];
            set => notifications[index] = value;
        }

        // Удаляет все напоминания и праздники, которые уже прошли.
        public void UpdateList(DateTime dateTime)
        {
            notifications.RemoveAll(n => n.Ended(dateTime));
        }

        // Добавить напоминание или праздник в список.
        public void Add(NotificationBase notification)
        {
            notifications.Add(notification);
        }

        // Удалить напоминание или праздник по индексу.
        public void RemoveAt(int index) => notifications.RemoveAt(index);

        // Получить описание всех напоминаний и праздников.
        public IEnumerable<string> GetNotificationsString() => notifications.Select(n => n.ToString());
    }
}
