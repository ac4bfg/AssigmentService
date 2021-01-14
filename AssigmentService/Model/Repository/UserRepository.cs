using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using AssigmentService.Model.Entity;
using AssigmentService.Model.Context;

namespace AssigmentService.Model.Repository
{
    public class UserRepository
    {

        private OleDbConnection _conn;


        public UserRepository(DbContext context)
        {
            _conn = context.Conn;
        }

        public bool IsValidUser(string userName, string password)
        {
            bool result = false;

            string sql = @"select count(*) as row_count
                           from user_aplikasi
                           where user_name = @userName and password = @password";


            using (OleDbCommand cmd = new OleDbCommand(sql, _conn))
            {

                cmd.Parameters.AddWithValue("@userName", userName);
                cmd.Parameters.AddWithValue("@password", password);


                using (OleDbDataReader dtr = cmd.ExecuteReader())
                {

                    if (dtr.Read())
                    {
                        result = Convert.ToInt32(dtr["row_count"]) > 0;
                    }
                }
            }

            return result;
        }

        public int Create(User akun)
        {
            int result = 0;

            string sql = @"INSERT INTO user_aplikasi 
                            VALUES (@userName, @Nama, NULL, NULL, @Email, @password)";

            using (OleDbCommand cmd = new OleDbCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@userName", akun.user_name);

                cmd.Parameters.AddWithValue("@Nama", akun.Nama);
                cmd.Parameters.AddWithValue("@Email", akun.Email);
                cmd.Parameters.AddWithValue("@password", akun.password);

                try
                {
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Create error: {0}", ex.Message);
                }
            }
            return result;

        }

        public List<User> CheckUser(string akun)
        {
            List<User> listOfUser = new List<User>();
            
            try
            {
                string sql = @"select user_name from user_aplikasi
                            where user_name = @userName";

                
                using (OleDbCommand cmd = new OleDbCommand(sql, _conn))
                {
                    cmd.Parameters.AddWithValue("@userName", akun);
                    using (OleDbDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            var usr = new User();
                            
                            usr.user_name = dtr["user_name"].ToString();

                            listOfUser.Add(usr);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("ReadAll error: {0}", ex.Message);
            }

            return listOfUser;
        }

        public List<User> ReadAll(string akun)
        {
            List<User> listOfUser = new List<User>();

            try
            {
                string sql = @"select * from user_aplikasi 
                               where user_name = @userName";

                using (OleDbCommand cmd = new OleDbCommand(sql, _conn))
                {
                    MessageBox.Show("" + akun);
                    cmd.Parameters.AddWithValue("@userName", akun);
                    using (OleDbDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            User usr = new User();

                            MessageBox.Show("" + usr.user_name);
                            usr.user_name = dtr["user_name"].ToString();
/*                            usr.Nama = dtr["Nama"].ToString();
                            usr.Email = dtr["Email"].ToString();
                            usr.Alamat = dtr["Alamat"].ToString();
                            usr.Telp = dtr["Telp"].ToString();
                            usr.password = dtr["password"].ToString();*/

                            listOfUser.Add(usr);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("ReadAll error: {0}", ex.Message);
            }
            return listOfUser;
        }
    }
}
