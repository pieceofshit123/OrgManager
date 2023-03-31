using OrganisationManager.Helpers;
using OrganisationManager.Models;
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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using TRADEORGContext context = new TRADEORGContext();

            var admin = context?.TbAdmins.Where(x => x.AdminLogin == textBox1.Text && x.AdminPassword == textBox2.Text).FirstOrDefault();

            if (admin?.AdminId > 0)
            {
                IdInfoHelper.IDOrg = admin.IdTradeorg;
            }

            MainMenuForm mainMenu = new MainMenuForm();
            mainMenu.Shown += delegate { this.Hide(); };
            mainMenu.FormClosed += (sender, e) => { this.Show(); };
            mainMenu.Show();
        }

        private void button1_Enter(object sender, EventArgs e)
        {
            
        }

        private void LoginForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }
    }
}
