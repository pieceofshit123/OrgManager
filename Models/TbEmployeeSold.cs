using System;
using System.Collections.Generic;

namespace OrganisationManager.Models
{
    public partial class TbEmployeeSold
    {
        public int Id { get; set; }
        public int? IdProductSold { get; set; }
        public int? IdEmployee { get; set; }

        public virtual TbEmployee? IdEmployeeNavigation { get; set; }
        public virtual TbProductSold? IdProductSoldNavigation { get; set; }
    }
}
