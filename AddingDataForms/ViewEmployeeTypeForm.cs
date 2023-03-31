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
    public partial class ViewEmployeeTypeForm : Form
    {
        private TRADEORGContext _context = new TRADEORGContext();
        private int _currentIndex = -1;
        private TbEmployeeType? _currentType = null!;
        public ViewEmployeeTypeForm()
        {
            InitializeComponent();
            _context = new TRADEORGContext();
        }

        private void ViewEmployeeTypeForm_Load(object sender, EventArgs e)
        {
            lb_types.Items.Add("Posts:");
            foreach (var type in _context.TbEmployeeTypes.ToList())
            {
                lb_types.Items.Add(type);
            }
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_type.Text))
            {
                var newEmployeeType = new TbEmployeeType() { EmployeeTname = tb_type.Text };
                _context.TbEmployeeTypes.Add(newEmployeeType);
                lb_types.Items.Add(newEmployeeType);

                _context.SaveChanges();
            }
            else
            {
                MessageBox.Show("Wrong input");
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (_currentIndex > -1)
            {
                _currentType = _context.TbEmployeeTypes.Where(x => x.EmployeeTname == lb_types.Items[_currentIndex].ToString()).FirstOrDefault();

                if (_currentType != null && !string.IsNullOrEmpty(tb_type.Text))
                {
                    _currentType.EmployeeTname = tb_type.Text;
                    _context.Update(_currentType);
                    lb_types.Items[_currentIndex] = _currentType.ToString();
                }

                _context.SaveChanges();
            }

            
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (_currentIndex > -1)
            {
                var removeType = _context.TbEmployeeTypes.Where(x => x.EmployeeTname == lb_types.Items[_currentIndex].ToString()).FirstOrDefault();
                if (removeType != null)
                {
                    _context.TbEmployeeTypes.Remove(removeType);
                }
            }
        }

        private void lb_types_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentIndex = lb_types.SelectedIndex;
            tb_type.Text = lb_types.Text;
        }

        private void ViewEmployeeTypeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _context.Dispose();
        }
    }
}
