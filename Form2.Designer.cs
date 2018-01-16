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
	[Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
	public partial class Form2 : System.Windows.Forms.Form
	{
		//Form overrides dispose to clean up the component list.
		private bool InstanceFieldsInitialized = false;

		public Form2()
		{
			if (!InstanceFieldsInitialized)
			{
				InitializeInstanceFields();
				InstanceFieldsInitialized = true;
			}
		}

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
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			this.Button1 = new System.Windows.Forms.Button();
			this.Button2 = new System.Windows.Forms.Button();
			this.TextBox1 = new System.Windows.Forms.TextBox();
			this.TextBox2 = new System.Windows.Forms.TextBox();
			this.TextBox3 = new System.Windows.Forms.TextBox();
			this.TextBox4 = new System.Windows.Forms.TextBox();
			this.DataGridView1 = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)this.DataGridView1).BeginInit();
			this.SuspendLayout();
			//
			//Button1
			//
			this.Button1.Location = new System.Drawing.Point(12, 115);
			this.Button1.Name = "Button1";
			this.Button1.Size = new System.Drawing.Size(75, 23);
			this.Button1.TabIndex = 0;
			this.Button1.Text = "Button1";
			this.Button1.UseVisualStyleBackColor = true;
			//
			//Button2
			//
			this.Button2.Location = new System.Drawing.Point(93, 115);
			this.Button2.Name = "Button2";
			this.Button2.Size = new System.Drawing.Size(75, 23);
			this.Button2.TabIndex = 1;
			this.Button2.Text = "Button2";
			this.Button2.UseVisualStyleBackColor = true;
			//
			//TextBox1
			//
			this.TextBox1.Location = new System.Drawing.Point(12, 11);
			this.TextBox1.Name = "TextBox1";
			this.TextBox1.Size = new System.Drawing.Size(163, 20);
			this.TextBox1.TabIndex = 2;
			this.TextBox1.Text = "id";
			//
			//TextBox2
			//
			this.TextBox2.Location = new System.Drawing.Point(12, 37);
			this.TextBox2.Name = "TextBox2";
			this.TextBox2.Size = new System.Drawing.Size(163, 20);
			this.TextBox2.TabIndex = 3;
			this.TextBox2.Text = "user";
			//
			//TextBox3
			//
			this.TextBox3.Location = new System.Drawing.Point(12, 63);
			this.TextBox3.Name = "TextBox3";
			this.TextBox3.Size = new System.Drawing.Size(163, 20);
			this.TextBox3.TabIndex = 4;
			this.TextBox3.Text = "pass";
			//
			//TextBox4
			//
			this.TextBox4.Location = new System.Drawing.Point(12, 89);
			this.TextBox4.Name = "TextBox4";
			this.TextBox4.Size = new System.Drawing.Size(163, 20);
			this.TextBox4.TabIndex = 5;
			this.TextBox4.Text = "time";
			//
			//DataGridView1
			//
			DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
			DataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8.0F);
			DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
			DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4;
			this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
			DataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 8.0F);
			DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
			DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.DataGridView1.DefaultCellStyle = DataGridViewCellStyle5;
			this.DataGridView1.Location = new System.Drawing.Point(181, 11);
			this.DataGridView1.Name = "DataGridView1";
			DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
			DataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 8.0F);
			DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
			DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle6;
			this.DataGridView1.Size = new System.Drawing.Size(341, 167);
			this.DataGridView1.TabIndex = 6;
			//
			//Form2
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6.0F, 13.0F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(534, 190);
			this.Controls.Add(this.DataGridView1);
			this.Controls.Add(this.TextBox4);
			this.Controls.Add(this.TextBox3);
			this.Controls.Add(this.TextBox2);
			this.Controls.Add(this.TextBox1);
			this.Controls.Add(this.Button2);
			this.Controls.Add(this.Button1);
			this.Name = "Form2";
			this.Text = "Form2";
			((System.ComponentModel.ISupportInitialize)this.DataGridView1).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

//INSTANT C# NOTE: Converted event handler wireups:
			base.Load += new System.EventHandler(Form2_Load);
			Button1.Click += new System.EventHandler(Button1_Click);
			Button2.Click += new System.EventHandler(Button2_Click);
		}
		internal System.Windows.Forms.Button Button1;
		internal System.Windows.Forms.Button Button2;
		internal System.Windows.Forms.TextBox TextBox1;
		internal System.Windows.Forms.TextBox TextBox2;
		internal System.Windows.Forms.TextBox TextBox3;
		internal System.Windows.Forms.TextBox TextBox4;
		internal System.Windows.Forms.DataGridView DataGridView1;

		private static Form2 _DefaultInstance;
		public static Form2 DefaultInstance
		{
			get
			{
				if (_DefaultInstance == null)
					_DefaultInstance = new Form2();

				return _DefaultInstance;
			}
		}
	}

}