using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3.DAL;
using PBL3.DTO;

namespace PBL3.BLL
{
    public class Account_BLL
    {
        private static Account_BLL instance;
        public static Account_BLL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Account_BLL();
                }
                return instance;
            }
            private set { }
        }
        public Account getAccountByID(int id)
        {
            foreach(Account i in Account_DAL.Instance.getAccountList())
            {
                if(i.idAccount == id) 
                    return i;
            }
            return null;
        }
        public Account getAccountByUsername(string username)
        {
            foreach (Account i in Account_DAL.Instance.getAccountList())
            {
                if (i.UserName == username)
                {
                    return i;
                }
            }
            return null;
        }
        public Account getAccountByUsernameAndPass(string username, string pass)
        {
            foreach (Account i in Account_DAL.Instance.getAccountList())
            {
                if (i.UserName == username && i.Password == pass)
                {
                    return i;
                }
            }
            return null;
        }
        public bool checkLogin(string name, string pass)
        {
            bool login = false;
            if (getAccountByUsernameAndPass(name, pass) != null)
            {
                login = true;
            }
            return login;
        }
        public int updateAccount(Account after)
        {
            Account acc = getAccountByID(after.idAccount);
            if (after.UserName != acc.UserName)
            {
                if (getAccountByUsername(after.UserName) != null)
                {
                    MessageBox.Show("Username đã tồn tại. Vui lòng nhập lại.", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return 1;
                }
            }
            else
            {
                Account_DAL.Instance.update(after);
                return 0;
            }
            return 2;
        }
        public int changePassword(int id, string passOld, string passOld1, string passNew, string passNew1)
        {
            int focus = 1;
            if (passOld1 != passOld)
            {
                MessageBox.Show("Mật khẩu cũ không đúng. Vui lòng nhập lại.", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return focus = 1;
            }
            else
            {
                if (passNew1 != passNew)
                {
                    MessageBox.Show("Nhập lại mật khẩu không trùng khớp. Vui lòng nhập lại.", "Cảnh báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return focus = 2;
                }
                else
                {
                    Account_DAL.Instance.changePassword(id, passNew);
                    focus = 0;
                }
            }
            return focus;
        }

        // staffManager
        public List<Account> GetAccounts()
        {
            return Account_DAL.Instance.getListAccount();
        }
        public int addNV(Account nv)
        {
            Account acc = Account_DAL.Instance.getAccountByID(nv.idAccount);
            if
            (string.IsNullOrWhiteSpace(nv.DisplayName) ||
             string.IsNullOrWhiteSpace(nv.SDT) ||
             string.IsNullOrWhiteSpace(nv.address) ||
             string.IsNullOrWhiteSpace(nv.email) ||
             string.IsNullOrWhiteSpace(nv.UserName)
            )
            {
                MessageBox.Show("Không được để trống thông tin", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return 2;
            }
            else if ((nv.UserName != acc.UserName) && (Account_DAL.Instance.getAccountByUsername(nv.UserName) != null))
            {
                MessageBox.Show("Username đã tồn tại. Vui lòng nhập lại.", "Cảnh báo",
                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return 1;
            }
            else if (checkIDAccount(nv.idAccount))
            {
                MessageBox.Show("ID  đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return 3;
            }
            else
            {
                Account_DAL.Instance.add(nv);
                return 0;
            }
        }
        public bool checkIDAccount(int id)
        {
            if (Account_DAL.Instance.getAccountByID(id) == null)
            {
                return false; // không tồn tại
            }
            return true;
        }
        public Account GetAccountByid(int id)
        {
            return Account_DAL.Instance.getAccountByID(id);
        }
        public void deleteNV(int id)
        {
            Account_DAL.Instance.del(id);
        }
        public void resetPass(int id, string pass)
        {
            Account_DAL.Instance.resetPass(id, pass);
        }
        public List<Account> searchAccount(string s)
        {
            return Account_DAL.Instance.search(s);
        }
    }
}
