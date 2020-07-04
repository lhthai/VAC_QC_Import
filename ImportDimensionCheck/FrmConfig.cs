using ImportDimensionCheck.Helpers;
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
    public partial class FrmConfig : Form
    {
        AppSetting setting = new AppSetting();
        public FrmConfig()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string sServer = txtServer.Text.Trim();
            string sDatabase = txtDatabase.Text.Trim();
            string sUsername = txtUsername.Text.Trim();
            string sPassword = txtPassword.Text.Trim();
            string connectionString = String.Format("Data Source={0};Initial Catalog={1};User ID={2}; Password={3};", sServer, sDatabase, sUsername, sPassword);
            try
            {
                SQLConnection sql = new SQLConnection(connectionString);
                if (sql.isConnection)
                {
                    
                    setting.SaveConnectionString("conn", connectionString);
                    MessageBox.Show("Your connection string has been saved successfully!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void LoadConfig()
        {

        }
    }
}
