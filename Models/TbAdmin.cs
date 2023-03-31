using System;
using System.Collections.Generic;

namespace OrganisationManager.Models
{
    public partial class TbAdmin
    {
        public int AdminId { get; set; }
        public string AdminLogin { get; set; } = null!;
        public string AdminPassword { get; set; } = null!;
        public int? IdTradeorg { get; set; }

        public virtual TbTradeorg? IdTradeorgNavigation { get; set; }
    }
}
