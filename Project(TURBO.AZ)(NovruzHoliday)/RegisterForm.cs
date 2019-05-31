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
    public partial class RegisterForm : Form
    {

        private readonly TurboAzEntities db;
        public RegisterForm()
        {
            db = new TurboAzEntities();
            InitializeComponent();
        }

        UserPanel newUserName;

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmitUser_Click(object sender, EventArgs e)
        {
            string FirstName = txtFirstName.Text.Trim().ToLower();
            string Surname = txtSurName.Text.Trim().ToLower();
            string Email = txtNewEmail.Text.Trim().ToLower();
            string NewPassword = txtNewPassword.Text;

            if (String.IsNullOrEmpty(FirstName) || String.IsNullOrEmpty(Surname) || String.IsNullOrEmpty(Email) || String.IsNullOrEmpty(NewPassword))
            {
                MessageBox.Show("Please, Fill all inputs");
            }

            else
            {

            
            UserPanel newUser = new UserPanel
            {
                FirstName = FirstName,
                LastName = Surname,
                E_mail = Email,
                Password = Exception.Exception.HashPassword(NewPassword),
                ForgetingPassword = NewPassword,
            };

            newUserName = db.UserPanels.Where(w => w.FirstName == newUser.FirstName).FirstOrDefault();

            if (newUserName == null)
            {
                MessageBox.Show("You have registered", "Welcome");
                db.UserPanels.Add(newUser);
                db.SaveChanges();
            }

            else
            {
                MessageBox.Show("This UserName existes");
            }
            }


        }
    }
}
