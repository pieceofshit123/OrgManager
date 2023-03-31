using Microsoft.EntityFrameworkCore.Storage;
using OrganisationManager.AddingDataForms;
using OrganisationManager.Helpers;
using OrganisationManager.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrganisationManager.ViewForms
{
    public partial class EmployeeViewForm : Form
    {
        private TbEmployee _currentEmloyee { get; set; }
        private int _currentIndex { get; set; }
        TRADEORGContext _context = null!;
        private List<TbEmployee> _employees = null!;
        public EmployeeViewForm()
        {
            InitializeComponent();
            _context = new TRADEORGContext();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewEmloyeeForm emloyeeForm = new NewEmloyeeForm(OpenType.NEW);
            emloyeeForm.Owner = this;
            emloyeeForm.Show();
        }

        private void EmployeeViewForm_Load(object sender, EventArgs e)
        {
            _employees = _context.TbEmployees.ToList();

            foreach (var employee in _employees)
            {
                AddEmployeeToDGV(employee);
            }
        }

        public void AddEmployeeToDGV(TbEmployee employee)
        {
            var empType = GetEmployeeType(employee);
            dataGridView1.Rows.Add(employee.EmployeeName, employee.EmployeeGender.Value ? "M" : "W", employee.EmployeePassport, employee.EmployeeSalary, employee.EmploymentDate, employee.DismissalDate, empType.EmployeeTname);
        }

        public void EditEmployeeOnDGV(TbEmployee employee)
        {
            var empType = GetEmployeeType(employee);
            dataGridView1.Rows[_currentIndex].SetValues(employee.EmployeeName, employee.EmployeeGender.Value ? "M" : "W", employee.EmployeePassport, employee.EmployeeSalary, employee.EmploymentDate, employee.DismissalDate, empType.EmployeeTname);
        }

        public TbEmployeeType GetEmployeeType(TbEmployee employee)
        {
            var empType = _context.TbEmployeeTypes.Where(x => x.EmployeeTypeId == employee.IdType).FirstOrDefault();

            if (empType != null)
            {
                return empType;
            }
            else
            {
                return new TbEmployeeType() { EmployeeTname = "Salesman" };
            }
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            _currentIndex = (sender as DataGridView).SelectedRows[0].Index;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (_currentIndex > -1)
            {
                EntityHelper.Employee = _employees[_currentIndex];
                NewEmloyeeForm emloyeeForm = new NewEmloyeeForm(OpenType.EDIT);
                emloyeeForm.Owner = this;
                emloyeeForm.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (_currentIndex > -1)
            {
                _context.TbEmployees.Remove(_employees[_currentIndex]);
                _employees.RemoveAt(_currentIndex);
                dataGridView1.Rows.RemoveAt(_currentIndex);
            }

            _context.SaveChanges();
        }

        private void EmployeeViewForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _context.Dispose();
        }
    }
}
