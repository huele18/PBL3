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
        public List<CBBItem> getOrderedDrinnkCBB(string ids)
        {
            return Bill_DAL.Instance.getOrderedDrinnkCBB(ids);
        }
        public int getTotal(string ids)
        {
            return Bill_DAL.Instance.getTotal(ids);
        }

        public void delBill(string id)
        {
            Bill_DAL.Instance.del(id);
        }
        public void editBill(Bill b)
        {
            Bill_DAL.Instance.edit(b);
        }


        public List<Bill> getBills()
        {
            return Bill_DAL.Instance.getBills();
        }
        public Bill getBillTableByIdTable(int idtable)
        {
            return Bill_DAL.Instance.getBillTableByIdTable(idtable);
        }
        public List<ItemOrder> getBillInfoByIdTable(int idtable)
        {
            return Bill_DAL.Instance.GetBillInfoByIdTable(idtable);
        }
        public List<ItemOrder> getBillInfoByIdBill(int idbill)
        {
            return Bill_DAL.Instance.GetBillInfoByIdBill(idbill);
        }









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
