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
    public partial class NewShoppingRoomForm : Form
    {
        private OpenType openType = OpenType.NEW;
        private TRADEORGContext _context = null!;
        public NewShoppingRoomForm(OpenType openType)
        {
            InitializeComponent();
            this.openType = openType;
            this._context = new TRADEORGContext();
        }

        private void NewShoppingRoomForm_Load(object sender, EventArgs e)
        {
            if (openType == OpenType.EDIT && EntityHelper.ShopRoom != null)
            {
                textBox1.Text = EntityHelper.ShopRoom.ToString();
            }
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                var owner = Owner as SectionsAndShopRoomVIewForm;
                if (openType == OpenType.NEW)
                {
                    var newShopRoom = new TbShopingRoom()
                    {
                        StallCount = int.Parse(textBox1.Text)
                    };
                    _context.TbShopingRooms.Add(newShopRoom);

                    owner.AddShopRoomToDGV(newShopRoom);
                }
                else if (openType == OpenType.EDIT && EntityHelper.ShopRoom != null)
                {
                    EntityHelper.ShopRoom.StallCount = int.Parse(textBox1.Text);
                    _context.TbShopingRooms.Update(EntityHelper.ShopRoom);

                    owner.EditShopRoomToDGV(EntityHelper.ShopRoom);
                }

                _context.SaveChanges();
            }
        }
    }
}
