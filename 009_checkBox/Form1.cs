﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _009_checkBox
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      string checkStates = "";
      CheckBox[] cBox = {checkBox1, checkBox2,
        checkBox3,checkBox4, checkBox5};

      foreach(var item in cBox)
      {
        checkStates += string.Format("{0} : {1}\n",
          item.Text, item.Checked);
      }
      MessageBox.Show(checkStates, "Summary");

      string summary = "좋아하는 과일은 ";
      foreach(var item in cBox)
      {
        if (item.Checked == true)
          summary += item.Text + " ";
      }

      MessageBox.Show(summary, "Summary");
    }
  }
}
