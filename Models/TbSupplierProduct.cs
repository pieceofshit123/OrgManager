using System;
using System.Collections.Generic;

namespace OrganisationManager.Models
{
    public partial class TbSupplierProduct
    {
        public int SupplierpId { get; set; }
        public decimal ProductCost { get; set; }
        public int ProductVolume { get; set; }
        public string ProductName { get; set; } = null!;
        public int? IdOrder { get; set; }
        public int? IdProvider { get; set; }

        public virtual TbOrder? IdOrderNavigation { get; set; }
        public virtual TbProvider? IdProviderNavigation { get; set; }

        public override string ToString()
        {
            return ProductName + " " + ProductCost.ToString() + " " + ProductVolume.ToString();
        }
    }
}
