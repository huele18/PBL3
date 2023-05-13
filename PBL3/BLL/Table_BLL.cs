using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using PBL3.DAL;
using PBL3.DTO;
using PBL3.GUI;

namespace PBL3.BLL
{
    public class Table_BLL
    {
        private static Table_BLL instance;
        public static Table_BLL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Table_BLL();
                }
                return instance;
            }
        }
        public List<TableFood> showDGV()
        {
            List<TableFood> list = new List<TableFood>();
            list = Table_DAL.Instance.getTableFoodList();
            return list;
        }
        public TableFood getTableFoodById(int id)
        {
            foreach(TableFood i in Table_DAL.Instance.getTableFoodList())
            {
                if(i.idTableFood == id)
                    return i;
            }
            return null;
        }
        public bool checkIDTable(int id)
        {
            if(getTableFoodById(id) == null)
            {
                return false; // không tồn tại
            }
            return true;
        }
        public bool checkData(TableFood tb)
        {
            if (checkIDTable(tb.idTableFood))
            {
                MessageBox.Show("ID bàn đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        public void addTable(TableFood tb)
        {
            if(checkData(tb))
            {
                Table_DAL.Instance.add(tb);
            }
        }
        public void editTable(TableFood tb)
        {
            Table_DAL.Instance.edit(tb);
        }
        public void delTable(int id)
        {
            Table_DAL.Instance.del(id);
        }
        public DataGridView searchTable(string s)
        {
            DataGridView dgv = new DataGridView();
            dgv.DataSource = Table_DAL.Instance.search(s).DataSource;
            return dgv;
        }
        public List<Button> GetTables()
        {
            List<Button> tables = new List<Button>();
            foreach(TableFood i in Table_DAL.Instance.getTableFoodList())
            {
                Button uc = new Button();
                uc.Size = new Size(200, 200);
                uc.Text = i.idTableFood.ToString();
                if (i.status == "Có Người") 
                    uc.BackColor = Color.FromArgb(176, 125, 55); 
                else 
                    uc.BackColor = Color.FromArgb(240, 226, 182);
                uc.Tag = i.idTableFood;
                tables.Add(uc);
            }
            return tables;
        }

        public List<CBBItem> setCBBTable()
        {
            return Table_DAL.Instance.GetCBBTable();
        }
    }
}
