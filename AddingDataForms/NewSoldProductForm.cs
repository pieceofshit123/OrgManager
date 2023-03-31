using Microsoft.EntityFrameworkCore;
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
    public partial class NewSoldProductForm : Form
    {
        OpenType openType = 0;
        public NewSoldProductForm(OpenType type)
        {
            this.openType = type;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using TRADEORGContext context = new TRADEORGContext();
            var item = cb_productNames.SelectedItem.ToString()?.Split(' ').First();
            var request = context.TbProductTypes.Where(x => x.ProductName == item).FirstOrDefault();
            var soldProduct = new TbProductSold() { 
                SaleDate = DateTime.Parse(tb_saleDate.Text),
                VolumeSold = int.Parse(tb_volumeSold.Text),
                IdProductType = request?.ProductTypeId,
                IdOutlet = EntityHelper.Outlet?.OutletId,
            };

            if (openType == OpenType.NEW)
            {
                EntityHelper.SoldProducts.Add(soldProduct);
                if (Owner.GetType() == typeof(NewCustomerForm))
                {
                    ((NewCustomerForm)Owner).AddProduct(soldProduct, request);
                }
                else
                {
                    context.TbProductSolds.Add(soldProduct);
                    ((SoldProductViewForm)Owner).AddNewProduct(soldProduct);
                }
            }
            else if (openType == OpenType.EDIT)
            {
                if (Owner.GetType() == typeof(NewCustomerForm))
                {
                    EntityHelper.SoldProducts[IdInfoHelper.IndexProductSold] = soldProduct;
                    ((NewCustomerForm)Owner).EditProduct(soldProduct, request);
                }
                else
                {
                    context.ChangeTracker.Clear();
                    EntityHelper.SoldProduct.VolumeSold = int.Parse(tb_volumeSold.Text);
                    EntityHelper.SoldProduct.SaleDate = DateTime.Parse(tb_saleDate.Text);
                    context.TbProductSolds.Update(EntityHelper.SoldProduct);
                    ((SoldProductViewForm)Owner).EditNewProduct(EntityHelper.SoldProduct);
                }
            }

            context.SaveChanges();
        }

        private void btn_newProdType_Click(object sender, EventArgs e)
        {
            NewProductTypeForm productTypeForm = new NewProductTypeForm(OpenType.NEW);
            productTypeForm.Owner = this;
            productTypeForm.Show();
            IdInfoHelper.IndexProductType = cb_productNames.SelectedIndex;
        }

        public void AddProductType(TbProductType type)
        {
            cb_productNames.Items.Add(type.ProductName + "   " + type.ProductCost.ToString());
        }

        public void EditProductType(TbProductType type)
        {
            cb_productNames.Items[IdInfoHelper.IndexProductType] = type;
        }

        private async void NewSoldProductForm_Load(object sender, EventArgs e)
        {
            using TRADEORGContext context = new TRADEORGContext();
            foreach (var type in await context.TbProductTypes.ToListAsync())
            {
               cb_productNames.Items.Add(type);
            }
            if (openType == OpenType.EDIT)
            {
                cb_productNames.SelectedItem = context.TbProductTypes.Where(x => x.ProductTypeId == EntityHelper.SoldProduct.IdProductType).FirstOrDefault();
                tb_saleDate.Text = EntityHelper.SoldProduct?.SaleDate.ToShortDateString();
                tb_volumeSold.Text = EntityHelper.SoldProduct?.VolumeSold.ToString();
            }
        }
    }
}
