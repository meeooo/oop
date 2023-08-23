using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Calendar
{
    internal static class NotificationLoader
    {
        private const string notificationFileName = "notifications.data";

        // Сохраняет список напоминаний и праздников в файл.
        public static void Save(NotificationList list)
        {
            using (FileStream fs = File.Open(notificationFileName, FileMode.OpenOrCreate))
            {
                var bf = new BinaryFormatter();
                bf.Serialize(fs, list);
            }
        }

        // Загружает список напоминаний и праздников из файла.
        public static NotificationList Load()
        {
            if (!File.Exists(notificationFileName))
                return new NotificationList();

            using (FileStream fs = File.Open(notificationFileName, FileMode.Open))
            {
                var bf = new BinaryFormatter();
                return (NotificationList)bf.Deserialize(fs);
            }
        }
    }
}
