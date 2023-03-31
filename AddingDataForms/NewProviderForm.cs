using OrganisationManager.Helpers;
using OrganisationManager.Models;
using OrganisationManager.ViewForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrganisationManager.AddingDataForms
{
    public partial class NewProviderForm : Form
    {
        OpenType openType = OpenType.NEW;
        public NewProviderForm(OpenType type)
        {
            openType = type;
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using TRADEORGContext context = new TRADEORGContext();
            if (!string.IsNullOrEmpty(tb_name.Text))
            {
                var tempProvider = new TbProvider() { ProvideName = tb_name.Text };
                if (openType == OpenType.NEW)
                {
                    context.TbProviders.Add(tempProvider);
                    ((ProviderViewForm)Owner).AddProviderToListBox(tempProvider);
                }
                else if (openType == OpenType.EDIT)
                {
                    if (EntityHelper.Provider != null)
                    {
                        EntityHelper.Provider.ProvideName = tempProvider.ProvideName;
                        context.TbProviders.Update(EntityHelper.Provider);
                        ((ProviderViewForm)Owner).EditProviderFromListBox(tempProvider);
                    }
                    else
                    {
                        MessageBox.Show("Wrong Update");
                    }
                }
            }

            context.SaveChanges();
        }

        private void NewProviderForm_Load(object sender, EventArgs e)
        {
            if (openType == OpenType.EDIT)
            {
                tb_name.Text = EntityHelper.Provider?.ProvideName;
            }
        }
    }
}
