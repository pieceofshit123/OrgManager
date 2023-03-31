using System;
using System.Collections.Generic;

namespace OrganisationManager.Models
{
    public partial class TbEmployeeType
    {
        public TbEmployeeType()
        {
            TbEmployees = new HashSet<TbEmployee>();
        }

        public int EmployeeTypeId { get; set; }
        public string? EmployeeTname { get; set; }

        public virtual ICollection<TbEmployee> TbEmployees { get; set; }

        public override string ToString()
        {
            return EmployeeTname.ToString();
        }
    }
}
