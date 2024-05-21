using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _032_WPFCalc
{
  /// <summary>
  /// MainWindow.xaml에 대한 상호 작용 논리
  /// </summary>
  public partial class MainWindow : Window
  {
    private double saved;
    private char op;
    private bool opFlag = false;
    private double memory = 0;

    public MainWindow()
    {
      InitializeComponent();
      txtExp.Text = "";
      txtResult.Text = "0";
    }

    // 숫자버튼
    private void btnClick(object sender, RoutedEventArgs e)
    {
      Button btn = (Button)sender;
      string s = btn.Content.ToString();

      if(txtResult.Text == "0" || opFlag == true)
      {
        txtResult.Text = s;
        opFlag = false;
      }
      else
      {
        txtResult.Text += s;
      }
    }

    // 소수점 버튼
    private void btnDot_Click(object sender, RoutedEventArgs e)
    {
      if(txtResult.Text.Contains(".")) 
        return;
      else
        txtResult.Text += ".";
    }

    // ± 버튼
    private void btnPlusMinus_Click(object sender, RoutedEventArgs e)
    {
      double v = Convert.ToDouble(txtResult.Text);
      txtResult.Text = (-v).ToString();
    }

    // 연산자 버튼
    private void btnOP_Click(object sender, RoutedEventArgs e)
    {
      Button btn = (Button)sender;

      saved = Double.Parse(txtResult.Text);
      op = (btn.Content.ToString())[0];
      opFlag = true;

      if(txtExp.Text == "")
        txtExp.Text += txtResult.Text + " " + btn.Content.ToString() + " ";
      else
        txtExp.Text = txtResult.Text + " " + btn.Content.ToString() + " "; 
    }

    // = 버튼
    private void btnEqual_Click(object sender, RoutedEventArgs e)
    {
      double value = double.Parse(txtResult.Text);

      txtExp.Text += txtResult.Text + " = ";

      switch (op)
      {
        case '+':
          txtResult.Text = (saved + value).ToString();
          break;
        case '-':
          txtResult.Text = (saved - value).ToString();
          break;
        case '×':
          txtResult.Text = (saved * value).ToString();
          break;
        case '÷':
          txtResult.Text = (saved / value).ToString();
          break;
      }
      
    }

    // 1/x
    private void btnRecip_Click(object sender, RoutedEventArgs e)
    {
      if (txtExp.Text == "")
        txtExp.Text = "1/(" + txtResult.Text + ")";
      else
        txtExp.Text = "1/(" + txtExp.Text + ")";

      double v = 1/double.Parse(txtResult.Text);
      txtResult.Text = v.ToString();
    }

    private void btnSqr_Click(object sender, RoutedEventArgs e)
    {
      if (txtExp.Text == "")
        txtExp.Text = "sqr(" + txtResult.Text + ")";
      else
        txtExp.Text = "sqr(" + txtExp.Text + ")";

      double v = double.Parse(txtResult.Text);
      txtResult.Text = (v*v).ToString();
    }

    private void btnSqrt_Click(object sender, RoutedEventArgs e)
    {
      if (txtExp.Text == "")
        txtExp.Text = "√(" + txtResult.Text + ")";
      else
        txtExp.Text = "√(" + txtExp.Text + ")";

      double v = double.Parse(txtResult.Text);
      txtResult.Text = (Math.Sqrt(v)).ToString();
    }

    private void btnCE_Click(object sender, RoutedEventArgs e)
    {
      txtResult.Text = "0";
    }

    private void btnC_Click(object sender, RoutedEventArgs e)
    {
      txtResult.Text = "0";
      txtExp.Text = "";
      saved = 0;
      op = '\0';
      opFlag = false;
    }

    private void btnDelete_Click(object sender, RoutedEventArgs e)
    {
      txtResult.Text = 
        txtResult.Text.Remove(txtResult.Text.Length - 1);

      if (txtResult.Text.Length == 0)
        txtResult.Text = "0";
    }

    private void btnMS_Click(object sender, RoutedEventArgs e)
    {
      memory = double.Parse(txtResult.Text);
      btnMC.IsEnabled = true;
      btnMR.IsEnabled = true;
    }

    private void btnMR_Click(object sender, RoutedEventArgs e)
    {
      txtResult.Text = memory.ToString();
    }

    private void btnMC_Click(object sender, RoutedEventArgs e)
    {
      memory = 0;
      btnMC.IsEnabled = false;
      btnMR.IsEnabled = false;
    }

    private void btnMPlus_Click(object sender, RoutedEventArgs e)
    {
      memory += double.Parse(txtResult.Text);
    }

    private void btnMMinus_Click(object sender, RoutedEventArgs e)
    {
      memory -= double.Parse(txtResult.Text);
    }
  }
}
