namespace UserLoginApp
{
    partial class RegisterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtFullName = new TextBox();
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            txtPasswordConfirm = new TextBox();
            txtTcNo = new TextBox();
            dtpBirthDate = new DateTimePicker();
            cmbFavoriteTeam = new ComboBox();
            txtAge = new TextBox();
            txtProfession = new TextBox();
            btnRegister = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(83, 140);
            txtFullName.Name = "txtFullName";
            txtFullName.PlaceholderText = "Ad Soyad ";
            txtFullName.Size = new Size(196, 27);
            txtFullName.TabIndex = 0;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(83, 192);
            txtUserName.Name = "txtUserName";
            txtUserName.PlaceholderText = "Kullanıcı Adı ";
            txtUserName.Size = new Size(196, 27);
            txtUserName.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(83, 244);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Parola";
            txtPassword.Size = new Size(196, 27);
            txtPassword.TabIndex = 2;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // txtPasswordConfirm
            // 
            txtPasswordConfirm.Location = new Point(83, 296);
            txtPasswordConfirm.Name = "txtPasswordConfirm";
            txtPasswordConfirm.PasswordChar = '*';
            txtPasswordConfirm.PlaceholderText = "Parola";
            txtPasswordConfirm.Size = new Size(196, 27);
            txtPasswordConfirm.TabIndex = 3;
            // 
            // txtTcNo
            // 
            txtTcNo.Location = new Point(83, 354);
            txtTcNo.Name = "txtTcNo";
            txtTcNo.PlaceholderText = "Tc Kimlik Numarası";
            txtTcNo.Size = new Size(196, 27);
            txtTcNo.TabIndex = 4;
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.Location = new Point(354, 138);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(250, 27);
            dtpBirthDate.TabIndex = 5;
            // 
            // cmbFavoriteTeam
            // 
            cmbFavoriteTeam.DisplayMember = "Trabzonspor";
            cmbFavoriteTeam.FormattingEnabled = true;
            cmbFavoriteTeam.Items.AddRange(new object[] { "Trabzonspor", "Galatasaray", "Bursaspor", "Beşiktaş" });
            cmbFavoriteTeam.Location = new Point(354, 192);
            cmbFavoriteTeam.Name = "cmbFavoriteTeam";
            cmbFavoriteTeam.Size = new Size(250, 28);
            cmbFavoriteTeam.TabIndex = 6;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(354, 244);
            txtAge.Name = "txtAge";
            txtAge.PlaceholderText = "Yaş";
            txtAge.Size = new Size(250, 27);
            txtAge.TabIndex = 7;
            // 
            // txtProfession
            // 
            txtProfession.Location = new Point(354, 296);
            txtProfession.Name = "txtProfession";
            txtProfession.PlaceholderText = "Meslek";
            txtProfession.Size = new Size(250, 27);
            txtProfession.TabIndex = 8;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(479, 354);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(125, 29);
            btnRegister.TabIndex = 9;
            btnRegister.Text = "Kayıt Ol";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(83, 72);
            label1.Name = "label1";
            label1.Size = new Size(99, 31);
            label1.TabIndex = 10;
            label1.Text = "Kayıt Ol";
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnRegister);
            Controls.Add(txtProfession);
            Controls.Add(txtAge);
            Controls.Add(cmbFavoriteTeam);
            Controls.Add(dtpBirthDate);
            Controls.Add(txtTcNo);
            Controls.Add(txtPasswordConfirm);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(txtFullName);
            Name = "RegisterForm";
            Text = "RegisterForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFullName;
        private TextBox txtUserName;
        private TextBox txtPassword;
        private TextBox txtPasswordConfirm;
        private TextBox txtTcNo;
        private DateTimePicker dtpBirthDate;
        private ComboBox cmbFavoriteTeam;
        private TextBox txtAge;
        private TextBox txtProfession;
        private Button btnRegister;
        private Label label1;
    }
}