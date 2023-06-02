using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3.DTO;

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
        public Calam getCalamByIdShift(int id)
        {
            using (QuanLyQuanCafeEntities3 db = new QuanLyQuanCafeEntities3())
            {
                foreach (Calam b in db.Calams)
                {
                    if (b.idShift == id)
                    {
                        return b;
                    }
                }
            }
            return null;
        }
        public Calam  getCalamById(int id)
        {
            using (QuanLyQuanCafeEntities3 db = new QuanLyQuanCafeEntities3())
            {
                foreach (Calam b in db.Calams)
                {
                    if (b.idAccount == id)
                    {
                        return b;
                    }
                }
            }
            return null;
        }
        
        public DataGridView getShift()
        {
            using (QuanLyQuanCafeEntities3 db = new QuanLyQuanCafeEntities3())
            {
                DataGridView Shift = new DataGridView();
                Shift.DataSource = db.Calams
                    .Select(p => new
                    {
                        p.idShift,
                        p.idAccount,
                        p.DisplayName,
                        p.TimeStart,
                        p.TimeEnd
                    }).ToList();
                return Shift;
            }
        }
        public void del(int idShift)
        {
            using (QuanLyQuanCafeEntities3 db = new QuanLyQuanCafeEntities3())
            {
                Calam f = db.Calams.Find(idShift);
                if (f != null)
                {
                    db.Calams.Remove(f);
                    db.SaveChanges();
                    MessageBox.Show("Đã xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy Calam với idAccount tương ứng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        public void edit(Calam after)
        {
            using (QuanLyQuanCafeEntities3 db = new QuanLyQuanCafeEntities3())
            {
               
                    Calam calam = db.Calams.Find(after.idShift);
                   
                        calam.idShift = after.idShift;
                        calam.idAccount = after.idAccount;
                        calam.DisplayName = after.DisplayName;
                        calam.TimeStart = after.TimeStart;
                        calam.TimeEnd = after.TimeEnd;
                        db.SaveChanges();
                        MessageBox.Show("Đã cập nhật thành công thông tin ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                   
                
            }
        }
        public void add(Calam calam)
        {
            using (QuanLyQuanCafeEntities3 db = new QuanLyQuanCafeEntities3())
            {
                db.Calams.Add(calam);
                db.SaveChanges();
                MessageBox.Show("Đã thêm thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public List<Calam> getCalamList()
        {
            List<Calam> ca = new List<Calam>();
            using (QuanLyQuanCafeEntities3 db = new QuanLyQuanCafeEntities3())
            {   
                ca.AddRange(db.Calams.ToList());
            }
            return ca;
        }
        public DataGridView search(string search)
        {
           
            DataGridView calam = new DataGridView();
            using (QuanLyQuanCafeEntities3 db = new QuanLyQuanCafeEntities3())
            {
               calam.DataSource = db.Calams.Where
                    (
                        p => p.DisplayName.ToUpper().Contains(search.ToUpper()) 
                            
                    )
                    .Select(p => new { p.idShift, p.idAccount, p.DisplayName, p.TimeStart, p.TimeEnd }).ToList();
            }
            return calam;
        }

    }
}
