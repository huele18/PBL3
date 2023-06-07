using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3.DTO;

namespace PBL3.DAL
{
    public class Table_DAL
    {
        private static Table_DAL instance;
        public static Table_DAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Table_DAL();
                }
                return instance;
            }
            private set { }
        }
        public TableFood getTableById(string id)
        {
            using (QuanLyQuanCafeEntities db = new QuanLyQuanCafeEntities())
            {
                foreach (TableFood f in db.TableFoods)
                {
                    if (f.idTableFood.ToString() == id)
                    {
                        return f;
                    }
                }
            }
            return null;
        }
        public List<TableFood> getTableFoodList(string str)
        {
            List<TableFood> table = new List<TableFood>();
            using (QuanLyQuanCafeEntities db = new QuanLyQuanCafeEntities())
            {
                if (str == "occupied")
                    table.AddRange(db.TableFoods.Where(p => p.status == "Có Người").ToList());
                if (str == "unoccupied")
                    table.AddRange(db.TableFoods.Where(p => p.status == "Trống").ToList());
                if (str == "All")
                    table.AddRange(db.TableFoods.ToList());
            }
            return table;
        }
        public void add(TableFood tf)
        {
            using (QuanLyQuanCafeEntities db = new QuanLyQuanCafeEntities())
            {
                db.TableFoods.Add(tf);
                db.SaveChanges();
                MessageBox.Show("Đã thêm thành công bàn mới vào danh sách bàn", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public DataGridView search(string search)
        {
            DataGridView table = new DataGridView();
            using (QuanLyQuanCafeEntities db = new QuanLyQuanCafeEntities())
            {
                table.DataSource = db.TableFoods
                    .Where(p => p.name.ToUpper().Contains(search.ToUpper()))
                    .Select(p => new { p.idTableFood, p.name, p.status }).ToList();
            }
            return table;
        }
        public void edit(TableFood after)
        {
            using (QuanLyQuanCafeEntities db = new QuanLyQuanCafeEntities())
            {
                TableFood tf = db.TableFoods.Find(after.idTableFood);
                tf.name = after.name;
                tf.status = after.status;
                db.SaveChanges();
            }
        }
        public void del(int idtable)
        {
            using (QuanLyQuanCafeEntities db = new QuanLyQuanCafeEntities())
            {
                TableFood tf = db.TableFoods.Find(idtable);
                db.TableFoods.Remove(tf);
                db.SaveChanges();
            }
        }
        public List<CBBItem> GetCBBTable()
        {
            List<CBBItem> cbb = new List<CBBItem>();
            using (QuanLyQuanCafeEntities db = new QuanLyQuanCafeEntities())
            {
                foreach (TableFood f in db.TableFoods)
                {
                    cbb.Add(new CBBItem
                    {
                        Value = f.idTableFood,
                        Text = f.name
                    });
                }
            }
            return cbb;
        }

        public TableFood getTableByName(string name)
        {
            using (QuanLyQuanCafeEntities db = new QuanLyQuanCafeEntities())
            {
                foreach (TableFood f in db.TableFoods)
                {
                    if (f.name.ToUpper() == name.ToUpper())
                    {
                        return f;
                    }
                }
            }
            return null;
        }
        public int getTableIDByName(string name)
        {
            using (QuanLyQuanCafeEntities db = new QuanLyQuanCafeEntities())
            {
                foreach (TableFood f in db.TableFoods)
                {
                    if (f.name.ToUpper() == name.ToUpper())
                    {
                        return f.idTableFood;
                    }
                }
            }
            return 0;
        }

        public string rateOfTable()
        {
            string count;
            using (QuanLyQuanCafeEntities db = new QuanLyQuanCafeEntities())
            {
                var query = db.TableFoods.Count();
                var queryuse = db.TableFoods
                    .Where(p => p.status == "Có Người")
                    .Count();
                count = queryuse + "/" + query;
            }
            return count;
        }
    }
}
