using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _007_MessageBoxes
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      //MessageBox.Show("안녕");
      //MessageBox.Show("안녕하세요", "Hello");
      //MessageBox.Show("두개의 버튼",
      //  "Question",
      //  MessageBoxButtons.YesNo);
      //MessageBox.Show("세개의 버튼과 물음표", "Question",
      //  MessageBoxButtons.YesNoCancel,
      //  MessageBoxIcon.Question);

      DialogResult result = MessageBox.Show("세개의 버튼과 물음표", "Question",
        MessageBoxButtons.YesNoCancel,
        MessageBoxIcon.Question,
        MessageBoxDefaultButton.Button2);

      if(result == DialogResult.Yes) { }
      else if(result == DialogResult.No) { }


      // <Ctrl-KC> : Comment로 만들기
      // <Ctrl-KU> : UnComment로 만들기

      //MessageBox.Show("느낌표와 알람","Title",
      //  MessageBoxButtons.OK,
      //  MessageBoxIcon.Exclamation);
    }
  }
}
