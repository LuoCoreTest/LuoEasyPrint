﻿namespace LuoEasyPrint
{
	// Token: 0x0200000C RID: 12
	
	
	public partial class PivotTableView : Form
	{
		// Token: 0x06000094 RID: 148 RVA: 0x0000C81C File Offset: 0x0000AA1C
		[System.Diagnostics.DebuggerNonUserCode]
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing && this.components != null)
				{
					this.components.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		// Token: 0x06000095 RID: 149 RVA: 0x0000C85C File Offset: 0x0000AA5C
		[System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager componentResourceManager = new System.ComponentModel.ComponentResourceManager(typeof(PivotTableView));
			this.tv1 = new System.Windows.Forms.TreeView();
			this.ContextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.ToolStripMenuItem_0 = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenuItem_1 = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.ToolStripMenuItem_2 = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenuItem_3 = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
			this.ToolStripButton5 = new System.Windows.Forms.ToolStripButton();
			this.ToolStripButton6 = new System.Windows.Forms.ToolStripButton();
			this.ToolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.ToolStripButton1 = new System.Windows.Forms.ToolStripButton();
			this.ToolStripButton2 = new System.Windows.Forms.ToolStripButton();
			this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.ToolStripButton4 = new System.Windows.Forms.ToolStripButton();
			this.ToolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.ToolStripButton3 = new System.Windows.Forms.ToolStripButton();
			this.SplitContainer1 = new System.Windows.Forms.SplitContainer();
			this.zt = new System.Windows.Forms.Label();
			this.Label5 = new System.Windows.Forms.Label();
			this.c1 = new System.Windows.Forms.CheckBox();
			this.cc = new System.Windows.Forms.Button();
			this.Button11 = new System.Windows.Forms.Button();
			this.GroupBox4 = new System.Windows.Forms.GroupBox();
			this.ComboBox2 = new System.Windows.Forms.ComboBox();
			this.formatbotton = new System.Windows.Forms.Button();
			this.Label4 = new System.Windows.Forms.Label();
			this.TextBox2 = new System.Windows.Forms.TextBox();
			this.TextBox1 = new System.Windows.Forms.TextBox();
			this.Label1 = new System.Windows.Forms.Label();
			this.Label6 = new System.Windows.Forms.Label();
			this.Label3 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.ComboBox1 = new System.Windows.Forms.ComboBox();
			this.ListBox4 = new System.Windows.Forms.ListBox();
			this.Button7 = new System.Windows.Forms.Button();
			this.Button8 = new System.Windows.Forms.Button();
			this.Button9 = new System.Windows.Forms.Button();
			this.GroupBox3 = new System.Windows.Forms.GroupBox();
			this.ListBox3 = new System.Windows.Forms.ListBox();
			this.Button4 = new System.Windows.Forms.Button();
			this.Button5 = new System.Windows.Forms.Button();
			this.Button6 = new System.Windows.Forms.Button();
			this.GroupBox2 = new System.Windows.Forms.GroupBox();
			this.ListBox2 = new System.Windows.Forms.ListBox();
			this.Button2 = new System.Windows.Forms.Button();
			this.Button3 = new System.Windows.Forms.Button();
			this.Button1 = new System.Windows.Forms.Button();
			this.GroupBox1 = new System.Windows.Forms.GroupBox();
			this.ListBox1 = new System.Windows.Forms.ListBox();
			this.d1 = new MulHeaderDataGridView();
			this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.SaveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.OpenFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.ContextMenuStrip1.SuspendLayout();
			this.ToolStrip1.SuspendLayout();
			this.SplitContainer1.Panel1.SuspendLayout();
			this.SplitContainer1.Panel2.SuspendLayout();
			this.SplitContainer1.SuspendLayout();
			this.GroupBox4.SuspendLayout();
			this.GroupBox3.SuspendLayout();
			this.GroupBox2.SuspendLayout();
			this.GroupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.d1).BeginInit();
			this.SuspendLayout();
			System.Windows.Forms.Control tv = this.tv1;
			System.Drawing.Point location = new System.Drawing.Point(586, 304);
			tv.Location = location;
			this.tv1.Name = "tv1";
			System.Windows.Forms.Control tv2 = this.tv1;
			System.Drawing.Size size = new System.Drawing.Size(121, 97);
			tv2.Size = size;
			this.tv1.TabIndex = 1;
			this.tv1.Visible = false;
			this.ContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[]
			{
				this.ToolStripMenuItem_0,
				this.ToolStripMenuItem_1,
				this.ToolStripMenuItem1,
				this.ToolStripMenuItem_2,
				this.ToolStripMenuItem_3
			});
			this.ContextMenuStrip1.Name = "ContextMenuStrip1";
			System.Windows.Forms.Control contextMenuStrip = this.ContextMenuStrip1;
			size = new System.Drawing.Size(149, 98);
			contextMenuStrip.Size = size;
			this.ToolStripMenuItem_0.Name = "复制选中内容ToolStripMenuItem";
			System.Windows.Forms.ToolStripItem toolStripItem = this.ToolStripMenuItem_0;
			size = new System.Drawing.Size(148, 22);
			toolStripItem.Size = size;
			this.ToolStripMenuItem_0.Text = "复制选中内容";
			this.ToolStripMenuItem_1.Name = "选中内容求和ToolStripMenuItem";
			System.Windows.Forms.ToolStripItem toolStripItem2 = this.ToolStripMenuItem_1;
			size = new System.Drawing.Size(148, 22);
			toolStripItem2.Size = size;
			this.ToolStripMenuItem_1.Text = "选中内容求和";
			this.ToolStripMenuItem1.Name = "ToolStripMenuItem1";
			System.Windows.Forms.ToolStripItem toolStripMenuItem = this.ToolStripMenuItem1;
			size = new System.Drawing.Size(145, 6);
			toolStripMenuItem.Size = size;
			this.ToolStripMenuItem_2.Name = "数据导出ToolStripMenuItem";
			System.Windows.Forms.ToolStripItem toolStripItem3 = this.ToolStripMenuItem_2;
			size = new System.Drawing.Size(148, 22);
			toolStripItem3.Size = size;
			this.ToolStripMenuItem_2.Text = "数据导出";
			this.ToolStripMenuItem_3.Name = "打印ToolStripMenuItem";
			System.Windows.Forms.ToolStripItem toolStripItem4 = this.ToolStripMenuItem_3;
			size = new System.Drawing.Size(148, 22);
			toolStripItem4.Size = size;
			this.ToolStripMenuItem_3.Text = "打印";
			this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[]
			{
				this.ToolStripButton5,
				this.ToolStripButton6,
				this.ToolStripSeparator3,
				this.ToolStripButton1,
				this.ToolStripButton2,
				this.ToolStripSeparator1,
				this.ToolStripButton4,
				this.ToolStripSeparator2,
				this.ToolStripButton3
			});
			System.Windows.Forms.Control toolStrip = this.ToolStrip1;
			location = new System.Drawing.Point(0, 0);
			toolStrip.Location = location;
			this.ToolStrip1.Name = "ToolStrip1";
			System.Windows.Forms.Control toolStrip2 = this.ToolStrip1;
			size = new System.Drawing.Size(845, 25);
			toolStrip2.Size = size;
			this.ToolStrip1.TabIndex = 2;
			this.ToolStrip1.Text = "ToolStrip1";
			this.ToolStripButton5.Image = Properties.Resources.save;
			this.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.ToolStripButton5.Name = "ToolStripButton5";
			System.Windows.Forms.ToolStripItem toolStripButton = this.ToolStripButton5;
			size = new System.Drawing.Size(76, 22);
			toolStripButton.Size = size;
			this.ToolStripButton5.Text = "保存方案";
			this.ToolStripButton6.Image = Properties.Resources.open;
			this.ToolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.ToolStripButton6.Name = "ToolStripButton6";
			System.Windows.Forms.ToolStripItem toolStripButton2 = this.ToolStripButton6;
			size = new System.Drawing.Size(76, 22);
			toolStripButton2.Size = size;
			this.ToolStripButton6.Text = "打开方案";
			this.ToolStripSeparator3.Name = "ToolStripSeparator3";
			System.Windows.Forms.ToolStripItem toolStripSeparator = this.ToolStripSeparator3;
			size = new System.Drawing.Size(6, 25);
			toolStripSeparator.Size = size;
			this.ToolStripButton1.Image = Properties.Resources.printer1;
			this.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.ToolStripButton1.Name = "ToolStripButton1";
			System.Windows.Forms.ToolStripItem toolStripButton3 = this.ToolStripButton1;
			size = new System.Drawing.Size(52, 22);
			toolStripButton3.Size = size;
			this.ToolStripButton1.Text = "打印";
			this.ToolStripButton2.Image = Properties.Resources.Excel;
			this.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.ToolStripButton2.Name = "ToolStripButton2";
			System.Windows.Forms.ToolStripItem toolStripButton4 = this.ToolStripButton2;
			size = new System.Drawing.Size(76, 22);
			toolStripButton4.Size = size;
			this.ToolStripButton2.Text = "导出数据";
			this.ToolStripSeparator1.Name = "ToolStripSeparator1";
			System.Windows.Forms.ToolStripItem toolStripSeparator2 = this.ToolStripSeparator1;
			size = new System.Drawing.Size(6, 25);
			toolStripSeparator2.Size = size;
			this.ToolStripButton4.Image = Properties.Resources.uncheck;
			this.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.ToolStripButton4.Name = "ToolStripButton4";
			System.Windows.Forms.ToolStripItem toolStripButton5 = this.ToolStripButton4;
			size = new System.Drawing.Size(81, 22);
			toolStripButton5.Size = size;
			this.ToolStripButton4.Text = "显示/隐藏";
			this.ToolStripButton4.ToolTipText = "显示或隐藏汇总列设置";
			this.ToolStripSeparator2.Name = "ToolStripSeparator2";
			System.Windows.Forms.ToolStripItem toolStripSeparator3 = this.ToolStripSeparator2;
			size = new System.Drawing.Size(6, 25);
			toolStripSeparator3.Size = size;
			this.ToolStripButton3.Image = Properties.Resources.exit2;
			this.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.ToolStripButton3.Name = "ToolStripButton3";
			System.Windows.Forms.ToolStripItem toolStripButton6 = this.ToolStripButton3;
			size = new System.Drawing.Size(52, 22);
			toolStripButton6.Size = size;
			this.ToolStripButton3.Text = "退出";
			this.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			System.Windows.Forms.Control splitContainer = this.SplitContainer1;
			location = new System.Drawing.Point(0, 25);
			splitContainer.Location = location;
			this.SplitContainer1.Name = "SplitContainer1";
			this.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			this.SplitContainer1.Panel1.Controls.Add(this.zt);
			this.SplitContainer1.Panel1.Controls.Add(this.Label5);
			this.SplitContainer1.Panel1.Controls.Add(this.c1);
			this.SplitContainer1.Panel1.Controls.Add(this.cc);
			this.SplitContainer1.Panel1.Controls.Add(this.Button11);
			this.SplitContainer1.Panel1.Controls.Add(this.GroupBox4);
			this.SplitContainer1.Panel1.Controls.Add(this.GroupBox3);
			this.SplitContainer1.Panel1.Controls.Add(this.GroupBox2);
			this.SplitContainer1.Panel1.Controls.Add(this.GroupBox1);
			this.SplitContainer1.Panel1MinSize = 1;
			this.SplitContainer1.Panel2.Controls.Add(this.d1);
			this.SplitContainer1.Panel2MinSize = 1;
			System.Windows.Forms.Control splitContainer2 = this.SplitContainer1;
			size = new System.Drawing.Size(845, 388);
			splitContainer2.Size = size;
			this.SplitContainer1.SplitterDistance = 199;
			this.SplitContainer1.TabIndex = 3;
			this.zt.ForeColor = System.Drawing.Color.Red;
			System.Windows.Forms.Control zt = this.zt;
			location = new System.Drawing.Point(610, 108);
			zt.Location = location;
			this.zt.Name = "zt";
			System.Windows.Forms.Control zt2 = this.zt;
			size = new System.Drawing.Size(232, 57);
			zt2.Size = size;
			this.zt.TabIndex = 5;
			this.zt.Text = "dd";
			this.zt.Visible = false;
			this.Label5.ForeColor = System.Drawing.Color.Black;
			System.Windows.Forms.Control label = this.Label5;
			location = new System.Drawing.Point(609, 7);
			label.Location = location;
			this.Label5.Name = "Label5";
			System.Windows.Forms.Control label2 = this.Label5;
			size = new System.Drawing.Size(233, 101);
			label2.Size = size;
			this.Label5.TabIndex = 5;
			this.Label5.Text = "注1：请从\"可供选择的全部列\"列表中拖动列到相应的列表框中。\r\n注2：只有选择了\"数据列（Z轴）\"才会自动刷新。\r\n注3：双击汇总表中的行可查看相应的明细数据。\r\n注4：行列组合的数据不能太多，否则会影响汇总速度。";
			this.c1.AutoSize = true;
			System.Windows.Forms.Control c = this.c1;
			location = new System.Drawing.Point(615, 172);
			c.Location = location;
			this.c1.Name = "c1";
			System.Windows.Forms.Control c2 = this.c1;
			size = new System.Drawing.Size(72, 16);
			c2.Size = size;
			this.c1.TabIndex = 4;
			this.c1.Text = "自动刷新";
			this.c1.UseVisualStyleBackColor = true;
			this.cc.Enabled = false;
			System.Windows.Forms.Control cc = this.cc;
			location = new System.Drawing.Point(768, 168);
			cc.Location = location;
			this.cc.Name = "cc";
			System.Windows.Forms.Control cc2 = this.cc;
			size = new System.Drawing.Size(65, 23);
			cc2.Size = size;
			this.cc.TabIndex = 3;
			this.cc.Text = "停止汇总";
			this.cc.UseVisualStyleBackColor = true;
			System.Windows.Forms.Control button = this.Button11;
			location = new System.Drawing.Point(689, 168);
			button.Location = location;
			this.Button11.Name = "Button11";
			System.Windows.Forms.Control button2 = this.Button11;
			size = new System.Drawing.Size(75, 23);
			button2.Size = size;
			this.Button11.TabIndex = 3;
			this.Button11.Text = "立即刷新";
			this.Button11.UseVisualStyleBackColor = true;
			this.GroupBox4.Controls.Add(this.ComboBox2);
			this.GroupBox4.Controls.Add(this.formatbotton);
			this.GroupBox4.Controls.Add(this.Label4);
			this.GroupBox4.Controls.Add(this.TextBox2);
			this.GroupBox4.Controls.Add(this.TextBox1);
			this.GroupBox4.Controls.Add(this.Label1);
			this.GroupBox4.Controls.Add(this.Label6);
			this.GroupBox4.Controls.Add(this.Label3);
			this.GroupBox4.Controls.Add(this.Label2);
			this.GroupBox4.Controls.Add(this.ComboBox1);
			this.GroupBox4.Controls.Add(this.ListBox4);
			this.GroupBox4.Controls.Add(this.Button7);
			this.GroupBox4.Controls.Add(this.Button8);
			this.GroupBox4.Controls.Add(this.Button9);
			System.Windows.Forms.Control groupBox = this.GroupBox4;
			location = new System.Drawing.Point(166, 97);
			groupBox.Location = location;
			this.GroupBox4.Name = "GroupBox4";
			System.Windows.Forms.Control groupBox2 = this.GroupBox4;
			size = new System.Drawing.Size(438, 96);
			groupBox2.Size = size;
			this.GroupBox4.TabIndex = 2;
			this.GroupBox4.TabStop = false;
			this.GroupBox4.Text = "数据列（Z轴）";
			this.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ComboBox2.Enabled = false;
			this.ComboBox2.FormattingEnabled = true;
			this.ComboBox2.Items.AddRange(new object[]
			{
				"",
				"求和",
				"计数",
				"最大值",
				"最小值",
				"平均值"
			});
			System.Windows.Forms.Control comboBox = this.ComboBox2;
			location = new System.Drawing.Point(363, 11);
			comboBox.Location = location;
			this.ComboBox2.Name = "ComboBox2";
			System.Windows.Forms.Control comboBox2 = this.ComboBox2;
			size = new System.Drawing.Size(66, 20);
			comboBox2.Size = size;
			this.ComboBox2.TabIndex = 36;
			this.formatbotton.Enabled = false;
			System.Windows.Forms.Control formatbotton = this.formatbotton;
			location = new System.Drawing.Point(373, 32);
			formatbotton.Location = location;
			this.formatbotton.Name = "formatbotton";
			System.Windows.Forms.Control formatbotton2 = this.formatbotton;
			size = new System.Drawing.Size(57, 23);
			formatbotton2.Size = size;
			this.formatbotton.TabIndex = 35;
			this.formatbotton.Text = "设置...";
			this.formatbotton.UseVisualStyleBackColor = true;
			this.Label4.AutoSize = true;
			this.Label4.ForeColor = System.Drawing.Color.Red;
			System.Windows.Forms.Control label3 = this.Label4;
			location = new System.Drawing.Point(197, 81);
			label3.Location = location;
			this.Label4.Name = "Label4";
			System.Windows.Forms.Control label4 = this.Label4;
			size = new System.Drawing.Size(167, 12);
			label4.Size = size;
			this.Label4.TabIndex = 5;
			this.Label4.Text = "注：数据列至少必须选择1列。";
			this.TextBox2.Enabled = false;
			System.Windows.Forms.Control textBox = this.TextBox2;
			location = new System.Drawing.Point(337, 56);
			textBox.Location = location;
			this.TextBox2.Name = "TextBox2";
			System.Windows.Forms.Control textBox2 = this.TextBox2;
			size = new System.Drawing.Size(95, 21);
			textBox2.Size = size;
			this.TextBox2.TabIndex = 4;
			this.TextBox1.Enabled = false;
			System.Windows.Forms.Control textBox3 = this.TextBox1;
			location = new System.Drawing.Point(270, 34);
			textBox3.Location = location;
			this.TextBox1.Name = "TextBox1";
			System.Windows.Forms.Control textBox4 = this.TextBox1;
			size = new System.Drawing.Size(102, 21);
			textBox4.Size = size;
			this.TextBox1.TabIndex = 4;
			this.Label1.AutoSize = true;
			System.Windows.Forms.Control label5 = this.Label1;
			location = new System.Drawing.Point(300, 15);
			label5.Location = location;
			this.Label1.Name = "Label1";
			System.Windows.Forms.Control label6 = this.Label1;
			size = new System.Drawing.Size(65, 12);
			label6.Size = size;
			this.Label1.TabIndex = 3;
			this.Label1.Text = "计算类型：";
			this.Label6.AutoSize = true;
			System.Windows.Forms.Control label7 = this.Label6;
			location = new System.Drawing.Point(192, 62);
			label7.Location = location;
			this.Label6.Name = "Label6";
			System.Windows.Forms.Control label8 = this.Label6;
			size = new System.Drawing.Size(149, 12);
			label8.Size = size;
			this.Label6.TabIndex = 3;
			this.Label6.Text = "列标题（为空表示默认）：";
			this.Label3.AutoSize = true;
			System.Windows.Forms.Control label9 = this.Label3;
			location = new System.Drawing.Point(193, 38);
			label9.Location = location;
			this.Label3.Name = "Label3";
			System.Windows.Forms.Control label10 = this.Label3;
			size = new System.Drawing.Size(77, 12);
			label10.Size = size;
			this.Label3.TabIndex = 3;
			this.Label3.Text = "格式字符串：";
			this.Label2.AutoSize = true;
			System.Windows.Forms.Control label11 = this.Label2;
			location = new System.Drawing.Point(193, 15);
			label11.Location = location;
			this.Label2.Name = "Label2";
			System.Windows.Forms.Control label12 = this.Label2;
			size = new System.Drawing.Size(41, 12);
			label12.Size = size;
			this.Label2.TabIndex = 3;
			this.Label2.Text = "对齐：";
			this.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ComboBox1.Enabled = false;
			this.ComboBox1.FormattingEnabled = true;
			this.ComboBox1.Items.AddRange(new object[]
			{
				"",
				"左对齐",
				"右对齐",
				"居中对齐"
			});
			System.Windows.Forms.Control comboBox3 = this.ComboBox1;
			location = new System.Drawing.Point(235, 11);
			comboBox3.Location = location;
			this.ComboBox1.Name = "ComboBox1";
			System.Windows.Forms.Control comboBox4 = this.ComboBox1;
			size = new System.Drawing.Size(60, 20);
			comboBox4.Size = size;
			this.ComboBox1.TabIndex = 2;
			this.ListBox4.AllowDrop = true;
			this.ListBox4.FormattingEnabled = true;
			this.ListBox4.ItemHeight = 12;
			System.Windows.Forms.Control listBox = this.ListBox4;
			location = new System.Drawing.Point(6, 15);
			listBox.Location = location;
			this.ListBox4.Name = "ListBox4";
			System.Windows.Forms.Control listBox2 = this.ListBox4;
			size = new System.Drawing.Size(129, 76);
			listBox2.Size = size;
			this.ListBox4.TabIndex = 0;
			System.Windows.Forms.Control button3 = this.Button7;
			location = new System.Drawing.Point(138, 41);
			button3.Location = location;
			this.Button7.Name = "Button7";
			System.Windows.Forms.Control button4 = this.Button7;
			size = new System.Drawing.Size(51, 23);
			button4.Size = size;
			this.Button7.TabIndex = 1;
			this.Button7.Text = "上移";
			this.Button7.UseVisualStyleBackColor = true;
			System.Windows.Forms.Control button5 = this.Button8;
			location = new System.Drawing.Point(138, 62);
			button5.Location = location;
			this.Button8.Name = "Button8";
			System.Windows.Forms.Control button6 = this.Button8;
			size = new System.Drawing.Size(51, 23);
			button6.Size = size;
			this.Button8.TabIndex = 1;
			this.Button8.Text = "下移";
			this.Button8.UseVisualStyleBackColor = true;
			System.Windows.Forms.Control button7 = this.Button9;
			location = new System.Drawing.Point(138, 19);
			button7.Location = location;
			this.Button9.Name = "Button9";
			System.Windows.Forms.Control button8 = this.Button9;
			size = new System.Drawing.Size(51, 23);
			button8.Size = size;
			this.Button9.TabIndex = 1;
			this.Button9.Text = "删除";
			this.Button9.UseVisualStyleBackColor = true;
			this.GroupBox3.Controls.Add(this.ListBox3);
			this.GroupBox3.Controls.Add(this.Button4);
			this.GroupBox3.Controls.Add(this.Button5);
			this.GroupBox3.Controls.Add(this.Button6);
			System.Windows.Forms.Control groupBox3 = this.GroupBox3;
			location = new System.Drawing.Point(166, 3);
			groupBox3.Location = location;
			this.GroupBox3.Name = "GroupBox3";
			System.Windows.Forms.Control groupBox4 = this.GroupBox3;
			size = new System.Drawing.Size(197, 94);
			groupBox4.Size = size;
			this.GroupBox3.TabIndex = 2;
			this.GroupBox3.TabStop = false;
			this.GroupBox3.Text = "行标题列（Y轴）";
			this.ListBox3.AllowDrop = true;
			this.ListBox3.FormattingEnabled = true;
			this.ListBox3.ItemHeight = 12;
			System.Windows.Forms.Control listBox3 = this.ListBox3;
			location = new System.Drawing.Point(6, 15);
			listBox3.Location = location;
			this.ListBox3.Name = "ListBox3";
			System.Windows.Forms.Control listBox4 = this.ListBox3;
			size = new System.Drawing.Size(129, 76);
			listBox4.Size = size;
			this.ListBox3.TabIndex = 0;
			System.Windows.Forms.Control button9 = this.Button4;
			location = new System.Drawing.Point(140, 40);
			button9.Location = location;
			this.Button4.Name = "Button4";
			System.Windows.Forms.Control button10 = this.Button4;
			size = new System.Drawing.Size(49, 23);
			button10.Size = size;
			this.Button4.TabIndex = 1;
			this.Button4.Text = "上移";
			this.Button4.UseVisualStyleBackColor = true;
			System.Windows.Forms.Control button11 = this.Button5;
			location = new System.Drawing.Point(140, 63);
			button11.Location = location;
			this.Button5.Name = "Button5";
			System.Windows.Forms.Control button12 = this.Button5;
			size = new System.Drawing.Size(49, 23);
			button12.Size = size;
			this.Button5.TabIndex = 1;
			this.Button5.Text = "下移";
			this.Button5.UseVisualStyleBackColor = true;
			System.Windows.Forms.Control button13 = this.Button6;
			location = new System.Drawing.Point(140, 18);
			button13.Location = location;
			this.Button6.Name = "Button6";
			System.Windows.Forms.Control button14 = this.Button6;
			size = new System.Drawing.Size(49, 23);
			button14.Size = size;
			this.Button6.TabIndex = 1;
			this.Button6.Text = "删除";
			this.Button6.UseVisualStyleBackColor = true;
			this.GroupBox2.Controls.Add(this.ListBox2);
			this.GroupBox2.Controls.Add(this.Button2);
			this.GroupBox2.Controls.Add(this.Button3);
			this.GroupBox2.Controls.Add(this.Button1);
			System.Windows.Forms.Control groupBox5 = this.GroupBox2;
			location = new System.Drawing.Point(365, 3);
			groupBox5.Location = location;
			this.GroupBox2.Name = "GroupBox2";
			System.Windows.Forms.Control groupBox6 = this.GroupBox2;
			size = new System.Drawing.Size(239, 94);
			groupBox6.Size = size;
			this.GroupBox2.TabIndex = 2;
			this.GroupBox2.TabStop = false;
			this.GroupBox2.Text = "列标题列（X轴）";
			this.ListBox2.AllowDrop = true;
			this.ListBox2.FormattingEnabled = true;
			this.ListBox2.ItemHeight = 12;
			System.Windows.Forms.Control listBox5 = this.ListBox2;
			location = new System.Drawing.Point(6, 15);
			listBox5.Location = location;
			this.ListBox2.Name = "ListBox2";
			System.Windows.Forms.Control listBox6 = this.ListBox2;
			size = new System.Drawing.Size(160, 76);
			listBox6.Size = size;
			this.ListBox2.TabIndex = 0;
			System.Windows.Forms.Control button15 = this.Button2;
			location = new System.Drawing.Point(169, 40);
			button15.Location = location;
			this.Button2.Name = "Button2";
			System.Windows.Forms.Control button16 = this.Button2;
			size = new System.Drawing.Size(57, 23);
			button16.Size = size;
			this.Button2.TabIndex = 1;
			this.Button2.Text = "上移";
			this.Button2.UseVisualStyleBackColor = true;
			System.Windows.Forms.Control button17 = this.Button3;
			location = new System.Drawing.Point(169, 63);
			button17.Location = location;
			this.Button3.Name = "Button3";
			System.Windows.Forms.Control button18 = this.Button3;
			size = new System.Drawing.Size(57, 23);
			button18.Size = size;
			this.Button3.TabIndex = 1;
			this.Button3.Text = "下移";
			this.Button3.UseVisualStyleBackColor = true;
			System.Windows.Forms.Control button19 = this.Button1;
			location = new System.Drawing.Point(169, 18);
			button19.Location = location;
			this.Button1.Name = "Button1";
			System.Windows.Forms.Control button20 = this.Button1;
			size = new System.Drawing.Size(57, 23);
			button20.Size = size;
			this.Button1.TabIndex = 1;
			this.Button1.Text = "删除";
			this.Button1.UseVisualStyleBackColor = true;
			this.GroupBox1.Controls.Add(this.ListBox1);
			System.Windows.Forms.Control groupBox7 = this.GroupBox1;
			location = new System.Drawing.Point(7, 3);
			groupBox7.Location = location;
			this.GroupBox1.Name = "GroupBox1";
			System.Windows.Forms.Control groupBox8 = this.GroupBox1;
			size = new System.Drawing.Size(157, 199);
			groupBox8.Size = size;
			this.GroupBox1.TabIndex = 2;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "可供选择的全部列";
			this.ListBox1.FormattingEnabled = true;
			this.ListBox1.ItemHeight = 12;
			System.Windows.Forms.Control listBox7 = this.ListBox1;
			location = new System.Drawing.Point(6, 15);
			listBox7.Location = location;
			this.ListBox1.Name = "ListBox1";
			System.Windows.Forms.Control listBox8 = this.ListBox1;
			size = new System.Drawing.Size(144, 172);
			listBox8.Size = size;
			this.ListBox1.TabIndex = 0;
			this.d1.AddRowNumber = false;
			this.d1.AllowUserToAddRows = false;
			this.d1.AllowUserToDeleteRows = false;
			this.d1.ColHeaderTreeView = this.tv1;
			this.d1.ColumnHeadersHeight = 58;
			this.d1.ContextMenuStrip = this.ContextMenuStrip1;
			dataGridViewCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle.Font = new System.Drawing.Font("宋体", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
			dataGridViewCellStyle.ForeColor = System.Drawing.SystemColors.ControlText;
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = dataGridViewCellStyle;
			System.Windows.Forms.Padding padding = new System.Windows.Forms.Padding(1, 0, 1, 0);
			dataGridViewCellStyle2.Padding = padding;
			dataGridViewCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.d1.DefaultCellStyle = dataGridViewCellStyle;
			this.d1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.d1.GridColor = System.Drawing.Color.Black;
			System.Windows.Forms.Control d = this.d1;
			location = new System.Drawing.Point(0, 0);
			d.Location = location;
			this.d1.Name = "d1";
			this.d1.RowTemplate.Height = 23;
			System.Windows.Forms.Control d2 = this.d1;
			size = new System.Drawing.Size(845, 185);
			d2.Size = size;
			this.d1.TabIndex = 0;
			this.SaveFileDialog1.DefaultExt = "sum";
			this.SaveFileDialog1.Filter = "汇总方案(*.sum)|*.sum";
			this.SaveFileDialog1.Title = "选择数据汇总方案文件";
			this.OpenFileDialog1.Filter = "汇总方案(*.sum)|*.sum";
			this.OpenFileDialog1.Title = "选择数据汇总方案文件";
			System.Drawing.SizeF autoScaleDimensions = new System.Drawing.SizeF(6f, 12f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			size = new System.Drawing.Size(845, 413);
			this.ClientSize = size;
			this.Controls.Add(this.SplitContainer1);
			this.Controls.Add(this.ToolStrip1);
			this.Controls.Add(this.tv1);
			this.Icon = (System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			this.Name = "PivotTableView";
			this.Text = "数据汇总";
			this.WindowState = FormWindowState.Maximized;
			this.ContextMenuStrip1.ResumeLayout(false);
			this.ToolStrip1.ResumeLayout(false);
			this.ToolStrip1.PerformLayout();
			this.SplitContainer1.Panel1.ResumeLayout(false);
			this.SplitContainer1.Panel1.PerformLayout();
			this.SplitContainer1.Panel2.ResumeLayout(false);
			this.SplitContainer1.ResumeLayout(false);
			this.GroupBox4.ResumeLayout(false);
			this.GroupBox4.PerformLayout();
			this.GroupBox3.ResumeLayout(false);
			this.GroupBox2.ResumeLayout(false);
			this.GroupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.d1).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		// Token: 0x04000046 RID: 70
		private System.ComponentModel.IContainer components;
	}
}
