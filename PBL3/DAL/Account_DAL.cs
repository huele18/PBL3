using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using System.Xml.Linq;
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
        public List<Account> getAccountList()
        {
            List<Account> list = new List<Account>();
            using (QuanLyQuanCafeEntities db = new QuanLyQuanCafeEntities())
            {
                list = db.Accounts.ToList();
            }
            return list;
        }
        public void update(Account after)
        {
            using (QuanLyQuanCafeEntities db = new QuanLyQuanCafeEntities())
            {
                Account acc = db.Accounts.Find(after.idAccount);
                acc.DisplayName = after.DisplayName;
                acc.SDT = after.SDT;
                acc.GT = after.GT;
                acc.address = after.address;
                acc.email = after.email;
                acc.UserName = after.UserName;
                acc.Calam = after.Calam;
                acc.Anh = after.Anh;
                db.SaveChanges();
                MessageBox.Show("Đã cập nhật thành công thông tin tài khoản của bạn", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void changePassword(int id, string pass)
        {
            using (QuanLyQuanCafeEntities db = new QuanLyQuanCafeEntities())
            {
                Account acc = db.Accounts.Find(id);
                acc.Password = pass;
                db.SaveChanges();
                MessageBox.Show("Đổi mật khẩu thành công", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public List<Account> getListAccount()
        {
            using (QuanLyQuanCafeEntities db = new QuanLyQuanCafeEntities())
            {
                List<Account> ac = new List<Account>();
                var j = db.Accounts.Select(p => new
                {
                    p.idAccount,
                    p.DisplayName,
                    p.GT,
                    p.SDT,
                    p.address,
                    p.email,
                    p.UserName,
                    p.Calam,
                    p.Type,
                    p.Anh
                });
                foreach (var jacc in j)
                {
                    Account acc = new Account
                    {
                        idAccount = jacc.idAccount,
                        DisplayName = jacc.DisplayName,
                        GT = jacc.GT,
                        SDT = jacc.SDT,
                        address = jacc.address,
                        email = jacc.email,
                        UserName = jacc.UserName,
                        Calam = jacc.Calam,
                        Type = jacc.Type,
                        Anh = jacc.Anh,
                    };
                    ac.Add(acc);
                }
                return ac;
            }
        }
        public Account getAccountByID(int id)
        {
            using (QuanLyQuanCafeEntities db = new QuanLyQuanCafeEntities())
            {
                foreach (Account i in db.Accounts)
                {
                    if (i.idAccount == id)
                    {
                        return i;
                    }
                }
                return null;
            }

        }
        public Account getAccountByUsername(string username)
        {
            using (QuanLyQuanCafeEntities db = new QuanLyQuanCafeEntities())
            {
                foreach (Account i in db.Accounts)
                {
                    if (i.UserName == username)
                    {
                        return i;
                    }
                }
                return null;
            }
        }
        public void add(Account nv)
        {
            using (QuanLyQuanCafeEntities db = new QuanLyQuanCafeEntities())
            {
                db.Accounts.Add(nv);
                db.SaveChanges();
                MessageBox.Show("Đã thêm thành công ", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void del(int id)
        {
            using (QuanLyQuanCafeEntities db = new QuanLyQuanCafeEntities())
            {
                Account nv = db.Accounts.Find(id);
                db.Accounts.Remove(nv);
                db.SaveChanges();
            }
        }
        public List<Account> search(string search)
        {
            using (QuanLyQuanCafeEntities db = new QuanLyQuanCafeEntities())
            {
                List<Account> ac = new List<Account>();
                var j = db.Accounts.
                    Where(p => p.DisplayName.ToUpper().Contains(search.ToUpper()))
                    .Select(p => new
                    {
                        p.idAccount,
                        p.DisplayName,
                        p.GT,
                        p.SDT,
                        p.address,
                        p.email,
                        p.UserName,
                        p.Calam,
                        p.Type,
                        p.Anh
                    });
                foreach (var jacc in j)
                {
                    Account acc = new Account
                    {
                        idAccount = jacc.idAccount,
                        DisplayName = jacc.DisplayName,
                        GT = jacc.GT,
                        SDT = jacc.SDT,
                        address = jacc.address,
                        email = jacc.email,
                        UserName = jacc.UserName,
                        Calam = jacc.Calam,
                        Type = jacc.Type,
                        Anh = jacc.Anh,
                    };
                    ac.Add(acc);
                }
                return ac;
            }
        }
        public void resetPass(int id, string pass)
        {
            using (QuanLyQuanCafeEntities db = new QuanLyQuanCafeEntities())
            {
                Account acc = db.Accounts.Find(id);
                acc.Password = pass;
                db.SaveChanges();
            }
        }
    }
}
