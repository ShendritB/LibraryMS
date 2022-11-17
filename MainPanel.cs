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
using Library_TI1.Forms;

namespace Library_TI1
{
    public partial class MainPanel : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        LibraBLL libBLL;
        AutoriBLL autBLL;
        HuazimiBLL huaBLL;
        StudentiBLL stuBLL;
        public MainPanel()
        {
            InitializeComponent();
            TotalLibrat(lblTotLib);
            TotalCopiesLibrat(lblTotalCopies);
            TotalAutoret(lblTotAut);
            HuazimetAktive(lblHuazimetAktive);
            TotalStudentet(lblStudenti);
            if (Session.Roli == Roli.Biblotekist)
            {
                btnRolet.Enabled = false;
                lblRoli.Text = "Biblotekist";
                
            }
            else
                lblRoli.Text = "Admin";
            random = new Random();
            btnCloseChild.Visible = false;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        private string TotalLibrat(Label lbl1)
        {
           libBLL = new LibraBLL();
           return libBLL.CountLibratBLL(lbl1);
        }

        private string TotalCopiesLibrat(Label lbl1)
        {
           libBLL = new LibraBLL();
           return libBLL.CopiesLibratBLL(lbl1);
        }
        private string HuazimetAktive(Label lbl1)
        {
           huaBLL = new HuazimiBLL();
           return huaBLL.CountHuazimetBLL(lbl1);
        }
        private string TotalAutoret(Label lbl1)
        {
            autBLL = new AutoriBLL();
            return autBLL.CountAutoretBLL(lbl1);
        }
        private string TotalStudentet(Label lbl1)
        {
            stuBLL = new StudentiBLL();
            return stuBLL.CountStudentetBLL(lbl1);
        }
        private void MainPanel_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }
        private void LoadTheme()
        {
            var color = ThemeColors.PrimaryColor;
            PnlBtmMid.BackColor = ThemeColors.ChangeColorBrightness(color, -0.3);
            PnlBtmMid.BackColor = ThemeColors.PrimaryColor;
        }
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
                    currentButton.Font = new System.Drawing.Font("Gilroy Bold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    pnlNav.BackColor = color;
                    PnlBtmMid.BackColor = color;
                    pnlBtmRight.BackColor = ThemeColors.ChangeColorBrightness(color, -0.3);
                    pnlTitle.BackColor = ThemeColors.ChangeColorBrightness(color, -0.3);
                    pnlCloseBtns.BackColor = ThemeColors.ChangeColorBrightness(color, -0.3);
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
                    previousBtn.Font = new System.Drawing.Font("Gilroy Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        public void OpenChildForm(Form childForm, object btnSender)
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
        private void BtnKategorit_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Kategoria(), sender);
        }
        private void btnSignOut_Click(object sender, EventArgs e)
        {
            MainPanel mainPanel = new MainPanel();
            mainPanel.Hide();
            MessageBox.Show("Ju jeni çkyqur me suskses!", "Lajmerim");
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
