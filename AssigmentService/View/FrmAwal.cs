using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AssigmentService.View;

using AssigmentService.Controller;
using AssigmentService.Model.Entity;

namespace AssigmentService.View
{
    public partial class FrmAwal : Form
    {
        private List<User> listOfUser = new List<User>();
        private UserController controller;
        private User akun;

        public FrmAwal()
        {
            InitializeComponent();
            controller = new UserController();
        }

        private void FrmAwal_Load(object sender, EventArgs e)
        {
            pgSignUp.Hide();
            gbCreate.Visible = false;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you Sure to Exit", "Exit", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            controller = new UserController();
            User akun = new User();

            akun.user_name = pgLogin.txtUserName.Text;
            akun.password = pgLogin.txtPassword.Text;

            bool isValidUser = controller.IsValidUser(pgLogin.txtUserName.Text, pgLogin.txtPassword.Text);
            if (isValidUser)
            {
                this.DialogResult = DialogResult.OK;
                listOfUser.Add(akun);
                this.Close();

                
            }
        }

        private void lblCreate_Click(object sender, EventArgs e)
        {
            pgSignUp.Show();
            gbCreate.Visible = true;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            akun = new User();
          
            akun.Nama = pgSignUp.txtName.Text;
            akun.user_name = pgSignUp.txtUserName.Text;
            akun.Email = pgSignUp.txtEmail.Text;
            akun.password = pgSignUp.txtPassword.Text;
            akun.confirmPassword = pgSignUp.txtConfirmPassword.Text;

            int result = 0;

            result = controller.Create(akun);

            if (result > 0)
            {
                    listOfUser.Add(akun);
                    pgSignUp.Hide();
                    gbCreate.Visible = false;
            }
            else
            {
                pgSignUp.txtPassword.Clear();
                pgSignUp.txtConfirmPassword.Clear();
            }
        }

        
    }
}
