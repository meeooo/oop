using System;

namespace Calendar
{
    [Serializable]
    internal class Reminder : NotificationBase
    {
        public Reminder(string name) : base(name)
        {
        }

        public Reminder(string name, DateTime dateTime) : this(name)
        {
            reminderDateTime = dateTime;
        }

        public DateTime reminderDateTime { get; set; }

        public override bool Ended(DateTime dateTime)
        {
            return reminderDateTime < dateTime;
        }

        public override string ToString()
        {
            return $"{name}: {reminderDateTime}";
        }
    }
}
