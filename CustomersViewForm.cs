using Microsoft.EntityFrameworkCore;
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
    public partial class CustomersViewForm : Form
    {
        private List<TbBuyer> _customers = null!;
        private int _currentIndex = -1;
        public CustomersViewForm()
        {
            InitializeComponent();
        }

        private async void CustomersViewForm_Load(object sender, EventArgs e)
        {
            using TRADEORGContext context = new TRADEORGContext();

            _customers = await context.TbBuyers.ToListAsync();
            if (_customers != null)
            {
                var collection = _customers.Where(x => context.TbProductSolds
                                .Where(y => y.IdBuyer == x.BuyerId).FirstOrDefault()?.IdOutlet == EntityHelper.Outlet?.OutletId);
                if (collection != null)
                {
                    foreach (var customer in collection)
                    {
                        dataGridView1.Rows.Add(customer.BuyerName, customer.BuyerGender ? "Man" : "Woman");
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewCustomerForm newCustomerForm = new NewCustomerForm(OpenType.NEW);
            newCustomerForm.Owner = this;
            newCustomerForm.Show();
        }

        public void AddCustomer(TbBuyer customer)
        {
            dataGridView1.Rows.Add(customer.BuyerName, customer.BuyerGender ? "Man" : "Woman");
            _customers.Add(customer);
        }

        public void EditCustomer(TbBuyer customer)
        {
            if (IdInfoHelper.IdCustomer > 0)
            {
                dataGridView1.Rows[IdInfoHelper.IdCustomer.Value].SetValues(customer.BuyerName, customer.BuyerGender ? "Man" : "Woman");
            }
            else
            {
                MessageBox.Show("You are not selected value");
            }
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 0)
            {
                _currentIndex = dataGridView1.SelectedRows[0].Index;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using TRADEORGContext context = new TRADEORGContext();
            if (_currentIndex > -1)
            {
                EntityHelper.Customer = _customers[_currentIndex];
                NewCustomerForm newCustomerForm = new NewCustomerForm(OpenType.EDIT);
                newCustomerForm.Owner = this;
                newCustomerForm.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using TRADEORGContext context = new TRADEORGContext();
            if (_currentIndex > -1)
            {
                context.TbBuyers.Remove(_customers[_currentIndex]);
                _customers.RemoveAt(_currentIndex);
                dataGridView1.Rows.RemoveAt(_currentIndex);

                context.SaveChanges();
            }
        }
    }
}
