using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MechanicAppWebBased.ViewModels.Maintenance
{
    public class tbl_MachineHistoryModel
    {
        public string MachineVenderName { get; set; }
        public DateTime MachinePurchaseDate { get; set; }
        public DateTime LastMaintenceDate { get; set; }
    }
}