using ImportDimensionCheck.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImportDimensionCheck
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
           
        }

        private void txtMachine_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogon_Click(object sender, EventArgs e)
        {
            Logon(txtEmployee.Text, txtPassword.Text);
        }


        private void Logon(string employee, string password)
        {

            try
            {
                using (VACP4DBContext db = new VACP4DBContext())
                {
                    var emp = db.Employee.Where(x => x.Employee1 == employee && x.EmployeePWD==password).FirstOrDefault();
                    if (emp == null)
                    {
                        MessageBox.Show("Invalid username or password!", "Error", MessageBoxButtons.OK);
                        ClearInput();
                    }
                    else
                    {
                        txtEmployeeName.Text = emp.EmployeeName;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
            
        }

        private void ClearInput()
        {
            txtEmployee.Text = "";
            txtPassword.Text = "";
        }

        private void txtMachine_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter || e.KeyCode == Keys.Tab)
            {
                using (VACP4DBContext db = new VACP4DBContext())
                {
                    var machine = db.Machine.Where(x => x.Machine1 == txtMachine.Text.Trim()).FirstOrDefault();
                    if (machine == null)
                    {
                        MessageBox.Show("Invalid machine", "Error", MessageBoxButtons.OK);
                        ClearInput();
                    }
                    else
                    {
                        txtMachineName.Text = machine.MachineName;
                    }
                }
            }
        }
    }
}
