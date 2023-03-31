using System;
using System.Collections.Generic;

namespace OrganisationManager.Models
{
    public partial class TbBuyer
    {
        public TbBuyer()
        {
            TbProductSolds = new HashSet<TbProductSold>();
        }

        public int BuyerId { get; set; }
        public string BuyerName { get; set; } = null!;
        public bool BuyerGender { get; set; }

        public virtual ICollection<TbProductSold> TbProductSolds { get; set; }
    }
}
