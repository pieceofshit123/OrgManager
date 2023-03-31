using System;
using System.Collections.Generic;

namespace OrganisationManager.Models
{
    public partial class TbDate
    {
        public int? IdProvider { get; set; }
        public int? IdTradeorg { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }

        public virtual TbProvider? IdProviderNavigation { get; set; }
        public virtual TbTradeorg? IdTradeorgNavigation { get; set; }
    }
}
