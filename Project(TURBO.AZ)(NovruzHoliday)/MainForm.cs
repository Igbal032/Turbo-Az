using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_TURBO.AZ__NovruzHoliday_.Models;
using Project_TURBO.AZ__NovruzHoliday_.Exception;

namespace Project_TURBO.AZ__NovruzHoliday_
{
    public partial class MainForm : Form
    {
        private readonly TurboAzEntities db;
        public MainForm()
        {
            db = new TurboAzEntities();
            InitializeComponent();
        }

        Car selectedCar;
        SelledCar selectedSelledCar;
        AdminPanel myAdmin;
        UserPanel myUserName;

        bool whoOnline = false;
        public void updateInformation()
        {
            dgvCarList.DataSource = db.Cars.Select(c => new
            {
                c.ID,
                c.Model.Marka.MarkaName,
                c.Model.ModelName,
                c.Car_Year.Year,
                c.Status.StatusName,
                c.EnginerPower.EPowName,
                c.Fuel.FuelName,

            }).ToList();
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            updateInformation();
            AdminPanel admin = db.AdminPanels.FirstOrDefault();
            //txtPassword.Text = Exception.Exception.HashPassword(admin.Password);
            //txtUserName.Text = admin.AdminName;

        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            groupBoxLogin.Visible = Enabled;
            btnLogin2.Visible = Enabled;
            btnLogin.Hide();
        }

        private void btnLogin2_Click(object sender, EventArgs e)
        {


            string enteredName = txtUserName.Text.Trim().ToLower();
            string enteredPassword = txtPassword.Text.Trim();
            bool asAdmin = radioAdmin.Checked;
            bool asUser = radiouser.Checked;
            //myUserPassword = db.UserPanels.Where(w => w.Password == enteredPassword).FirstOrDefault();

            if (String.IsNullOrEmpty(enteredName) || String.IsNullOrEmpty(enteredPassword))
            {
                MessageBox.Show("Please, Fill all inputs!!");
            }

            else
            {


                UserPanel user = new UserPanel();

                if (asAdmin)
                {
                    myAdmin = db.AdminPanels.Where(w => w.AdminName == enteredName).FirstOrDefault();

                    if (myAdmin == null)
                    {
                        MessageBox.Show("Admin doesn't exist");
                    }

                    else
                    {


                        if (String.IsNullOrEmpty(enteredName) || String.IsNullOrEmpty(enteredPassword))
                        {
                            MessageBox.Show("Please, Fill All Inputs");
                        }


                        if (Exception.Exception.CheckPassword(enteredPassword, myAdmin.Password) && (enteredName == myAdmin.AdminName)) //There is a problem 
                        {
                            MessageBox.Show("Welcome");
                            btnAddCar.Visible = Enabled;
                            btnLogout.Visible = Enabled;
                            btnLookAtSelledCar.Visible = Enabled;
                            groupBoxLogin.Hide();
                            btnLogin2.Hide();
                            btnBuyCar.Hide();
                            whoOnline = true;
                            lbStatus.Visible = Enabled;
                            lbUserNameBy.Visible = Enabled;
                            lbUserNameBy.Text = txtUserName.Text;
                            btnRegister.Hide();

                        }


                        else
                            MessageBox.Show("Password or Username is False");
                    }
                }

                if (asUser)
                {
                    myUserName = db.UserPanels.Where(w => w.FirstName == enteredName).FirstOrDefault();


                    if (myUserName == null)
                    {
                        MessageBox.Show("User doesn't exist");
                    }

                    else
                    {


                        if (String.IsNullOrEmpty(enteredName) || String.IsNullOrEmpty(enteredPassword))
                        {
                            MessageBox.Show("Please, Fill All Inputs");
                        }
                        if (Exception.Exception.CheckPassword(enteredPassword, myUserName.Password) && (enteredName == myUserName.FirstName)) //There is a problem 
                        {
                            //MessageBox.Show("Welcome");
                            //btnLogout.Visible = Enabled;
                            //btnBuyCar.Visible = Enabled;
                            //btnLookAtSelledCar.Hide();
                            //groupBoxLogin.Hide();
                            //btnLogin2.Hide();
                            //gbSelledList.Hide();
                            //groupBoxAddCar.Hide();
                            //lbStatus.Visible = Enabled;
                            //btnRegister.Hide();
                            //lbUserNameBy.Visible = Enabled;
                            //lbUserNameBy.Text = "" + txtUserName.Text;

                            MessageBox.Show("Welcome");
                            btnAddCar.Visible = Enabled;
                            btnLogout.Visible = Enabled;
                            btnLookAtSelledCar.Visible = Enabled;
                            groupBoxLogin.Hide();
                            btnLogin2.Hide();
                            btnBuyCar.Hide();
                            whoOnline = true;
                            lbStatus.Visible = Enabled;
                            lbUserNameBy.Visible = Enabled;
                            lbUserNameBy.Text = txtUserName.Text;
                            btnRegister.Hide();
                        }


                        else
                            MessageBox.Show("Password or Username is False");
                    }
                }
            }
        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            groupBoxAddCar.Visible = Enabled;
            btnAddCar.Hide();

            cmbMarka.DataSource = db.Markas.Select(m => new ComboItem
            {
                Text = m.MarkaName,
                Value = m.ID,
            }).ToList();

            cmbFuel.DataSource = db.Fuels.Select(f => new ComboItem
            {
                Text = f.FuelName,
                Value = f.ID,
            }).ToList();

            cmbYear.DataSource = db.Car_Year.Select(y => new ComboItem
            {
                Text = y.Year.ToString(),
                Value = y.ID,
            }).ToList();

            cmbEnginerPow.DataSource = db.EnginerPowers.Select(p => new ComboItem
            {
                Text = (p.EPowName + " sm3").ToString(),
                Value = p.ID,
            }).ToList();

            cmbStatus.DataSource = db.Status.Select(S => new ComboItem
            {
                Value = S.ID,
                Text = S.StatusName.ToString(),
            }).ToList();

        }


