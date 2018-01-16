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

using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Data.OleDb;
namespace M.Coffee_shop___Coder36
{
	public partial class Form1
	{
		private bool InstanceFieldsInitialized = false;

		internal Form1()
		{
			if (!InstanceFieldsInitialized)
			{
				InitializeInstanceFields();
				InstanceFieldsInitialized = true;
			}

			InitializeComponent();
		}

//INSTANT C# NOTE: These were formerly VB static local variables:
		private int found_m = 0;
		private int uptime0_m = 0;
		private int Button4_Click_m = 0;

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
		private System.Net.Sockets.TcpClient clientSocket = new System.Net.Sockets.TcpClient();
		private NetworkStream serverStream;
		private string readData;
		private int infiniteCounter;
		private void msg()
		{
			if (this.InvokeRequired)
			{
				this.Invoke(new MethodInvoker(msg));
			}
			else
			{
				Label4.Text = readData;
				if0 = Convert.ToInt32("1");
			}
		}
		private void getMessage()
		{
			for (this.infiniteCounter = 1; this.infiniteCounter <= 2; this.infiniteCounter++)
			{
				infiniteCounter = 1;
				serverStream = clientSocket.GetStream();
				int buffSize = 0;
				byte[] inStream = new byte[10025];
				buffSize = clientSocket.ReceiveBufferSize;
				serverStream.Read(inStream, 0, buffSize);
				string returndata = System.Text.Encoding.ASCII.GetString(inStream);
				readData = "" + returndata;
				msg();
			}
		}
		public void SEND()
		{
			byte[] outStream = System.Text.Encoding.ASCII.GetBytes(Label5.Text + "$");
			serverStream.Write(outStream, 0, outStream.Length);
			serverStream.Flush();
		}

		private void Button2_Click(object sender, EventArgs e)
		{
			msg();
			clientSocket.Connect(TextBox2.Text, Convert.ToInt32(TextBox3.Text));
			serverStream = clientSocket.GetStream();
			byte[] outStream = System.Text.Encoding.ASCII.GetBytes(">" + "$");
			serverStream.Write(outStream, 0, outStream.Length);
			serverStream.Flush();
			System.Threading.Thread ctThread = new System.Threading.Thread(getMessage);
			ctThread.Start();
			Timer1.Start();
		}

