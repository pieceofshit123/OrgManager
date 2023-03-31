using System;
using System.Collections.Generic;

namespace OrganisationManager.Models
{
    public partial class TbProvider
    {
        public TbProvider()
        {
            TbOrders = new HashSet<TbOrder>();
            TbSupplierProducts = new HashSet<TbSupplierProduct>();
        }

        public int ProviderId { get; set; }
        public string? ProvideName { get; set; }

        public virtual ICollection<TbOrder> TbOrders { get; set; }
        public virtual ICollection<TbSupplierProduct> TbSupplierProducts { get; set; }

        public override string ToString()
        {
            return ProvideName.ToString();
        }
    }
}
