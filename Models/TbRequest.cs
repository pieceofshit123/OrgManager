using System;
using System.Collections.Generic;

namespace OrganisationManager.Models
{
    public partial class TbRequest
    {
        public int RequestId { get; set; }
        public string ProductName { get; set; } = null!;
        public int ProductVolume { get; set; }
        public int? IdOrder { get; set; }
        public int? IdOutlet { get; set; }

        public virtual TbOrder? IdOrderNavigation { get; set; }
        public virtual TbOutlet? IdOutletNavigation { get; set; }
    }
}