        private void cmbMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboItem selectededMarka = cmbMarka.SelectedItem as ComboItem;
            cmbModel.DataSource = db.Models.Where(ml => ml.MarkaID == selectededMarka.Value).Select(ml => new ComboItem
            {
                Value = ml.ID,
                Text = ml.ModelName,
            }).Distinct().ToList();
        }

        private void dgvCarList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)dgvCarList.Rows[e.RowIndex].Cells[0].Value;
            selectedCar = db.Cars.Where(c => c.ID == id).FirstOrDefault();
        }

        private void dgvSelledCar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)dgvSelledCar.Rows[e.RowIndex].Cells[0].Value;
            selectedSelledCar = db.SelledCars.Where(s => s.ID == id).FirstOrDefault();
        }

       
        private void btnAddToList_Click(object sender, EventArgs e)
        {
            string newMarka = cmbMarka.SelectedItem.ToString();
            ComboItem newModel = cmbModel.SelectedItem as ComboItem;
            ComboItem newYear = cmbYear.SelectedItem as ComboItem;
            ComboItem newEngPow = cmbEnginerPow.SelectedItem as ComboItem;
            ComboItem newFuel = cmbFuel.SelectedItem as ComboItem;
            ComboItem newStatus = cmbStatus.SelectedItem as ComboItem;



            Car newCar = new Car
            {
                ModelID = newModel.Value,
                YearID = newYear.Value,
                EPowID = newEngPow.Value,
                FuelID = newFuel.Value,
                StatusID = newStatus.Value,

            };

            db.Cars.Add(newCar);
            db.SaveChanges();
            updateInformation();


        }

        public void UpdateSelled()
        {

            dgvSelledCar.DataSource = db.SelledCars.Select(se => new
            {
                se.ID,
                se.Model.Marka.MarkaName,
                se.Model.ModelName,
                se.Car_Year.Year,
                se.Fuel.FuelName,
                se.EnginerPower.EPowName,
                se.Status.StatusName,
                se.By,

            }).ToList();
        }

        private void btnLookAtSelledCar_Click(object sender, EventArgs e)
        {
            gbSelledList.Visible = Enabled;
            btnLookAtSelledCar.Hide();
            UpdateSelled();
        }

        private void btnBuyCar_Click(object sender, EventArgs e)
        {

            if (selectedCar == null)
            {
                MessageBox.Show("You should select the car");
            }
            else
            {



                var confirmResult = MessageBox.Show("Are you sure to order this Car ??",
                                        "Confirm Order!!", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    SelledCar sell = new SelledCar
                    {
                        ID = selectedCar.ID,
                        ModelIDs = selectedCar.ModelID,
                        YearIDs = selectedCar.YearID,
                        FuelIDs = selectedCar.FuelID,
                        EpowIDs = selectedCar.EPowID,
                        StatusIDs = selectedCar.StatusID,
                        By = lbUserNameBy.Text,

                    };


                    db.SelledCars.Add(sell);
                    db.SaveChanges();
                    UpdateSelled();
                }
                else
                {
                    MessageBox.Show("You did't order any car");
                }
            }
        }


        private void btnCloseSelledcar_Click(object sender, EventArgs e)
        {
            gbSelledList.Hide();
            btnLookAtSelledCar.Show();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            btnLogin.Show();
            btnLogout.Hide();
            btnBuyCar.Hide();
            btnAddCar.Hide();
            groupBoxAddCar.Hide();
            btnLookAtSelledCar.Hide();
            gbSelledList.Hide();
            lbStatus.Hide();
            lbUserNameBy.Hide();
            btnRegister.Show();
            whoOnline = false;
        }

        private void lbStatus_Click(object sender, EventArgs e)
        {

        }

        private void vtnCloseSelledcar_Click(object sender, EventArgs e)
        {
            gbSelledList.Hide();
            btnLookAtSelledCar.Show();
        }

        private void btnForgetPassword_Click(object sender, EventArgs e)
        {
            ForgetPasswordForm ForgetPasswordForm = new ForgetPasswordForm();
            ForgetPasswordForm.Show();
        }

        private void btnRemoveCar_Click_1(object sender, EventArgs e)
        {
            if (selectedCar == null)
            {
                MessageBox.Show("You shold select the car");
            }
            else if (db.Cars.FirstOrDefault() == null)
            {
                MessageBox.Show("There are no any cars");

            }
            else if(selectedCar != null)
            {

                var confirmResult = MessageBox.Show("Are you sure to delete this Car ??",
                                             "Confirm Delete!!", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    db.Cars.Remove(selectedCar);
                    db.SaveChanges();
                    updateInformation();
                }
                else
                {
                    MessageBox.Show("You did't delete any car");
                }
            }
        }
    }
}
