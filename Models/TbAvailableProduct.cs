using System;
using System.Collections.Generic;

namespace OrganisationManager.Models
{
    public partial class TbAvailableProduct
    {
        public int ProductAvId { get; set; }
        public int? ProductVolume { get; set; }
        public int? IdProductType { get; set; }
        public int? IdOutlet { get; set; }

        public virtual TbOutlet? IdOutletNavigation { get; set; }
        public virtual TbProductType? IdProductTypeNavigation { get; set; }
    }
}
