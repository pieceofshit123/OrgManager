using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;
using OrganisationManager.AddingDataForms;
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
    public partial class MainMenuForm : Form
    {
        public object EmployeeViewForm { get; private set; }
        private List<TbOutlet> _outlets = null!;
       
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void newOutletToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var newOutletForm = new NewOutletForm(OpenType.NEW);
            newOutletForm.Owner = this;
            newOutletForm.Show();
        }

        private async void MainMenuForm_Load(object sender, EventArgs e)
        {
            using TRADEORGContext context = new TRADEORGContext();

            _outlets = await context.TbOutlets.Where(x => x.IdTradeorg == IdInfoHelper.IDOrg).ToListAsync();

            foreach (var outlet in _outlets)
            {
                datagridview1.Rows.Add(outlet.OutletName, outlet.OutletAddress, outlet.OutletType);
            }

            if (datagridview1.RowCount > 0)
            {
                IdInfoHelper.IDOutl = datagridview1.SelectedRows[0].Index;
                EntityHelper.Outlet = _outlets[IdInfoHelper.IDOutl.Value];
                label1.Text = EntityHelper.Outlet.OutletName;
            }
        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using TRADEORGContext context = new TRADEORGContext();
            if (IdInfoHelper.IDOutl > -1)
            {
                var removeItem = _outlets[IdInfoHelper.IDOutl.Value];
                if (removeItem != null)
                {
                    context.TbOutlets?.Remove(removeItem);
                    datagridview1.Rows.RemoveAt(IdInfoHelper.IDOutl.Value);
                    _outlets.Remove(removeItem);
                }
            }
            else
            {
                MessageBox.Show("Select the item");
            }

            context.SaveChanges();
        }

        private void datagridview1_SelectionChanged(object sender, EventArgs e)
        {
            if (datagridview1.RowCount > 0)
            {
                IdInfoHelper.IDOutl = datagridview1.SelectedRows[0].Index;
                EntityHelper.Outlet = _outlets[IdInfoHelper.IDOutl.Value];
            }
        }

        private void datagridview1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            using TRADEORGContext context = new TRADEORGContext();
            if (IdInfoHelper.IDOutl > -1)
            {
                if (EntityHelper.Outlet.OutletType != "Trading Tray")
                {
                    EntityHelper.OutletAdv = context.TbOutletAdvanceds.Where(x => x.IdOutlet == EntityHelper.Outlet.OutletId).FirstOrDefault();
                    if (EntityHelper.Outlet.OutletType == "Store")
                    {
                        EntityHelper.Store = context.TbStores.Where(x => x.IdOutletAdvanced == EntityHelper.OutletAdv.OutletAdvId).FirstOrDefault();
                    }
                }
                OutletDataForm dataForm = new OutletDataForm();
                dataForm.Show();
            }
        }

        private void contextMenu_Opening(object sender, CancelEventArgs e)
        {
            
        }

        public void AddOutlet(TbOutlet outlet)
        {
            datagridview1.Rows.Add(outlet.OutletName, outlet.OutletAddress, outlet.OutletType);
            
        }

        private void editToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (var context = new TRADEORGContext())
            {
                if (IdInfoHelper.IDOutl > -1)
                {
                    EntityHelper.OutletAdv = context.TbOutletAdvanceds.Where(x => x.IdOutlet == EntityHelper.Outlet.OutletId).FirstOrDefault();
                    NewOutletForm newOutletForm = new NewOutletForm(OpenType.EDIT);
                    newOutletForm.Owner = this;
                    newOutletForm.Show();
                }
            }
        }

        private void datagridview1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                datagridview1.ContextMenuStrip.Show();
            }
        }

        private void customersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (IdInfoHelper.IDOutl > -1)
            {
                CustomersViewForm customersForm = new CustomersViewForm();
                customersForm.FormClosed += (sender, e) => { this.Show(); };
                this.Hide();
                customersForm.Show();
            }
        }

        private void soldProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (IdInfoHelper.IDOutl > -1)
            {
                SoldProductViewForm soldProductForm = new SoldProductViewForm();
                soldProductForm.FormClosed += (sender, e) => { this.Show(); };
                this.Hide();
                soldProductForm.Show();
            }
        }

        private void providersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProviderViewForm providersForm = new ProviderViewForm();
            providersForm.FormClosed += (sender, e) => { this.Show(); };
            this.Hide();
            providersForm.Show();
        }

        private void availableProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (IdInfoHelper.IDOutl > -1)
            {
                AvProductViewForm productViewForm = new AvProductViewForm();
                productViewForm.FormClosed += (sender, e) => { this.Show(); };
                this.Hide();
                productViewForm.Show();
            }

            
        }

        public void EditOutlet(TbOutlet outlet)
        {
            datagridview1.Rows[IdInfoHelper.IDOutl.Value].SetValues(outlet.OutletName, outlet.OutletAddress, outlet.OutletType);
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sectionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void employeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (IdInfoHelper.IDOutl > -1)
            {
                EmployeeViewForm employeesform = new EmployeeViewForm();
                employeesform.FormClosed += (s, ev) => { this.Show(); };
                this.Hide();
                employeesform.Show();
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ViewEmployeeTypeForm viewEmployeeTypeForm = new ViewEmployeeTypeForm();
            viewEmployeeTypeForm.FormClosed += (s, ev) => { this.Show(); };
            this.Hide();
            viewEmployeeTypeForm.Show();
        }

        private void productRangeToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void ordersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrdersViewForm orderView = new OrdersViewForm();
            orderView.FormClosed += (s, ev) => { this.Show(); };
            this.Hide();
            orderView.Show();
        }
    }
}
