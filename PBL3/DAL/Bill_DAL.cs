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
        public DataGridView getBill()
        {
            using (QuanLyQuanCafeEntities db = new QuanLyQuanCafeEntities())
            {
                DataGridView bill = new DataGridView();
                bill.DataSource = db.Bills
                    .Select(p => new {
                        p.idBill,
                        p.Customer,
                        p.paymenttime,
                        p.status,
                        p.TableFood.name,
                        p.idAccount
                    }).ToList();
                return bill;
            }
        }
        public List<CBBItem> getOrderedDrinnkCBB(string ids)
        {
            using (QuanLyQuanCafeEntities db = new QuanLyQuanCafeEntities())
            {
                List<CBBItem> items = new List<CBBItem>();
                foreach (BillInfo d in db.BillInfoes)
                {
                    if (d.idBill.ToString() == ids)
                    {

                        items.Add(new CBBItem
                        {
                            Value = (int)d.idFood,
                            Text = d.Food.NameFood + " (x" + d.count + "):  " + (d.count * d.Food.price) + "đ"
                        });
                    }
                }
                return items;
            }
        }
        public int getTotal(string s)
        {
            int tprice = 0;
            using (QuanLyQuanCafeEntities db = new QuanLyQuanCafeEntities())
            {
                foreach (BillInfo d in db.BillInfoes)
                {
                    if (d.idBill.ToString() == s)
                    {

                        tprice += (int)(d.count * d.Food.price);
                    }
                }
            }
            return tprice;
        }
        public void del(string id)
        {
            using (QuanLyQuanCafeEntities db = new QuanLyQuanCafeEntities())
            {
                Bill b = db.Bills.Find(id);
                db.Bills.Remove(b);
                db.SaveChanges();
            }
        }
        public void edit(Bill newBill)
        {
            using (QuanLyQuanCafeEntities db = new QuanLyQuanCafeEntities())
            {
                Bill bill = db.Bills.Find(newBill.idBill);
                bill.Customer = newBill.Customer;
                bill.paymenttime = newBill.paymenttime;
                bill.status = newBill.status;
                bill.idAccount = newBill.idAccount;
                bill.idTable = newBill.idTable;
                db.SaveChanges();
                MessageBox.Show("Đã cập nhật thành công thông tin hóa đơn", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }




        //public DataGridView getBillInfoByIdBillInfo()
        //{
        //    DataGridView dgv = new DataGridView();
        //    using (QuanLyQuanCafeEntities db = new QuanLyQuanCafeEntities())
        //    {
        //        var v = db.BillInfoes
        //            .Where
        //            .Select(x => new {x.idBillInfo, x.idBill, x.Food.NameFood, x.Food.price, x.count});
        //        dgv.DataSource = v;
        //    }
        //    return dgv;
        //}
        
    }
}
