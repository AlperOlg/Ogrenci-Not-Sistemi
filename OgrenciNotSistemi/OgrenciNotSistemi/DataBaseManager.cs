using Microsoft.Win32;
using OgrenciNotSistemi.formlar;
using StudentChoose;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCrypt;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Security.Cryptography;
using System.IO;
namespace StudentChoose
{
    public enum Choose
    {
        TotalStudents,
        TotalTeachers,
        TotalLessons,
        PassedStudens,
        FailedStudens
    }

    public enum LoginResult
    {
        StudentLogin,
        TeacherLogin,
        NoLogin
    }
}
namespace OgrenciNotSistemi
{
    internal class DataBaseManager
    {
        static string databasePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Database4.mdb");

        string connectionString = $@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= {databasePath}";
        public DataTable GetStudent(string studentUserName)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                string query = "SELECT * FROM Ogrenciler WHERE KullaniciAdi = @KullaniciAdi";
                using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@KullaniciAdi", studentUserName);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }
        public bool UpgradeStudentGrades(Dictionary<string, int> parametreler)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();
                string query = "update Ogrenciler set TurkceNot = @turkcenot, MatematikNot = @matematiknot, FizikNot = @fiziknot, KimyaNot = @kimyanot, EdebiyatNot = @edebiyatnot, CografyaNot = @cografyanot, FelsefeNot = @felsefenot, TarihNot = @tarihnot, GeometriNot = @geometrinot, BiyolojiNot = @biyolojinot where ID = @id";
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    foreach (var parametre in parametreler)
                    {
                        command.Parameters.AddWithValue(parametre.Key, parametre.Value);
                    }
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }

