using PBL3.BLL;
using PBL3.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace PBL3.GUI
{
    public partial class fStatisticManager : Form
    {
        public fStatisticManager()
        {
            InitializeComponent();
            GUI();
            setPieChart();
            setLineChart(DateTime.MinValue, DateTime.MaxValue);
        }

        private void setPieChart()
        {
            //chart2.Series["Quantity"].Points.Clear();
            chart2.DataSource = Drink_BLL.Instance.Sort();
            chart2.Series["Quantity"].XValueMember = "Key";
            chart2.Series["Quantity"].YValueMembers = "Value";
            chart2.DataBind();
        }
        private void setLineChart(DateTime start, DateTime end)
        {
            if (start <= end)
            {
                chart1.Series["FoodQuantity"].Points.Clear();
                // Cấu hình trục x
                chart1.ChartAreas[0].AxisX.Minimum = 0;
                chart1.ChartAreas[0].AxisX.Maximum = 24;
                chart1.ChartAreas[0].AxisX.Interval = 2;
                chart1.ChartAreas[0].AxisX.Title = "Hour of Day";

                // Cấu hình trục y
                chart1.ChartAreas[0].AxisY.Title = "Food Quantity";

                foreach (var food in Bill_BLL.Instance.hourly(start.Date, end.Date))
                {
                    chart1.Series["FoodQuantity"].Points.AddXY(food.Key, food.Value);
                }
            }
            else
                MessageBox.Show("Thời gian bắt đầu phải nhỏ hơn hoặc bằng thời gian kết thúc");
        }
        private void GUI()
        {
            lbRevenue.Text = Bill_BLL.Instance.totalRevenue() + " VNĐ";
            lbProduct.Text = Bill_BLL.Instance.totalDrink().ToString();
            lbBill.Text = Bill_BLL.Instance.totalBill() + " đơn";
            lbTable.Text = Table_BLL.Instance.rateOfTable();
        }
        private void btAdd_Click(object sender, EventArgs e)
        {
            setLineChart(dtpStart.Value, dtpEnd.Value);
        }
    }
}
