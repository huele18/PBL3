using PBL3.BLL;
using PBL3.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3.GUI
{
    public partial class fViewShift : Form
    {
        string thu;
        public fViewShift(string t)
        {
            InitializeComponent();
            thu = t;
            setDGV();
            //dataGridView1.DataSource = Shift_BLL.Instance.show(t).DataSource;
        }

        private void setDGV()
        {
            dataGridView1.DataSource = Shift_BLL.Instance.show(thu).DataSource;
        }
        private void btXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    int id = Convert.ToInt32(row.Cells["idPhanca"].Value);
                    Shift_BLL.Instance.remove(id);
                }
            }
            setDGV();
        }
    }
}
