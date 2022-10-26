using Library_BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library_BO;
using Library_BLL;
using System.Runtime.InteropServices;

namespace Library_TI1
{
    public partial class MainPanel : Form
    {
        //private Login _login;
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        //public MainPanel()
        //{
        //    InitializeComponent();
        //    //if (Session.Roli == Roli.Admin)
        //    //{
        //    //  btnRolet.Enabled = false;
        //    //}
        //}
        public MainPanel(/*Login login*/)
        {
            InitializeComponent();
           // _login = login;
            if (Session.Roli == Roli.Admin)
            {
                btnRolet.Enabled = false;
                lblRoli.Text = "Admin";
            }
            else
                lblRoli.Text = "Biblotekist";
            random = new Random();
            btnCloseChild.Visible = false;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        //[DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        //private extern static void ReleaseCapture();
        //[DllImport("user32.DLL", EntryPoint = "SendMessage")]
        //  private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private Color SelectThemeColor()
        {
            //random = new Random();
            int index = (int)random.Next(ThemeColors.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColors.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColors.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Lucida Bright", 13.5F, System.Drawing.FontStyle.Bold);
                    pnlNav.BackColor = color;
                    pnlTitle.BackColor = ThemeColors.ChangeColorBrightness(color, -0.3);
                    btnSignOut.BackColor = ThemeColors.ChangeColorBrightness(color, -0.3);
                    ThemeColors.PrimaryColor = color;
                    ThemeColors.SecondaryColor = ThemeColors.ChangeColorBrightness(color, -0.3);
                    btnCloseChild.Visible = true;
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in pnlMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Lucida Bright", 12.2F, System.Drawing.FontStyle.Bold);
                }
            }
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pnlShowData.Controls.Add(childForm);
            this.pnlShowData.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblPageTitle.Text = childForm.Text;
        }

        private void MainPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
          //_login.Close();
        }
        private void btnLibrat_Click(object sender, EventArgs e)
        {

            OpenChildForm(new Forms.Librat(), sender);
        }

        private void btnAutoret_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Autori(), sender);
        }

        private void btnStudentet_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Studentet(), sender);
        }

        private void btnRolet_Click(object sender, EventArgs e)
        {

            OpenChildForm(new Forms.Rolet(), sender);
        }

        private void btnHuazimet_Click(object sender, EventArgs e)
        {

            OpenChildForm(new Forms.Huazimet(), sender);
        }

        private void btnListat_Click(object sender, EventArgs e)
        {

            OpenChildForm(new Forms.Listat(), sender);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }
        private void BtnKategorit_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Kategoria(), sender);
        }
        private void btnSignOut_Click(object sender, EventArgs e)
        {
            MainPanel mainPanel = new MainPanel();
            mainPanel.Hide();
            MessageBox.Show("Ju jeni çkyqur me suskses!", "Lajmrim");
            Application.Restart();
        }

        private void btnCloseChild_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }
        private void Reset()
        {
            DisableButton();
            lblPageTitle.Text = "HOME";
            //lblPageTitle.BackColor = Color.FromArgb(0, 150, 136);
            pnlTitle.BackColor = Color.FromArgb(39, 39, 58);
            currentButton = null;
            btnCloseChild.Visible = false;
        }
        private void btnClose_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
