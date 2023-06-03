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
    public class Bill_BLL
    {
        private static Bill_BLL instance;
        public static Bill_BLL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Bill_BLL();
                }
                return instance;
            }
        }
        public DataGridView showDGV()
        {
            return Bill_DAL.Instance.getBill();
        }
        public int getTotal(string ids)
        {
            return Bill_DAL.Instance.getTotal(ids);
        }

        public void delBill(int id)
        {
            Bill_DAL.Instance.del(id);
        }
        public void editBill(Bill b)
        {
            Bill_DAL.Instance.edit(b);
        }

        public Bill getBillById(int id)
        {
            return Bill_DAL.Instance.getBillById(id);
        }

        public Bill getBillTableByIdTable(int idtable)
        {
            return Bill_DAL.Instance.getBillTableByIdTable(idtable);
        }
        public List<ItemOrder> getBillInfoByIdBill(int idbill)
        {
            return Bill_DAL.Instance.GetBillInfoByIdBill(idbill);
        }
        public DataGridView getDetailBill(string ids)
        {
            return Bill_DAL.Instance.getDetailBill(ids);
        }
        public bool idBillExit(int id)
        {
            if (getBillById(id) != null)
            {
                return true;
            }
            return false;
        }
        public void addBill(Bill bill, List<ItemOrder> lio)
        {
            if (!idBillExit(bill.idBill))
            {
                Bill_DAL.Instance.addBill(bill, lio);
            }
            else
            {
                MessageBox.Show("ID hóa đơn đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //public DataGridView showDGV()
        //{
        //    return Bill_DAL.Instance.getBill();
        //}
        //public List<CBBItem> getOrderedDrinnkCBB(string ids)
        //{
        //    return Bill_DAL.Instance.getOrderedDrinnkCBB(ids);
        //}
        //public int getTotal(string ids)
        //{
        //    return Bill_DAL.Instance.getTotal(ids);
        //}

        //public void delBill(string id)
        //{
        //    Bill_DAL.Instance.del(id);
        //}
        //public void editBill(Bill b)
        //{
        //    Bill_DAL.Instance.edit(b);
        //}


        //public List<Bill> getBillsPaid()
        //{
        //    return Bill_DAL.Instance.getBillsPaid();
        //}
        public Bill GetBillById(string id)
        {
            foreach (Bill i in Bill_DAL.Instance.getBills())
            {
                if (i.idBill.ToString() == id) return i;
            }
            return null;
        }
        //public Bill getBillTableByIdTable(int idtable)
        //{
        //    return Bill_DAL.Instance.getBillTableByIdTable(idtable);
        //}
        //public List<ItemOrder> getBillInfoByIdBill(int idbill)
        //{
        //    return Bill_DAL.Instance.GetBillInfoByIdBill(idbill);
        //}
        //public DataGridView getDetailBill(string ids)
        //{
        //    return Bill_DAL.Instance.getDetailBill(ids);
        //}






        //Order
        public void delItemOrder(string idbill)
        {
            Bill_DAL.Instance.delItemOrder(idbill);
        }
        public void updateItemOrder(ItemOrder item)
        {
            Bill_DAL.Instance.updateItemOrder(item);
        }
        public void addBill(Bill b)
        {
            Bill_DAL.Instance.addBill(b);
        }
        public void removeBill(string idbill)
        {
            Bill_DAL.Instance.removeBill(idbill);
        }

    }
}
