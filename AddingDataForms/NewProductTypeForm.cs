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

namespace OrganisationManager.AddingDataForms
{
    public partial class NewProductTypeForm : Form
    {
        OpenType openType = OpenType.NEW;
        public NewProductTypeForm(OpenType type)
        {
            openType = type;
            InitializeComponent();
        }

        private bool IsEmptyTextBoxes()
        {
            return string.IsNullOrEmpty(tb_name.Text) && string.IsNullOrEmpty(tb_price.Text);
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            using TRADEORGContext context = new TRADEORGContext();
            if (!IsEmptyTextBoxes())
            {
                var productType = new TbProductType() { ProductName = tb_name.Text, ProductCost = decimal.Parse(tb_price.Text) };

                if (openType == OpenType.NEW)
                {
                    context.TbProductTypes.Add(productType);
                    if (Owner.GetType() == typeof(NewSoldProductForm)) ((NewSoldProductForm)Owner).AddProductType(productType);
                }
                else if (openType == OpenType.EDIT)
                {
                    context.TbProductTypes.Update(productType);
                    if (Owner.GetType() == typeof(NewSoldProductForm)) ((NewSoldProductForm)Owner).EditProductType(productType);
                }

            }
            else
            {
                MessageBox.Show("Fill the boxes, please.");
            }

            context.SaveChanges();
        }

        private void NewProductTypeForm_Load(object sender, EventArgs e)
        {
            if (openType == OpenType.EDIT)
            {
                tb_name.Text = EntityHelper.ProductType?.ProductName;
                tb_price.Text = EntityHelper.ProductType?.ProductCost.ToString();
            }
        }
    }
}
