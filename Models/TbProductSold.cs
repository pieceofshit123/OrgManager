using System;
using System.Collections.Generic;

namespace OrganisationManager.Models
{
    public partial class TbProductSold
    {
        public TbProductSold()
        {
            TbEmployeeSolds = new HashSet<TbEmployeeSold>();
        }

        public int Id { get; set; }
        public int? IdOutlet { get; set; }
        public int? IdBuyer { get; set; }
        public int? IdProductType { get; set; }
        public int VolumeSold { get; set; }
        public DateTime SaleDate { get; set; }

        public virtual TbBuyer? IdBuyerNavigation { get; set; }
        public virtual TbOutlet? IdOutletNavigation { get; set; }
        public virtual TbProductType? IdProductTypeNavigation { get; set; }
        public virtual ICollection<TbEmployeeSold> TbEmployeeSolds { get; set; }

        public override string ToString()
        {
            return " " + VolumeSold.ToString() + " " + SaleDate.ToString();
        }
    }
}
