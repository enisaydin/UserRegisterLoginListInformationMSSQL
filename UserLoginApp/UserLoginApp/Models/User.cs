using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLoginApp.Models
{
    public class User
    {

        public int Id { get; set; }
        [DisplayName("İsim")]
        public string FulName { get; set; }
        [DisplayName("Kullanici Adım")]
        public string UserName { get; set; }
        [DisplayName("Parola")]
        public string Password { get; set; }
        [DisplayName("Tc kimlik")]
        public string TcNo { get; set; }
        [DisplayName("Doğum Tarihi")]
        public DateTime BirthDate { get; set; }
        [DisplayName("Tuttuğu takım")]
        public string FavoriteTeam { get; set; }
        [DisplayName("Yaş")]
        public int Age  { get; set; }
        [DisplayName("Meslek")]
        public string Profession { get; set; }


    }
}
