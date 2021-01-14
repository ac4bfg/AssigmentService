using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssigmentService.Model.Entity
{
    public class User
    {
        public string user_name { get; set; }
        public string Nama { get; set; }
        public string Alamat { get; set; }
        public string Telp { get; set; }
        public string Email { get; set; }
        public string password { get; set; }
        public string confirmPassword { get; set; }
    }
}
