using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace Fullerene
{
    public partial class Fullerene : ServiceBase
    {
        private System.Diagnostics.EventLog eventLog;
        private System.Timers.Timer timer;
        public Fullerene()
        {
            InitializeComponent();
            eventLog = new System.Diagnostics.EventLog();
            bool logExists = true;
            if (!System.Diagnostics.EventLog.SourceExists("Fullerene"))
            {
                System.Diagnostics.EventLog.CreateEventSource(
                    "Fullerene", "Application");
                logExists = false;
            }
            eventLog.Source = "Fullerene";
            eventLog.Log = "Application";
            if (!logExists)
            {
                eventLog.WriteEntry("Eventlog Fullerene Source recreated.", EventLogEntryType.Warning, 100);
            }
        }

        protected override void OnStart(string[] args)
        {
            eventLog.WriteEntry("Fullerene Service initializing", EventLogEntryType.Information, 100);
            // Set up a timer to trigger every minute.
            timer = new System.Timers.Timer();
            timer.Interval = 60000; // 60 seconds
            timer.Elapsed += new System.Timers.ElapsedEventHandler(this.OnTimer);
            timer.Start();
        }
        protected void OnTimer(object sender, System.Timers.ElapsedEventArgs args)
        {
            // TODO: Insert monitoring activities here.
            eventLog.WriteEntry("Monitoring the System", EventLogEntryType.Information, 101);
        }

        protected override void OnStop()
        {
        }
        

    }
}
