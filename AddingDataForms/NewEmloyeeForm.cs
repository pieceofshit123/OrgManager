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
    public partial class NewEmloyeeForm : Form
    {
        private OpenType type = OpenType.NEW;
        TRADEORGContext _context;
        public NewEmloyeeForm(OpenType type)
        {
            this.type = type;
            InitializeComponent();
            _context = new TRADEORGContext();
        }

        private void NewEmloyeeForm_Load(object sender, EventArgs e)
        {
            LoadPosts();
            if (type == OpenType.EDIT)
            {
                FillBoxes();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            if (FunctionHelper.IsAllFill(Controls))
            {
                if (type == OpenType.NEW)
                {
                    AddEmployeeToDatabase();
                    if (EntityHelper.Employee != null)
                    {
                        (Owner as EmployeeViewForm).AddEmployeeToDGV(EntityHelper.Employee);
                    }
                }
                else if (type == OpenType.EDIT)
                {
                    EditEmployeeToDatabase();
                    if (EntityHelper.Employee != null)
                    {
                        (Owner as EmployeeViewForm).EditEmployeeOnDGV(EntityHelper.Employee);
                    }
                }
            }
            else
            {
                MessageBox.Show("Wrong input");
            }
        }

        private void AddEmployeeToDatabase()
        {
            var typeId = _context.TbEmployeeTypes.Where(x => x.EmployeeTname == cb_type.SelectedItem.ToString()).FirstOrDefault()?.EmployeeTypeId;

            if (typeId != null && EntityHelper.Outlet != null)
            {
                var addingEmployee = new TbEmployee()
                {
                    EmployeeName = tb_name.Text,
                    EmployeeGender = rb_gender.Checked,
                    EmployeePassport = tb_passport.Text,
                    EmployeeSalary = decimal.Parse(tb_salary.Text),
                    EmploymentDate = DateTime.Parse(tb_empDate.Text),
                    DismissalDate = DateTime.Parse(tb_disDate.Text),
                    IdOutlet = EntityHelper.Outlet.OutletId,
                    IdType = typeId
                };

                EntityHelper.Employee = addingEmployee;
                _context.Add(addingEmployee);
            }

            _context.SaveChanges();
        }

        private void EditEmployeeToDatabase()
        {
            var typeId = _context.TbEmployeeTypes.Where(x => x.EmployeeTname == cb_type.SelectedItem.ToString()).FirstOrDefault()?.EmployeeTypeId;
            _context.ChangeTracker.Clear();
            if (typeId != null && EntityHelper.Outlet != null && EntityHelper.Employee != null)
            {
                EntityHelper.Employee.EmployeeName = tb_name.Text;
                EntityHelper.Employee.EmployeeGender = rb_gender.Checked;
                EntityHelper.Employee.EmployeePassport = tb_passport.Text;
                EntityHelper.Employee.EmployeeSalary = decimal.Parse(tb_salary.Text);
                EntityHelper.Employee.EmploymentDate = DateTime.Parse(tb_empDate.Text);
                EntityHelper.Employee.DismissalDate = DateTime.Parse(tb_disDate.Text);
                if (EntityHelper.Employee.IdType != typeId) { EntityHelper.Employee.IdType = typeId; }                
                _context.Update(EntityHelper.Employee);
            }

            _context.SaveChanges();
        }

        private void LoadPosts()
        {
            cb_type.Items.Clear();
            foreach (var type in _context.TbEmployeeTypes.ToList())
            {
                cb_type.Items.Add(type);
            }
        }

        private void FillBoxes()
        {
            if (EntityHelper.Employee != null)
            {
                tb_name.Text = EntityHelper.Employee.EmployeeName;
                tb_salary.Text = EntityHelper.Employee.EmployeeSalary.ToString();
                tb_passport.Text = EntityHelper.Employee.EmployeePassport.ToString();
                tb_disDate.Text = EntityHelper.Employee.DismissalDate.ToString();
                tb_empDate.Text = EntityHelper.Employee.EmploymentDate.ToString();
                rb_gender.Checked = EntityHelper.Employee.EmployeeGender.Value;
                cb_type.SelectedItem = _context.TbEmployeeTypes.Where(x => x.EmployeeTypeId == EntityHelper.Employee.IdType).FirstOrDefault();
            }
        }

        private void NewEmloyeeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _context.Dispose();
        }
    }
}
