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

namespace OrganisationManager
{
    public partial class OutletDataForm : Form
    {
        TRADEORGContext _context = null!;
        public OutletDataForm()
        {
            InitializeComponent();
            _context = new TRADEORGContext();
        }

        private void OutletDataForm_Load(object sender, EventArgs e)
        {
            
            if (EntityHelper.Outlet != null)
            {
                EnableSpecificControls();
                lb_name.Text += " " + EntityHelper.Outlet.OutletName;
                lb_address.Text += " " + EntityHelper.Outlet.OutletAddress;
                lb_type.Text += " " + EntityHelper.Outlet.OutletType;

                if (EntityHelper.Outlet.OutletType != "Trading Tray")
                {
                    var outletAdv = _context.TbOutletAdvanceds.Where(x => x.IdOutlet == EntityHelper.Outlet.OutletId).FirstOrDefault();

                    if (outletAdv != null)
                    {
                        lb_rent.Text += " " + outletAdv.RentPayments.ToString();
                        lb_utility.Text += " " + outletAdv.UtilitiesPayments.ToString();
                        lb_size.Text += " " + outletAdv.OutletSize.ToString() + " " + "mᶟ";
                        lb_counters.Text += " " + outletAdv.StallCount.ToString();

                        if (EntityHelper.Outlet.OutletType == "Store")
                        {
                            var store = _context.TbStores.Where(x => x.IdOutletAdvanced == outletAdv.OutletAdvId).FirstOrDefault();

                            if (store != null)
                            {
                                lb_level.Text += " " + store.LevelsCount.ToString();
                            }
                        }
                    }

                    
                }
            }
        }

        

        private void OutletDataForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _context.Dispose();
        }

        private void btn_sections_Click(object sender, EventArgs e)
        {
            SectionsAndShopRoomVIewForm form = new SectionsAndShopRoomVIewForm();
            form.Show();
        }

        private void btn_shoppingRooms_Click(object sender, EventArgs e)
        {
            SectionsAndShopRoomVIewForm form = new SectionsAndShopRoomVIewForm();
            form.Show();
        }

        private void btn_soldProduct_Click(object sender, EventArgs e)
        {
            SoldProductViewForm soldProductForm = new SoldProductViewForm();
            soldProductForm.Owner = this;
            soldProductForm.Show();
        }

        private void btn_availableProduct_Click(object sender, EventArgs e)
        {
            AvProductViewForm avProductForm = new AvProductViewForm();
            avProductForm.Owner = this;
            avProductForm.Show();
        }

        private void EnableSpecificControls()
        {
            var type = EntityHelper.Outlet.OutletType;

            if (type == "Trading Tray" || type == "Kiosk")
            {
                btn_sections.Enabled = false;
                btn_shoppingRooms.Enabled = false;
            }
            else if (type == "Shop")
            {
                btn_sections.Enabled = false;
            }
        }
    }
}
