using Microsoft.EntityFrameworkCore;
using OrganisationManager.AddingDataForms;
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

namespace OrganisationManager.ViewForms
{
    public partial class SoldProductViewForm : Form
    {
        private int _currentIndex = -1;
        private List<TbProductSold> _products = null!;
        public SoldProductViewForm()
        {
            InitializeComponent();
        }

        private void SoldProductViewForm_Load(object sender, EventArgs e)
        {
            using TRADEORGContext context = new TRADEORGContext();

            if (EntityHelper.Outlet != null)
            {
                _products = context.TbProductSolds.Where(x => x.IdOutlet == EntityHelper.Outlet.OutletId).ToList();
                var request = _products.Join(context.TbProductTypes.ToList(), x => x.IdProductType, y => y.ProductTypeId, (x, y) => new
                {
                    ProductName = y.ProductName,
                    ProductCost = y.ProductCost,
                    VolumeSold = x.VolumeSold,
                    SaleDate = x.SaleDate,
                }).ToList();

                foreach (var product in request)
                {
                    dataGridView1.Rows.Add(product.ProductName, product.ProductCost, product.VolumeSold, product.SaleDate);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewSoldProductForm newSoldProductForm = new NewSoldProductForm(OpenType.NEW);
            newSoldProductForm.Owner = this;
            newSoldProductForm.Show();
        }

        public void AddNewProduct(TbProductSold product)
        {
            var productType = GetProductType(product);
            dataGridView1.Rows.Add(productType.ProductName, productType.ProductCost, product.VolumeSold, product.SaleDate);
            _products.Add(product);
        }

        public void EditNewProduct(TbProductSold product)
        {
            var productType = GetProductType(product);
            dataGridView1.Rows[_currentIndex].SetValues(productType.ProductName, productType.ProductCost, product.VolumeSold, product.SaleDate);
            _products[_currentIndex] = product;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using TRADEORGContext context = new TRADEORGContext();
            if (_currentIndex > -1)
            {
                context.TbProductSolds.Remove(_products[_currentIndex]);
                dataGridView1.Rows.RemoveAt(_currentIndex);
                _products.RemoveAt(_currentIndex);
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            _currentIndex = dataGridView1.SelectedRows[0].Index;
        }

        private TbProductType GetProductType(TbProductSold product)
        {
            using TRADEORGContext context = new TRADEORGContext();

            var productType = context.TbProductTypes.Where(x => product.IdProductType == x.ProductTypeId).FirstOrDefault();

            if (productType != null)
            {
                return productType;
            }
            else
            {
                MessageBox.Show("There is no such product type in the database");
            }

            return new TbProductType() { };
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (_currentIndex > -1)
            {
                EntityHelper.SoldProduct = _products[_currentIndex];
                NewSoldProductForm newSoldProductForm = new NewSoldProductForm(OpenType.EDIT);
                newSoldProductForm.Owner = this;
                newSoldProductForm.Show();
            }
        }
    }
}
