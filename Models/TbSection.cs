using System;
using System.Collections.Generic;

namespace OrganisationManager.Models
{
    public partial class TbSection
    {
        public int SectionId { get; set; }
        public int SLevel { get; set; }
        public int StallCount { get; set; }
        public int? IdStore { get; set; }

        public virtual TbStore? IdStoreNavigation { get; set; }

        public override string ToString()
        {
            return $"Level: {SLevel}, Stalls: {StallCount}";
        }
    }
}
