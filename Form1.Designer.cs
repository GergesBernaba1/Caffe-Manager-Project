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
	[Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
	public partial class Form1 : System.Windows.Forms.Form
	{
		//Form overrides dispose to clean up the component list.
		[System.Diagnostics.DebuggerNonUserCode()]
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing && components != null)
				{
					components.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		//Required by the Windows Form Designer
		private System.ComponentModel.IContainer components;

		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.  
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.Button2 = new System.Windows.Forms.Button();
			this.TextBox2 = new System.Windows.Forms.TextBox();
			this.TextBox3 = new System.Windows.Forms.TextBox();
			this.Label1 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label3 = new System.Windows.Forms.Label();
			this.Label4 = new System.Windows.Forms.Label();
			this.Timer1 = new System.Windows.Forms.Timer(this.components);
			this.Label5 = new System.Windows.Forms.Label();
			this.Label6 = new System.Windows.Forms.Label();
			this.ListBox1 = new System.Windows.Forms.ListBox();
			this.DataGridView1 = new System.Windows.Forms.DataGridView();
			this.TextBox1 = new System.Windows.Forms.TextBox();
			this.TextBox4 = new System.Windows.Forms.TextBox();
			this.TextBox5 = new System.Windows.Forms.TextBox();
			this.TextBox6 = new System.Windows.Forms.TextBox();
			this.TextBox7 = new System.Windows.Forms.TextBox();
			this.TextBox8 = new System.Windows.Forms.TextBox();
			this.TextBox9 = new System.Windows.Forms.TextBox();
			this.Label7 = new System.Windows.Forms.Label();
			this.TextBox10 = new System.Windows.Forms.TextBox();
			this.Timer2 = new System.Windows.Forms.Timer(this.components);
			this.Panel1 = new System.Windows.Forms.Panel();
			this.Panel2 = new System.Windows.Forms.Panel();
			this.Label8 = new System.Windows.Forms.Label();
			this.Panel3 = new System.Windows.Forms.Panel();
			this.Button1 = new System.Windows.Forms.Button();
			this.TextBox11 = new System.Windows.Forms.TextBox();
			this.Label9 = new System.Windows.Forms.Label();
			this.ListBox2 = new System.Windows.Forms.ListBox();
			this.Label10 = new System.Windows.Forms.Label();
			this.TextBox12 = new System.Windows.Forms.TextBox();
			this.Button3 = new System.Windows.Forms.Button();
			this.DataGridView2 = new System.Windows.Forms.DataGridView();
			this.TextBox13 = new System.Windows.Forms.TextBox();
			this.Button4 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)this.DataGridView1).BeginInit();
			this.Panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.DataGridView2).BeginInit();
			this.SuspendLayout();
			//
			//Button2
			//
			this.Button2.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(239)), Convert.ToInt32(Convert.ToByte(60)), Convert.ToInt32(Convert.ToByte(57)));
			this.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Button2.ForeColor = System.Drawing.Color.White;
			this.Button2.Location = new System.Drawing.Point(12, 52);
			this.Button2.Name = "Button2";
			this.Button2.Size = new System.Drawing.Size(75, 23);
			this.Button2.TabIndex = 2;
			this.Button2.Text = "Contact";
			this.Button2.UseVisualStyleBackColor = false;
			//
			//TextBox2
			//
			this.TextBox2.Location = new System.Drawing.Point(12, 26);
			this.TextBox2.Name = "TextBox2";
			this.TextBox2.Size = new System.Drawing.Size(129, 20);
			this.TextBox2.TabIndex = 5;
			this.TextBox2.Text = "127.0.0.1";
			//
			//TextBox3
			//
			this.TextBox3.Location = new System.Drawing.Point(147, 26);
			this.TextBox3.Name = "TextBox3";
			this.TextBox3.Size = new System.Drawing.Size(39, 20);
			this.TextBox3.TabIndex = 6;
			this.TextBox3.Text = "1997";
			//
			//Label1
			//
			this.Label1.AutoSize = true;
			this.Label1.BackColor = System.Drawing.Color.Transparent;
			this.Label1.ForeColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(70)), Convert.ToInt32(Convert.ToByte(70)), Convert.ToInt32(Convert.ToByte(70)));
			this.Label1.Location = new System.Drawing.Point(12, 10);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(22, 13);
			this.Label1.TabIndex = 7;
			this.Label1.Text = "ip :";
			//
			//Label2
			//
			this.Label2.AutoSize = true;
			this.Label2.BackColor = System.Drawing.Color.Transparent;
			this.Label2.ForeColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(70)), Convert.ToInt32(Convert.ToByte(70)), Convert.ToInt32(Convert.ToByte(70)));
			this.Label2.Location = new System.Drawing.Point(144, 10);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(34, 13);
			this.Label2.TabIndex = 8;
			this.Label2.Text = "port :";
			//
			//Label3
			//
			this.Label3.AutoSize = true;
			this.Label3.Location = new System.Drawing.Point(24, 157);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(23, 13);
			this.Label3.TabIndex = 9;
			this.Label3.Text = ">>";
			//
			//Label4
			//
			this.Label4.AutoSize = true;
			this.Label4.Location = new System.Drawing.Point(47, 157);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(11, 13);
			this.Label4.TabIndex = 10;
			this.Label4.Text = "-";
			//
			//Timer1
			//
			this.Timer1.Interval = 1000;
			//
			//Label5
			//
			this.Label5.AutoSize = true;
			this.Label5.Location = new System.Drawing.Point(120, 172);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(11, 13);
			this.Label5.TabIndex = 12;
			this.Label5.Text = "-";
			//
			//Label6
			//
			this.Label6.AutoSize = true;
			this.Label6.Location = new System.Drawing.Point(133, 172);
			this.Label6.Name = "Label6";
			this.Label6.Size = new System.Drawing.Size(23, 13);
			this.Label6.TabIndex = 11;
			this.Label6.Text = "<<";
			//
			//ListBox1
			//
			this.ListBox1.ForeColor = System.Drawing.Color.Black;
			this.ListBox1.FormattingEnabled = true;
			this.ListBox1.Location = new System.Drawing.Point(15, 93);
			this.ListBox1.Name = "ListBox1";
			this.ListBox1.Size = new System.Drawing.Size(174, 264);
			this.ListBox1.TabIndex = 13;
			//
			//DataGridView1
			//
			this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DataGridView1.Location = new System.Drawing.Point(579, 138);
			this.DataGridView1.Name = "DataGridView1";
			this.DataGridView1.Size = new System.Drawing.Size(237, 129);
			this.DataGridView1.TabIndex = 15;
			//
			//TextBox1
			//
			this.TextBox1.Location = new System.Drawing.Point(3, 56);
			this.TextBox1.Name = "TextBox1";
			this.TextBox1.Size = new System.Drawing.Size(100, 20);
			this.TextBox1.TabIndex = 16;
			this.TextBox1.Text = "id";
			this.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			//
			//TextBox4
			//
			this.TextBox4.Location = new System.Drawing.Point(3, 82);
			this.TextBox4.Name = "TextBox4";
			this.TextBox4.Size = new System.Drawing.Size(100, 20);
			this.TextBox4.TabIndex = 17;
			this.TextBox4.Text = "User";
			this.TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			//
			//TextBox5
			//
			this.TextBox5.Location = new System.Drawing.Point(3, 108);
			this.TextBox5.Name = "TextBox5";
			this.TextBox5.Size = new System.Drawing.Size(100, 20);
			this.TextBox5.TabIndex = 18;
			this.TextBox5.Text = "Pass";
			this.TextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			//
			//TextBox6
			//
			this.TextBox6.Location = new System.Drawing.Point(109, 56);
			this.TextBox6.Name = "TextBox6";
			this.TextBox6.Size = new System.Drawing.Size(100, 20);
			this.TextBox6.TabIndex = 19;
			this.TextBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			//
			//TextBox7
			//
			this.TextBox7.Location = new System.Drawing.Point(109, 82);
			this.TextBox7.Name = "TextBox7";
			this.TextBox7.Size = new System.Drawing.Size(100, 20);
			this.TextBox7.TabIndex = 20;
			this.TextBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			//
			//TextBox8
			//
			this.TextBox8.Location = new System.Drawing.Point(109, 108);
			this.TextBox8.Name = "TextBox8";
			this.TextBox8.Size = new System.Drawing.Size(100, 20);
			this.TextBox8.TabIndex = 21;
			this.TextBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			//
			//TextBox9
			//
			this.TextBox9.Location = new System.Drawing.Point(3, 134);
			this.TextBox9.Name = "TextBox9";
			this.TextBox9.Size = new System.Drawing.Size(206, 20);
			this.TextBox9.TabIndex = 22;
			this.TextBox9.Text = "time";
			this.TextBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			//
			//Label7
			//
			this.Label7.AutoSize = true;
			this.Label7.Location = new System.Drawing.Point(79, 14);
			this.Label7.Name = "Label7";
			this.Label7.Size = new System.Drawing.Size(54, 13);
			this.Label7.TabIndex = 23;
			this.Label7.Text = "< Login >";
			//
			//TextBox10
			//
			this.TextBox10.Location = new System.Drawing.Point(3, 30);
			this.TextBox10.Name = "TextBox10";
			this.TextBox10.Size = new System.Drawing.Size(206, 20);
			this.TextBox10.TabIndex = 24;
			this.TextBox10.Text = "ip";
			this.TextBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			//
			//Timer2
			//
			this.Timer2.Interval = 1000;
			//
			//Panel1
			//
			this.Panel1.Controls.Add(this.TextBox10);
			this.Panel1.Controls.Add(this.TextBox9);
			this.Panel1.Controls.Add(this.Label5);
			this.Panel1.Controls.Add(this.Label7);
			this.Panel1.Controls.Add(this.Label6);
			this.Panel1.Controls.Add(this.TextBox1);
			this.Panel1.Controls.Add(this.Label4);
			this.Panel1.Controls.Add(this.TextBox4);
			this.Panel1.Controls.Add(this.Label3);
			this.Panel1.Controls.Add(this.TextBox8);
			this.Panel1.Controls.Add(this.TextBox5);
			this.Panel1.Controls.Add(this.TextBox7);
			this.Panel1.Controls.Add(this.TextBox6);
			this.Panel1.Location = new System.Drawing.Point(907, 103);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new System.Drawing.Size(219, 186);
			this.Panel1.TabIndex = 25;
			//
			//Panel2
			//
			this.Panel2.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(70)), Convert.ToInt32(Convert.ToByte(70)), Convert.ToInt32(Convert.ToByte(70)));
			this.Panel2.Location = new System.Drawing.Point(-4, 371);
			this.Panel2.Name = "Panel2";
			this.Panel2.Size = new System.Drawing.Size(851, 25);
			this.Panel2.TabIndex = 26;
			//
			//Label8
			//
			this.Label8.AutoSize = true;
			this.Label8.BackColor = System.Drawing.Color.Transparent;
			this.Label8.ForeColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(70)), Convert.ToInt32(Convert.ToByte(70)), Convert.ToInt32(Convert.ToByte(70)));
			this.Label8.Location = new System.Drawing.Point(12, 77);
			this.Label8.Name = "Label8";
			this.Label8.Size = new System.Drawing.Size(44, 13);
			this.Label8.TabIndex = 27;
			this.Label8.Text = "Online :";
			//
			//Panel3
			//
			this.Panel3.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(70)), Convert.ToInt32(Convert.ToByte(70)), Convert.ToInt32(Convert.ToByte(70)));
			this.Panel3.Location = new System.Drawing.Point(196, -10);
			this.Panel3.Name = "Panel3";
			this.Panel3.Size = new System.Drawing.Size(10, 485);
			this.Panel3.TabIndex = 27;
			//
			//Button1
			//
			this.Button1.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(239)), Convert.ToInt32(Convert.ToByte(60)), Convert.ToInt32(Convert.ToByte(57)));
			this.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Button1.ForeColor = System.Drawing.Color.White;
			this.Button1.Location = new System.Drawing.Point(337, 24);
			this.Button1.Name = "Button1";
			this.Button1.Size = new System.Drawing.Size(85, 23);
			this.Button1.TabIndex = 28;
			this.Button1.Text = "Get processor";
			this.Button1.UseVisualStyleBackColor = false;
			//
			//TextBox11
			//
			this.TextBox11.Location = new System.Drawing.Point(216, 26);
			this.TextBox11.Name = "TextBox11";
			this.TextBox11.Size = new System.Drawing.Size(115, 20);
			this.TextBox11.TabIndex = 29;
			this.TextBox11.Text = "127.0.0.1";
			//
			//Label9
			//
			this.Label9.AutoSize = true;
			this.Label9.BackColor = System.Drawing.Color.Transparent;
			this.Label9.ForeColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(70)), Convert.ToInt32(Convert.ToByte(70)), Convert.ToInt32(Convert.ToByte(70)));
			this.Label9.Location = new System.Drawing.Point(213, 10);
			this.Label9.Name = "Label9";
			this.Label9.Size = new System.Drawing.Size(22, 13);
			this.Label9.TabIndex = 30;
			this.Label9.Text = "ip :";
			//
			//ListBox2
			//
			this.ListBox2.ForeColor = System.Drawing.Color.Black;
			this.ListBox2.FormattingEnabled = true;
			this.ListBox2.Location = new System.Drawing.Point(216, 54);
			this.ListBox2.Name = "ListBox2";
			this.ListBox2.Size = new System.Drawing.Size(174, 303);
			this.ListBox2.TabIndex = 31;
			//
			//Label10
			//
			this.Label10.AutoSize = true;
			this.Label10.BackColor = System.Drawing.Color.Transparent;
			this.Label10.ForeColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(70)), Convert.ToInt32(Convert.ToByte(70)), Convert.ToInt32(Convert.ToByte(70)));
			this.Label10.Location = new System.Drawing.Point(425, 10);
			this.Label10.Name = "Label10";
			this.Label10.Size = new System.Drawing.Size(43, 13);
			this.Label10.TabIndex = 34;
			this.Label10.Text = "name  :";
			//
			//TextBox12
			//
			this.TextBox12.Location = new System.Drawing.Point(428, 26);
			this.TextBox12.Name = "TextBox12";
			this.TextBox12.Size = new System.Drawing.Size(115, 20);
			this.TextBox12.TabIndex = 33;
			this.TextBox12.Text = "notepad";
			//
			//Button3
			//
			this.Button3.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(239)), Convert.ToInt32(Convert.ToByte(60)), Convert.ToInt32(Convert.ToByte(57)));
			this.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Button3.ForeColor = System.Drawing.Color.White;
			this.Button3.Location = new System.Drawing.Point(549, 24);
			this.Button3.Name = "Button3";
			this.Button3.Size = new System.Drawing.Size(44, 23);
			this.Button3.TabIndex = 32;
			this.Button3.Text = "Kill";
			this.Button3.UseVisualStyleBackColor = false;
			//
			//DataGridView2
			//
			this.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DataGridView2.Location = new System.Drawing.Point(316, 138);
			this.DataGridView2.Name = "DataGridView2";
			this.DataGridView2.Size = new System.Drawing.Size(240, 150);
			this.DataGridView2.TabIndex = 35;
			//
			//TextBox13
			//
			this.TextBox13.Location = new System.Drawing.Point(397, 311);
			this.TextBox13.Name = "TextBox13";
			this.TextBox13.Size = new System.Drawing.Size(100, 20);
			this.TextBox13.TabIndex = 36;
			//
			//Button4
			//
			this.Button4.Location = new System.Drawing.Point(471, 121);
			this.Button4.Name = "Button4";
			this.Button4.Size = new System.Drawing.Size(75, 20);
			this.Button4.TabIndex = 37;
			this.Button4.Text = "Button4";
			this.Button4.UseVisualStyleBackColor = true;
			//
			//Form1
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6.0F, 13.0F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(242)), Convert.ToInt32(Convert.ToByte(242)), Convert.ToInt32(Convert.ToByte(242)));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1208, 391);
			this.Controls.Add(this.DataGridView1);
			this.Controls.Add(this.Button4);
			this.Controls.Add(this.TextBox13);
			this.Controls.Add(this.DataGridView2);
			this.Controls.Add(this.Label10);
			this.Controls.Add(this.TextBox12);
			this.Controls.Add(this.Button3);
			this.Controls.Add(this.ListBox2);
			this.Controls.Add(this.Label9);
			this.Controls.Add(this.TextBox11);
			this.Controls.Add(this.Button1);
			this.Controls.Add(this.Panel3);
			this.Controls.Add(this.Label8);
			this.Controls.Add(this.Panel2);
			this.Controls.Add(this.ListBox1);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.TextBox3);
			this.Controls.Add(this.TextBox2);
			this.Controls.Add(this.Button2);
			this.Controls.Add(this.Panel1);
			this.DoubleBuffered = true;
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)this.DataGridView1).EndInit();
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.DataGridView2).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

