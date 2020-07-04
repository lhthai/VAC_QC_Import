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
    public partial class FrmImport : Form
    {
        FrmLogin frmLogin = new FrmLogin();
        public FrmImport()
        {
            InitializeComponent();
        }

        private void FrmImport_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = "Welcome " + frmLogin.GetCurrentUser().UserId;
        }
    }
}
