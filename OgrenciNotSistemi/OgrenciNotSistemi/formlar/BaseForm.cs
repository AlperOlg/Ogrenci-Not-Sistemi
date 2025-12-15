using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrenciNotSistemi.formlar
{
    public partial class BaseForm : Form
    {
        protected Button btnBaseClose { get; set; }
        protected Button btnSizeChanger { get; set; }
        protected Button btnBaseMinimize { get; set; }
        protected Panel pnlDraging { get; set; }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        public BaseForm()
        {
            InitializeComponent();
        }

        private void BaseForm_Load(object sender, EventArgs e)
        {
            if (btnBaseClose != null && btnSizeChanger != null && btnBaseMinimize != null && pnlDraging != null)
            {
                btnSizeChanger.Click += BtnSizeChanger_Click;
                btnBaseClose.Click += BtnBaseClose_Click;
                btnBaseMinimize.Click += BtnBaseMinimize_Click;
                pnlDraging.MouseDown += pnlDraging_MouseDown;
                this.SizeChanged += IfSizeChanged;
            }
        }
        private void pnlDraging_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void BtnSizeChanger_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }
        private void BtnBaseClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkış Yapmak istediğinizden emin misiniz?", "?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }
        private void IfSizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                btnSizeChanger.BackgroundImage = Properties.Resources.minimize__1_;
            }
            else
            {
                btnSizeChanger.BackgroundImage = Properties.Resources.maximize;
            }
        }
        private void BtnBaseMinimize_Click(object sender ,EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
