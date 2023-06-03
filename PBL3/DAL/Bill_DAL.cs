using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3.BLL;
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
                        p.idAccount,
                        p.paymenttime,
                        p.thanhtoan,
                        p.TableFood.name
                    }).ToList();
                return bill;
            }
        }
        public DataGridView getDetailBill(string ids)
        {
            using (QuanLyQuanCafeEntities db = new QuanLyQuanCafeEntities())
            {
                DataGridView items = new DataGridView();
                items.DataSource = db.ItemOrders.
                    Where(p => p.idBill.ToString() == ids).
                    Select(p => new { p.idFood, p.Food.NameFood, p.billquantity, p.Food.price }).
                    ToList();
                return items;
            }
        }
        public int getTotal(string s)
        {
            int tprice = 0;
            using (QuanLyQuanCafeEntities db = new QuanLyQuanCafeEntities())
            {
                foreach (ItemOrder d in db.ItemOrders)
                {
                    if (d.idBill.ToString() == s)
                    {

                        tprice += (int)(d.billquantity * d.Food.price);
                    }
                }
            }
            return tprice;
        }
        public void del(int id)
        {
            using (QuanLyQuanCafeEntities db = new QuanLyQuanCafeEntities())
            {
                foreach (ItemOrder d in db.ItemOrders)
                {
                    if (d.idBill == id)
                    {
                        db.ItemOrders.Remove(d);
                    }
                }
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
                bill.paymenttime = newBill.paymenttime;
                bill.thanhtoan = newBill.thanhtoan;
                bill.idAccount = newBill.idAccount;
                bill.idTable = newBill.idTable;
                db.SaveChanges();
                MessageBox.Show("Đã cập nhật thành công thông tin hóa đơn", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        //tra ve Bill chua thanh toan
        public Bill getBillTableByIdTable(int idtable)
        {
            using (QuanLyQuanCafeEntities db = new QuanLyQuanCafeEntities())
            {
                foreach (Bill b in db.Bills.Where(p => p.idTable == idtable).ToList())
                {
                    if (b.thanhtoan == false)
                        return b;

                }
            }
            return null;
        }
        public List<ItemOrder> GetBillInfoByIdBill(int idbill)
        {
            List<ItemOrder> list = new List<ItemOrder>();
            if (idbill.ToString() != null)
            {
                using (QuanLyQuanCafeEntities db = new QuanLyQuanCafeEntities())
                {
                    foreach (ItemOrder bi in db.ItemOrders)
                    {
                        if (bi.idBill == idbill)
                            list.Add(bi);
                    }
                }
            }
            return list;
        }
        public void addBill(Bill bill, List<ItemOrder> lio)
        {
            using (QuanLyQuanCafeEntities db = new QuanLyQuanCafeEntities())
            {
                db.Bills.Add(bill);
                db.ItemOrders.AddRange(lio);
                db.SaveChanges();
                MessageBox.Show("Đã thêm hóa đơn thành công", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public Bill getBillById(int id)
        {
            using (QuanLyQuanCafeEntities db = new QuanLyQuanCafeEntities())
            {
                foreach (Bill b in db.Bills)
                {
                    if (b.idBill == id)
                    {
                        return b;
                    }
                }
            }
            return null;
        }
        //public DataGridView getBill()
        //{
        //    using (QuanLyQuanCafeEntities db = new QuanLyQuanCafeEntities())
        //    {
        //        DataGridView bill = new DataGridView();
        //        bill.DataSource = db.Bills
        //            .Where(p => p.thanhtoan == true)
        //            .Select(p => new {
        //                p.idBill,
        //                p.paymenttime,
        //                p.TableFood.name,
        //                p.idAccount
        //            }).ToList();
        //        return bill;
        //    }
        //}
        //public List<Bill> getBillsPaid()
        //{
        //    using (QuanLyQuanCafeEntities db = new QuanLyQuanCafeEntities())
        //    {
        //        List<Bill> bill = new List<Bill>();
        //        bill = db.Bills.Where(p => p.thanhtoan == true).ToList();
        //        return bill;
        //    }
        //}
        public List<Bill> getBills()
        {
            using (QuanLyQuanCafeEntities db = new QuanLyQuanCafeEntities())
            {
                List<Bill> bill = new List<Bill>();
                bill = db.Bills.ToList();
                return bill;
            }
        }
        //public List<CBBItem> getOrderedDrinnkCBB(string ids)
        //{
        //    using (QuanLyQuanCafeEntities db = new QuanLyQuanCafeEntities())
        //    {
        //        List<CBBItem> items = new List<CBBItem>();
        //        foreach (ItemOrder d in db.ItemOrders)
        //        {
        //            if (d.idBill.ToString() == ids)
        //            {

        //                items.Add(new CBBItem
        //                {
        //                    Value = (int)d.idFood,
        //                    Text = d.Food.NameFood + " (x" + d.billquantity + "):  " + (d.billquantity * d.Food.price) + "đ"
        //                });
        //            }
        //        }
        //        return items;
        //    }
        //}
        //public int getTotal(string s)
        //{
        //    int tprice = 0;
        //    using (QuanLyQuanCafeEntities db = new QuanLyQuanCafeEntities())
        //    {
        //        foreach (ItemOrder d in db.ItemOrders)
        //        {
        //            if (d.idBill.ToString() == s)
        //            {

        //                tprice += (int)(d.billquantity * d.Food.price);
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
        //        bill.paymenttime = newBill.paymenttime;
        //        bill.thanhtoan = newBill.thanhtoan;
        //        bill.idAccount = newBill.idAccount;
        //        bill.idTable = newBill.idTable;
        //        db.SaveChanges();
        //    }
        //}
        //public DataGridView getDetailBill(string ids)
        //{
        //    using (QuanLyQuanCafeEntities db = new QuanLyQuanCafeEntities())
        //    {
        //        DataGridView items = new DataGridView();
        //        items.DataSource = db.ItemOrders.
        //            Where(p => p.idBill.ToString() == ids).
        //            Select(p => new { p.idFood, p.Food.NameFood, p.billquantity, p.Food.price }).
        //            ToList();
        //        return items;
        //    }
        //}


        ////public DataGridView getBillInfoByIdBillInfo()
        ////{
        ////    DataGridView dgv = new DataGridView();
        ////    using (QuanLyQuanCafeEntities db = new QuanLyQuanCafeEntities())
        ////    {
        ////        var v = db.BillInfoes
        ////            .Where
        ////            .Select(x => new {x.idBillInfo, x.idBill, x.Food.NameFood, x.Food.price, x.count});
        ////        dgv.DataSource = v;
        ////    }
        ////    return dgv;
        ////}





        ////tra ve Bill chua thanh toan
        //public Bill getBillTableByIdTable(int idtable)
        //{
        //    using (QuanLyQuanCafeEntities db = new QuanLyQuanCafeEntities())
        //    {
        //        foreach (Bill b in db.Bills.Where(p => p.idTable == idtable).ToList())
        //        {
        //            if (b.thanhtoan == false)
        //                return b;
        //        }
        //    }
        //    return null;
        //}

        //public List<ItemOrder> GetBillInfoByIdBill(int idbill)
        //{
        //    List<ItemOrder> list = new List<ItemOrder>();
        //    if (idbill.ToString() != null)
        //    {
        //        using (QuanLyQuanCafeEntities db = new QuanLyQuanCafeEntities())
        //        {
        //            foreach (ItemOrder bi in db.ItemOrders)
        //            {
        //                if (bi.idBill == idbill)
        //                    list.Add(bi);
        //            }
        //        }

        //    }
        //    return list;
        //}





        public void delItemOrder(string idbill)
        {
            if (!string.IsNullOrEmpty(idbill))
            {
                int id = Convert.ToInt32(idbill);
                QuanLyQuanCafeEntities db = new QuanLyQuanCafeEntities();
                //foreach (ItemOrder io in GetBillInfoByIdBill(Convert.ToInt32(idbill)))
                //{
                //    delItem(io.idorder);
                //    MessageBox.Show("aa");
                //}
                var item = db.ItemOrders.Where(p => p.idBill == id).ToList();
                db.ItemOrders.RemoveRange(item);
                db.SaveChanges();
            }
        }
        public void updateItemOrder(ItemOrder item)
        {
            using (QuanLyQuanCafeEntities db = new QuanLyQuanCafeEntities())
            {
                db.ItemOrders.Add(item);
                db.SaveChanges();
            }
        }

        public void addBill(Bill bill)
        {
            using (QuanLyQuanCafeEntities db = new QuanLyQuanCafeEntities())
            {
                db.Bills.Add(bill);
                db.SaveChanges();
            }
        }
        public void removeBill(string idbill)
        {
            if (!string.IsNullOrEmpty(idbill))
            {
                int id = Convert.ToInt32(idbill);
                QuanLyQuanCafeEntities db = new QuanLyQuanCafeEntities();
                var item = db.ItemOrders.Where(p => p.idBill == id).ToList();
                if (item != null)
                {
                    db.ItemOrders.RemoveRange(item);
                }
                var bill = db.Bills.FirstOrDefault(b => b.idBill == id);
                db.Bills.Remove(bill);

                db.SaveChanges();
            }
        }
    }
}
