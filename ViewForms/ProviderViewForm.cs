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
    public partial class ProviderViewForm : Form
    {
        public ProviderViewForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewProviderForm providerForm = new NewProviderForm(OpenType.NEW);
            providerForm.Owner = this;
            providerForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using TRADEORGContext context = new TRADEORGContext();

            if (lb_providers.SelectedIndex > -1)
            {
                var removeProvider = context.TbProviders.Where(x => x.ProvideName == lb_providers.SelectedItem.ToString()).FirstOrDefault();
                try
                {
                    if (removeProvider != null)
                    {
                        context.TbProviders.Remove(removeProvider);
                        lb_providers.Items.Remove(removeProvider);

                    }
                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.Message);
                }
                
            }
            else
            {
                MessageBox.Show("Select the value");
            }

            context.SaveChanges();
        }

        private async void ProviderViewForm_Load(object sender, EventArgs e)
        {
            using TRADEORGContext context = new TRADEORGContext();
            var providers = await context.TbProviders.ToListAsync();
            EntityHelper.SupProducts = await context.TbSupplierProducts.ToListAsync();
            foreach (var provider in providers)
            {
                AddProviderToListBox(provider);
            }

            
        }

        private void btn_NewSupProduct_Click(object sender, EventArgs e)
        {
            if (lb_providers.SelectedIndex > -1)
            {
                using TRADEORGContext context = new TRADEORGContext();
                EntityHelper.Provider = context.TbProviders.Where(x => x.ProvideName == lb_providers.SelectedItem.ToString()).FirstOrDefault();
                NewSupProductForm supProductForm = new NewSupProductForm(OpenType.NEW);
                supProductForm.Owner = this;
                supProductForm.Show();
            }
        }

        private void btn_RemoveSupProduct_Click(object sender, EventArgs e)
        {
            using TRADEORGContext context = new TRADEORGContext();

            if (lb_supProducts.SelectedIndex > -1)
            {
                var selectedItem = lb_supProducts.SelectedItem.ToString()?.Split(' ').First();
                var removeSupProduct = EntityHelper.SupProducts.Where(x => x.ProductName == selectedItem).FirstOrDefault();
                try
                {
                    if (removeSupProduct != null)
                    {
                        context.TbSupplierProducts.Remove(removeSupProduct);
                        lb_supProducts.Items.RemoveAt(lb_supProducts.SelectedIndex);
                        EntityHelper.SupProducts.Remove(removeSupProduct);
                    }

                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.Message);
                }

            }
            else
            {
                MessageBox.Show("Select the value");
            }

            context.SaveChanges();
        }

        private void lb_providers_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lb_providers.SelectedIndex > -1)
            {
                using TRADEORGContext context = new TRADEORGContext();
                EntityHelper.Provider = context.TbProviders.Where(x => x.ProvideName == lb_providers.SelectedItem.ToString()).FirstOrDefault();
                NewProviderForm providerForm = new NewProviderForm(OpenType.EDIT);
                providerForm.Owner = this;
                providerForm.Show();
            }
        }

        public void AddProviderToListBox(TbProvider provider)
        {
            if (provider.ProvideName != null)
            {
                lb_providers.Items.Add(provider.ProvideName);
            }
            else
            {
                lb_providers.Items.Add("null");
            }
        }

        public void EditProviderFromListBox(TbProvider provider)
        {
            if (provider.ProvideName != null)
            {
                lb_providers.Items[lb_providers.SelectedIndex] = provider.ProvideName;
            }
            else
            {
                lb_providers.Items[lb_providers.SelectedIndex] = "null";
            }
        }

        public void AddSupProductToListBox(TbSupplierProduct supProduct)
        {
            if (supProduct != null)
            {
                lb_supProducts.Items.Add(supProduct);
            }
            else
            {
                MessageBox.Show("NULL");
            }
        }

        public void EditSupProductToListBox(TbSupplierProduct supProduct)
        {
            if (supProduct != null && lb_supProducts.SelectedIndex > -1)
            {
                lb_supProducts.Items[lb_supProducts.SelectedIndex] = supProduct;
            }
            else
            {
                MessageBox.Show("NULL");
            }
        }

        private void lb_providers_MouseClick(object sender, MouseEventArgs e)
        {
            using TRADEORGContext context = new TRADEORGContext();
            var currentProvider = context.TbProviders.Where(x => x.ProvideName == lb_providers.SelectedItem.ToString()).FirstOrDefault();
            
            if (currentProvider != null)
            {
                lb_supProducts.Items.Clear();
                foreach (var product in EntityHelper.SupProducts.Where(x => x.IdProvider == currentProvider.ProviderId))
                {
                    AddSupProductToListBox(product);
                }
            }
        }

        private void lb_supProducts_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lb_supProducts.SelectedIndex > -1)
            {
                var selectedItem = lb_supProducts.SelectedItem.ToString().Split(' ').First();
                EntityHelper.SupplierProduct = EntityHelper.SupProducts.Where(x => x.ProductName == selectedItem).FirstOrDefault();
                NewSupProductForm supProductForm = new NewSupProductForm(OpenType.EDIT);
                supProductForm.Owner = this;
                supProductForm.Show();
            }
        }
    }
}
