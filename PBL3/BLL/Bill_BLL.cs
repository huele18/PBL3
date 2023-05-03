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
        //public DataGridView showDGV()
        //{
        //    DataGridView dgv = new DataGridView();
        //    dgv.DataSource = Bill_DAL.Instance.getBill().DataSource;
        //    return dgv;
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
    }
}
