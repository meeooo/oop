using System;

namespace Calendar
{
    [Serializable]
    internal abstract class NotificationBase
    {
        public string name { get; set; }

        protected NotificationBase(string name)
        {
            this.name = name;
        }

        public abstract bool Ended(DateTime dateTime);
    }
}
