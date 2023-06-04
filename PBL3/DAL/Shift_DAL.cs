using PBL3.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3.DAL
{
    public class Shift_DAL
    {
        private static Shift_DAL instance;
        public static Shift_DAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Shift_DAL();
                }
                return instance;
            }
            private set { }
        }
        public List<Account> GetAccounts()
        {
            List<Account> pc = new List<Account>();
            using (QuanLyQuanCafeEntities db = new QuanLyQuanCafeEntities())
            {
                pc = db.Accounts.ToList();
            }
            return pc;
        }
        public List<Phanca> GetPhancas()
        {
            List<Phanca> pc = new List<Phanca>();
            using(QuanLyQuanCafeEntities db = new QuanLyQuanCafeEntities())
            {
                pc = db.Phancas.ToList();
            }
            return pc;
        }
        public DataGridView show(string thu)
        {
            DataGridView dgv = new DataGridView();
            using (QuanLyQuanCafeEntities db = new QuanLyQuanCafeEntities())
            {
                dgv.DataSource = db.Phancas.Where(p => p.Daywork == thu)
                    .Select(p => new {p.idPhanca, p.Calam.Display, p.Account.DisplayName })
                    .ToList();
            }
            return dgv;
        }

        public List<Calam> GetCalams()
        {
            List<Calam> pc = new List<Calam>();
            using (QuanLyQuanCafeEntities db = new QuanLyQuanCafeEntities())
            {
                pc = db.Calams.ToList();
            }
            return pc;
        }

        public void add(Phanca pc)
        {
            using (QuanLyQuanCafeEntities db = new QuanLyQuanCafeEntities())
            {
                db.Phancas.Add(pc);
                db.SaveChanges();
                MessageBox.Show("Đã thêm nhân viên vào ca làm mới", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void remove(int idphanca)
        {
            using (QuanLyQuanCafeEntities db = new QuanLyQuanCafeEntities())
            {
                Phanca pc = db.Phancas.Find(idphanca);
                db.Phancas.Remove(pc);
                db.SaveChanges() ;
            }
        }
    }
}
