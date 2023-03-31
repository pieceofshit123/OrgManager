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
    public partial class NewAvProductForm : Form
    {
        OpenType openType = OpenType.NEW;
        public NewAvProductForm(OpenType type)
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

        private async void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_volume.Text) && !string.IsNullOrEmpty(cb_names.Text))
            {
                using TRADEORGContext context = new TRADEORGContext();

                if (EntityHelper.Outlet != null)
                {
                    var items = cb_names.SelectedItem.ToString()?.Split(' ');
                    var idProductType = context.TbProductTypes.Where(x => x.ProductName == items.First() && x.ProductCost == decimal.Parse(items[1])).FirstOrDefault()?.ProductTypeId;
                    var tempProduct = new TbAvailableProduct() { ProductVolume = int.Parse(tb_volume.Text), IdOutlet = EntityHelper.Outlet.OutletId, IdProductType = idProductType };
                    if (openType == OpenType.NEW)
                    {
                        await context.TbAvailableProducts.AddAsync(tempProduct);
                        EntityHelper.AvailableProducts.Add(tempProduct);
                        ((AvProductViewForm)Owner).AddAvProductToDataGrid(tempProduct);
                    }
                    else if (openType == OpenType.EDIT)
                    {
                        if (EntityHelper.AvailableProduct != null)
                        {
                            var index = EntityHelper.AvailableProducts.IndexOf(EntityHelper.AvailableProduct);
                            EntityHelper.AvailableProduct.IdProductType = tempProduct.IdProductType;
                            EntityHelper.AvailableProduct.ProductVolume = tempProduct.ProductVolume;
                            context.TbAvailableProducts.Update(EntityHelper.AvailableProduct);
                            EntityHelper.AvailableProducts[index] = EntityHelper.AvailableProduct;
                            ((AvProductViewForm)Owner).EditAvProductOnDataGrid(EntityHelper.AvailableProduct);
                        }
                    }

                    await context.SaveChangesAsync();
                }
            }
        }

        private void btn_type_Click(object sender, EventArgs e)
        {
            NewProductTypeForm productTypeForm = new NewProductTypeForm(OpenType.NEW);
            productTypeForm.Owner = this;
            productTypeForm.FormClosed += (send, evt) => { UpdateComboBoxData(); };
            productTypeForm.Show();    
        }


        private async void UpdateComboBoxData()
        {
            using TRADEORGContext context = new TRADEORGContext();

            var productTypes = await context.TbProductTypes.ToListAsync();
            cb_names.Items.Clear();
            foreach (var productType in productTypes)
            {
                cb_names.Items.Add(productType);
            }
        }

        private void NewAvProductForm_Load(object sender, EventArgs e)
        {
            using TRADEORGContext context = new TRADEORGContext();
            UpdateComboBoxData();
            if (openType == OpenType.EDIT && EntityHelper.AvailableProduct != null)
            {
                var currentProductType = context.TbProductTypes.Where(x => x.ProductTypeId == EntityHelper.AvailableProduct.IdProductType).FirstOrDefault();

                if (currentProductType != null)
                {
                    cb_names.SelectedItem = currentProductType;
                    tb_volume.Text = EntityHelper.AvailableProduct.ProductVolume.ToString();
                }
            } 
        }
    }
}
