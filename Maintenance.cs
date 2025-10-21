using MechanicAppWebBased.Models;
using MechanicAppWebBased.ViewModels.Maintenance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MechanicAppWebBased.BusinessEntities.Maintenance
{
    public class Maintenance
    {
        EnterpriseSystemESEntities _db = new EnterpriseSystemESEntities();
        TimeZoneInfo setTimeZoneInfo;
        DateTime currentDateTime;
        public tbl_UnScheduleMaintenanceModel RetriveMachineUnscheduleStatus(int MachineID)
        {
            return _db.Database.SqlQuery<tbl_UnScheduleMaintenanceModel>("Exec [dbo].[RetriveMachineUnscheduleStatus] {0}", new object[] { MachineID }).FirstOrDefault();
        }
        public tbl_UnScheduleMaintenanceModel SaveUnScheduleMaintenance(int MachineID, int CardNo, bool Started, bool Ended)
        {
            setTimeZoneInfo = TimeZoneInfo.FindSystemTimeZoneById("Pakistan Standard Time");
            currentDateTime = TimeZoneInfo.ConvertTime(DateTime.Now, setTimeZoneInfo);
            return _db.Database.SqlQuery<tbl_UnScheduleMaintenanceModel>("Exec [dbo].[SaveUnScheduleMaintenance] {0},{1},{2},{3},{4},{5},{6},{7},{8}", new object[] { MachineID, CardNo, currentDateTime.ToString("yyyy-MM-dd HH:mm:ss"), currentDateTime.ToString("yyyy-MM-dd HH:mm:ss"), currentDateTime.ToString("hh:mm:ss"), currentDateTime.ToString("hh:mm:ss"), Started, Ended, currentDateTime.ToString("yyyy-MM-dd hh:mm:ss") }).FirstOrDefault();
        }
        public tbl_UnScheduleMaintenanceModel UpdateUnscheduleMaintenance(int MachineID, bool Ended)
        {
            setTimeZoneInfo = TimeZoneInfo.FindSystemTimeZoneById("Pakistan Standard Time");
            currentDateTime = TimeZoneInfo.ConvertTime(DateTime.Now, setTimeZoneInfo);
            return _db.Database.SqlQuery<tbl_UnScheduleMaintenanceModel>("Exec [dbo].[UpdateUnscheduleMaintenance] {0},{1},{2},{3}", new object[] { MachineID, currentDateTime.ToString("yyyy-MM-dd HH:mm:ss"), currentDateTime.ToString("hh:mm:ss"), Ended }).FirstOrDefault();
        }
        public List<tbl_UnScheduleMaintenanceModel> RetriveDataTable()
        { 
            return _db.Database.SqlQuery<tbl_UnScheduleMaintenanceModel>("Exec [dbo].[RetriveDataTable]").ToList();
        }
        public List<tbl_MachineHistoryModel> RetriveMachineHistory()
        {
            return _db.Database.SqlQuery<tbl_MachineHistoryModel>("Exec [dbo].[RetriveMachineHistory]").ToList();
        }
    }
}