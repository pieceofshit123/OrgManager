using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrganisationManager.Helpers
{
    internal class FunctionHelper
    {
        public static bool IsAllFill(Control.ControlCollection controls)
        {
            foreach (var control in controls)
            {
                if (control.GetType() == typeof(TextBox))
                {
                    var temp = control as TextBox;

                    if (temp.Enabled && string.IsNullOrEmpty(temp.Text))
                    {
                        return false;
                    }
                }
                
            }

            return true;
        }

        
    }
}
