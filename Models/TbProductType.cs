using System;
using System.Collections.Generic;

namespace OrganisationManager.Models
{
    public partial class TbProductType
    {
        public TbProductType()
        {
            TbAvailableProducts = new HashSet<TbAvailableProduct>();
            TbProductSolds = new HashSet<TbProductSold>();
        }

        public int ProductTypeId { get; set; }
        public string ProductName { get; set; } = null!;
        public decimal ProductCost { get; set; }

        public virtual ICollection<TbAvailableProduct> TbAvailableProducts { get; set; }
        public virtual ICollection<TbProductSold> TbProductSolds { get; set; }

        public override string ToString()
        {
            return ProductName + " " + ProductCost.ToString();
        }
    }
}
