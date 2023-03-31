using Microsoft.EntityFrameworkCore;
using OrganisationManager.AddingDataForms;
using OrganisationManager.Helpers;
using OrganisationManager.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrganisationManager.ViewForms
{
    public partial class AvProductViewForm : Form
    {
        private int _currentIndex = 0;
        public AvProductViewForm()
        {
            InitializeComponent();
        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            NewAvProductForm form = new NewAvProductForm(OpenType.NEW);
            form.Owner = this;
            form.Show();
        }

        public void AddAvProductToDataGrid(TbAvailableProduct product)
        {
            var productType = GetProductType(product);
            dataGridView1.Rows.Add(productType?.ProductName, productType?.ProductCost, product.ProductVolume);
        }

        public void EditAvProductOnDataGrid(TbAvailableProduct product)
        {
            var productType = GetProductType(product);
            dataGridView1.Rows[_currentIndex].SetValues(productType?.ProductName, productType?.ProductCost, product.ProductVolume);
        }

        private TbProductType GetProductType(TbAvailableProduct product)
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

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            EntityHelper.AvailableProduct = EntityHelper.AvailableProducts[dataGridView1.SelectedRows[0].Index];
            NewAvProductForm form = new NewAvProductForm(OpenType.EDIT);
            form.Owner = this;
            form.Show();
            
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            using TRADEORGContext context = new TRADEORGContext();
            if (_currentIndex > -1)
            {
                var removeAvProdct = EntityHelper.AvailableProducts[_currentIndex];
                context.Remove(removeAvProdct);
                dataGridView1.Rows.RemoveAt(_currentIndex);
                EntityHelper.AvailableProducts.RemoveAt(_currentIndex);

                context.SaveChanges();
            }
        }

        private void AvProductViewForm_Load(object sender, EventArgs e)
        {
            using TRADEORGContext context = new TRADEORGContext();

            if (EntityHelper.Outlet != null)
            {
                if (Owner != null && Owner.GetType() == typeof(OutletDataForm))
                {
                    EntityHelper.AvailableProducts = context.TbAvailableProducts.Where(x => x.IdOutlet == EntityHelper.Outlet.OutletId).ToList();
                    foreach (var product in EntityHelper.AvailableProducts)
                    {
                        AddAvProductToDataGrid(product);
                    }
                }
                else
                {
                    var products = context.TbProductTypes
                        .Select(x => new
                        {
                            ProductName = x.ProductName,
                            ProductCost = x.ProductCost,
                            Volume = context.TbAvailableProducts.Where(y => y.IdProductType == x.ProductTypeId).Sum(z => z.ProductVolume),
                        }).ToList();

                    foreach (var AvProduct in products)
                    {
                        dataGridView1.Rows.Add(AvProduct.ProductName, AvProduct.ProductCost, AvProduct.Volume);
                    }
                }
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            _currentIndex = dataGridView1.SelectedRows[0].Index;
        }
    }
}
