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
    public partial class OrdersViewForm : Form
    {
        private List<TbOrder> _orders = null!;
        private TRADEORGContext _context = null!;
        private int _currentIndex = -1;
        public OrdersViewForm()
        {
            InitializeComponent();
            _context = new TRADEORGContext();
        }

        private void OrdersViewForm_Load(object sender, EventArgs e)
        {
            _orders = _context.TbOrders.ToList();
            foreach (var order in _orders)
            {
                AddOrderToDGV(order);
            }
        }


        public void AddOrderToDGV(TbOrder order)
        {
            dataGridView1.Rows.Add(order.OrderNumber, order.OrderDate, order.CurrentVolume, order.Cost);
            if (!_orders.Contains(order)) _orders.Add(order);
        }

        public void EditOrderToDGV(TbOrder order)
        {
            dataGridView1.Rows[_currentIndex].SetValues(order.OrderNumber, order.OrderDate, order.CurrentVolume, order.Cost);
            _orders[_currentIndex] = order;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewOrderForm newOrder = new NewOrderForm(OpenType.NEW);
            newOrder.Owner = this;
            newOrder.Show();
        }

        private void OrdersViewForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _context.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (_currentIndex > -1)
            {
                EntityHelper.Order = _orders[_currentIndex];
                NewOrderForm newOrder = new NewOrderForm(OpenType.EDIT);
                newOrder.Owner = this;
                newOrder.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (_currentIndex > -1)
            {
                EntityHelper.Order = _orders[_currentIndex];
                _context.TbOrders.Remove(EntityHelper.Order);
                _orders.RemoveAt(_currentIndex);
                dataGridView1.Rows.RemoveAt(_currentIndex);

                _context.SaveChanges();
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            _currentIndex = dataGridView1.SelectedRows[0].Index;
        }
    }
}
