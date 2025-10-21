using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MechanicAppWebBased.ViewModels.Maintenance
{
    public class tbl_UnScheduleMaintenanceModel
    {
        public int UnScheduleID { get; set; }
        public int MachineID { get; set; }
        public int CardNo { get; set; }
        public System.DateTime StartDateTime { get; set; }
        public System.DateTime EndDateTime { get; set; }
        public int DownTimeMinute { get; set; }
        public int DownTimeSecond { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public Nullable<bool> Started { get; set; }
        public Nullable<bool> Ended { get; set; }
        public System.DateTime CreatedDateTime { get; set; }
        public string Response { get; set; }
    }
}