using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Personal_Calendar.Models;
using ApplicationContext = Personal_Calendar.Models.ApplicationContext;

namespace Personal_Calendar
{
    public partial class MainWindow : Form
    {
        private readonly ApplicationContext _dbContext = new ApplicationContext();

        public List<DbEvent> DbEvents = new List<DbEvent>();
        public DbEvent CurrentEvent = null;

        private DateTime ThisMonth = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);

        public MainWindow()
        {
            InitializeComponent();
            var first_day = this.ThisMonth;
            var last_day = this.ThisMonth.AddMonths(1);
            this.DbEvents =
                this._dbContext.Events.Where(e => e.StartTime >= first_day && e.EndTime <= last_day).ToList();
            this.eventsList.DataSource = this.DbEvents;
        }

        private void eventsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.CurrentEvent = (DbEvent) this.eventsList.SelectedItem;
            this.removeEventButton.Enabled = true;
            this.editEventButton.Enabled = true;
            this.eventDetailsPanel.Text = this.CurrentEvent.Description;
        }

        private void addEventButton_Click(object sender, EventArgs e)
        {
            // Display the Create/Edit Event form
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            var start = new DateTime(e.Start.Year, e.Start.Month, 1);
            var end = start.AddMonths(1);
            this.DbEvents = this._dbContext.Events.Where(evt => evt.StartTime >= start && evt.EndTime <= end).ToList();
            this.eventsList.DataSource = this.DbEvents;
            if (this.DbEvents.Count == 0)
            {
                this.removeEventButton.Enabled = false;
                this.editEventButton.Enabled = false;
                this.eventDetailsPanel.Text = "";
            }
        }
    }
}
