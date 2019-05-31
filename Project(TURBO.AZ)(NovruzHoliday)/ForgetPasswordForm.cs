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

namespace Project_TURBO.AZ__NovruzHoliday_
{
    public partial class ForgetPasswordForm : Form
    {
        private readonly TurboAzEntities db;
        public ForgetPasswordForm()
        {
            db = new TurboAzEntities();
            InitializeComponent();
        }

        UserPanel findEmail;
        private void ForgetPasswordForm_Load(object sender, EventArgs e)
        {

        }

        private void btnShowPassword_Click(object sender, EventArgs e)
        {
            string enteredEmail = txtWriteEmail.Text.Trim().ToLower();



            findEmail = db.UserPanels.Where(w => w.E_mail == enteredEmail).FirstOrDefault();
            if (findEmail == null)
            {
                MessageBox.Show("This email doesn't exist");
            }
            else
            {
                MessageBox.Show("UserName: "+findEmail.FirstName+ "\n" + "Password: " +findEmail.ForgetingPassword,"UserName and Password");

            }
        }

       
    }
}
