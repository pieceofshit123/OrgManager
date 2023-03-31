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
    public partial class NewSupProductForm : Form
    {
        OpenType openType = OpenType.NEW;
        public NewSupProductForm(OpenType openType)
        {
            InitializeComponent();
            this.openType = openType;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using TRADEORGContext context = new TRADEORGContext();
            if (FunctionHelper.IsAllFill(Controls))
            {
                var newSupProduct = new TbSupplierProduct()
                {
                    ProductName = tb_name.Text,
                    ProductCost = decimal.Parse(tb_cost.Text),
                    ProductVolume = int.Parse(tb_volume.Text),
                    IdProvider = EntityHelper.Provider?.ProviderId,
                };
                if (openType == OpenType.NEW)
                {
                    context.TbSupplierProducts.Add(newSupProduct);
                    ((ProviderViewForm)Owner).AddSupProductToListBox(newSupProduct);
                    EntityHelper.SupProducts.Add(newSupProduct);
                }
                else if (openType == OpenType.EDIT)
                {
                    var index = EntityHelper.SupProducts.IndexOf(EntityHelper.SupplierProduct);
                    EntityHelper.SupplierProduct.ProductName = newSupProduct.ProductName;
                    EntityHelper.SupplierProduct.ProductCost = newSupProduct.ProductCost;
                    EntityHelper.SupplierProduct.ProductVolume = newSupProduct.ProductVolume;
                    context.TbSupplierProducts.Update(EntityHelper.SupplierProduct);
                    ((ProviderViewForm)Owner).EditSupProductToListBox(newSupProduct);
                    EntityHelper.SupProducts[index] = EntityHelper.SupplierProduct;
                }
            }
            else
            {
                MessageBox.Show("Fill all boxes");
            }

            if (context.SaveChanges() > 0)
            {
                MessageBox.Show("Data was successfully added");
            }
        }

        private void NewSupProductForm_Load(object sender, EventArgs e)
        {
            if (openType == OpenType.EDIT)
            {
                if (EntityHelper.SupplierProduct != null)
                {
                    tb_name.Text = EntityHelper.SupplierProduct.ProductName;
                    tb_cost.Text = EntityHelper.SupplierProduct.ProductCost.ToString();
                    tb_volume.Text = EntityHelper.SupplierProduct.ProductVolume.ToString();
                }
                else
                {
                    MessageBox.Show("Something went wrong");
                }
            }
        }
    }
}
