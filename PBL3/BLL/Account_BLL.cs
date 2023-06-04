using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using PBL3.DAL;
using PBL3.DTO;
using PBL3.GUI;

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
        public int checkLogin(string name, string pass)
        {
            Account acc = getAccountByUsernameAndPass(name, pass);
            if (acc != null && acc.Type == 0)
                return 0;
            if (acc != null && acc.Type == 1)
                return 1;
            return -1;
        }
        
        public bool checkUsername(int id, string username)
        {
            Account acc = getAccountByID(id);
            if(username != acc.UserName)
            {
                if(getAccountByUsername(username) != null)
                {
                    return false;
                }
            }
            return true;
        }
        public void editAccount(Account after)
        {
            Account_DAL.Instance.update(after);
        }
        public void changePassword(int id, string passNew)
        {
            Account_DAL.Instance.changePassword(id, GetMD5(passNew));
        }

        // staffManager
        public List<Account> GetAccounts()
        {
            return Account_DAL.Instance.getListAccount();
        }
        public int addNV(Account nv)
        {
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
            else if ((Account_DAL.Instance.getAccountByUsername(nv.UserName) != null))
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
                nv.Password = GetMD5(nv.Password);
                Account_DAL.Instance.add(nv);
                return 0;
            }
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
                after.Password = GetMD5(after.Password);
                Account_DAL.Instance.update(after);
                return 0;
            }
            return 2;
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




        public List<ucAccountInfo> GetUcAccountInfos(List<Account> list)
        {
            List<ucAccountInfo> uc = new List<ucAccountInfo>();
            foreach (Account dr in list)
            {
                ucAccountInfo f = new ucAccountInfo();
                if (dr.Anh != null)
                {
                    byte[] imageData = (byte[])dr.Anh;
                    MemoryStream ms = new MemoryStream(imageData);
                    Image image = Image.FromStream(ms);
                    f.pbAnh.Image = image;
                }
                f.lbName.Text = dr.DisplayName;
                if (dr.Type == 0)
                    f.lbChucvu.Text = "Nhân viên";
                else if (dr.Type == 1)
                    f.lbChucvu.Text = "Quản lý";
                f.lbSdt.Text = dr.SDT;
                f.lbEmail.Text = dr.email;
                f.lbAddress.Text = dr.address;
                //f.lbID.Text = dr.idFood.ToString();
                //f.lbNameFood.Text = dr.NameFood;
                //f.lbPrice.Text = dr.price.ToString();
                f.Tag = dr.idAccount;
                uc.Add(f);
            }
            return uc;
        }
        public string GetMD5(string text)
        {
            MD5 md5 = MD5.Create();
            byte[] hash = md5.ComputeHash(Encoding.UTF8.GetBytes(text));
            StringBuilder hashSb = new StringBuilder();
            foreach (byte b in hash)
            {
                hashSb.Append(b.ToString("X2"));
            }
            return hashSb.ToString();
        }
    }
}
