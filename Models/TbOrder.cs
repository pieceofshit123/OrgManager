using System;
using System.Collections.Generic;

namespace OrganisationManager.Models
{
    public partial class TbOrder
    {
        public TbOrder()
        {
            TbRequests = new HashSet<TbRequest>();
            TbSupplierProducts = new HashSet<TbSupplierProduct>();
        }

        public int OrderId { get; set; }
        public int? IdProvider { get; set; }
        public int? IdTradeorg { get; set; }
        public decimal Cost { get; set; }
        public int OrderNumber { get; set; }
        public int CurrentVolume { get; set; }
        public DateTime OrderDate { get; set; }

        public virtual TbProvider? IdProviderNavigation { get; set; }
        public virtual TbTradeorg? IdTradeorgNavigation { get; set; }
        public virtual ICollection<TbRequest> TbRequests { get; set; }
        public virtual ICollection<TbSupplierProduct> TbSupplierProducts { get; set; }
    }
}
