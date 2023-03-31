using System;
using System.Collections.Generic;

namespace OrganisationManager.Models
{
    public partial class TbStore
    {
        public TbStore()
        {
            TbSections = new HashSet<TbSection>();
        }

        public int StoreId { get; set; }
        public int LevelsCount { get; set; }
        public int? IdOutletAdvanced { get; set; }

        public virtual TbOutletAdvanced? IdOutletAdvancedNavigation { get; set; }
        public virtual ICollection<TbSection> TbSections { get; set; }

        public override string ToString()
        {
            return "Level: " + LevelsCount.ToString() + ", StoreId: " + StoreId.ToString();
        }
    }
}
