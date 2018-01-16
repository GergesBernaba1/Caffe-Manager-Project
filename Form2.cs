//INSTANT C# NOTE: Formerly VB project-level imports:
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.Linq;
using System.Xml.Linq;
using System.Threading.Tasks;

using System.Data.OleDb;
namespace M.Coffee_shop___Coder36
{
	public partial class Form2
	{
		private bool InstanceFieldsInitialized = false;

//INSTANT C# NOTE: These were formerly VB static local variables:
		private int Button2_Click_m = 0;

			private void InitializeInstanceFields()
			{
				Conn = new OleDbConnection(Cnn);
			}

		private string gender;
		private byte[] bytimage;
		private string SQLstr;
		private DataSet DataSet1 = new DataSet();
		private string Cnn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source = C:\\Users\\User\\Desktop\\Coder.mdb";
		private OleDbConnection Conn;
		private OpenFileDialog Op = new OpenFileDialog();
		private byte[] BB;
		private void Form2_Load(object sender, EventArgs e)
		{
			//;()
		}
		private void Button1_Click(object sender, EventArgs e)
		{
			Conn.Open();
			System.Data.OleDb.OleDbCommand cmd = new System.Data.OleDb.OleDbCommand();
			cmd.Connection = Conn; //, [Status] ', @Status
			cmd.CommandText = "insert into Table1([id], [user], [pass], [time]) VALUES(@id, @user, @pass, @time)";
			cmd.Parameters.AddWithValue("@id", TextBox1.Text);
			cmd.Parameters.AddWithValue("@user", TextBox2.Text);
			cmd.Parameters.AddWithValue("@pass", TextBox3.Text);
			cmd.Parameters.AddWithValue("@time", TextBox4.Text);
			cmd.ExecuteNonQuery();
			Conn.Close();
		}

		private void Button2_Click(object sender, EventArgs e)
		{
//INSTANT C# NOTE: VB local static variable moved to class level:
//			Static m As Integer = 0
			if (string.IsNullOrEmpty(TextBox1.Text).Trim(' '))
			{
				return;
			}
			SQLstr = "SELECT * FROM Table1 WHERE id LIKE '%" + TextBox1.Text + "%'";
			Conn.Open();
			OleDbDataAdapter DataAdapter1 = new OleDbDataAdapter(SQLstr, Conn);
			DataAdapter1.Fill(DataSet1, "Table1");
			Conn.Close();
			TextBox2.DataBindings.Add("Text", DataSet1, "Table1.user");
			TextBox3.DataBindings.Add("Text", DataSet1, "Table1.pass");
			TextBox4.DataBindings.Add("Text", DataSet1, "Table1.time");
			DataGridView1.DataSource = DataSet1;
			DataGridView1.DataMember = "Table1";
			Button1.Enabled = false;
			if (this.BindingContext[DataSet1, "Table1"].Count == 0)
			{
				MessageBox.Show("No Result, Please Try Again ");
				return;
			}
		}
	}
}