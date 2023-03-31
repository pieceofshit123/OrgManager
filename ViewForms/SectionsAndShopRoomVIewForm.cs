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
    public partial class SectionsAndShopRoomVIewForm : Form
    {
        private TRADEORGContext _context = null!;
        private List<TbSection> _sections = null!;
        private List<TbShopingRoom> _shopRooms = null!;
        public SectionsAndShopRoomVIewForm()
        {
            InitializeComponent();
            _context = new TRADEORGContext();
        }

        private void btn_newSection_Click(object sender, EventArgs e)
        {
            NewSectionForm newSectionForm = new NewSectionForm(OpenType.NEW);
            newSectionForm.Owner = this;
            newSectionForm.Show();
        }

        private void btn_editSection_Click(object sender, EventArgs e)
        {
            if (lb_sections.SelectedIndex > -1)
            {
                EntityHelper.Section = _sections[lb_sections.SelectedIndex];
                NewSectionForm newSectionForm = new NewSectionForm(OpenType.EDIT);
                newSectionForm.Owner = this;
                newSectionForm.Show();
            }
        }

        private void btn_deleteSection_Click(object sender, EventArgs e)
        {
            if (lb_sections.SelectedIndex > -1)
            {
                _context.TbSections.Remove(_sections[lb_sections.SelectedIndex]);
                _sections.RemoveAt(lb_sections.SelectedIndex);
                lb_sections.Items.RemoveAt(lb_sections.SelectedIndex);
            }
        }

        private void btn_newShopRoom_Click(object sender, EventArgs e)
        {
            NewShoppingRoomForm newShoppingRoomForm = new NewShoppingRoomForm(OpenType.NEW);
            newShoppingRoomForm.Owner = this;
            newShoppingRoomForm.Show();
        }

        private void btn_editShopRoom_Click(object sender, EventArgs e)
        {
            if (lb_shopRooms.SelectedIndex > -1)
            {
                EntityHelper.ShopRoom = _shopRooms[lb_shopRooms.SelectedIndex];
                NewShoppingRoomForm newShoppingRoomForm = new NewShoppingRoomForm(OpenType.EDIT);
                newShoppingRoomForm.Owner = this;
                newShoppingRoomForm.Show();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_deleteShopRoom_Click(object sender, EventArgs e)
        {
            if (lb_shopRooms.SelectedIndex > -1)
            {
                _context.TbShopingRooms.Remove(_shopRooms[lb_shopRooms.SelectedIndex]);
                _shopRooms.RemoveAt(lb_shopRooms.SelectedIndex);
                lb_shopRooms.Items.RemoveAt(lb_shopRooms.SelectedIndex);
            }
        }

        public void AddSectionToDGV(TbSection section)
        {
            lb_sections.Items.Add(section);
        }

        public void EditSectionToDGV(TbSection section)
        {
            lb_sections.Items[lb_sections.SelectedIndex] = section;
        }

        public void AddShopRoomToDGV(TbShopingRoom room)
        {
            lb_shopRooms.Items.Add(room);
        }

        public void EditShopRoomToDGV(TbShopingRoom room)
        {
            lb_shopRooms.Items[lb_shopRooms.SelectedIndex] = room;
        }

        private void SectionsAndShopRoomVIewForm_Load(object sender, EventArgs e)
        {
            EnableSpecificControls();
            _sections = _context.TbSections.ToList();
            _shopRooms = _context.TbShopingRooms.ToList();
            lb_sections.Items.Add("Sections:");
            lb_shopRooms.Items.Add("Shopping Rooms:");
            if (EntityHelper.Store != null)
            {
                foreach (var section in _sections.Where(x => x.IdStore == EntityHelper.Store.StoreId))
                {
                    lb_sections.Items.Add(section);
                }
            }

            foreach (var room in _shopRooms.Where(x => x.IdOutletAdv == EntityHelper.OutletAdv.OutletAdvId))
            {
                lb_shopRooms.Items.Add(room);
            }
        }

        private void EnableSpecificControls()
        {
            if (EntityHelper.Store == null)
            {
                btn_deleteSection.Enabled = false;
                btn_newSection.Enabled = false;
                btn_editSection.Enabled = false;
                lb_sections.Enabled = false;
            }
        }
    }
}
