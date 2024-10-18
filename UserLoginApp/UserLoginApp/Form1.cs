using UserLoginApp.Models;

namespace UserLoginApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (var context = new AppDbContext())
            {
                var user = context.Users.FirstOrDefault(u => u.UserName == txtUserName.Text && u.Password == txtPassword.Text);
                if (user != null)
                {
                    MessageBox.Show("Giriþ Baþarýlý");
                    LoadUsers loadUsers = new LoadUsers();
                    loadUsers.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Kullanici Bulnumadý ,lütfen kayýt olun");
                }
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.ShowDialog();

        }
    }
}
