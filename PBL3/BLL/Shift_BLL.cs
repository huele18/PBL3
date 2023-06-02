using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3.DAL;
using PBL3.DTO;

namespace PBL3.BLL
{
    public class Shift_BLL
    {
        private static Shift_BLL instance;
        public static Shift_BLL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Shift_BLL();
                }
                return instance;
            }
        }
        public List<Calam> showDGV()
        {
            List<Calam> list = new List<Calam>();
            list = Shift_DAL.Instance.getCalamList();
            return list;
        }
        public Calam getCalambyidShift(int id)
        {
            return Shift_DAL.Instance.getCalamByIdShift(id);
        }
        
        public void delShift(int idShift)
        {
            Shift_DAL.Instance.del(idShift);
        }
        
        public void editShift(Calam after)
        {
            Shift_DAL.Instance.edit(after);
        }
        public Calam getCalamById(int id)
        {
            return Shift_DAL.Instance.getCalamById(id);
        }
        public void addCalam(Calam calam)
        {
            Shift_DAL.Instance.add(calam);
        }
        public DataGridView searchCalam(string s)
        {
            DataGridView dgv = new DataGridView();
            dgv.DataSource = Shift_DAL.Instance.search(s).DataSource;
            return dgv;
        }
    }
}
