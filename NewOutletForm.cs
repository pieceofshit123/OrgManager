using Microsoft.Data.SqlClient;
using OrganisationManager.Helpers;
using OrganisationManager.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrganisationManager
{
    public enum OpenType
    {
        NEW,
        EDIT
    }

    public partial class NewOutletForm : Form
    {
        OpenType openType = OpenType.NEW;

        private List<TbShopingRoom> _shopRooms = null!;
        private List<TbSection> _sections = null!;
        public NewOutletForm(OpenType type)
        {
            this.openType = type;
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void NewOutlletForm_Load(object sender, EventArgs e)
        {
            if (openType == OpenType.NEW)
            {
                DisableAllControls();
                cb_type.SelectedItem = "Trading Tray";
            }
            else if (openType == OpenType.EDIT)
            {
                FillControls();
                cb_type.SelectedItem = EntityHelper.Outlet.OutletType;
            }

            EnableSpecificControls();
        }

        private void cb_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnableSpecificControls();
        }

        private void EnableSpecificControls()
        {
            var item = cb_type.SelectedItem.ToString();
                DisableAllControls();

            if (item == "Trading Tray")
            {
                tb_address.Enabled = true;
                tb_name.Enabled = true;
                lb_address.Enabled = true;
                lb_name.Enabled = true;
            }
            else if (item == "Store")
            {
                EnableAllControls();
            }
            else
            {
                EnableAllControls();
                lb_level.Enabled = false;
                tb_level.Enabled = false;
            }

            this.Refresh();
            
        }

        private void FillControls()
        {
            using TRADEORGContext context = new TRADEORGContext();
            var selectedOutlet = EntityHelper.OutletAdv;
            var item = EntityHelper.Outlet.OutletType;
            cb_type.SelectedItem = item;
            tb_name.Text = EntityHelper.Outlet.OutletName;
            tb_address.Text = EntityHelper.Outlet.OutletAddress;


            if (selectedOutlet != null)
            {
                tb_rent.Text = selectedOutlet.RentPayments.ToString();
                tb_utility.Text = selectedOutlet.UtilitiesPayments.ToString();
                tb_size.Text = selectedOutlet.OutletSize.ToString();
                tb_counter.Text = selectedOutlet.StallCount.ToString();

                if (item == "Store")
                {
                    tb_level.Text = context.TbStores
                        .Where(x => x.IdOutletAdvanced == selectedOutlet.OutletAdvId)
                        ?.FirstOrDefault()
                        .LevelsCount
                        .ToString();
                }
            }
        }

        private void EnableAllControls()
        {
            foreach (var control in this.Controls)
            {
                Control? control1 = control as Control;
                control1.Enabled = true;
            }

            this.Refresh();
        }

        private void DisableAllControls()
        {
            foreach (var control in this.Controls)
            {
                Control? control1 = control as Control;
                control1.Enabled = false;
            }

            cb_type.Enabled = true;
            btn_submit.Enabled = true;

            this.Refresh();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            using TRADEORGContext context = new TRADEORGContext();
            var item = cb_type.SelectedItem.ToString();
            int? id = context.TbOutlets.OrderByDescending(x => x.OutletId)?.FirstOrDefault()?.OutletId + 1;
            var ownerForm = Owner as MainMenuForm;
            if (id == null)
            {
                id = 1;
            }
            if (openType == OpenType.NEW)
            {
                if (id != null && item != null)
                {
                    AddOutletToDatabase(context, item, id.Value);
                    EntityHelper.Outlet = context.TbOutlets.OrderBy(x => x.OutletId).LastOrDefault();
                    ownerForm.AddOutlet(EntityHelper.Outlet);
                }
                else
                {
                    throw new ArgumentNullException("Null argument in function");
                }
            }
            else if (openType == OpenType.EDIT)
            {
                if (item != null)
                {
                    EditOutletToDatabase(context, item);
                    ownerForm.EditOutlet(EntityHelper.Outlet);
                }
                else
                {
                    throw new ArgumentNullException("Null argument in function");
                }
            }

            context.SaveChanges();
        }

        private void AddOutletToDatabase(TRADEORGContext context, string item, int id)
        {   
            if (FunctionHelper.IsAllFill(Controls))
            {
                context.TbOutlets.Add(
                            new TbOutlet { OutletName = tb_name.Text, OutletAddress = tb_address.Text, OutletType = item, IdTradeorg = IdInfoHelper.IDOrg });

                if (item != "Trading Tray")
                {  
                    context.TbOutletAdvanceds.Add(
                            new TbOutletAdvanced
                            {
                                IdOutlet = id,
                                OutletSize = int.Parse(tb_size.Text),
                                RentPayments = int.Parse(tb_rent.Text),
                                UtilitiesPayments = int.Parse(tb_utility.Text),
                                StallCount = int.Parse(tb_counter.Text)
                            });

                    if (item == "Store")
                    {
                        MessageBox.Show("Success");
                        var advancedId = context.TbOutletAdvanceds.OrderBy(x => x.OutletAdvId).LastOrDefault()?.OutletAdvId;
                        if (advancedId == null) { advancedId = 0; }
                        context.TbStores.Add(
                            new TbStore() { IdOutletAdvanced = advancedId.Value + 1, LevelsCount = int.Parse(tb_level.Text) });
                    }
                }
            }
            else
            {
                MessageBox.Show("Wrong input");
               
            }

            context.SaveChanges();
        }

        private void EditOutletToDatabase(TRADEORGContext context, string item)
        {
            context.ChangeTracker.Clear();
            if (EntityHelper.Outlet != null)
            {
                EntityHelper.Outlet.OutletName = tb_name.Text;
                EntityHelper.Outlet.OutletAddress = tb_address.Text;
                context.TbOutlets.Update(EntityHelper.Outlet);

                if (item != "Trading Tray" && EntityHelper.OutletAdv != null)
                {
                    EntityHelper.OutletAdv.RentPayments = int.Parse(tb_rent.Text);
                    EntityHelper.OutletAdv.UtilitiesPayments = int.Parse(tb_utility.Text);
                    EntityHelper.OutletAdv.StallCount = int.Parse(tb_counter.Text);
                    EntityHelper.OutletAdv.OutletSize = int.Parse(tb_size.Text);
                    context.TbOutletAdvanceds.Update(EntityHelper.OutletAdv);

                    if (item == "Store" && EntityHelper.Store != null)
                    {
                        EntityHelper.Store.LevelsCount = int.Parse(tb_level.Text);
                    }
                }
            }

            context.SaveChanges();
        }

   

        

        
    }
}