		private void Button3_Click(object sender, EventArgs e)
		{
			string[] str = new string[3];
			ListViewItem itm = null;
			str[0] = "127.0.0.1";
			str[1] = "On";
			itm = new ListViewItem(str);
		}
		private int if0 = Convert.ToInt32("0");
		private void Timer1_Tick(object sender, EventArgs e)
		{
//INSTANT C# TODO TASK: The 'On Error Resume Next' statement is not converted by Instant C#:
			On Error Resume Next
			string sys = Label4.Text;
			string[] x = Microsoft.VisualBasic.Strings.Split(sys, "|1", -1, Microsoft.VisualBasic.CompareMethod.Binary);
			string[] x2 = Microsoft.VisualBasic.Strings.Split(sys, "|2", -1, Microsoft.VisualBasic.CompareMethod.Binary);
			string[] x3 = Microsoft.VisualBasic.Strings.Split(sys, "|4", -1, Microsoft.VisualBasic.CompareMethod.Binary);
			string ip = "0";
			string sty = "0";
			TextBox4.Text = x[1]; //user
			TextBox5.Text = x[2]; //pass
			TextBox1.Text = x[3]; //id
			TextBox10.Text = x[4]; //ip
			if (if0 == Convert.ToInt32("1")) // منع التكرار
			{
				found();
				if0 = Convert.ToInt32("0");
			}
			ip = x2[1];
			sty = x2[2];
			if (ip.Contains("."))
			{
				if (!string.IsNullOrEmpty("192.168.1.126"))
				{
					int index = ListBox1.FindString("192.168.1.126");
					if (index != -1)
					{
						ListBox1.SetSelected(index, true);
						ListBox1.Items.Remove(ListBox1.SelectedItem);
					}
					else
					{
						TextBox5.Text = "";
						ListBox1.Items.Add(ip + " - " + sty);
						Label4.Text = "";
						ip = "0";
						sty = "0";
					}
				}
			}
			if (Label4.Text.Contains("|4"))
			{
				string str = null;
				string[] strArr = null;
				int count = 0;
				str = Label4.Text;
				strArr = str.Split("|4");
				for (count = 1; count < x3.Length; count++)
				{
					if (x3[count].Contains(" "))
					{
					}
					else
					{
						ListBox2.Items.Add(x3[count]);
					}
				}
				Label4.Text = "";
			}
			string[] x4 = Microsoft.VisualBasic.Strings.Split(sys, "|up", -1, Microsoft.VisualBasic.CompareMethod.Binary);
			string id2 = null;
			if (sys.Contains("|up"))
			{

			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			Form2.DefaultInstance.Show();
			Timer1.Start();
			Timer2.Start();
			ListBox1.DrawMode = DrawMode.OwnerDrawFixed;
		}
		private void ListBox1_DrawItem(object sender, System.Windows.Forms.DrawItemEventArgs e)
		{
//INSTANT C# TODO TASK: The 'On Error Resume Next' statement is not converted by Instant C#:
			On Error Resume Next
			e.DrawBackground();
			if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
			{
				e.Graphics.FillRectangle(Brushes.ForestGreen, e.Bounds);
			}
			e.Graphics.DrawString(ListBox1.GetItemText(ListBox1.Items[e.Index]), e.Font, new SolidBrush(e.ForeColor), e.Bounds);
			e.DrawFocusRectangle();
		}
		private int if1 = Convert.ToInt32("1");
		private string msg0; //رد الرسالة
		public void found() // التحقق من المعلومات
		{
			if (if1 == Convert.ToInt32("1"))
			{
//INSTANT C# NOTE: VB local static variable moved to class level:
//				Static m As Integer = 0
				if (string.IsNullOrEmpty(TextBox1.Text).Trim(' '))
				{
					return;
				}
				SQLstr = "SELECT * FROM Table1 WHERE id LIKE '" + TextBox1.Text + "'";
				Conn.Open();
				OleDbDataAdapter DataAdapter1 = new OleDbDataAdapter(SQLstr, Conn);
				DataAdapter1.Fill(DataSet1, "Table1");
				Conn.Close();
				TextBox6.DataBindings.Add("Text", DataSet1, "Table1.id");
				TextBox7.DataBindings.Add("Text", DataSet1, "Table1.user");
				TextBox8.DataBindings.Add("Text", DataSet1, "Table1.pass");
				TextBox9.DataBindings.Add("Text", DataSet1, "Table1.time");
				DataGridView1.DataSource = DataSet1;
				DataGridView1.DataMember = "Table1";
				if (this.BindingContext[DataSet1, "Table1"].Count == 0)
				{
					return;
				}
			}
		}
		public void MSGS()
		{
			if (TextBox4.Text == TextBox7.Text)
			{
				if (TextBox5.Text == TextBox8.Text)
				{
					msg0 = "|3" + TextBox10.Text + "|3" + TextBox9.Text + "|3" + "run"; // قبول الاتصال
					SEND0();
				}
				else
				{
					msg0 = "|3" + TextBox10.Text + "ero"; // رفض
					SEND0();
				}
			}
			else
			{
				msg0 = "|3" + TextBox10.Text + "ero"; // رفض
				SEND0();
			}
		}
		public void SEND0()
		{
			byte[] outStream = System.Text.Encoding.ASCII.GetBytes(msg0 + "$");
			serverStream.Write(outStream, 0, outStream.Length);
			serverStream.Flush();
		}

		private void Timer2_Tick(object sender, EventArgs e)
		{
			if (TextBox1.Text == "id")
			{
			}
			else
			{
				MSGS();
				TextBox1.Text = "id";
			}
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			pro = "|5" + TextBox11.Text + "|5" + "proc";
			SEND1();
		}
		private string pro;
		private void ListBox2_SelectedIndexChanged(object sender, EventArgs e)
		{
			TextBox12.Text = ListBox2.SelectedItem.ToString();
		}
		public void SEND1()
		{
			byte[] outStream = System.Text.Encoding.ASCII.GetBytes(pro + "$");
			serverStream.Write(outStream, 0, outStream.Length);
			serverStream.Flush();
		}
		private void Button3_Click_1(object sender, EventArgs e)
		{
			pro = "|6" + TextBox11.Text + "|6" + TextBox12.Text;
			SEND1();
		}
		private string uptime = "5";
		public void uptime0()
		{
//INSTANT C# NOTE: VB local static variable moved to class level:
//			Static m As Integer = 0
			//On Error Resume Next
			if (string.IsNullOrEmpty(TextBox13.Text).Trim(' '))
			{
				return;
			}
			SQLstr = "SELECT * FROM Table1 WHERE id LIKE '" + TextBox13.Text + "'";
			Conn.Open();
			OleDbDataAdapter DataAdapter1 = new OleDbDataAdapter(SQLstr, Conn);
			DataAdapter1.Fill(DataSet1, "Table1");
			Conn.Close();
			TextBox6.DataBindings.Add("Text", DataSet1, "Table1.id");
			TextBox7.DataBindings.Add("Text", DataSet1, "Table1.user");
			TextBox8.DataBindings.Add("Text", DataSet1, "Table1.pass");
			TextBox9.DataBindings.Add("Text", DataSet1, "Table1.time");
			DataGridView1.DataSource = DataSet1;
			DataGridView1.DataMember = "Table1";
			if (this.BindingContext[DataSet1, "Table1"].Count == 0)
			{
				return;
			}
			OleDbDataAdapter adapter2 = new OleDbDataAdapter(SQLstr, Conn);
			System.Data.OleDb.OleDbCommand SavInto = new System.Data.OleDb.OleDbCommand();
			SavInto.Connection = Conn;
			SavInto.CommandType = CommandType.Text;
			SavInto.CommandText = "DELETE FROM Table1 WHERE id ='" + TextBox13.Text.Trim(' ') + "'";
			Conn.Open();
			SavInto.ExecuteNonQuery();
			DataSet1.Clear();
			adapter2.Fill(DataSet1, "Table1");
			Conn.Close();
			TextBox9.Text = uptime;
			Conn.Open();
			System.Data.OleDb.OleDbCommand cmd = new System.Data.OleDb.OleDbCommand();
			cmd.Connection = Conn; //, [Status] ', @Status
			cmd.CommandText = "insert into Table1([id], [user], [pass], [time]) VALUES(@id, @user, @pass, @time)";
			cmd.Parameters.AddWithValue("@id", TextBox6.Text);
			cmd.Parameters.AddWithValue("@user", TextBox7.Text);
			cmd.Parameters.AddWithValue("@pass", TextBox8.Text);
			cmd.Parameters.AddWithValue("@time", TextBox9.Text);
			cmd.ExecuteNonQuery();
			Conn.Close();
		}

		private void Button4_Click(object sender, EventArgs e)
		{
//INSTANT C# NOTE: VB local static variable moved to class level:
//			Static m As Integer = 0
			//On Error Resume Next
			if (string.IsNullOrEmpty(TextBox13.Text).Trim(' '))
			{
				return;
			}
			SQLstr = "SELECT * FROM Table1 WHERE id LIKE '" + TextBox13.Text + "'";
			Conn.Open();
			OleDbDataAdapter DataAdapter1 = new OleDbDataAdapter(SQLstr, Conn);
			DataAdapter1.Fill(DataSet1, "Table1");
			Conn.Close();
			TextBox6.DataBindings.Add("Text", DataSet1, "Table1.id");
			TextBox7.DataBindings.Add("Text", DataSet1, "Table1.user");
			TextBox8.DataBindings.Add("Text", DataSet1, "Table1.pass");
			TextBox9.DataBindings.Add("Text", DataSet1, "Table1.time");
			DataGridView1.DataSource = DataSet1;
			DataGridView1.DataMember = "Table1";
			if (this.BindingContext[DataSet1, "Table1"].Count == 0)
			{
				return;
			}
			string id = TextBox6.Text;
			string user = TextBox7.Text;
			string pass = TextBox8.Text;
			string time = TextBox9.Text;
			time = uptime;
			OleDbDataAdapter adapter2 = new OleDbDataAdapter(SQLstr, Conn);
			System.Data.OleDb.OleDbCommand SavInto = new System.Data.OleDb.OleDbCommand();
			SavInto.Connection = Conn;
			SavInto.CommandType = CommandType.Text;
			SavInto.CommandText = "DELETE FROM Table1 WHERE id ='" + TextBox13.Text.Trim(' ') + "'";
			Conn.Open();
			SavInto.ExecuteNonQuery();
			DataSet1.Clear();
			adapter2.Fill(DataSet1, "Table1");
			Conn.Close();
			Conn.Open();
			System.Data.OleDb.OleDbCommand cmd = new System.Data.OleDb.OleDbCommand();
			cmd.Connection = Conn; //, [Status] ', @Status
			cmd.CommandText = "insert into Table1([id], [user], [pass], [time]) VALUES(@id, @user, @pass, @time)";
			cmd.Parameters.AddWithValue("@id", id);
			cmd.Parameters.AddWithValue("@user", user);
			cmd.Parameters.AddWithValue("@pass", pass);
			cmd.Parameters.AddWithValue("@time", time);
			cmd.ExecuteNonQuery();
			Conn.Close();
		}

		private static Form1 _DefaultInstance;
		public static Form1 DefaultInstance
		{
			get
			{
				if (_DefaultInstance == null)
					_DefaultInstance = new Form1();

				return _DefaultInstance;
			}
		}
	}

}