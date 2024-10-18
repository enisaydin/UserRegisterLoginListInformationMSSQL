using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserLoginApp.Models;

namespace UserLoginApp
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            
            if (txtPassword.Text != txtPasswordConfirm.Text)
            {
                MessageBox.Show("Parolalar eşleşmiyor!");
                return;
            }

            using (var context = new AppDbContext())
            {
                
                var existingUser = context.Users.FirstOrDefault(u => u.UserName == txtUserName.Text);

                if (existingUser != null)
                {
                    MessageBox.Show("Bu kullanıcı adı zaten alınmış, lütfen başka bir kullanıcı adı deneyin.");
                    return;
                }

                
                var user = new User
                {
                    FulName = txtFullName.Text,
                    UserName = txtUserName.Text,
                    Password = txtPassword.Text,
                    TcNo = txtTcNo.Text,
                    BirthDate = dtpBirthDate.Value,
                    FavoriteTeam = cmbFavoriteTeam.SelectedItem.ToString(),
                    Age = int.Parse(txtAge.Text),
                    Profession = txtProfession.Text
                };

                
                context.Users.Add(user);
                context.SaveChanges();
            }

            MessageBox.Show("Kayıt başarılı, şimdi giriş yapabilirsiniz!");
            this.Close(); // Kayıt sonrası formu kapat

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
