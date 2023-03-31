using System;
using System.Collections.Generic;

namespace OrganisationManager.Models
{
    public partial class TbKiosk
    {
        public int KioskId { get; set; }
        public int? IdOutletAdv { get; set; }

        public virtual TbOutletAdvanced? IdOutletAdvNavigation { get; set; }
    }
}
