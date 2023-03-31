using System;
using System.Collections.Generic;

namespace OrganisationManager.Models
{
    public partial class TbTradeorg
    {
        public TbTradeorg()
        {
            TbAdmins = new HashSet<TbAdmin>();
            TbOrders = new HashSet<TbOrder>();
            TbOutlets = new HashSet<TbOutlet>();
        }

        public int OrgId { get; set; }
        public string? OrgName { get; set; }
        public int OrgIndex { get; set; }
        public int? OrgBudget { get; set; }

        public virtual ICollection<TbAdmin> TbAdmins { get; set; }
        public virtual ICollection<TbOrder> TbOrders { get; set; }
        public virtual ICollection<TbOutlet> TbOutlets { get; set; }
    }
}
