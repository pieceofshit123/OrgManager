using System;
using System.Collections.Generic;

namespace OrganisationManager.Models
{
    public partial class TbOutlet
    {
        public TbOutlet()
        {
            TbAvailableProducts = new HashSet<TbAvailableProduct>();
            TbEmployees = new HashSet<TbEmployee>();
            TbProductSolds = new HashSet<TbProductSold>();
            TbRequests = new HashSet<TbRequest>();
            TbTradingTrays = new HashSet<TbTradingTray>();
        }

        public int OutletId { get; set; }
        public string? OutletName { get; set; }
        public string? OutletAddress { get; set; }
        public string? OutletType { get; set; }
        public int? IdTradeorg { get; set; }

        public virtual TbTradeorg? IdTradeorgNavigation { get; set; }
        public virtual TbOutletAdvanced? TbOutletAdvanced { get; set; }
        public virtual ICollection<TbAvailableProduct> TbAvailableProducts { get; set; }
        public virtual ICollection<TbEmployee> TbEmployees { get; set; }
        public virtual ICollection<TbProductSold> TbProductSolds { get; set; }
        public virtual ICollection<TbRequest> TbRequests { get; set; }
        public virtual ICollection<TbTradingTray> TbTradingTrays { get; set; }
    }
}
