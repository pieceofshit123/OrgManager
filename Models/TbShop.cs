using System;
using System.Collections.Generic;

namespace OrganisationManager.Models
{
    public partial class TbShop
    {
        public int ShopId { get; set; }
        public int? IdOutletAdv { get; set; }

        public virtual TbOutletAdvanced? IdOutletAdvNavigation { get; set; }
    }
}