//INSTANT C# NOTE: Converted event handler wireups:
			Button2.Click += new System.EventHandler(Button2_Click);
			Timer1.Tick += new System.EventHandler(Timer1_Tick);
			base.Load += new System.EventHandler(Form1_Load);
			ListBox1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(ListBox1_DrawItem);
			Timer2.Tick += new System.EventHandler(Timer2_Tick);
			Button1.Click += new System.EventHandler(Button1_Click);
			ListBox2.SelectedIndexChanged += new System.EventHandler(ListBox2_SelectedIndexChanged);
			Button3.Click += new System.EventHandler(Button3_Click_1);
			Button4.Click += new System.EventHandler(Button4_Click);
		}
		internal System.Windows.Forms.Button Button2;
		internal System.Windows.Forms.TextBox TextBox2;
		internal System.Windows.Forms.TextBox TextBox3;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.Timer Timer1;
		internal System.Windows.Forms.Label Label5;
		internal System.Windows.Forms.Label Label6;
		internal System.Windows.Forms.ListBox ListBox1;
		internal System.Windows.Forms.DataGridView DataGridView1;
		internal System.Windows.Forms.TextBox TextBox1;
		internal System.Windows.Forms.TextBox TextBox4;
		internal System.Windows.Forms.TextBox TextBox5;
		internal System.Windows.Forms.TextBox TextBox6;
		internal System.Windows.Forms.TextBox TextBox7;
		internal System.Windows.Forms.TextBox TextBox8;
		internal System.Windows.Forms.TextBox TextBox9;
		internal System.Windows.Forms.Label Label7;
		internal System.Windows.Forms.TextBox TextBox10;
		internal System.Windows.Forms.Timer Timer2;
		internal System.Windows.Forms.Panel Panel1;
		internal System.Windows.Forms.Panel Panel2;
		internal System.Windows.Forms.Label Label8;
		internal System.Windows.Forms.Panel Panel3;
		internal System.Windows.Forms.Button Button1;
		internal System.Windows.Forms.TextBox TextBox11;
		internal System.Windows.Forms.Label Label9;
		internal System.Windows.Forms.ListBox ListBox2;
		internal System.Windows.Forms.Label Label10;
		internal System.Windows.Forms.TextBox TextBox12;
		internal System.Windows.Forms.Button Button3;
		internal System.Windows.Forms.DataGridView DataGridView2;
		internal System.Windows.Forms.TextBox TextBox13;
		internal System.Windows.Forms.Button Button4;

	}

}