        public DataTable GetAllStudents()
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                string query = "SELECT * FROM Ogrenciler";
                using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
        }

        public bool DeleteStudent(int studentID)
        {
            if (studentID != 0)
            {
                try
                {
                    using (OleDbConnection connection = new OleDbConnection(connectionString))
                    {
                        string query = "DELETE FROM Ogrenciler WHERE ID = @id";
                        connection.Open();
                        using (OleDbCommand command = new OleDbCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@id", studentID);
                            command.ExecuteNonQuery();
                            return true;
                        }
                    }
                }
                catch
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public LoginResult LogIn(string Username, string Password)
        {
            LoginResult rol = LoginResult.NoLogin;
            try
            {

                if (Username != "" && Password != "")
                {
                    using (OleDbConnection connection = new OleDbConnection(connectionString))
                    {
                        connection.Open();
                        string query = "SELECT Sifre FROM Ogrenciler WHERE KullaniciAdi = @KullaniciAdi";
                        using (OleDbCommand cmd = new OleDbCommand(query, connection))
                        {
                            cmd.Parameters.AddWithValue("@KullaniciAdi", Username);
                            var varibale = cmd.ExecuteScalar();
                            if (varibale != null)
                            {
                                string hashedStudentPassword = varibale.ToString();
                                if (BCrypt.Net.BCrypt.Verify(Password, hashedStudentPassword))
                                {
                                    rol = LoginResult.StudentLogin;
                                    return rol;
                                }
                            }
                            string query1 = "SELECT Sifre FROM Ogretmenler WHERE KullaniciAdi = @KullaniciAdi";
                            using (OleDbCommand command = new OleDbCommand(query1, connection))
                            {
                                command.Parameters.AddWithValue("@KullaniciAdi", Username);
                                var result = command.ExecuteScalar();
                                if (result != null)
                                {
                                    string hashed = result.ToString();
                                    if (BCrypt.Net.BCrypt.Verify(Password, hashed))
                                    {

                                        rol = LoginResult.TeacherLogin;
                                        return rol;
                                    }
                                }
                            }

                        }

                    }
                }
            }
            catch
            {
                return rol;
            }
            return rol;
        }

        public DataTable GetTeacher(string userName)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {

                string query = "SELECT * FROM Ogretmenler WHERE KullaniciAdi = @KullaniciAdi";
                OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@KullaniciAdi", userName);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }

        public int ExecuteScalar(string query, OleDbConnection connection)
        {
            using (OleDbCommand cmd = new OleDbCommand(query, connection))
            {
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }



        public int GetRaporlar(Choose choose)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();
                switch (choose)
                {
                    case Choose.TotalStudents:
                        string query = "SELECT COUNT(*) FROM Ogrenciler";
                        return ExecuteScalar(query, connection);
                    case Choose.TotalTeachers:
                        string query1 = "SELECT COUNT(*) FROM Ogretmenler";
                        return ExecuteScalar(query1, connection);
                    case Choose.TotalLessons:
                        string query2 = "SELECT COUNT(*) FROM Dersler";
                        return ExecuteScalar(query2, connection);
                    case Choose.PassedStudens:
                        string query3 = "SELECT COUNT(*) FROM Ogrenciler WHERE (TurkceNot + MatematikNot + FizikNot + KimyaNot + EdebiyatNot + CografyaNot + FelsefeNot + TarihNot + GeometriNot + BiyolojiNot) / 10.0 >= 50";
                        return ExecuteScalar(query3, connection);
                    case Choose.FailedStudens:
                        string query4 = "SELECT COUNT(*) FROM Ogrenciler WHERE (TurkceNot + MatematikNot + FizikNot + KimyaNot + EdebiyatNot + CografyaNot + FelsefeNot + TarihNot + GeometriNot + BiyolojiNot) / 10.0 < 50";
                        return ExecuteScalar(query4, connection);
                    default:
                        return -1;
                }
            }

        }
        public bool RegisterTeacher(string teacherName, string teacherSurname, string teacherNickname, string hashedTeacherPassword)
        {
            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();
                    string query1 = "SELECT ID FROM Ogretmenler WHERE KullaniciAdi = @KullaniciAdi";
                    using (OleDbCommand command = new OleDbCommand(query1, connection))
                    {
                        command.Parameters.AddWithValue("@KullaniciAdi", teacherNickname);
                        using (OleDbDataReader read = command.ExecuteReader())
                        {
                            if (read.Read())
                            {
                                return false;
                            }
                            else
                            {
                                string query = "INSERT INTO Ogretmenler (Ad, Soyad, KullaniciAdi, Sifre) VALUES (@Ad, @Soyad, @KullaniciAdi, @Sifre)";
                                using (OleDbCommand cmd = new OleDbCommand(query, connection))
                                {
                                    cmd.Parameters.AddWithValue("@Ad", teacherName);
                                    cmd.Parameters.AddWithValue("@Soyad", teacherSurname);
                                    cmd.Parameters.AddWithValue("@KullaniciAdi", teacherNickname);
                                    cmd.Parameters.AddWithValue("@Sifre", hashedTeacherPassword);

                                    cmd.ExecuteNonQuery();
                                    return true;
                                }
                            }
                        }
                    }
                }

            }
            catch
            {
                return false;
            }
        }
        public string RegisterStudent(string studentName, string studentSurname, string hashedStudentPassword)
        {

            try
            {
                string studentUsername = $"{studentName.ToLower()}{studentSurname.ToLower()}";

                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();
                    int counter = 0;
                    while (true)
                    {
                        string query2 = "SELECT ID FROM Ogrenciler WHERE KullaniciAdi = @KullaniciAdi";
                        using (OleDbCommand cmdStudentSearch = new OleDbCommand(query2, connection))
                        {
                            cmdStudentSearch.Parameters.AddWithValue("@KullaniciAdi", studentUsername);
                            using (OleDbDataReader read = cmdStudentSearch.ExecuteReader())
                            {
                                if (read.Read())
                                {
                                    studentUsername = $"{studentName.ToLower()}{studentSurname.ToLower()}{++counter}";
                                    continue;
                                }

                                string query1 = "SELECT MAX(Numara) FROM Ogrenciler";
                                using (OleDbCommand command = new OleDbCommand(query1, connection))
                                {
                                    object result = command.ExecuteScalar();
                                    int maxNumber = 0;
                                    if (result != null && result != DBNull.Value)
                                    {
                                        maxNumber = Convert.ToInt32(result);
                                    }

                                    string query = "INSERT INTO Ogrenciler (Ad, Soyad, KullaniciAdi, Numara, Sifre) VALUES (@Ad, @Soyad, @KullaniciAdi, @Numara, @Sifre)";
                                    using (OleDbCommand cmd = new OleDbCommand(query, connection))
                                    {
                                        cmd.Parameters.AddWithValue("@Ad", studentName);
                                        cmd.Parameters.AddWithValue("@Soyad", studentSurname);
                                        cmd.Parameters.AddWithValue("@KullaniciAdi", studentUsername);
                                        int studentNumber = maxNumber + 1;
                                        cmd.Parameters.AddWithValue("@Numara", studentNumber);
                                        cmd.Parameters.AddWithValue("@Sifre", hashedStudentPassword);

                                        cmd.ExecuteNonQuery();
                                        return studentUsername;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Beklenmedik bir hata oluştu '{ex.Message}'");
                return "";
            }
        }

        public bool UpdateStudent(string studentName, string studentSurname, string studentUsername, string studentPassword, int studentID)
        {
            try
            {
                string hashedStudentPassword = BCrypt.Net.BCrypt.HashPassword(studentPassword);

                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    string query = "UPDATE Ogrenciler SET Ad = @Ad, Soyad = @Soyad, KullaniciAdi = @KullaniciAdi, Sifre = @Sifre WHERE ID = @id";
                    connection.Open();
                    using (OleDbCommand cmd = new OleDbCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Ad", studentName);
                        cmd.Parameters.AddWithValue("@Soyad", studentSurname);
                        cmd.Parameters.AddWithValue("@KullaniciAdi", studentUsername);
                        cmd.Parameters.AddWithValue("@Sifre", hashedStudentPassword);
                        cmd.Parameters.AddWithValue("@id", studentID);
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }

            }
            catch
            {
                return false;
            }
        }
        public bool DeleteTeacher(int teacherID)
        {
            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();
                    string query = "DELETE FROM Ogretmenler WHERE ID = @ID";
                    using (OleDbCommand cmd = new OleDbCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@ID", teacherID);
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch
            {
                return false;
            }
        }
        public bool UpdateTeacherInfo(string teacherName, string teacherSurname, string teacherNickname, string teacherPassword, int teacherID)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "UPDATE Ogretmenler SET Ad = @Ad, Soyad = @Soyad, KullaniciAdi = @KullaniciAdi, Sifre = @Sifre WHERE ID = @ID";
                    using (OleDbCommand cmd = new OleDbCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Ad", teacherName);
                        cmd.Parameters.AddWithValue("@Soyad", teacherSurname);
                        cmd.Parameters.AddWithValue("@KullaniciAdi", teacherNickname);
                        string hashedPassword = BCrypt.Net.BCrypt.HashPassword(teacherPassword);
                        cmd.Parameters.AddWithValue("@Sifre", hashedPassword);
                        cmd.Parameters.AddWithValue("@ID", teacherID);
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
                catch
                {
                    return false;
                }
            }
        }
    }
}
