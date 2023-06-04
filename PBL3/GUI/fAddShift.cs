using PBL3.BLL;
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

namespace PBL3.GUI
{
    public partial class fAddShift : Form
    {
        public fAddShift(string t)
        {
            InitializeComponent();
            lbThu.Text = t;
            setCBBCa();
            setCBBStaff();
        }

        public void setCBBStaff()
        {
            cbbStaff.Items.AddRange(Shift_BLL.Instance.GetCbbAccounts().ToArray());
        }
        public void setCBBCa()
        {
            cbbCa.Items.AddRange(Shift_BLL.Instance.getCBBCa().ToArray());
        }
        private void cbbCa_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idshift = ((CBBItem)cbbCa.SelectedItem).Value;
            Calam cl = Shift_BLL.Instance.getCalamByID(idshift);
            dtpStart.Value = cl.TimeStart.Value;
            dtpEnd.Value = cl.TimeEnd.Value;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cbbCa.Text) && !string.IsNullOrEmpty(cbbStaff.Text))
            {
                int idaccount = ((CBBItem)cbbStaff.SelectedItem).Value;
                int idshift = ((CBBItem)cbbCa.SelectedItem).Value;
                if (!Shift_BLL.Instance.checkStaffShift(lbThu.Text, idaccount, idshift))
                {
                    try
                    {
                        Phanca pc = new Phanca()
                        {
                            idAccount = idaccount,
                            idShift = idshift,
                            Daywork = lbThu.Text,
                        };
                        Shift_BLL.Instance.add(pc);
                        this.Close();
                    }
                    catch (Exception ex) { }
                }
                else
                    MessageBox.Show("Nhân viên này đã có trong ca làm trên");
            }
            else
                MessageBox.Show("Chưa chọn đầy đủ thông tin");
        }
    }
}
