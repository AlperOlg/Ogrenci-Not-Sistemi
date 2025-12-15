using OgrenciNotSistemi.formlar;
using StudentChoose;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCrypt;
using BCrypt.Net;
using System.Diagnostics;
namespace OgrenciNotSistemi
{
    public partial class Form1 : BaseForm
    {
        //Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\bin\Debug\Database4.mdb

        string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\bin\\Debug\\Database4.mdb";
       

        public static string userName, password;


        public Form1()
        {
            InitializeComponent();
            btnSizeChanger = btnMaxMin;
            btnBaseClose = btnClose;
            btnBaseMinimize = btnMinimize;
            pnlDraging = panel1;
        }
        
       

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {

            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu Uygulama; öğretmenlerin Not girdiği, Öğrencilere bilgi vermesini sağlayan bir program");
        }
        bool loginPassHide = true;
        private void button6_Click(object sender, EventArgs e)
        {
            UiManager.TogglePasswordVisibility(btnShowHide, txtPass, ref loginPassHide);
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void btnMaxMin_Click(object sender, EventArgs e)
        {
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
        }

        private void lblCreateAcc_Click(object sender, EventArgs e)
        {
            pnlLogin.Visible = false;
            pnlRegister.Visible = true;
        }
        bool registerPassHide = true;
        private void buttonShowHide_Click(object sender, EventArgs e)
        {
            if (UiManager.TogglePasswordVisibility(buttonShowHide, txtCreatePass, ref registerPassHide))
            {
                txtCreateConfirmPass.UseSystemPasswordChar = true;
            }
            else
            {
                txtCreateConfirmPass.UseSystemPasswordChar = false;
            }

        }

        private void label11_Click(object sender, EventArgs e)
        {
            pnlRegister.Visible = false;
            pnlLogin.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataBaseManager dbManager = new DataBaseManager();

            if (rbStudent.Checked)
            {
                if (txtCreateName.Text != "" && txtCreateSurname.Text != "" && txtCreatePass.Text != "" && txtCreatePass.Text == txtCreateConfirmPass.Text)
                {
                    string hashedPassword = BCrypt.Net.BCrypt.HashPassword(txtCreatePass.Text);
                    string studentUsername = dbManager.RegisterStudent(txtCreateName.Text, txtCreateSurname.Text, hashedPassword);
                    if (studentUsername != "")
                    {
                        MessageBox.Show("Başarıyla öğrenci kaydedildi", "başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MessageBox.Show($"KullanıcıAdınız: {studentUsername} bununla giriş yapacaksınız!", "başarılı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        pnlRegister.Visible = false;
                        pnlLogin.Visible = true;
                    }
                    else
                        MessageBox.Show("Hata Oluştu, Öğrenci kaydedilemedi!", "başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    ChangeTxtColors(Color.Gray);
                    MessageBox.Show("Boş bilgi bırakmayın!", "başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (txtCreateName.Text != "" && txtCreateSurname.Text != "" && txtNickName.Text != "" && txtCreatePass.Text != "" && txtCreatePass.Text == txtCreateConfirmPass.Text)
                {
                    string hashedPassword = BCrypt.Net.BCrypt.HashPassword(txtCreatePass.Text);
                    if (dbManager.RegisterTeacher(txtCreateName.Text, txtCreateSurname.Text, txtNickName.Text, hashedPassword))
                    {
                        MessageBox.Show("Başarıyla öğretmen kaydedildi", "başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        pnlRegister.Visible = false;
                        pnlLogin.Visible = true;
                    }
                    else
                        MessageBox.Show("Hata Oluştu, Öğretmen kaydedilemedi!", "başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    ChangeTxtColors(Color.Gray);
                    txtNickName.BackColor = Color.Gray;
                    MessageBox.Show("Boş bilgi bırakmayın!", "başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void ChangeTxtColors(Color color)
        {
            txtCreateName.BackColor = color;
            txtCreatePass.BackColor = color;
            txtCreateSurname.BackColor = color;
            txtCreateConfirmPass.BackColor = color;
        }

        private void rbTeacher_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTeacher.Checked)
            {
                pictureboxHuman.Location = new Point(66, 198);
                lblName.Location = new Point(118, 65);
                txtCreateName.Location = new Point(120, 105);
                lblSurname.Location = new Point(118, 160);
                txtCreateSurname.Location = new Point(120, 200);
                lblNickName.Visible = true;
                txtNickName.Visible = true;
            }
            else
            {
                pictureboxHuman.Location = new Point(62, 238);
                lblName.Location = new Point(118, 160);
                txtCreateName.Location = new Point(120, 200);
                lblSurname.Location = new Point(118, 244);
                txtCreateSurname.Location = new Point(120, 281);
                lblNickName.Visible = false;
                txtNickName.Visible = false;
            }
        }

        private void btnDiscord_Click(object sender, EventArgs e)
        {
            string myDiscordID = "586622125671055491";
            string url = $"https://discord.com/users/{myDiscordID}";
            Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
        }


        private void button5_Click(object sender, EventArgs e)
        {

            if (txtUserName.Text != "" && txtPass.Text != "")
            {
                userName = txtUserName.Text;
                password = txtPass.Text;

                DataBaseManager dbManager = new DataBaseManager();
                LoginResult loginResult = dbManager.LogIn(userName, password);
                if (loginResult == LoginResult.StudentLogin)
                {
                    FormOgrenci formOgrenci = new FormOgrenci();
                    MessageBox.Show("Öğrenci Girişi Yapıldı", "başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    formOgrenci.ShowDialog();

                }
                else if (loginResult == LoginResult.TeacherLogin)
                {
                    FormOgretmen formOgretmen = new FormOgretmen();
                    MessageBox.Show("Öğretmen Girişi Yapıldı", "başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    formOgretmen.ShowDialog();
                }
                else
                {
                    MessageBox.Show("KullanıcıAdı veya şifre yanlış", "başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Giriş yapmak için boş bilgi bırakma", "başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
    public static class UiManager
    {
        public static void txtChangeColors(TextBox txtName, TextBox txtSurname, TextBox txtPass, TextBox txtUserName, Color color)
        {
            txtName.BackColor = color;
            txtSurname.BackColor = color;
            txtPass.BackColor = color;
            txtUserName.BackColor = color;
        }
        public static void txtReadOnly(TextBox txtName, TextBox txtSurname, TextBox txtPass, TextBox txtUserName, bool trueOrFalse)
        {
            txtName.ReadOnly = trueOrFalse;
            txtSurname.ReadOnly = trueOrFalse;
            txtPass.ReadOnly = trueOrFalse;
            txtUserName.ReadOnly = trueOrFalse;
        }
        public static bool TogglePasswordVisibility(Button btnShow, TextBox Pass, ref bool passHide)
        {
            if (passHide)
            {
                btnShow.BackgroundImageLayout = ImageLayout.Zoom;
                btnShow.BackgroundImage = Properties.Resources.eye;
                Pass.UseSystemPasswordChar = false;
                passHide = false;
                return false;
            }
            else
            {
                btnShow.BackgroundImageLayout = ImageLayout.Zoom;
                btnShow.BackgroundImage = Properties.Resources.hidden;
                Pass.UseSystemPasswordChar = true;
                passHide = true;
                return true;
            }
        }

    }
}
