using System;
using System.Collections.Generic;

namespace OrganisationManager.Models
{
    public partial class TbEmployee
    {
        public TbEmployee()
        {
            TbEmployeeSolds = new HashSet<TbEmployeeSold>();
        }

        public int EmployeeId { get; set; }
        public string? EmployeeName { get; set; }
        public bool? EmployeeGender { get; set; }
        public string? EmployeePassport { get; set; }
        public decimal? EmployeeSalary { get; set; }
        public DateTime EmploymentDate { get; set; }
        public DateTime DismissalDate { get; set; }
        public int? IdType { get; set; }
        public int? IdOutlet { get; set; }

        public virtual TbOutlet? IdOutletNavigation { get; set; }
        public virtual TbEmployeeType? IdTypeNavigation { get; set; }
        public virtual ICollection<TbEmployeeSold> TbEmployeeSolds { get; set; }
    }
}
