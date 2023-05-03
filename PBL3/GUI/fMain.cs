using PBL3.BLL;
using PBL3.DAL;
using PBL3.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PBL3
{
    public partial class fMain : Form
    {
        private Button currentButton;
        private Form activeForm;

        private Account acc = null;
        public fMain(string username)
        {
            InitializeComponent();
            acc = Account_BLL.Instance.getAccountByUsername(username);
            lbNameAccount.Text = acc.DisplayName;
            if (acc.Type == 1)
                lbPosition.Text = "(Quản lý)";
            if (acc.Type == 0)
                lbPosition.Text = "(Nhân viên)";
        }
        private void ActivateButton(object btSender)
        {
            if(btSender != null)
            {
                if(currentButton != (Button)btSender)
                {
                    DisableButton();
                    currentButton = (Button)btSender;
                    currentButton.Font = new Font("Lucida Handwriting", 13.8F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void DisableButton()
        {
            foreach(Control previousBt in panelMenu.Controls)
            {
                if(previousBt.GetType() == typeof(Button))
                {
                    previousBt.Font = new Font("Lucida Handwriting", 12F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void openChildForm(Form childForm, object btSender)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelForm.Controls.Add(childForm);
            this.panelForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lbTitle.Text = childForm.Text;
        }

        private void btHome_Click(object sender, EventArgs e)
        {
            openChildForm(new GUI.fOrder(), sender);
        }

        private void btTable_Click(object sender, EventArgs e)
        {
            openChildForm(new GUI.fTableManager(), sender);
        }

        private void btMenu_Click(object sender, EventArgs e)
        {
            openChildForm(new GUI.fMenuManager(), sender);
        }

        private void btStaff_Click(object sender, EventArgs e)
        {
            if (acc.Type == 1)
            {
                openChildForm(new GUI.fStaffManager(), sender);
            }
            else
            {
                if(activeForm != null)
                {
                    activeForm.Close();
                }
                Reset();
            }
        }

        private void Reset()
        {
            DisableButton();
            lbTitle.Text = "Hệ thống quản lý quán cafe";
            currentButton = null;
            lbNotify.Text = "Chỉ có quản lý mới có thể \n quản lý danh sách nhân viên";
        }

        private void btBill_Click(object sender, EventArgs e)
        {
            openChildForm(new GUI.fBillManager(), sender);
        }

        private void btStatistic_Click(object sender, EventArgs e)
        {
            openChildForm(new GUI.fStatistic(), sender);
        }

        private void btAccount_Click(object sender, EventArgs e)
        {
            openChildForm(new GUI.fAccountManager(acc.idAccount), sender);
        }

        private void btLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát khỏi chương trình không?", "Thông báo",
           MessageBoxButtons.YesNo) != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }
    }
}
