using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using System.Xml.Linq;
using PBL3._1;
using PBL3.DTO;

namespace PBL3.DAL
{
    public class Account_DAL
    {
        private static Account_DAL instance;
        public static Account_DAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Account_DAL();
                }
                return instance;
            }
            private set { }
        }
        public Account getAccountByUsername(string username)
        {
            QuanLyQuanCafe2Entities db = new QuanLyQuanCafe2Entities();
            foreach (Account i in db.Accounts)
            {
                if (i.UserName == username)
                {
                    return i;
                }
            }
            return null;
        }
        public Account getAccountByID(int id)
        {
            QuanLyQuanCafe2Entities db = new QuanLyQuanCafe2Entities();
            foreach (Account i in db.Accounts)
            {
                if (i.idAccount == id)
                {
                    return i;
                }
            }
            return null;
        }
        public Account getAccountByUsernameAndPass(string username, string pass)
        {
            QuanLyQuanCafe2Entities db = new QuanLyQuanCafe2Entities();
            foreach (Account i in db.Accounts)
            {
                if (i.UserName == username && i.Password == pass)
                {
                    return i;
                }
            }
            return null;
        }
        public void update(Account after)
        {
            using (QuanLyQuanCafe2Entities db = new QuanLyQuanCafe2Entities())
            {
                Account acc = db.Accounts.Find(after.idAccount);
                acc.DisplayName = after.DisplayName;
                acc.SDT = after.SDT;
                acc.GT = after.GT;
                acc.address = after.address;
                acc.email = after.email;
                acc.UserName = after.UserName;
                db.SaveChanges();
                MessageBox.Show("Đã cập nhật thành công thông tin tài khoản của bạn", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void changePassword(int id, string pass)
        {
            using (QuanLyQuanCafe2Entities db = new QuanLyQuanCafe2Entities())
            {
                Account acc = db.Accounts.Find(id);
                acc.Password = pass;
                db.SaveChanges();
                MessageBox.Show("Đổi mật khẩu thành công", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
