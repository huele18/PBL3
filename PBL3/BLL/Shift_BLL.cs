using PBL3.DAL;
using PBL3.DTO;
using PBL3.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3.BLL
{
    public class Shift_BLL
    {
        private static Shift_BLL instance;
        public static Shift_BLL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Shift_BLL();
                }
                return instance;
            }
        }
        public DataGridView show(string thu)
        {
            return Shift_DAL.Instance.show(thu);
        }
        public List<string> thu = new List<string> {"Thứ 2", "Thứ 3", "Thứ 4", "Thứ 5", "Thứ 6", "Thứ 7", "Chủ nhật"};
        public List<Phanca> getPhancaByThu(string thu)
        {
            List<Phanca> pc = new List<Phanca>();
            foreach(Phanca i in Shift_DAL.Instance.GetPhancas())
            {
                if (i.Daywork == thu)
                {
                    pc.Add(i);
                }
            }
            return pc;
        }
        public List<ucShift> GetUcShifts()
        {
            List<ucShift> ucShifts = new List<ucShift>();
            foreach(string i in thu)
            {
                ucShift uc = new ucShift();
                uc.Margin = new System.Windows.Forms.Padding(20, 10, 5, 3);
                uc.lbThu.Text = i;
                foreach(Phanca phanca in getPhancaByThu(i))
                {
                    string displayname = Account_BLL.Instance
                        .getAccountByID(Convert.ToInt32(phanca.idAccount)).DisplayName;
                    if (phanca.idShift == 1)
                        uc.lbSang.Items.Add(displayname);
                    if (phanca.idShift == 2)
                        uc.lbChieu.Items.Add(displayname);
                    if (phanca.idShift == 3)
                        uc.lbToi.Items.Add(displayname);
                }
                uc.btView.Tag = i;
                uc.btAdd.Tag = i;
                ucShifts.Add(uc);
            }
            return ucShifts;
        }

        public bool checkStaffShift(string thu, int idaccount, int idshift)
        {
            foreach (Phanca i in Shift_DAL.Instance.GetPhancas())
            {
                if (i.Daywork == thu)
                {
                    if (i.idAccount == idaccount && i.idShift == idshift)
                    {
                        return true; // da co nhan vien nay trong ca
                    }
                }
            }
            return false;
        }
        public List<CBBItem> GetCbbAccounts()
        {
            List<CBBItem> accounts = new List<CBBItem>();
            foreach (Account i in Shift_DAL.Instance.GetAccounts())
            {
                    accounts.Add(new CBBItem
                    {
                        Value = i.idAccount,
                        Text = i.DisplayName
                    });
            }
            return accounts;
        }

        public List<CBBItem> getCBBCa()
        {
            List<CBBItem> cBBItems = new List<CBBItem>();
            foreach (Calam i in Shift_DAL.Instance.GetCalams())
            {
                cBBItems.Add(new CBBItem
                {
                    Value = i.idShift,
                    Text = i.Display
                });
            }
            return cBBItems;
        }
        public Calam getCalamByID(int id)
        {
            foreach (Calam i in Shift_DAL.Instance.GetCalams())
            {
                if (i.idShift == id) { return i; }
            }
            return null;
        }
        public void add(Phanca pc)
        {
            Shift_DAL.Instance.add(pc);
        }
        public void remove(int idphanca)
        {
            Shift_DAL.Instance.remove(idphanca);
        }
    }
}
