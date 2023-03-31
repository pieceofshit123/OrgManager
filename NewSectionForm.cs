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

namespace OrganisationManager
{
    public partial class NewSectionForm : Form
    {
        OpenType type = OpenType.NEW;
        public NewSectionForm(OpenType type)
        {
            InitializeComponent();
            this.type = type;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(textBox1.Text) && string.IsNullOrEmpty(textBox2.Text)))
            {
                using TRADEORGContext context = new TRADEORGContext();
                var owner = Owner as SectionsAndShopRoomVIewForm;
                if (type == OpenType.NEW)
                {
                    context.TbSections.Add(new TbSection()
                    {
                        SLevel = int.Parse(textBox1.Text),
                        StallCount = int.Parse(textBox2.Text)
                    });
                    

                }
                else if (type == OpenType.EDIT && EntityHelper.Section != null)
                {
                    EntityHelper.Section.SLevel = int.Parse(textBox1.Text);
                    EntityHelper.Section.StallCount = int.Parse(textBox2.Text);
                    context.TbSections.Update(EntityHelper.Section);

                    owner.EditSectionToDGV(EntityHelper.Section);
                }

                context.SaveChanges();
            }
        }

        private void NewSectionForm_Load(object sender, EventArgs e)
        {
            if (type == OpenType.EDIT && EntityHelper.Section != null)
            {
                textBox1.Text = EntityHelper.Section.SLevel.ToString();
                textBox2.Text = EntityHelper.Section.StallCount.ToString();
            }
        }
    }
}
