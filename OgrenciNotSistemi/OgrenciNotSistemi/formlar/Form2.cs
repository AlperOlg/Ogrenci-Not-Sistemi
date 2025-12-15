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
namespace OgrenciNotSistemi
{
    public partial class FormOgrenci : formlar.BaseForm
    {
        string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Database4.mdb";
        string studentName, studentSurname, studentUserName, studentPassword;
        int studentID, studentNumber;
        DataTable studentDatabase;

        public FormOgrenci()
        {
            InitializeComponent();
            btnBaseClose = btnClose;
            btnBaseMinimize = btnMinimize;
            btnSizeChanger = btnMaxMin;
            pnlDraging = panel1;
        }



        private void btnClose_Click(object sender, EventArgs e)
        {
        }


        private void FormOgrenci_Load(object sender, EventArgs e)
        {


            studentUserName = Form1.userName.ToString();
            studentPassword = Form1.password.ToString();

            DataBaseManager dbManager = new DataBaseManager();
            studentDatabase = dbManager.GetStudent(studentUserName);

            studentName = studentDatabase.Rows[0]["Ad"].ToString();
            studentSurname = studentDatabase.Rows[0]["Soyad"].ToString();
            studentNumber = Convert.ToInt32(studentDatabase.Rows[0]["Numara"]);
            studentID = Convert.ToInt32(studentDatabase.Rows[0]["ID"]);


            lblWelcome.Text = $"{studentName} {studentSurname}";
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            gbStudentInfo.Visible = false;
            gbAccountInfo.Visible = true;
            txtName.Text = studentName;
            txtSurname.Text = studentSurname;
            txtUserName.Text = studentUserName;
            txtStudentNo.Text = studentNumber.ToString();
            txtPass.Text = studentPassword;
            txtID.Text = studentID.ToString();
        }
        bool isHide = true;
        private void btnShowHide_Click(object sender, EventArgs e)
        {
            if (isHide)
            {
                btnShowHide.BackgroundImage = Properties.Resources.eye;
                txtID.UseSystemPasswordChar = false;
                txtPass.UseSystemPasswordChar = false;
                isHide = false;
            }
            else
            {
                btnShowHide.BackgroundImage = Properties.Resources.hidden;
                txtPass.UseSystemPasswordChar = true;
                txtID.UseSystemPasswordChar = true;
                isHide = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (cbAccept.Checked)
            {
                DataBaseManager manager = new DataBaseManager();
                if (manager.DeleteStudent(studentID))
                {
                    MessageBox.Show("Öğrenci Hesabı Silindi", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    studentID = 0;
                    Form1 form1 = new Form1();
                    this.Hide();
                    form1.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Beklenmedik bir hata oluştu, hesap silinemedi", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                cbAccept.Visible = true;
                MessageBox.Show("Çıkan Onay kutucuğunu işaretleyin", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }



        bool readOnlyOpen = true;
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (readOnlyOpen)
            {
                UiManager.txtReadOnly(txtName,txtSurname,txtPass,txtUserName,false);
                readOnlyOpen = false;
                btnCancel.Visible = true;
                UiManager.txtChangeColors(txtName, txtSurname, txtPass, txtUserName, Color.White);
                btnUpdate.Text = "Güncellemeyi Tamamla";
            }
            else
            {
                if (txtName.Text != "" && txtSurname.Text != "" && txtPass.Text != "" && txtUserName.Text != "")
                {

                    DataBaseManager dbManager = new DataBaseManager();
                    if (dbManager.UpdateStudent(txtName.Text, txtSurname.Text, txtUserName.Text, txtPass.Text, studentID))
                    {
                        studentPassword = txtPass.Text;
                        studentSurname = txtSurname.Text;
                        studentUserName = txtUserName.Text;
                        studentName = txtName.Text;

                        MessageBox.Show("Hesap Bilgileri Güncellendi", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        lblWelcome.Text = $"{studentName} {studentSurname}";

                        BtnCancel_Finish();
                    }
                    else
                    {
                        MessageBox.Show("Sistemde Beklenmedik bir hata meydana geldi", "hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("Boş bilgi Bırakmayın", "hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            BtnCancel_Finish();
        }
        private void BtnCancel_Finish()
        {
            UiManager.txtReadOnly(txtName, txtSurname, txtPass, txtUserName, true);
            readOnlyOpen = true;
            txtName.Text = studentName;
            txtSurname.Text = studentSurname;
            txtPass.Text = studentPassword;
            btnCancel.Visible = false;
            UiManager.txtChangeColors(txtName, txtSurname, txtPass, txtUserName, Color.DarkGray);
            btnUpdate.Text = "Bilgileri Güncelle";
        }
        private void gbAccountInfo_Enter(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Hesaptan Çıkmak istediğine emin misin?", "soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Form1 form1 = new Form1();
                studentName = null;
                studentSurname = null;
                studentUserName = null;
                studentPassword = null;
                studentNumber = 0;
                studentID = 0;
                this.Hide();
                form1.ShowDialog();
            }
        }

        private void btnShowStudents_Click(object sender, EventArgs e)
        {
            gbAccountInfo.Visible = false;
            gbStudentInfo.Visible = true;

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {

                //daha az amelelik
                Dictionary<string, Label> dersler = new Dictionary<string, Label>()
                {
                    {"TurkceNot",lblTurkce },
                    {"EdebiyatNot", lblEdebiyat },
                    {"MatematikNot",lblMatematik },
                    {"FizikNot",lblFizik },
                    {"KimyaNot",lblKimya },
                    {"CografyaNot", lblCografya },
                    {"FelsefeNot",lblFelsefe },
                    {"TarihNot", lblTarih },
                    {"GeometriNot", lblGeometri },
                    {"BiyolojiNot", lblBiyoloji },
                };
                double total = 0;
                foreach (var ders in dersler)
                {
                    double notDegeri = Convert.ToDouble(studentDatabase.Rows[0][ders.Key]);
                    ders.Value.Text = $"{ders.Key.Replace("Not", "")}: {notDegeri}";
                    total += notDegeri;
                }
                lblAvarage.Text = "Ortalama: " + (total / dersler.Count).ToString();

                /*  aşırı amelelik için:
                 double turkce = Convert.ToInt32(dt.Rows[0]["TurkceNot"]);
                 double edebiyat = Convert.ToInt32(dt.Rows[0]["EdebiyatNot"]);
                 double matematik = Convert.ToInt32(dt.Rows[0]["MatematikNot"]);
                 double fizik = Convert.ToInt32(dt.Rows[0]["FizikNot"]);
                 double kimya = Convert.ToInt32(dt.Rows[0]["KimyaNot"]);
                 double cografya = Convert.ToInt32(dt.Rows[0]["CografyaNot"]);
                 double felsefe = Convert.ToInt32(dt.Rows[0]["FelsefeNot"]);
                 double tarih = Convert.ToInt32(dt.Rows[0]["TarihNot"]);
                 double geometri = Convert.ToInt32(dt.Rows[0]["GeometriNot"]);
                 double biyoloji = Convert.ToInt32(dt.Rows[0]["BiyolojiNot"]);
                 double ortalama = (turkce + edebiyat + matematik + fizik + kimya + cografya + felsefe + tarih + geometri + biyoloji) / 10;

                 lblAvarage.Text = $"Ortalama: {ortalama}";
                 lblTurkce.Text = $"Türkçe: {turkce}";
                 lblEdebiyat.Text = $"Edebiyat: {edebiyat}";
                 lblMatematik.Text = $"Matematik: {matematik}";
                 lblFizik.Text = $"Fizik: {fizik}";
                 lblKimya.Text = $"Kimya: {kimya}";
                 lblCografya.Text = $"Cografya: {cografya}";
                 lblFelsefe.Text = $"Felsefe: {felsefe}";
                 lblTarih.Text = $"Tarih: {tarih}";
                 lblGeometri.Text = $"Geometri: {geometri}";
                 lblBiyoloji.Text = $"Biyoloji: {biyoloji}"; */
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
        }
        bool isMaximized;
        private void btnMaxMin_Click(object sender, EventArgs e)
        {
        }
    }
}
