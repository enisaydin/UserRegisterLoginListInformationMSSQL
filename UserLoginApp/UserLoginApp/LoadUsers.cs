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
    public partial class LoadUsers : Form
    {
        public LoadUsers()
        {
            InitializeComponent();
            LoadList();
        }

        
        private void LoadList()
        {
            using (var context = new AppDbContext())
            {
                var users = context.Users.ToList();
                dataGridView1.DataSource = users;

                dataGridView1.Columns["UserName"].Visible = false;
                dataGridView1.Columns["Password"].Visible = false;
            }
        }
    }
}
