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
        }
        public bool checkLogin(string name, string pass)
        {
            bool login = false;
            if (Account_DAL.Instance.getAccountByUsernameAndPass(name, pass) != null)
            {
                login = true;
            }
            return login;
        }
        public int updateAccount(Account after)
        {
            Account acc = Account_DAL.Instance.getAccountByID(after.idAccount);
            if
            (string.IsNullOrWhiteSpace(after.DisplayName) ||
             string.IsNullOrWhiteSpace(after.SDT) ||
             string.IsNullOrWhiteSpace(after.address) ||
             string.IsNullOrWhiteSpace(after.email) ||
             string.IsNullOrWhiteSpace(after.UserName)
            )
            {
                MessageBox.Show("Không được để trống thông tin", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return 2;
            }
            else if (after.UserName != acc.UserName)
            {
                if (Account_DAL.Instance.getAccountByUsername(after.UserName) != null)
                {
                    MessageBox.Show("Username đã tồn tại. Vui lòng nhập lại.", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return 1;
                }
                else
                {
                    Account_DAL.Instance.update(after);
                    return 0;
                }
            }
            return 3;
        }
        public int changePassword(string id, string passOld, string passOld1, string passNew, string passNew1)
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
                    Account_DAL.Instance.changePassword(Convert.ToInt32(id), passNew);
                    focus = 0;
                }
            }
            return focus;
        }
    }
}
