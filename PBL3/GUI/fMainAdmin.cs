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
    public partial class fMainAdmin : Form
    {
        private Button currentButton;
        private Form activeForm;

        private Account acc = null;
        public fMainAdmin(string username)
        {
            InitializeComponent();
            acc = Account_BLL.Instance.getAccountByUsername(username);
            lbNameAccount.Text = acc.DisplayName;
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
            openChildForm(new GUI.fOrder(acc.idAccount), sender);
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
            openChildForm(new GUI.fStaffManager(), sender);
        }

        private void btBill_Click(object sender, EventArgs e)
        {
            openChildForm(new GUI.fBillManager(), sender);
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

        private void btShift_Click(object sender, EventArgs e)
        {
            openChildForm(new GUI.fShift(), sender);

        }
    }
}
