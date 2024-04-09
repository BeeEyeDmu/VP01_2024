using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Interfaces;
using FireSharp.Config;
using FireSharp.Response;

namespace _022_firebase
{
  public partial class Form1 : Form
  {
    IFirebaseConfig config = new FirebaseConfig
    {
      AuthSecret = "btWERSK1LXtr37Qs27MSRzTBLmxAWJOggMhsjLZT",
      BasePath = "https://aaaaa-87c75-default-rtdb.firebaseio.com/"
    };
    IFirebaseClient client;

    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      client = new FireSharp.FirebaseClient(config);

      if(client != null )
      {
        MessageBox.Show("Connection 성공!");
      }
    }

    private async void btnInsert_Click(object sender, EventArgs e)
    {
      var data = new Data
      {
        Id = txtId.Text,
        SId = txtSId.Text,
        Name = txtName.Text,
        Phone = txtPhone.Text
      };

      SetResponse response =
        await client.SetAsync("Phonebook/" + txtId.Text, data);
      Data result = response.ResultAs<Data>();

      MessageBox.Show("Data Inserted! Id = " + result.Id);
    }

    private void btnClear_Click(object sender, EventArgs e)
    {
      txtId.Text = "";
      txtSId.Text = "";
      txtName.Text = "";
      txtPhone.Text = "";
    }

    private async void btnRetrieve_Click(object sender, EventArgs e)
    {
      if (txtId.Text == "")
        return;

      FirebaseResponse r 
        = await client.GetAsync("Phonebook/" + txtId.Text);

      Data d = r.ResultAs<Data>();
      
      if (d == null)
      {
        MessageBox.Show("Id가 " + txtId.Text + "인 데이터가 없습니다!");
        return;
      }

      txtId.Text = d.Id;
      txtSId.Text = d.SId;
      txtName.Text = d.Name;
      txtPhone.Text = d.Phone;

      MessageBox.Show("Data Retrieved successfully!");

    }

    private async void btnUpdate_Click(object sender, EventArgs e)
    {
      var data = new Data
      {
        Id = txtId.Text,
        Name = txtName.Text,
        Phone = txtPhone.Text,
        SId = txtSId.Text        
      };
      FirebaseResponse r = await 
        client.UpdateAsync("Phonebook/"+txtId.Text, data);

      Data d = r.ResultAs<Data>();

      MessageBox.Show("Data Updated Succefully! Id = " + d.Id);
    }

    private async void btnDelete_Click(object sender, EventArgs e)
    {
      FirebaseResponse r = await
        client.DeleteAsync("Phonebook/" + txtId.Text);
      MessageBox.Show("Deleted! : id = " + txtId.Text);
    }

    private async void btnDeleteAll_Click(object sender, EventArgs e)
    {
      FirebaseResponse r = await
        client.DeleteAsync("Phonebook");
      MessageBox.Show("All data at Phonebook/ Deleted!");
    }
  }
}
