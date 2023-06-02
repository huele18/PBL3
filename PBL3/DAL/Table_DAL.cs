﻿using System;
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
        public TableFood getTableById(int id)
        {
            using (QuanLyQuanCafeEntities3 db = new QuanLyQuanCafeEntities3())
            {
                foreach (TableFood f in db.TableFoods)
                {
                    if (f.idTableFood == id)
                    {
                        return f;
                    }
                }
            }
            return null;
        }
        public TableFood getTableByName(string name)
        {
            using (QuanLyQuanCafeEntities3 db = new QuanLyQuanCafeEntities3())
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
        public List<TableFood> getTableFoodList()
        {
            List<TableFood> table = new List<TableFood>();
            using (QuanLyQuanCafeEntities3 db = new QuanLyQuanCafeEntities3())
            {
                table.AddRange(db.TableFoods.ToList());
            }
            return table;
        }
        public void add(TableFood tf)
        {
            using (QuanLyQuanCafeEntities3 db = new QuanLyQuanCafeEntities3())
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
            using (QuanLyQuanCafeEntities3 db = new QuanLyQuanCafeEntities3())
            {
                table.DataSource = db.TableFoods
                    .Where(p => p.name.ToUpper().Contains(search.ToUpper()))
                    .Select(p => new { p.idTableFood, p.name, p.status }).ToList();
            }
            return table;
        }
        public void edit(TableFood after)
        {
            using (QuanLyQuanCafeEntities3 db = new QuanLyQuanCafeEntities3())
            {
                TableFood tf = db.TableFoods.Find(after.idTableFood);
                tf.name = after.name;
                tf.status = after.status;
                db.SaveChanges();
                MessageBox.Show("Đã cập nhật thành công thông tin bàn", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void del(int idtable)
        {
            using (QuanLyQuanCafeEntities3 db = new QuanLyQuanCafeEntities3())
            {   
                TableFood tf = db.TableFoods.Find(idtable);
                db.TableFoods.Remove(tf);
                db.SaveChanges();
            }
        }
        public List<CBBItem> GetCBBTable()
        {
            List<CBBItem> cbb = new List<CBBItem>();
            using (QuanLyQuanCafeEntities3 db = new QuanLyQuanCafeEntities3())
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
        public int getTableIDByName(string name)
        {
            using (QuanLyQuanCafeEntities3 db = new QuanLyQuanCafeEntities3())
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
    }
}
