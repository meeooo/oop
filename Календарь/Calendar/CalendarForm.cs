using System;
using System.Linq;
using System.Windows.Forms;

namespace Calendar
{
    public partial class CalendarForm : Form
    {
        private const string dateTimeFormat = "ddd, dd MMMM yyyy, HH:mm:ss";

        private NotificationList notificationList;

        public CalendarForm()
        {
            InitializeComponent();
        }

        /// Загружает напоминания и праздники из файла и устанавливает время.
        private void CalendarForm_Load(object sender, EventArgs e)
        {
            notificationList = NotificationLoader.Load();
            notificationListBox.Items.Clear();
            notificationListBox.Items.AddRange(notificationList.GetNotificationsString().ToArray());

            UpdateCurrentTime();

            dateTimeStart.Format = DateTimePickerFormat.Custom;
            dateTimeStart.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            
            dateTimeEnd.Format = DateTimePickerFormat.Custom;
            dateTimeEnd.CustomFormat = "dd/MM/yyyy HH:mm:ss";
        }

        // Сохраняет напоминания и праздники в файл.
        private void CalendarForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            NotificationLoader.Save(notificationList);
        }

        // Обновляет текущее время.
        private void tick_Tick(object sender, EventArgs e)
        {
            UpdateCurrentTime();

            int index = notificationListBox.SelectedIndex;
            int oldCount = notificationList.Count;
            UpdateNotificationList();
            if (notificationList.Count == oldCount)
                notificationListBox.SelectedIndex = index;
        }

        // Обновить текущее время.
        private void UpdateCurrentTime() => currentTime.Text = DateTime.Now.ToString(dateTimeFormat);

        // Обновить список текущих праздников и напоминаний.
        private void UpdateNotificationList(bool forceRefresh = false)
        {
            int oldCount = notificationList.Count;
            notificationList.UpdateList(DateTime.Now);

            if (forceRefresh || oldCount != notificationList.Count)
            {
                notificationListBox.Items.Clear();
                notificationListBox.Items.AddRange(notificationList.GetNotificationsString().ToArray());
            }
        }

        // Обновляет кнопку удаления.
        private void notificationListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            deleteButton.Enabled = notificationListBox.SelectedIndex != -1;
            updateButton.Enabled = notificationListBox.SelectedIndex != -1;

            if (notificationListBox.SelectedIndex == -1)
                return;

            NotificationBase notification = notificationList[notificationListBox.SelectedIndex];
            notificationName.Text = notification.name;

            if (notification is Reminder reminder)
            {
                dateTimeStart.Text = dateTimeEnd.Text = reminder.reminderDateTime.ToString();
            }
            else if (notification is Holiday holiday)
            {
                dateTimeStart.Text = holiday.dateStart.ToString();
                dateTimeEnd.Text = holiday.dateEnd.ToString();
            }
        }

        // Добавить праздник.
        private void addHolidayButton_Click(object sender, EventArgs e)
        {
            var holiday = CreateHoliday();
            notificationList.Add(holiday);
            UpdateNotificationList(true);
        }

        // Добавить напоминание.
        private void addReminderButton_Click(object sender, EventArgs e)
        {
            var reminder = CreateReminder();
            notificationList.Add(reminder);
            UpdateNotificationList(true);
        }

        // Удалить напоминание.
        private void deleteButton_Click(object sender, EventArgs e)
        {
            notificationList.RemoveAt(notificationListBox.SelectedIndex);
            UpdateNotificationList(true);
        }

        // Обновить напоминание или праздник.
        private void updateButton_Click(object sender, EventArgs e)
        {
            NotificationBase notification;

            if (notificationList[notificationListBox.SelectedIndex] is Holiday)
                notification = CreateHoliday();
            else
                notification = CreateReminder();

            notificationList[notificationListBox.SelectedIndex] = notification;
            UpdateNotificationList(true);
        }

        // Создать праздник.
        private Holiday CreateHoliday()
        {
            return new Holiday(notificationName.Text, dateTimeStart.Value, dateTimeEnd.Value);
        }

        // Создать напоминание.
        private Reminder CreateReminder()
        {
            return new Reminder(notificationName.Text, dateTimeStart.Value);
        }
    }
}
