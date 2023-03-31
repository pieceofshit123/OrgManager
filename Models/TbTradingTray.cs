using System;
using System.Collections.Generic;

namespace OrganisationManager.Models
{
    public partial class TbTradingTray
    {
        public int TrayId { get; set; }
        public int? IdOutlet { get; set; }

        public virtual TbOutlet? IdOutletNavigation { get; set; }
    }
}
