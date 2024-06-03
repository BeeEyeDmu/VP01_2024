﻿using System;
using System.Collections.Generic;
using System.Data;
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
using MySql.Data.MySqlClient;

namespace _033_EIS
{
  /// <summary>
  /// MainWindow.xaml에 대한 상호 작용 논리
  /// </summary>
  public partial class MainWindow : Window
  {
    private string pos; // 직급
    private string dept; // 부서
    private string gender;  // 성별
    private string dateEnter; // 입사일
    private string dateExit;  // 퇴사일

    string connStr = "server=localhost; user id=root; password=1234; database=eis_db";
    MySqlConnection conn;

    public MainWindow()
    {
      InitializeComponent();
      conn = new MySqlConnection(connStr);
    }

    private void btnInsert_Click(object sender, RoutedEventArgs e)
    {
      if (rbMale.IsChecked == true)
        gender = "남성";
      else if (rbFemale.IsChecked == true)
        gender = "여성";

      if (dpEnter.SelectedDate != null)
        dateEnter = dpEnter.SelectedDate.Value.Date.ToShortDateString();
      if(dpExit.SelectedDate != null)
        dateExit = dpExit.SelectedDate.Value.Date.ToShortDateString();
      else
        dateExit = DateTime.MaxValue.ToShortDateString();

      dept = cbDept.Text;
      pos = cbPos.Text;

      conn.Open();

      string sql = string.Format("INSERT INTO eis_table"+
        " (name, department, position, gender, date_enter,"+
        " date_exit, contact, comment) VALUES" +
        " ('{0}', '{1}','{2}','{3}','{4}','{5}','{6}','{7}')",
        txtName.Text, dept, pos, gender, 
        dateEnter, dateExit, txtContact.Text, txtComment.Text);

      //MessageBox.Show(sql);
      MySqlCommand cmd = new MySqlCommand(sql, conn);
      if(cmd.ExecuteNonQuery() == 1)
        MessageBox.Show("추가 성공!");

      conn.Close();
    }

    private void btnUpdate_Click(object sender, RoutedEventArgs e)
    {

    }

    private void btnDelete_Click(object sender, RoutedEventArgs e)
    {

    }

    private void btnLoadData_Click(object sender, RoutedEventArgs e)
    {
      conn.Open();

      string sql = "SELECT * FROM eis_table";
      
      MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
      DataSet ds = new DataSet();
      da.Fill(ds);
      dataGrid.ItemsSource = ds.Tables[0].DefaultView;

      conn.Close();
    }
  }
}