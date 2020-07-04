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
        public static UserMasterDTO currentUser;
        ConnectionString conn = new ConnectionString();

        public UserMasterDTO GetCurrentUser()
        {
            return currentUser;
        }

        public FrmLogin()
        {
            InitializeComponent();

        }


        private void Logon(string username, string password)
        {
            try
            {
                using (VACP4DBContext db = new VACP4DBContext())
                {
                    var user = db.UserMaster.Where(x => x.UserId == username && x.Password == password).FirstOrDefault();
                    if (user != null)
                    {
                        currentUser = user;
                        FrmImport frm = new FrmImport();
                        frm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password!", "Error", MessageBoxButtons.OK);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }

        }

        private void btnLogon_Click(object sender, EventArgs e)
        {
            conn.DBName = cbDatabase.SelectedItem.ToString();
            Logon(txtUsername.Text.Trim(), txtPassword.Text.Trim());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Logon(txtUsername.Text.Trim(), txtPassword.Text.Trim());
            }
        }

        private void currentTime_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss");
        }

        private void btnChangeDB_Click(object sender, EventArgs e)
        {
            cbDatabase.Enabled = true;
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            cbDatabase.SelectedItem = "VACP4DB";
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            FrmConfig frm = new FrmConfig();
            frm.Show();
        }
    }
}
