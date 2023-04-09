namespace SupermarketTuto1
{
	partial class SellingForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.panel1 = new System.Windows.Forms.Panel();
			this.button8 = new System.Windows.Forms.Button();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.ProdDGV = new Guna.UI2.WinForms.Guna2DataGridView();
			this.DelBtn = new System.Windows.Forms.Button();
			this.EditBtn = new System.Windows.Forms.Button();
			this.AddBtn = new System.Windows.Forms.Button();
			this.ProdQtyTB = new Bunifu.Framework.UI.BunifuMaterialTextbox();
			this.label4 = new System.Windows.Forms.Label();
			this.ProdNameTB = new Bunifu.Framework.UI.BunifuMaterialTextbox();
			this.label3 = new System.Windows.Forms.Label();
			this.ProdIdTB = new Bunifu.Framework.UI.BunifuMaterialTextbox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.exitBtn = new System.Windows.Forms.Button();
			this.Datelbl = new System.Windows.Forms.Label();
			this.ProdDGV1 = new Guna.UI2.WinForms.Guna2DataGridView();
			this.ProdPriceTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
			this.label8 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ProdDGV)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ProdDGV1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.DarkRed;
			this.panel1.Controls.Add(this.ProdPriceTb);
			this.panel1.Controls.Add(this.label8);
			this.panel1.Controls.Add(this.ProdDGV1);
			this.panel1.Controls.Add(this.Datelbl);
			this.panel1.Controls.Add(this.button8);
			this.panel1.Controls.Add(this.comboBox2);
			this.panel1.Controls.Add(this.ProdDGV);
			this.panel1.Controls.Add(this.DelBtn);
			this.panel1.Controls.Add(this.EditBtn);
			this.panel1.Controls.Add(this.AddBtn);
			this.panel1.Controls.Add(this.ProdQtyTB);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.ProdNameTB);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.ProdIdTB);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(114, 6);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(839, 565);
			this.panel1.TabIndex = 1;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			// 
			// button8
			// 
			this.button8.BackColor = System.Drawing.Color.LightSalmon;
			this.button8.FlatAppearance.BorderSize = 2;
			this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button8.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button8.ForeColor = System.Drawing.Color.DarkRed;
			this.button8.Location = new System.Drawing.Point(182, 192);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(80, 27);
			this.button8.TabIndex = 28;
			this.button8.Text = "Refresh";
			this.button8.UseVisualStyleBackColor = false;
			// 
			// comboBox2
			// 
			this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.comboBox2.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold);
			this.comboBox2.ForeColor = System.Drawing.Color.DarkRed;
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Items.AddRange(new object[] {
            "ADMIN",
            "SELLER"});
			this.comboBox2.Location = new System.Drawing.Point(38, 195);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(138, 24);
			this.comboBox2.TabIndex = 27;
			this.comboBox2.Text = "Select Category";
			// 
			// ProdDGV
			// 
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
			this.ProdDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.IndianRed;
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.ProdDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
			this.ProdDGV.ColumnHeadersHeight = 25;
			this.ProdDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.ProdDGV.DefaultCellStyle = dataGridViewCellStyle6;
			this.ProdDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.ProdDGV.Location = new System.Drawing.Point(320, 348);
			this.ProdDGV.Name = "ProdDGV";
			this.ProdDGV.RowHeadersVisible = false;
			this.ProdDGV.Size = new System.Drawing.Size(474, 177);
			this.ProdDGV.TabIndex = 26;
			this.ProdDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
			this.ProdDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
			this.ProdDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
			this.ProdDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
			this.ProdDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
			this.ProdDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
			this.ProdDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.ProdDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.ProdDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.ProdDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ProdDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
			this.ProdDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.ProdDGV.ThemeStyle.HeaderStyle.Height = 25;
			this.ProdDGV.ThemeStyle.ReadOnly = false;
			this.ProdDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
			this.ProdDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.ProdDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ProdDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.ProdDGV.ThemeStyle.RowsStyle.Height = 22;
			this.ProdDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.ProdDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			// 
			// DelBtn
			// 
			this.DelBtn.BackColor = System.Drawing.Color.LightSalmon;
			this.DelBtn.FlatAppearance.BorderSize = 2;
			this.DelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.DelBtn.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold);
			this.DelBtn.ForeColor = System.Drawing.Color.DarkRed;
			this.DelBtn.Location = new System.Drawing.Point(593, 301);
			this.DelBtn.Name = "DelBtn";
			this.DelBtn.Size = new System.Drawing.Size(93, 32);
			this.DelBtn.TabIndex = 25;
			this.DelBtn.Text = "DELETE";
			this.DelBtn.UseVisualStyleBackColor = false;
			// 
			// EditBtn
			// 
			this.EditBtn.BackColor = System.Drawing.Color.LightSalmon;
			this.EditBtn.FlatAppearance.BorderSize = 2;
			this.EditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.EditBtn.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold);
			this.EditBtn.ForeColor = System.Drawing.Color.DarkRed;
			this.EditBtn.Location = new System.Drawing.Point(500, 301);
			this.EditBtn.Name = "EditBtn";
			this.EditBtn.Size = new System.Drawing.Size(87, 32);
			this.EditBtn.TabIndex = 24;
			this.EditBtn.Text = "EDIT";
			this.EditBtn.UseVisualStyleBackColor = false;
			// 
			// AddBtn
			// 
			this.AddBtn.BackColor = System.Drawing.Color.LightSalmon;
			this.AddBtn.FlatAppearance.BorderSize = 2;
			this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.AddBtn.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold);
			this.AddBtn.ForeColor = System.Drawing.Color.DarkRed;
			this.AddBtn.Location = new System.Drawing.Point(407, 301);
			this.AddBtn.Name = "AddBtn";
			this.AddBtn.Size = new System.Drawing.Size(87, 32);
			this.AddBtn.TabIndex = 23;
			this.AddBtn.Text = "ADD";
			this.AddBtn.UseVisualStyleBackColor = false;
			// 
			// ProdQtyTB
			// 
			this.ProdQtyTB.BackColor = System.Drawing.Color.DarkRed;
			this.ProdQtyTB.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.ProdQtyTB.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ProdQtyTB.ForeColor = System.Drawing.Color.White;
			this.ProdQtyTB.HintForeColor = System.Drawing.Color.Empty;
			this.ProdQtyTB.HintText = "";
			this.ProdQtyTB.isPassword = false;
			this.ProdQtyTB.LineFocusedColor = System.Drawing.Color.WhiteSmoke;
			this.ProdQtyTB.LineIdleColor = System.Drawing.Color.White;
			this.ProdQtyTB.LineMouseHoverColor = System.Drawing.Color.WhiteSmoke;
			this.ProdQtyTB.LineThickness = 3;
			this.ProdQtyTB.Location = new System.Drawing.Point(122, 139);
			this.ProdQtyTB.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.ProdQtyTB.Name = "ProdQtyTB";
			this.ProdQtyTB.Size = new System.Drawing.Size(178, 33);
			this.ProdQtyTB.TabIndex = 18;
			this.ProdQtyTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(8, 160);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(93, 16);
			this.label4.TabIndex = 17;
			this.label4.Text = "QUANTITY";
			// 
			// ProdNameTB
			// 
			this.ProdNameTB.BackColor = System.Drawing.Color.DarkRed;
			this.ProdNameTB.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.ProdNameTB.Enabled = false;
			this.ProdNameTB.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ProdNameTB.ForeColor = System.Drawing.Color.White;
			this.ProdNameTB.HintForeColor = System.Drawing.Color.Empty;
			this.ProdNameTB.HintText = "";
			this.ProdNameTB.isPassword = false;
			this.ProdNameTB.LineFocusedColor = System.Drawing.Color.WhiteSmoke;
			this.ProdNameTB.LineIdleColor = System.Drawing.Color.White;
			this.ProdNameTB.LineMouseHoverColor = System.Drawing.Color.WhiteSmoke;
			this.ProdNameTB.LineThickness = 3;
			this.ProdNameTB.Location = new System.Drawing.Point(122, 58);
			this.ProdNameTB.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.ProdNameTB.Name = "ProdNameTB";
			this.ProdNameTB.Size = new System.Drawing.Size(178, 33);
			this.ProdNameTB.TabIndex = 16;
			this.ProdNameTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(8, 75);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(81, 16);
			this.label3.TabIndex = 15;
			this.label3.Text = "ProdName";
			// 
			// ProdIdTB
			// 
			this.ProdIdTB.BackColor = System.Drawing.Color.DarkRed;
			this.ProdIdTB.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.ProdIdTB.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ProdIdTB.ForeColor = System.Drawing.Color.White;
			this.ProdIdTB.HintForeColor = System.Drawing.Color.Empty;
			this.ProdIdTB.HintText = "";
			this.ProdIdTB.isPassword = false;
			this.ProdIdTB.LineFocusedColor = System.Drawing.Color.WhiteSmoke;
			this.ProdIdTB.LineIdleColor = System.Drawing.Color.White;
			this.ProdIdTB.LineMouseHoverColor = System.Drawing.Color.WhiteSmoke;
			this.ProdIdTB.LineThickness = 3;
			this.ProdIdTB.Location = new System.Drawing.Point(122, 23);
			this.ProdIdTB.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.ProdIdTB.Name = "ProdIdTB";
			this.ProdIdTB.Size = new System.Drawing.Size(178, 33);
			this.ProdIdTB.TabIndex = 14;
			this.ProdIdTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.ProdIdTB.OnValueChanged += new System.EventHandler(this.ProdIdTB_OnValueChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(8, 40);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(67, 16);
			this.label2.TabIndex = 13;
			this.label2.Text = "BILL ID";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(341, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(105, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "SELLING";
			// 
			// exitBtn
			// 
			this.exitBtn.FlatAppearance.BorderSize = 0;
			this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.exitBtn.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.exitBtn.ForeColor = System.Drawing.Color.DarkRed;
			this.exitBtn.Location = new System.Drawing.Point(910, -8);
			this.exitBtn.Name = "exitBtn";
			this.exitBtn.Size = new System.Drawing.Size(40, 30);
			this.exitBtn.TabIndex = 6;
			this.exitBtn.Text = "x";
			this.exitBtn.UseVisualStyleBackColor = true;
			this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
			// 
			// Datelbl
			// 
			this.Datelbl.AutoSize = true;
			this.Datelbl.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Datelbl.ForeColor = System.Drawing.Color.White;
			this.Datelbl.Location = new System.Drawing.Point(690, 12);
			this.Datelbl.Name = "Datelbl";
			this.Datelbl.Size = new System.Drawing.Size(51, 16);
			this.Datelbl.TabIndex = 29;
			this.Datelbl.Text = "DATE";
			// 
			// ProdDGV1
			// 
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
			this.ProdDGV1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.IndianRed;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.ProdDGV1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.ProdDGV1.ColumnHeadersHeight = 25;
			this.ProdDGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.ProdDGV1.DefaultCellStyle = dataGridViewCellStyle3;
			this.ProdDGV1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.ProdDGV1.Location = new System.Drawing.Point(11, 225);
			this.ProdDGV1.Name = "ProdDGV1";
			this.ProdDGV1.RowHeadersVisible = false;
			this.ProdDGV1.Size = new System.Drawing.Size(289, 319);
			this.ProdDGV1.TabIndex = 30;
			this.ProdDGV1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
			this.ProdDGV1.ThemeStyle.AlternatingRowsStyle.Font = null;
			this.ProdDGV1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
			this.ProdDGV1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
			this.ProdDGV1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
			this.ProdDGV1.ThemeStyle.BackColor = System.Drawing.Color.White;
			this.ProdDGV1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.ProdDGV1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.ProdDGV1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.ProdDGV1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ProdDGV1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
			this.ProdDGV1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.ProdDGV1.ThemeStyle.HeaderStyle.Height = 25;
			this.ProdDGV1.ThemeStyle.ReadOnly = false;
			this.ProdDGV1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
			this.ProdDGV1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.ProdDGV1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ProdDGV1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.ProdDGV1.ThemeStyle.RowsStyle.Height = 22;
			this.ProdDGV1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.ProdDGV1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.ProdDGV1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProdDGV1_CellContentClick);
			// 
			// ProdPriceTb
			// 
			this.ProdPriceTb.BackColor = System.Drawing.Color.DarkRed;
			this.ProdPriceTb.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.ProdPriceTb.Enabled = false;
			this.ProdPriceTb.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ProdPriceTb.ForeColor = System.Drawing.Color.White;
			this.ProdPriceTb.HintForeColor = System.Drawing.Color.Empty;
			this.ProdPriceTb.HintText = "";
			this.ProdPriceTb.isPassword = false;
			this.ProdPriceTb.LineFocusedColor = System.Drawing.Color.WhiteSmoke;
			this.ProdPriceTb.LineIdleColor = System.Drawing.Color.White;
			this.ProdPriceTb.LineMouseHoverColor = System.Drawing.Color.WhiteSmoke;
			this.ProdPriceTb.LineThickness = 3;
			this.ProdPriceTb.Location = new System.Drawing.Point(122, 99);
			this.ProdPriceTb.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.ProdPriceTb.Name = "ProdPriceTb";
			this.ProdPriceTb.Size = new System.Drawing.Size(178, 33);
			this.ProdPriceTb.TabIndex = 32;
			this.ProdPriceTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.Color.White;
			this.label8.Location = new System.Drawing.Point(8, 116);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(43, 16);
			this.label8.TabIndex = 31;
			this.label8.Text = "Price";
			// 
			// SellingForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(977, 583);
			this.Controls.Add(this.exitBtn);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "SellingForm";
			this.Text = "SellingForm";
			this.Load += new System.EventHandler(this.SellingForm_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.ProdDGV)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ProdDGV1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.ComboBox comboBox2;
		private Guna.UI2.WinForms.Guna2DataGridView ProdDGV;
		private System.Windows.Forms.Button DelBtn;
		private System.Windows.Forms.Button EditBtn;
		private System.Windows.Forms.Button AddBtn;
		private Bunifu.Framework.UI.BunifuMaterialTextbox ProdQtyTB;
		private System.Windows.Forms.Label label4;
		private Bunifu.Framework.UI.BunifuMaterialTextbox ProdNameTB;
		private System.Windows.Forms.Label label3;
		private Bunifu.Framework.UI.BunifuMaterialTextbox ProdIdTB;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button exitBtn;
		private Bunifu.Framework.UI.BunifuMaterialTextbox ProdPriceTb;
		private System.Windows.Forms.Label label8;
		private Guna.UI2.WinForms.Guna2DataGridView ProdDGV1;
		private System.Windows.Forms.Label Datelbl;
	}
}