namespace Project_TURBO.AZ__NovruzHoliday_
{
    partial class MainForm
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
            this.dgvCarList = new System.Windows.Forms.DataGridView();
            this.groupBoxForList = new System.Windows.Forms.GroupBox();
            this.Logo = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.groupBoxLogin = new System.Windows.Forms.GroupBox();
            this.btnForgetPassword = new System.Windows.Forms.Button();
            this.radiouser = new System.Windows.Forms.RadioButton();
            this.radioAdmin = new System.Windows.Forms.RadioButton();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.btnLogin2 = new System.Windows.Forms.Button();
            this.btnAddCar = new System.Windows.Forms.Button();
            this.groupBoxAddCar = new System.Windows.Forms.GroupBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.btnRemoveCar = new System.Windows.Forms.Button();
            this.btnAddToList = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.cmbModel = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbEnginerPow = new System.Windows.Forms.ComboBox();
            this.cmbFuel = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbMarka = new System.Windows.Forms.ComboBox();
            this.btnBuyCar = new System.Windows.Forms.Button();
            this.gbSelledList = new System.Windows.Forms.GroupBox();
            this.vtnCloseSelledcar = new System.Windows.Forms.Button();
            this.dgvSelledCar = new System.Windows.Forms.DataGridView();
            this.btnLookAtSelledCar = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lbStatus = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lbUserNameBy = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarList)).BeginInit();
            this.groupBoxForList.SuspendLayout();
            this.groupBoxLogin.SuspendLayout();
            this.groupBoxAddCar.SuspendLayout();
            this.gbSelledList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelledCar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCarList
            // 
            this.dgvCarList.AllowUserToAddRows = false;
            this.dgvCarList.AllowUserToDeleteRows = false;
            this.dgvCarList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCarList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCarList.Location = new System.Drawing.Point(3, 18);
            this.dgvCarList.Name = "dgvCarList";
            this.dgvCarList.ReadOnly = true;
            this.dgvCarList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCarList.Size = new System.Drawing.Size(1376, 255);
            this.dgvCarList.TabIndex = 0;
            this.dgvCarList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCarList_CellClick);
            // 
            // groupBoxForList
            // 
            this.groupBoxForList.Controls.Add(this.dgvCarList);
            this.groupBoxForList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxForList.Location = new System.Drawing.Point(21, 413);
            this.groupBoxForList.Name = "groupBoxForList";
            this.groupBoxForList.Size = new System.Drawing.Size(1382, 276);
            this.groupBoxForList.TabIndex = 1;
            this.groupBoxForList.TabStop = false;
            this.groupBoxForList.Text = "List OF Cars";
            // 
            // Logo
            // 
            this.Logo.AutoSize = true;
            this.Logo.Font = new System.Drawing.Font("Times New Roman", 35F, System.Drawing.FontStyle.Bold);
            this.Logo.Location = new System.Drawing.Point(12, 9);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(224, 53);
            this.Logo.TabIndex = 2;
            this.Logo.Text = "Turbo.AZ";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(1226, 35);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(96, 33);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Daxil OL";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // groupBoxLogin
            // 
            this.groupBoxLogin.Controls.Add(this.btnForgetPassword);
            this.groupBoxLogin.Controls.Add(this.radiouser);
            this.groupBoxLogin.Controls.Add(this.radioAdmin);
            this.groupBoxLogin.Controls.Add(this.txtPassword);
            this.groupBoxLogin.Controls.Add(this.txtUserName);
            this.groupBoxLogin.Controls.Add(this.lblPassword);
            this.groupBoxLogin.Controls.Add(this.lblUserName);
            this.groupBoxLogin.Controls.Add(this.btnLogin2);
            this.groupBoxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBoxLogin.Location = new System.Drawing.Point(1087, 74);
            this.groupBoxLogin.Name = "groupBoxLogin";
            this.groupBoxLogin.Size = new System.Drawing.Size(251, 138);
            this.groupBoxLogin.TabIndex = 4;
            this.groupBoxLogin.TabStop = false;
            this.groupBoxLogin.Text = "Log In";
            this.groupBoxLogin.Visible = false;
            // 
            // btnForgetPassword
            // 
            this.btnForgetPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForgetPassword.Location = new System.Drawing.Point(129, 107);
            this.btnForgetPassword.Name = "btnForgetPassword";
            this.btnForgetPassword.Size = new System.Drawing.Size(51, 25);
            this.btnForgetPassword.TabIndex = 12;
            this.btnForgetPassword.Text = "Forget ";
            this.btnForgetPassword.UseVisualStyleBackColor = true;
            this.btnForgetPassword.Click += new System.EventHandler(this.btnForgetPassword_Click);
            // 
            // radiouser
            // 
            this.radiouser.AutoSize = true;
            this.radiouser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radiouser.Location = new System.Drawing.Point(67, 108);
            this.radiouser.Name = "radiouser";
            this.radiouser.Size = new System.Drawing.Size(56, 21);
            this.radiouser.TabIndex = 4;
            this.radiouser.TabStop = true;
            this.radiouser.Text = "User";
            this.radiouser.UseVisualStyleBackColor = true;
            // 
            // radioAdmin
            // 
            this.radioAdmin.AutoSize = true;
            this.radioAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioAdmin.Location = new System.Drawing.Point(6, 108);
            this.radioAdmin.Name = "radioAdmin";
            this.radioAdmin.Size = new System.Drawing.Size(65, 21);
            this.radioAdmin.TabIndex = 3;
            this.radioAdmin.TabStop = true;
            this.radioAdmin.Text = "Admin";
            this.radioAdmin.UseVisualStyleBackColor = true;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(114, 76);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(131, 26);
            this.txtPassword.TabIndex = 2;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(114, 44);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(131, 26);
            this.txtUserName.TabIndex = 1;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(22, 82);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(78, 20);
            this.lblPassword.TabIndex = 0;
            this.lblPassword.Text = "Password";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(22, 45);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(85, 20);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "UserName";
            // 
            // btnLogin2
            // 
            this.btnLogin2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin2.Location = new System.Drawing.Point(186, 107);
            this.btnLogin2.Name = "btnLogin2";
            this.btnLogin2.Size = new System.Drawing.Size(62, 25);
            this.btnLogin2.TabIndex = 5;
            this.btnLogin2.Text = "Daxil OL";
            this.btnLogin2.UseVisualStyleBackColor = true;
            this.btnLogin2.Visible = false;
            this.btnLogin2.Click += new System.EventHandler(this.btnLogin2_Click);
            // 
            // btnAddCar
            // 
            this.btnAddCar.Location = new System.Drawing.Point(135, 76);
            this.btnAddCar.Name = "btnAddCar";
            this.btnAddCar.Size = new System.Drawing.Size(113, 31);
            this.btnAddCar.TabIndex = 0;
            this.btnAddCar.Text = "Add or Remove Car";
            this.btnAddCar.UseVisualStyleBackColor = true;
            this.btnAddCar.Visible = false;
            this.btnAddCar.Click += new System.EventHandler(this.btnAddCar_Click);
            // 
            // groupBoxAddCar
            // 
            this.groupBoxAddCar.Controls.Add(this.cmbStatus);
            this.groupBoxAddCar.Controls.Add(this.btnRemoveCar);
            this.groupBoxAddCar.Controls.Add(this.btnAddToList);
            this.groupBoxAddCar.Controls.Add(this.label4);
            this.groupBoxAddCar.Controls.Add(this.label6);
            this.groupBoxAddCar.Controls.Add(this.label3);
            this.groupBoxAddCar.Controls.Add(this.cmbYear);
            this.groupBoxAddCar.Controls.Add(this.cmbModel);
            this.groupBoxAddCar.Controls.Add(this.label2);
            this.groupBoxAddCar.Controls.Add(this.label5);
            this.groupBoxAddCar.Controls.Add(this.cmbEnginerPow);
            this.groupBoxAddCar.Controls.Add(this.cmbFuel);
            this.groupBoxAddCar.Controls.Add(this.label1);
            this.groupBoxAddCar.Controls.Add(this.cmbMarka);
            this.groupBoxAddCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxAddCar.Location = new System.Drawing.Point(266, 12);
            this.groupBoxAddCar.Name = "groupBoxAddCar";
            this.groupBoxAddCar.Size = new System.Drawing.Size(812, 127);
            this.groupBoxAddCar.TabIndex = 6;
            this.groupBoxAddCar.TabStop = false;
            this.groupBoxAddCar.Text = "AddNewCar";
            this.groupBoxAddCar.Visible = false;
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(249, 69);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(98, 24);
            this.cmbStatus.TabIndex = 6;
            this.cmbStatus.Text = "Candition";
            // 
            // btnRemoveCar
            // 
            this.btnRemoveCar.Location = new System.Drawing.Point(388, 72);
            this.btnRemoveCar.Name = "btnRemoveCar";
            this.btnRemoveCar.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveCar.TabIndex = 0;
            this.btnRemoveCar.Text = "Remove";
            this.btnRemoveCar.UseVisualStyleBackColor = true;
            this.btnRemoveCar.Click += new System.EventHandler(this.btnRemoveCar_Click_1);
            // 
            // btnAddToList
            // 
            this.btnAddToList.Location = new System.Drawing.Point(478, 72);
            this.btnAddToList.Name = "btnAddToList";
            this.btnAddToList.Size = new System.Drawing.Size(75, 23);
            this.btnAddToList.TabIndex = 0;
            this.btnAddToList.Text = "Add";
            this.btnAddToList.UseVisualStyleBackColor = true;
            this.btnAddToList.Click += new System.EventHandler(this.btnAddToList_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(391, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Year";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(192, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(192, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Model";
            // 
            // cmbYear
            // 
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Location = new System.Drawing.Point(448, 29);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(121, 24);
            this.cmbYear.TabIndex = 3;
            this.cmbYear.Text = "Year";
            // 
            // cmbModel
            // 
            this.cmbModel.FormattingEnabled = true;
            this.cmbModel.Location = new System.Drawing.Point(249, 29);
            this.cmbModel.Name = "cmbModel";
            this.cmbModel.Size = new System.Drawing.Size(121, 24);
            this.cmbModel.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(593, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enginer";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Fuel";
            // 
            // cmbEnginerPow
            // 
            this.cmbEnginerPow.FormattingEnabled = true;
            this.cmbEnginerPow.Location = new System.Drawing.Point(660, 29);
            this.cmbEnginerPow.Name = "cmbEnginerPow";
            this.cmbEnginerPow.Size = new System.Drawing.Size(130, 24);
            this.cmbEnginerPow.TabIndex = 4;
            this.cmbEnginerPow.Text = "Select Enginer";
            // 
            // cmbFuel
            // 
            this.cmbFuel.FormattingEnabled = true;
            this.cmbFuel.Location = new System.Drawing.Point(63, 68);
            this.cmbFuel.Name = "cmbFuel";
            this.cmbFuel.Size = new System.Drawing.Size(121, 24);
            this.cmbFuel.TabIndex = 5;
            this.cmbFuel.Text = "Select Fuel";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Marka";
            // 
            // cmbMarka
            // 
            this.cmbMarka.FormattingEnabled = true;
            this.cmbMarka.Location = new System.Drawing.Point(63, 29);
            this.cmbMarka.Name = "cmbMarka";
            this.cmbMarka.Size = new System.Drawing.Size(121, 24);
            this.cmbMarka.TabIndex = 1;
            this.cmbMarka.Text = "All Markas";
            this.cmbMarka.SelectedIndexChanged += new System.EventHandler(this.cmbMarka_SelectedIndexChanged);
            // 
            // btnBuyCar
            // 
            this.btnBuyCar.Location = new System.Drawing.Point(1226, 356);
            this.btnBuyCar.Name = "btnBuyCar";
            this.btnBuyCar.Size = new System.Drawing.Size(125, 31);
            this.btnBuyCar.TabIndex = 0;
            this.btnBuyCar.Text = "Buy Car";
            this.btnBuyCar.UseVisualStyleBackColor = true;
            this.btnBuyCar.Visible = false;
            this.btnBuyCar.Click += new System.EventHandler(this.btnBuyCar_Click);
            // 
            // gbSelledList
            // 
            this.gbSelledList.Controls.Add(this.vtnCloseSelledcar);
            this.gbSelledList.Controls.Add(this.dgvSelledCar);
            this.gbSelledList.Location = new System.Drawing.Point(10, 138);
            this.gbSelledList.Name = "gbSelledList";
            this.gbSelledList.Size = new System.Drawing.Size(1077, 249);
            this.gbSelledList.TabIndex = 8;
            this.gbSelledList.TabStop = false;
            this.gbSelledList.Text = "SelledCar";
            this.gbSelledList.Visible = false;
            // 
            // vtnCloseSelledcar
            // 
            this.vtnCloseSelledcar.Location = new System.Drawing.Point(980, 222);
            this.vtnCloseSelledcar.Name = "vtnCloseSelledcar";
            this.vtnCloseSelledcar.Size = new System.Drawing.Size(91, 23);
            this.vtnCloseSelledcar.TabIndex = 0;
            this.vtnCloseSelledcar.Text = "Close";
            this.vtnCloseSelledcar.UseVisualStyleBackColor = true;
            this.vtnCloseSelledcar.Click += new System.EventHandler(this.vtnCloseSelledcar_Click);
            // 
            // dgvSelledCar
            // 
            this.dgvSelledCar.AllowUserToAddRows = false;
            this.dgvSelledCar.AllowUserToDeleteRows = false;
            this.dgvSelledCar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSelledCar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelledCar.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvSelledCar.Location = new System.Drawing.Point(3, 16);
            this.dgvSelledCar.Name = "dgvSelledCar";
            this.dgvSelledCar.ReadOnly = true;
            this.dgvSelledCar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSelledCar.Size = new System.Drawing.Size(1071, 204);
            this.dgvSelledCar.TabIndex = 0;
            // 
            // btnLookAtSelledCar
            // 
            this.btnLookAtSelledCar.Location = new System.Drawing.Point(16, 76);
            this.btnLookAtSelledCar.Name = "btnLookAtSelledCar";
            this.btnLookAtSelledCar.Size = new System.Drawing.Size(113, 31);
            this.btnLookAtSelledCar.TabIndex = 0;
            this.btnLookAtSelledCar.Text = "Look At Selled List";
            this.btnLookAtSelledCar.UseVisualStyleBackColor = true;
            this.btnLookAtSelledCar.Visible = false;
            this.btnLookAtSelledCar.Click += new System.EventHandler(this.btnLookAtSelledCar_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(1124, 35);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(96, 33);
            this.btnRegister.TabIndex = 9;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(1084, 12);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(37, 13);
            this.lbStatus.TabIndex = 10;
            this.lbStatus.Text = "Active";
            this.lbStatus.Visible = false;
            this.lbStatus.Click += new System.EventHandler(this.lbStatus_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(1226, 34);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(96, 34);
            this.btnLogout.TabIndex = 11;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Visible = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lbUserNameBy
            // 
            this.lbUserNameBy.AutoSize = true;
            this.lbUserNameBy.Location = new System.Drawing.Point(1127, 12);
            this.lbUserNameBy.Name = "lbUserNameBy";
            this.lbUserNameBy.Size = new System.Drawing.Size(0, 13);
            this.lbUserNameBy.TabIndex = 10;
            this.lbUserNameBy.Visible = false;
            this.lbUserNameBy.Click += new System.EventHandler(this.lbStatus_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1437, 809);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lbUserNameBy);
            this.Controls.Add(this.groupBoxForList);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.gbSelledList);
            this.Controls.Add(this.btnBuyCar);
            this.Controls.Add(this.groupBoxAddCar);
            this.Controls.Add(this.btnLookAtSelledCar);
            this.Controls.Add(this.btnAddCar);
            this.Controls.Add(this.groupBoxLogin);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.Logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cars";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarList)).EndInit();
            this.groupBoxForList.ResumeLayout(false);
            this.groupBoxLogin.ResumeLayout(false);
            this.groupBoxLogin.PerformLayout();
            this.groupBoxAddCar.ResumeLayout(false);
            this.groupBoxAddCar.PerformLayout();
            this.gbSelledList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelledCar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCarList;
        private System.Windows.Forms.GroupBox groupBoxForList;
        private System.Windows.Forms.Label Logo;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.GroupBox groupBoxLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Button btnLogin2;
        private System.Windows.Forms.RadioButton radiouser;
        private System.Windows.Forms.RadioButton radioAdmin;
        private System.Windows.Forms.Button btnAddCar;
        private System.Windows.Forms.GroupBox groupBoxAddCar;
        private System.Windows.Forms.ComboBox cmbMarka;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.ComboBox cmbModel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbEnginerPow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbFuel;
        private System.Windows.Forms.Button btnAddToList;
        private System.Windows.Forms.Button btnRemoveCar;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Button btnBuyCar;
        private System.Windows.Forms.GroupBox gbSelledList;
        private System.Windows.Forms.DataGridView dgvSelledCar;
        private System.Windows.Forms.Button btnLookAtSelledCar;
        private System.Windows.Forms.Button vtnCloseSelledcar;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lbUserNameBy;
        private System.Windows.Forms.Button btnForgetPassword;
    }
}

