using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
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

namespace OrganisationManager
{
    public partial class NewCustomerForm : Form
    {
        OpenType openType = 0;
        private List<TbProductSold> soldProducts = null!;
        public NewCustomerForm(OpenType type)
        {
            openType = type;
            InitializeComponent();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_newProduct_Click(object sender, EventArgs e)
        {
            NewSoldProductForm soldProductForm = new NewSoldProductForm(OpenType.NEW);
            soldProductForm.Owner = this;
            soldProductForm.Show();
        }

        private async void btn_submit_Click(object sender, EventArgs e)
        {
            using TRADEORGContext context = new TRADEORGContext();
            var newCustomer = new TbBuyer() { BuyerGender = radioButton1.Checked, BuyerName = tb_name.Text, TbProductSolds = EntityHelper.SoldProducts };
            if (openType == OpenType.NEW)
            {
                await context.TbBuyers.AddAsync(newCustomer);
                var lastCustomer = context.TbBuyers.OrderBy(x => x.BuyerId).LastOrDefault();
                if (lastCustomer != null)
                {
                    ListBinding(lastCustomer.BuyerId);
                }
                else
                {
                    ListBinding(1);
                }
                await context.TbProductSolds.AddRangeAsync(EntityHelper.SoldProducts);
                ((CustomersViewForm)Owner).AddCustomer(newCustomer);
            }
            else if(openType == OpenType.EDIT)
            {
                EntityHelper.Customer.BuyerGender = radioButton1.Checked;
                EntityHelper.Customer.BuyerName = tb_name.Text;
                ListBinding(EntityHelper.Customer.BuyerId);
                EntityHelper.Customer.TbProductSolds = EntityHelper.SoldProducts;
                context.TbBuyers.Update(EntityHelper.Customer);
                context.TbProductSolds.UpdateRange(EntityHelper.SoldProducts.ToArray());
                ((CustomersViewForm)Owner).EditCustomer(newCustomer);
            }

            context.SaveChanges();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            using TRADEORGContext context = new TRADEORGContext();
            context.TbProductSolds.Remove(EntityHelper.SoldProducts[lb_products.SelectedIndex]);
            EntityHelper.SoldProducts.RemoveAt(lb_products.SelectedIndex);
            lb_products.Items.RemoveAt(lb_products.SelectedIndex);
        }

        public void AddProduct(TbProductSold product, TbProductType productType)
        { 
            lb_products.Items.Add(productType.ProductName + " " + productType.ProductCost + " " + product.VolumeSold.ToString() + " " + product.SaleDate.ToString());
        }

        public void EditProduct(TbProductSold product, TbProductType productType)
        {
            lb_products.Items[lb_products.SelectedIndex] = productType.ProductName + " " + productType.ProductCost + " " + product.VolumeSold.ToString() + " " + product.SaleDate.ToString();
        }

        private async void NewCustomerForm_Load(object sender, EventArgs e)
        {
            using TRADEORGContext context = new TRADEORGContext();
            if (openType == OpenType.NEW)
            {
                
            }
            else if (openType == OpenType.EDIT)
            {
                EntityHelper.SoldProducts = await context.TbProductSolds.ToListAsync();
                foreach (var product in EntityHelper.SoldProducts.Where(x => x.IdBuyer == EntityHelper.Customer.BuyerId))
                {
                    var productType = context.TbProductTypes.Where(x => x.ProductTypeId == product.IdProductType).FirstOrDefault();

                    lb_products.Items.Add(productType.ToString() + product.ToString());
                }

                tb_name.Text = EntityHelper.Customer?.BuyerName;
                radioButton1.Checked = EntityHelper.Customer.BuyerGender;
            }
        }

        private void ListBinding(int id)
        {
            for (int i = 0; i < EntityHelper.SoldProducts.Count; i++)
            {
                EntityHelper.SoldProducts[i].IdBuyer = id;
            }
        }
    }
}
