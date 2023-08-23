using System;

namespace Calendar
{
    [Serializable]
    internal class Holiday : NotificationBase
    {
        public Holiday(string name) : base(name)
        {
        }

        public Holiday(string name, DateTime dateStart, DateTime dateEnd) : this(name)
        {
            this.dateStart = dateStart;
            this.dateEnd = dateEnd;
        }

        public DateTime dateStart { get; set; }
        public DateTime dateEnd { get; set; }

        public override bool Ended(DateTime dateTime)
        {
            return dateEnd < dateTime;
        }

        public override string ToString()
        {
            return $"{name}: {dateStart}-{dateEnd}";
        }
    }
}
