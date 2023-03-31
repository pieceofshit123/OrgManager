using System;
using System.Collections.Generic;

namespace OrganisationManager.Models
{
    public partial class TbShopingRoom
    {
        public int ShopingroomId { get; set; }
        public int StallCount { get; set; }
        public int? IdOutletAdv { get; set; }

        public virtual TbOutletAdvanced? IdOutletAdvNavigation { get; set; }

        public override string ToString()
        {
            return $"Shopping Room № {ShopingroomId + 1}: {StallCount} stalls";
        }
    }
}
