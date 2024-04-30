using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace _025_SensorMonitoring
{
  public partial class Form1 : Form
  {
    SerialPort sPort = null;
    private double xCount = 200;
    // List<SensorData> myData = new List<SensorData>();

    // 시뮬레이션 용
    Timer t = new Timer();
    Random r = new Random();

    public Form1()
    {
      InitializeComponent();

      foreach(var ports in SerialPort.GetPortNames())
        comboBox1.Items.Add(ports);
      comboBox1.Text = "Select Port";

      progressBar1.Minimum = 0;
      progressBar1.Maximum = 1023;

      InitSetting();
      ChartSetting();
    }

    private void ChartSetting()
    {
      chart1.Titles.Add("조도");
      chart2.Titles.Add("온도/습도");

      chart1.ChartAreas.Clear();
      chart1.ChartAreas.Add("limu");

      chart1.Series.Clear();
      chart1.Series.Add("lumi");
      chart1.ChartAreas[0].AxisX.Minimum = 0;
      chart1.ChartAreas[0].AxisX.Maximum = xCount;
      chart1.ChartAreas[0].AxisX.Interval = xCount/4;
      chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.Gray;
      chart1.ChartAreas[0].AxisX.MajorGrid.LineDashStyle 
        = ChartDashStyle.Dash;

      chart1.ChartAreas[0].AxisY.Minimum = 0;
      chart1.ChartAreas[0].AxisY.Maximum = 800;
      chart1.ChartAreas[0].AxisY.Interval = 200;
      chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.Gray;
      chart1.ChartAreas[0].AxisY.MajorGrid.LineDashStyle 
        = ChartDashStyle.Dash;

      chart1.ChartAreas[0].BackColor = Color.Black;

      chart2.Series.Clear();
      chart2.Series.Add("temp");
      chart2.Series.Add("humi");

      chart2.ChartAreas[0].AxisX.Minimum = 0;
      chart2.ChartAreas[0].AxisX.Maximum = xCount;
      chart2.ChartAreas[0].AxisX.Interval = xCount / 4;
      chart2.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.Gray;
      chart2.ChartAreas[0].AxisX.MajorGrid.LineDashStyle
        = ChartDashStyle.Dash;

      chart2.ChartAreas[0].AxisY.Minimum = 0;
      chart2.ChartAreas[0].AxisY.Maximum = 100;
      chart2.ChartAreas[0].AxisY.Interval = 20;
      chart2.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.Gray;
      chart2.ChartAreas[0].AxisY.MajorGrid.LineDashStyle
        = ChartDashStyle.Dash;

      chart2.ChartAreas[0].BackColor = Color.Black;

      // Series 디자인
      chart1.Series[0].ChartType = SeriesChartType.Line;
      chart1.Series[0].Color = Color.LightGreen;
      chart1.Series[0].BorderWidth = 2;

      chart2.Series[0].Color = Color.LightBlue;
      chart2.Series[0].BorderWidth = 2;
      chart2.Series[0].ChartType = SeriesChartType.Line;

      chart2.Series[1].Color = Color.Orange;
      chart2.Series[1].BorderWidth = 2;
      chart2.Series[1].ChartType = SeriesChartType.Line;
    }

    private void InitSetting()
    {
      btnPortValue.BackColor = Color.Blue;
      btnPortValue.ForeColor = Color.White;
      btnPortValue.Text = "";
      btnPortValue.Font 
        = new Font("맑은 고딕", 12, FontStyle.Bold);

      lblConnectionTime.Text = "Connection time : ";
      txtCount.TextAlign = HorizontalAlignment.Center;
      btnConnect.Enabled = true;
      btnDisconnect.Enabled = false;
    }

    private void button2_Click(object sender, EventArgs e)
    {

    }

    private void 시작ToolStripMenuItem_Click(object sender, EventArgs e)
    {
      t.Interval = 1000;
      t.Tick += T_Tick;
      t.Start();
    }

    private void T_Tick(object sender, EventArgs e)
    {
      int value = r.Next(1024);
      ShowValue(value.ToString());
    }

    private void ShowValue(string v)
    {
      listBox1.Items.Add(v);
      listBox1.SelectedIndex = listBox1.Items.Count - 1;
      progressBar1.Value = int.Parse(v);
      chart1.Series[0].Points.Add(int.Parse(v));
    }
  }
}
