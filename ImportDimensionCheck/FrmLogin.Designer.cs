namespace ImportDimensionCheck
{
    partial class FrmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.lblDateTime = new System.Windows.Forms.Label();
            this.currentTime = new System.Windows.Forms.Timer(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnConfig = new System.Windows.Forms.Button();
            this.cbDatabase = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnChangeDB = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnLogon = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTime.Location = new System.Drawing.Point(458, 20);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(123, 16);
            this.lblDateTime.TabIndex = 13;
            this.lblDateTime.Text = "30/06/2020 12:12:12";
            // 
            // currentTime
            // 
            this.currentTime.Enabled = true;
            this.currentTime.Tick += new System.EventHandler(this.currentTime_Tick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnConfig);
            this.groupBox2.Controls.Add(this.cbDatabase);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnChangeDB);
            this.groupBox2.Controls.Add(this.btnLogout);
            this.groupBox2.Controls.Add(this.btnLogon);
            this.groupBox2.Controls.Add(this.txtUsername);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtPassword);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(58, 55);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(523, 255);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Log In";
            // 
            // btnConfig
            // 
            this.btnConfig.BackColor = System.Drawing.SystemColors.Control;
            this.btnConfig.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfig.ForeColor = System.Drawing.Color.White;
            this.btnConfig.Image = ((System.Drawing.Image)(resources.GetObject("btnConfig.Image")));
            this.btnConfig.Location = new System.Drawing.Point(403, 189);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(35, 30);
            this.btnConfig.TabIndex = 12;
            this.btnConfig.UseVisualStyleBackColor = false;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // cbDatabase
            // 
            this.cbDatabase.Enabled = false;
            this.cbDatabase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbDatabase.FormattingEnabled = true;
            this.cbDatabase.Items.AddRange(new object[] {
            "VACP4DB",
            "TESTP1"});
            this.cbDatabase.Location = new System.Drawing.Point(157, 40);
            this.cbDatabase.Name = "cbDatabase";
            this.cbDatabase.Size = new System.Drawing.Size(221, 24);
            this.cbDatabase.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Database:";
            // 
            // btnChangeDB
            // 
            this.btnChangeDB.BackColor = System.Drawing.SystemColors.Control;
            this.btnChangeDB.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnChangeDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeDB.ForeColor = System.Drawing.Color.White;
            this.btnChangeDB.Image = ((System.Drawing.Image)(resources.GetObject("btnChangeDB.Image")));
            this.btnChangeDB.Location = new System.Drawing.Point(403, 34);
            this.btnChangeDB.Name = "btnChangeDB";
            this.btnChangeDB.Size = new System.Drawing.Size(35, 35);
            this.btnChangeDB.TabIndex = 8;
            this.btnChangeDB.UseVisualStyleBackColor = false;
            this.btnChangeDB.Click += new System.EventHandler(this.btnChangeDB_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.SlateGray;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(291, 189);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(87, 30);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Exit";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnLogon
            // 
            this.btnLogon.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnLogon.FlatAppearance.BorderSize = 0;
            this.btnLogon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogon.ForeColor = System.Drawing.Color.White;
            this.btnLogon.Location = new System.Drawing.Point(157, 189);
            this.btnLogon.Name = "btnLogon";
            this.btnLogon.Size = new System.Drawing.Size(87, 30);
            this.btnLogon.TabIndex = 6;
            this.btnLogon.Text = "Log On";
            this.btnLogon.UseVisualStyleBackColor = false;
            this.btnLogon.Click += new System.EventHandler(this.btnLogon_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(157, 88);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(221, 22);
            this.txtUsername.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Username:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(157, 137);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(221, 22);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password:";
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 322);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblDateTime);
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log On";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Timer currentTime;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnLogon;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnChangeDB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbDatabase;
        private System.Windows.Forms.Button btnConfig;
    }
}