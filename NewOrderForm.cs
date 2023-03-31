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

    public partial class NewOrderForm : Form
    {
        private TRADEORGContext _context = null!;
        private OpenType type = 0;
        public NewOrderForm(OpenType type)
        {
            InitializeComponent();
            this._context = new TRADEORGContext();
            this.type = type;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void NewOrderForm_Load(object sender, EventArgs e)
        {
            LoadProviders();
            if (type == OpenType.EDIT)
            {
                FillBoxes();
            }
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            var owner = Owner as OrdersViewForm;
            if (FunctionHelper.IsAllFill(Controls) && owner != null)
            {
                if (type == OpenType.NEW)
                {
                    AddOrderToDataBase();
                    if (EntityHelper.Order != null)
                    {
                        owner.AddOrderToDGV(EntityHelper.Order);
                    }
                }
                else if (type == OpenType.EDIT)
                {
                    EditOrderToDataBase();
                    if (EntityHelper.Order != null)
                    {
                        owner.EditOrderToDGV(EntityHelper.Order);
                    }
                }
            }
            else
            {
                MessageBox.Show("Wrong Input");
            }
        }

        private void btn_deleteRequest_Click(object sender, EventArgs e)
        {

        }

        private void btn_newRequest_Click(object sender, EventArgs e)
        {

        }

        private void NewOrderForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _context.Dispose();
        }

        private void AddOrderToDataBase()
        {
            var providerId = _context.TbProviders.Where(x => x.ProvideName == cb_provider.SelectedItem.ToString()).FirstOrDefault()?.ProviderId;

            if (providerId != null)
            {
                var newOrder = new TbOrder()
                {
                    OrderNumber = int.Parse(tb_orderNumber.Text),
                    Cost = decimal.Parse(tb_cost.Text),
                    CurrentVolume = int.Parse(tb_volume.Text),
                    OrderDate = DateTime.Parse(dtp_date.Text),
                    IdProvider = providerId,
                    IdTradeorg = IdInfoHelper.IDOrg
                };

                EntityHelper.Order = newOrder;
                _context.TbOrders.Add(newOrder);

                _context.SaveChanges();
            }
        }

        private void EditOrderToDataBase()
        {
            var providerId = _context.TbProviders.Where(x => x.ProvideName == cb_provider.SelectedItem.ToString()).FirstOrDefault()?.ProviderId;
            _context.ChangeTracker.Clear();
            if (providerId != null && EntityHelper.Order != null)
            {
                EntityHelper.Order.OrderNumber = int.Parse(tb_orderNumber.Text);
                EntityHelper.Order.Cost = decimal.Parse(tb_cost.Text);
                EntityHelper.Order.CurrentVolume = int.Parse(tb_volume.Text);
                EntityHelper.Order.OrderDate = DateTime.Parse(dtp_date.Text);
                EntityHelper.Order.IdProvider = providerId;

                _context.TbOrders.Update(EntityHelper.Order);

                _context.SaveChanges();
            }
        }

        private void LoadProviders()
        {
            foreach (var provider in _context.TbProviders.ToList())
            {
                cb_provider.Items.Add(provider);
            }
        }

        private void FillBoxes()
        {
            if (EntityHelper.Order != null)
            {
                var provider= _context.TbProviders.Where(x => x.ProviderId == EntityHelper.Order.IdProvider).FirstOrDefault();

                if (provider != null)
                {
                    cb_provider.SelectedItem = provider;
                    tb_cost.Text = EntityHelper.Order.Cost.ToString();
                    tb_orderNumber.Text = EntityHelper.Order.OrderNumber.ToString();
                    tb_volume.Text = EntityHelper.Order.CurrentVolume.ToString();
                    dtp_date.Text = EntityHelper.Order.OrderDate.ToString();
                }
            }
        }
    }
}
