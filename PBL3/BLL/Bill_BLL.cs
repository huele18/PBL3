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



        public Bill getBillTableByIdTable(int idtable)
        {
            return Bill_DAL.Instance.getBillTableByIdTable(idtable);
        }
        public List<ItemOrder> getBillInfoByIdBill(int idtable)
        {
            return Bill_DAL.Instance.GetBillInfoByIdBill(idtable);
        }
        public DataGridView getDetailBill(string ids)
        {
            return Bill_DAL.Instance.getDetailBill(ids);
        }
        public bool idBillExit(int id)
        {
            return false;
        }
        public void addBill(Bill bill, List<ItemOrder> lio)
        {
            if( !idBillExit(bill.idBill) )
            {
                Bill_DAL.Instance.addBill(bill, lio);
            }
            else
            {
                MessageBox.Show("ID hóa đơn đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
