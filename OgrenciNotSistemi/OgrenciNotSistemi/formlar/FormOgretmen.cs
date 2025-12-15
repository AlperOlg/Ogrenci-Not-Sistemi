using StudentChoose;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace OgrenciNotSistemi.formlar
{
    public partial class FormOgretmen : BaseForm
    {
        int ogrenciID, teacherID;
        string teacherName, teacherSurname, teacherNick, teacherPassword;

        public FormOgretmen()
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
        double matematik, turkce, edebiyat, tarih, cografya, felsefe, kimya, fizik, biyoloji, geometri, gpa;
        private void ListGradeData()
        {
            if (cbStudents.SelectedItem != null)
            {
                DataRowView rowView = cbStudents.SelectedItem as DataRowView;
                if (rowView != null)
                {
                    ogrenciID = Convert.ToInt32(rowView["ID"]);
                    lblStudentName.Text = $"Öğrenci Adı: {rowView["Ad"]} {rowView["Soyad"]}";
                    lblStudentNo.Text = $"Numarası: {rowView["Numara"]}";
                    lblStudentID.Text = $"ID'si: {ogrenciID}";

                    /* kısaltayım derken uzattım
                     string[] alanlar = { "MatematikNot", "TurkceNot", "EdebiyatNot", "TarihNot", "CografyaNot", "FelsefeNot", "KimyaNot", "FizikNot", "BiyolojiNot", "GeometriNot" };
                     double[] dersler = new double[alanlar.Length];


                     for (int i = 0; i < dersler.Length; i++)
                     {
                         dersler[i] = Convert.ToDouble(rowView[alanlar[i]]);
                     }
                     matematik = dersler[0];
                     turkce = dersler[1];
                     edebiyat = dersler[2];
                     tarih = dersler[3];
                     cografya = dersler[4];
                     felsefe = dersler[5];
                     kimya = dersler[6];
                     fizik = dersler[7];
                     biyoloji = dersler[8];
                     geometri = dersler[9]; */

                    double Get(string name) => Convert.ToDouble(rowView[name]);

                    matematik = Get("MatematikNot");
                    turkce = Get("TurkceNot");
                    edebiyat = Get("EdebiyatNot");
                    tarih = Get("TarihNot");
                    cografya = Get("CografyaNot");
                    felsefe = Get("FelsefeNot");
                    kimya = Get("KimyaNot");
                    fizik = Get("FizikNot");
                    biyoloji = Get("BiyolojiNot");
                    geometri = Get("GeometriNot");
                    gpa = (turkce + edebiyat + tarih + cografya + felsefe + matematik + fizik + kimya + geometri + biyoloji) / 10;

                    lblTurkce.Text = $"Türkçe: {turkce}";
                    lblMatematik.Text = $"Matematik: {matematik}";
                    lblEdebiyat.Text = $"Edebiyat: {edebiyat}";
                    lblTarih.Text = $"Tarih: {tarih}";
                    lblCografya.Text = $"Coğrafya: {cografya}";
                    lblFelsefe.Text = $"Felsefe: {felsefe}";
                    lblKimya.Text = $"Kimya: {kimya}";
                    lblFizik.Text = $"Fizik: {fizik}";
                    lblBiyoloji.Text = $"Biyoloji: {biyoloji}";
                    lblGeometri.Text = $"Geometri: {geometri}";
                    if (gpa >= 85)
                    {
                        lblGPA.ForeColor = Color.Black;
                        lblGPA.BackColor = Color.Gold;
                    }
                    else if (gpa >= 70)
                    {
                        lblGPA.ForeColor = Color.White;
                        lblGPA.BackColor = Color.Green;
                    }
                    else if (gpa >= 50)
                    {
                        lblGPA.ForeColor = Color.White;
                        lblGPA.BackColor = Color.Orange;
                    }
                    else
                    {
                        lblGPA.ForeColor = Color.White;
                        lblGPA.BackColor = Color.Red;
                    }
                    lblGPA.Text = "Ortalama: " + gpa.ToString("0.00");

                    Dictionary<TextBox, double> degerler = new Dictionary<TextBox, double>()
                    {
                        {txtEdebiyat, edebiyat},
                        {txtTurkce, turkce},
                        {txtMat, matematik},
                        {txtKimya, kimya},
                        {txtFizik, fizik},
                        {txtBiyo, biyoloji},
                        {txtGeo, geometri},
                        {txtTarih, tarih},
                        {txtCografya, cografya},
                        {txtFelsefe , felsefe},
                    };
                    foreach (var deger in degerler)
                    {
                        deger.Key.Text = deger.Value.ToString();
                    }
                    /* bir diğer amele yöntemi
                     txtEdebiyat.Text = edebiyat.ToString();
                     txtTurkce.Text = turkce.ToString();
                     txtMat.Text = matematik.ToString();
                     txtKimya.Text = kimya.ToString();
                     txtFizik.Text = fizik.ToString();
                     txtBiyo.Text = biyoloji.ToString();
                     txtGeo.Text = geometri.ToString();
                     txtTarih.Text = tarih.ToString();
                     txtCografya.Text = cografya.ToString();
                     txtFelsefe.Text = felsefe.ToString(); */
                }
            }
        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {

        }
        private void SetWelcomeText() => lblWelcome.Text = $"{teacherName} {teacherSurname}";
        private void FormOgretmen_Load(object sender, EventArgs e)
        {

            teacherNick = Form1.userName;
            DataBaseManager dbManager = new DataBaseManager();
            DataTable dataTable = dbManager.GetTeacher(teacherNick);
            teacherPassword = Form1.password;
            teacherID = Convert.ToInt32(dataTable.Rows[0]["ID"]);
            teacherName = dataTable.Rows[0]["Ad"].ToString();
            teacherSurname = dataTable.Rows[0]["Soyad"].ToString();
            SetWelcomeText();
            
        }
        private void ShowStudents()
        {
            try
            {
                DataBaseManager dbManager = new DataBaseManager();
                DataTable dataTable = dbManager.GetAllStudents();
                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Beklenmedik bir hata oluştu" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            /* adapter.SelectCommand.Parameters.AddWithValue("@KullaniciAdi", Form1.userName);
             adapter.SelectCommand.Parameters.AddWithValue("@Sifre", Form1.password); */

        }
        private void btnShowStudents_Click(object sender, EventArgs e)
        {
            pnlRaporlar.Visible = false;
            pnlExamResults.Visible = false;
            pnlShowStudent.Visible = true;
            pnlAccInfo.Visible = false;
            lblInfo.Visible = true;
            lblInfo.Text = "Öğrenciler:";
            ShowStudents();
        }

        private void cbStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListGradeData();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
        }

        bool isMaximized;

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataBaseManager dbManager = new DataBaseManager();
            if (cbAccept.Checked)
            {
                if (dbManager.DeleteTeacher(teacherID))
                {
                    Form1 loginForm = new Form1();
                    MessageBox.Show("Öğretmen Hesabı Başarıyla Silindi", "başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    loginForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Beklenmedik bir hata oluştu, hesap silinemedi", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Çıkan Onay kutucuğunu işaretleyin", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbAccept.Visible = true;
            }
        }
        bool isHide = true;
        private void btnShowHide_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            UiManager.TogglePasswordVisibility(btnShowHide, txtPass, ref isHide);
        }

        bool isUpdateReadOnly = true;

        private void btnUpdateInfos_Click(object sender, EventArgs e)
        {
            if (isUpdateReadOnly == false)
            {
                if (!string.IsNullOrEmpty(txtName.Text) && !string.IsNullOrEmpty(txtSurname.Text) && !string.IsNullOrEmpty(txtPass.Text) && !string.IsNullOrEmpty(txtUserName.Text))
                {
                    teacherName = txtName.Text;
                    teacherSurname = txtSurname.Text;
                    teacherPassword = txtPass.Text;
                    teacherNick = txtUserName.Text;
                    DataBaseManager dbManager = new DataBaseManager();
                    btnCancel.Visible = false;
                    bool updateResult = dbManager.UpdateTeacherInfo(txtName.Text, txtSurname.Text, txtUserName.Text, txtPass.Text, teacherID);
                    if (updateResult)
                    {
                        MessageBox.Show("Bilgiler Başarıyla Güncellendi", "başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Bilgiler Güncellenemedi", "hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    BtnCancel_Finish();
                    isUpdateReadOnly = true;
                }
                else
                {
                    MessageBox.Show("Boş bilgi Bırakmayın", "hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    BtnCancel_Finish();
                }
            }
            else
            {

                UiManager.txtReadOnly(txtName, txtSurname, txtPass, txtUserName, false);
                UiManager.txtChangeColors(txtName, txtSurname, txtPass, txtUserName, Color.White);
                btnCancel.Visible = true;

                btnUpdateInfos.Text = "Bilgileri Güncelle";
                isUpdateReadOnly = false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            BtnCancel_Finish();
        }
        private void BtnCancel_Finish()
        {
            UiManager.txtReadOnly(txtName, txtSurname, txtPass, txtUserName, true);
            isUpdateReadOnly = true;
            txtName.Text = teacherName;
            txtSurname.Text = teacherSurname;
            txtPass.Text = teacherPassword;
            btnCancel.Visible = false;
            SetWelcomeText();
            UiManager.txtChangeColors(txtName, txtSurname, txtPass, txtUserName, Color.DarkGray);
            btnUpdate.Text = "Bilgileri Güncelle";
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            pnlAccInfo.Visible = true;
            pnlExamResults.Visible = false;
            pnlRaporlar.Visible = false;
            pnlShowStudent.Visible = false;

            txtName.Text = teacherName;
            txtSurname.Text = teacherSurname;
            txtUserName.Text = teacherNick;
            txtPass.Text = teacherPassword;
            txtID.Text = teacherID.ToString();
        }

        private void btnMaxMin_Click(object sender, EventArgs e)
        {
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Hesaptan Çıkmak istediğine emin misin?", "soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                teacherName = null;
                teacherSurname = null;
                Form1 form1 = new Form1();
                this.Hide();
                form1.ShowDialog();
            }
        }

        bool isExpanded;

        private void button1_Click(object sender, EventArgs e)
        {
            if (isExpanded)
            {
                button1.Text = "Genişlet";
                this.Width = 949;
                pnlExamResults.Width = 656;
                pnlExamResults.Width = 656;
                gbSetUpdates.Width = 339;
                gbStudentInfo.Location = new Point(352, 73);

                isExpanded = false;
            }
            else
            {
                button1.Text = "Daralt";
                this.Width = 1471;
                pnlExamResults.Width = 1169;
                pnlExamResults.Width = 1169;
                gbSetUpdates.Width = 845;
                gbStudentInfo.Location = new Point(871, 73);
                isExpanded = true;
            }
        }
        private void TxtChangeColors(Color color)
        {
            txtEdebiyat.BackColor = color;
            txtTurkce.BackColor = color;
            txtMat.BackColor = color;
            txtKimya.BackColor = color;
            txtFizik.BackColor = color;
            txtBiyo.BackColor = color;
            txtGeo.BackColor = color;
            txtTarih.BackColor = color;
            txtCografya.BackColor = color;
            txtFelsefe.BackColor = color;
        }

        private void txtChangeReadOnly(bool trueOrFalse)
        {
            if (trueOrFalse)
            {
                TxtChangeColors(Color.DarkGray);
            }
            else
            {
                TxtChangeColors(Color.White);
            }
            txtEdebiyat.ReadOnly = trueOrFalse;
            txtTurkce.ReadOnly = trueOrFalse;
            txtMat.ReadOnly = trueOrFalse;
            txtKimya.ReadOnly = trueOrFalse;
            txtFizik.ReadOnly = trueOrFalse;
            txtBiyo.ReadOnly = trueOrFalse;
            txtGeo.ReadOnly = trueOrFalse;
            txtTarih.ReadOnly = trueOrFalse;
            txtCografya.ReadOnly = trueOrFalse;
            txtFelsefe.ReadOnly = trueOrFalse;
            isReadOnly = trueOrFalse;

        }
        private void WriteExamNotes()
        {
            txtEdebiyat.Text = edebiyat.ToString();
            txtTurkce.Text = turkce.ToString();
            txtMat.Text = matematik.ToString();
            txtKimya.Text = kimya.ToString();
            txtFizik.Text = fizik.ToString();
            txtBiyo.Text = biyoloji.ToString();
            txtGeo.Text = geometri.ToString();
            txtTarih.Text = tarih.ToString();
            txtCografya.Text = cografya.ToString();
            txtFelsefe.Text = felsefe.ToString();
        }


        bool isReadOnly = true;
        private void btnUpdateGrades_Click(object sender, EventArgs e)
        {
            if (isReadOnly)
            {
                btnCancelUpdate.Visible = true;
                txtChangeReadOnly(false);
                btnUpdateGrades.Text = "Tamamla";
            }
            else
            {
                try
                {
                    int matNot = Convert.ToInt32(txtMat.Text);
                    int fizikNot = Convert.ToInt32(txtFizik.Text);
                    int kimyaNot = Convert.ToInt32(txtKimya.Text);
                    int biyoNot = Convert.ToInt32(txtBiyo.Text);
                    int turkceNot = Convert.ToInt32(txtTurkce.Text);
                    int tarihNot = Convert.ToInt32(txtTarih.Text);
                    int felsefeNot = Convert.ToInt32(txtFelsefe.Text);
                    int cografyaNot = Convert.ToInt32(txtCografya.Text);
                    int geoNot = Convert.ToInt32(txtGeo.Text);
                    int edebiyatNot = Convert.ToInt32(txtEdebiyat.Text);

                    int[] notlar = { matNot, fizikNot, kimyaNot, biyoNot, turkceNot, tarihNot, felsefeNot, cografyaNot, geoNot, edebiyatNot };
                    bool hepsiGecerliMi = notlar.All(n => n >= 0 && n <= 100);

                    if (hepsiGecerliMi)
                    {
                        Dictionary<string, int> parametreler = new Dictionary<string, int>()
                        {
                            {"@turkcenot",turkceNot},
                            {"@matematiknot",matNot},
                            {"@fiziknot",fizikNot},
                            {"@kimyanot",kimyaNot},
                            {"@edebiyatnot",edebiyatNot},
                            {"@cografyanot",cografyaNot},
                            {"@felsefenot",felsefeNot},
                            {"@tarihnot",tarihNot},
                            {"@geometrinot",geoNot},
                            {"@biyolojinot",biyoNot},
                            {"@id",ogrenciID},
                        };

                        DataBaseManager dbManager = new DataBaseManager();


                        if (dbManager.UpgradeStudentGrades(parametreler))
                        {
                            MessageBox.Show("öğrencinin notları güncellendi", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            GetStudents();
                            ListGradeData();

                            txtChangeReadOnly(true);
                            btnUpdateGrades.Text = "Güncelle";
                            btnCancelUpdate.Visible = false;
                        }
                        else
                        {
                            MessageBox.Show($"hiçbir not güncellenmedi", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtChangeReadOnly(true);
                            btnUpdateGrades.Text = "Güncelle";
                            btnCancelUpdate.Visible = false;
                        }


                    }
                    else
                    {
                        MessageBox.Show("Notlar 0 ile 100 arasında olmalı", "başarısız", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (FormatException fx)
                {
                    MessageBox.Show("Boş bilgi bırakmayın" + fx.Message, "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Beklenmedik bir hata meydana geldi" + ex.Message, "hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }
        private void GetStudents()
        {
            pnlAccInfo.Visible = false;
            pnlRaporlar.Visible = false;
            pnlShowStudent.Visible = false;
            pnlExamResults.Visible = true;

            lblInfo.Visible = true;
            lblInfo.Text = "Not Güncelleme Paneli";

            DataBaseManager manager = new DataBaseManager();
            DataTable dataTable = manager.GetAllStudents();

            cbStudents.DisplayMember = "Ad";
            cbStudents.ValueMember = "ID";
            cbStudents.DataSource = dataTable;
        }


        private void btnRaports_Click(object sender, EventArgs e)
        {
            pnlAccInfo.Visible = false;
            pnlRaporlar.Visible = true;
            pnlExamResults.Visible = false;
            pnlShowStudent.Visible = false;

            DataBaseManager dbManager = new DataBaseManager();

            lblAllStudents.Text = dbManager.GetRaporlar(Choose.TotalStudents).ToString();
            lblAllTeachers.Text = dbManager.GetRaporlar(Choose.TotalTeachers).ToString();
            lblAllLesson.Text = dbManager.GetRaporlar(Choose.TotalLessons).ToString();
            lblPassedStudents.Text = dbManager.GetRaporlar(Choose.PassedStudens).ToString();
            lblUnsuccessStud.Text = dbManager.GetRaporlar(Choose.FailedStudens).ToString();
        }

        private void btnCancelUpdate_Click(object sender, EventArgs e)
        {
            txtChangeReadOnly(true);
            btnCancelUpdate.Visible = false;
            btnUpdateGrades.Text = "Güncelle";
            WriteExamNotes();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            GetStudents();
        }
    }
}
