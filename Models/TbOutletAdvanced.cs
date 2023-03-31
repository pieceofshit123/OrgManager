using System;
using System.Collections.Generic;

namespace OrganisationManager.Models
{
    public partial class TbOutletAdvanced
    {
        public TbOutletAdvanced()
        {
            TbShopingRooms = new HashSet<TbShopingRoom>();
        }

        public int OutletAdvId { get; set; }
        public int OutletSize { get; set; }
        public int? RentPayments { get; set; }
        public int? UtilitiesPayments { get; set; }
        public int StallCount { get; set; }
        public int? IdOutlet { get; set; }

        public virtual TbOutlet? IdOutletNavigation { get; set; }
        public virtual TbKiosk? TbKiosk { get; set; }
        public virtual TbShop? TbShop { get; set; }
        public virtual TbStore? TbStore { get; set; }
        public virtual ICollection<TbShopingRoom> TbShopingRooms { get; set; }
    }
}
