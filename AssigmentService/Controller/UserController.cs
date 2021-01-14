using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using AssigmentService.Model.Repository;
using AssigmentService.Model.Entity;
using AssigmentService.Model.Context;
using AssigmentService.View;

namespace AssigmentService.Controller
{
    public class UserController
    {
        private UserRepository _repository;

        public bool IsValidUser(string userName, string password)
        {

            if (string.IsNullOrEmpty(userName))
            {
                MessageBox.Show("User name harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Password harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            bool isValidUser = false;


            using (DbContext context = new DbContext())
            {

                _repository = new UserRepository(context);


                isValidUser = _repository.IsValidUser(userName, password);
            }

            if (!isValidUser)
            {
                MessageBox.Show("User name atau password salah !!!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return false;
            }

            return true;
        }

        public int Create(User akun)
        {
            List<User> listOfUser = new List<User>();
            int result = 0;


            if (string.IsNullOrEmpty(akun.user_name))
            {
                MessageBox.Show("Username Harus Diisi !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(akun.Nama))
            {
                MessageBox.Show("Nama Harus Diisi !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(akun.Email))
            {
                MessageBox.Show("Email Harus Diisi !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(akun.password))
            {
                MessageBox.Show("Password Harus Diisi !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (akun.password != akun.confirmPassword)
            {
                MessageBox.Show("Password Tidak Cocok !\nHarap Ulangi", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            listOfUser = CheckUser(akun.user_name);

            foreach (var validasi in listOfUser)
            {
                if (!string.IsNullOrEmpty(validasi.user_name))
                {
                    MessageBox.Show("Username Sudah Digunakan !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return 0;
                }
            }

            using (DbContext context = new DbContext())
            {
                _repository = new UserRepository(context);

                result = _repository.Create(akun);
            }

            if (result > 0)
            {
                MessageBox.Show("Selamat, Akun Berhasil Dibuat !\nKlik OK untuk kembali ke Menu Login", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Akun Gagal Dibuat !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return result;
        }

        public List<User> CheckUser(string akun)
        {
            List<User> listOfUser = new List<User>();

            using (DbContext context = new DbContext())
            {
                _repository = new UserRepository(context);
                listOfUser = _repository.CheckUser(akun);
            }

            return listOfUser;
        }

        public List<User> ReadAll(string akun)
        {
            List<User> listOfUser = new List<User>();

            using (DbContext context = new DbContext())
            {
                _repository = new UserRepository(context);

                listOfUser = _repository.ReadAll(akun);
            }
            return listOfUser;
        }
    }
}
