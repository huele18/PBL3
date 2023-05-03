using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3.DTO;

namespace PBL3.DAL
{
    public class Bill_DAL
    {
        private static Bill_DAL instance;
        public static Bill_DAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Bill_DAL();
                }
                return instance;
            }
            private set { }
        }
        //public DataGridView getBill()
        //{
        //    using (QuanLyQuanCafeEntities db = new QuanLyQuanCafeEntities())
        //    {
        //        DataGridView bill = new DataGridView();
        //        bill.DataSource = db.Bills
        //            .Select(p => new {
        //                p.idBill,
        //                p.Customer,
        //                p.paymenttime,
        //                p.thanhtoan,
        //                p.orderedDrink,
        //                p.TableFood.name,
        //                p.idAccount
        //            }).ToList();
        //        return bill;
        //    }
        //}
        //public List<CBBItem> getOrderedDrinnkCBB(string ids)
        //{
        //    using (QuanLyQuanCafeEntities db = new QuanLyQuanCafeEntities())
        //    {
        //        int count = 0;
        //        List<CBBItem> items = new List<CBBItem>();
        //        foreach (Food d in db.Foods)
        //        {
        //            if (ids.Contains(d.idFood.ToString()))
        //            {
        //                for (int j = 0; j < ids.Length; j++)
        //                {
        //                    if (ids.Substring(j, 1) == d.idFood.ToString())
        //                    {
        //                        count++;
        //                    }
        //                }
        //                items.Add(new CBBItem
        //                {
        //                    Value = d.idFood,
        //                    Text = d.NameFood + " (x" + count + "):  " + (count * d.price) + "đ"
        //                });
        //                count = 0;
        //            }
        //        }
        //        return items;
        //    }
        //}
        //public int getTotal(string s)
        //{
        //    int count = 0;
        //    int tprice = 0;
        //    using (QuanLyQuanCafeEntities db = new QuanLyQuanCafeEntities())
        //    {
        //        foreach (Food d in db.Foods)
        //        {
        //            if (s.Contains(d.idFood.ToString()))
        //            {
        //                for (int j = 0; j < s.Length; j++)
        //                {
        //                    if (s.Substring(j, 1) == d.idFood.ToString())
        //                    {
        //                        count++;
        //                    }
        //                }
        //                tprice += (int)(count * d.price);
        //                count = 0;
        //            }
        //        }
        //    }
        //    return tprice;
        //}
        //public void del(string id)
        //{
        //    using (QuanLyQuanCafeEntities db = new QuanLyQuanCafeEntities())
        //    {
        //        Bill b = db.Bills.Find(id);
        //        db.Bills.Remove(b);
        //        db.SaveChanges();
        //    }
        //}
        //public void edit(Bill newBill)
        //{
        //    using (QuanLyQuanCafeEntities db = new QuanLyQuanCafeEntities())
        //    {
        //        Bill bill = db.Bills.Find(newBill.idBill);
        //        bill.Customer = newBill.Customer;
        //        bill.paymenttime = newBill.paymenttime;
        //        bill.thanhtoan = newBill.thanhtoan;
        //        bill.idAccount = newBill.idAccount;
        //        bill.idTable = newBill.idTable;
        //        db.SaveChanges();
        //        MessageBox.Show("Đã cập nhật thành công thông tin hóa đơn", "Thông báo",
        //            MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //}
    }
}
