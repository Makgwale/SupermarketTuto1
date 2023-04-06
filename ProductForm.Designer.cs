namespace SupermarketTuto1
{
	partial class ProductForm
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
			this.catCB = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.ProdPriceTB = new Bunifu.Framework.UI.BunifuMaterialTextbox();
			this.label5 = new System.Windows.Forms.Label();
			this.ProdQtyTB = new Bunifu.Framework.UI.BunifuMaterialTextbox();
			this.label4 = new System.Windows.Forms.Label();
			this.ProdNameTB = new Bunifu.Framework.UI.BunifuMaterialTextbox();
			this.label3 = new System.Windows.Forms.Label();
			this.ProdIdTB = new Bunifu.Framework.UI.BunifuMaterialTextbox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.sellerFormBtn = new System.Windows.Forms.Button();
			this.CategoryFormBtn = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.exitBtn = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ProdDGV)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.DarkRed;
			this.panel1.Controls.Add(this.button8);
			this.panel1.Controls.Add(this.comboBox2);
			this.panel1.Controls.Add(this.ProdDGV);
			this.panel1.Controls.Add(this.DelBtn);
			this.panel1.Controls.Add(this.EditBtn);
			this.panel1.Controls.Add(this.AddBtn);
			this.panel1.Controls.Add(this.catCB);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.ProdPriceTB);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.ProdQtyTB);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.ProdNameTB);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.ProdIdTB);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(114, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(839, 542);
			this.panel1.TabIndex = 0;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			// 
			// button8
			// 
			this.button8.BackColor = System.Drawing.Color.LightSalmon;
			this.button8.FlatAppearance.BorderSize = 2;
			this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button8.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button8.ForeColor = System.Drawing.Color.DarkRed;
			this.button8.Location = new System.Drawing.Point(654, 52);
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
			this.comboBox2.Location = new System.Drawing.Point(470, 55);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(178, 24);
			this.comboBox2.TabIndex = 27;
			this.comboBox2.Text = "Select Category";
			// 
			// ProdDGV
			// 
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
			this.ProdDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.IndianRed;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.ProdDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.ProdDGV.ColumnHeadersHeight = 25;
			this.ProdDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.ProdDGV.DefaultCellStyle = dataGridViewCellStyle3;
			this.ProdDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.ProdDGV.Location = new System.Drawing.Point(320, 85);
			this.ProdDGV.Name = "ProdDGV";
			this.ProdDGV.RowHeadersVisible = false;
			this.ProdDGV.Size = new System.Drawing.Size(474, 440);
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
			this.ProdDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProdDGV_CellContentClick);
			// 
			// DelBtn
			// 
			this.DelBtn.BackColor = System.Drawing.Color.LightSalmon;
			this.DelBtn.FlatAppearance.BorderSize = 2;
			this.DelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.DelBtn.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold);
			this.DelBtn.ForeColor = System.Drawing.Color.DarkRed;
			this.DelBtn.Location = new System.Drawing.Point(200, 317);
			this.DelBtn.Name = "DelBtn";
			this.DelBtn.Size = new System.Drawing.Size(93, 32);
			this.DelBtn.TabIndex = 25;
			this.DelBtn.Text = "DELETE";
			this.DelBtn.UseVisualStyleBackColor = false;
			this.DelBtn.Click += new System.EventHandler(this.DelBtn_Click);
			// 
			// EditBtn
			// 
			this.EditBtn.BackColor = System.Drawing.Color.LightSalmon;
			this.EditBtn.FlatAppearance.BorderSize = 2;
			this.EditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.EditBtn.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold);
			this.EditBtn.ForeColor = System.Drawing.Color.DarkRed;
			this.EditBtn.Location = new System.Drawing.Point(107, 317);
			this.EditBtn.Name = "EditBtn";
			this.EditBtn.Size = new System.Drawing.Size(87, 32);
			this.EditBtn.TabIndex = 24;
			this.EditBtn.Text = "EDIT";
			this.EditBtn.UseVisualStyleBackColor = false;
			this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
			// 
			// AddBtn
			// 
			this.AddBtn.BackColor = System.Drawing.Color.LightSalmon;
			this.AddBtn.FlatAppearance.BorderSize = 2;
			this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.AddBtn.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold);
			this.AddBtn.ForeColor = System.Drawing.Color.DarkRed;
			this.AddBtn.Location = new System.Drawing.Point(14, 317);
			this.AddBtn.Name = "AddBtn";
			this.AddBtn.Size = new System.Drawing.Size(87, 32);
			this.AddBtn.TabIndex = 23;
			this.AddBtn.Text = "ADD";
			this.AddBtn.UseVisualStyleBackColor = false;
			this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
			// 
			// catCB
			// 
			this.catCB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.catCB.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold);
			this.catCB.ForeColor = System.Drawing.Color.DarkRed;
			this.catCB.FormattingEnabled = true;
			this.catCB.Items.AddRange(new object[] {
            "ADMIN",
            "SELLER"});
			this.catCB.Location = new System.Drawing.Point(123, 257);
			this.catCB.Name = "catCB";
			this.catCB.Size = new System.Drawing.Size(178, 24);
			this.catCB.TabIndex = 22;
			this.catCB.Text = "Select Category";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.White;
			this.label6.Location = new System.Drawing.Point(9, 257);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(97, 16);
			this.label6.TabIndex = 21;
			this.label6.Text = "CATEGORY";
			// 
			// ProdPriceTB
			// 
			this.ProdPriceTB.BackColor = System.Drawing.Color.DarkRed;
			this.ProdPriceTB.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.ProdPriceTB.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ProdPriceTB.ForeColor = System.Drawing.Color.White;
			this.ProdPriceTB.HintForeColor = System.Drawing.Color.Empty;
			this.ProdPriceTB.HintText = "";
			this.ProdPriceTB.isPassword = false;
			this.ProdPriceTB.LineFocusedColor = System.Drawing.Color.WhiteSmoke;
			this.ProdPriceTB.LineIdleColor = System.Drawing.Color.White;
			this.ProdPriceTB.LineMouseHoverColor = System.Drawing.Color.WhiteSmoke;
			this.ProdPriceTB.LineThickness = 3;
			this.ProdPriceTB.Location = new System.Drawing.Point(123, 191);
			this.ProdPriceTB.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.ProdPriceTB.Name = "ProdPriceTB";
			this.ProdPriceTB.Size = new System.Drawing.Size(178, 33);
			this.ProdPriceTB.TabIndex = 20;
			this.ProdPriceTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(9, 208);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(54, 16);
			this.label5.TabIndex = 19;
			this.label5.Text = "PRICE";
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
			this.ProdQtyTB.Location = new System.Drawing.Point(123, 150);
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
			this.label4.Location = new System.Drawing.Point(9, 171);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(93, 16);
			this.label4.TabIndex = 17;
			this.label4.Text = "QUANTITY";
			// 
			// ProdNameTB
			// 
			this.ProdNameTB.BackColor = System.Drawing.Color.DarkRed;
			this.ProdNameTB.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.ProdNameTB.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ProdNameTB.ForeColor = System.Drawing.Color.White;
			this.ProdNameTB.HintForeColor = System.Drawing.Color.Empty;
			this.ProdNameTB.HintText = "";
			this.ProdNameTB.isPassword = false;
			this.ProdNameTB.LineFocusedColor = System.Drawing.Color.WhiteSmoke;
			this.ProdNameTB.LineIdleColor = System.Drawing.Color.White;
			this.ProdNameTB.LineMouseHoverColor = System.Drawing.Color.WhiteSmoke;
			this.ProdNameTB.LineThickness = 3;
			this.ProdNameTB.Location = new System.Drawing.Point(123, 109);
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
			this.label3.Location = new System.Drawing.Point(9, 126);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(55, 16);
			this.label3.TabIndex = 15;
			this.label3.Text = "NAME";
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
			this.ProdIdTB.Location = new System.Drawing.Point(123, 68);
			this.ProdIdTB.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.ProdIdTB.Name = "ProdIdTB";
			this.ProdIdTB.Size = new System.Drawing.Size(178, 33);
			this.ProdIdTB.TabIndex = 14;
			this.ProdIdTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(9, 85);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(25, 16);
			this.label2.TabIndex = 13;
			this.label2.Text = "ID";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(254, 11);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(232, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "MANAGE PRODUCTS";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// sellerFormBtn
			// 
			this.sellerFormBtn.FlatAppearance.BorderSize = 0;
			this.sellerFormBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.sellerFormBtn.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold);
			this.sellerFormBtn.ForeColor = System.Drawing.Color.DarkRed;
			this.sellerFormBtn.Location = new System.Drawing.Point(12, 96);
			this.sellerFormBtn.Name = "sellerFormBtn";
			this.sellerFormBtn.Size = new System.Drawing.Size(87, 23);
			this.sellerFormBtn.TabIndex = 1;
			this.sellerFormBtn.Text = "Seller";
			this.sellerFormBtn.UseVisualStyleBackColor = true;
			this.sellerFormBtn.Click += new System.EventHandler(this.SellerFormBtn);
			// 
			// CategoryFormBtn
			// 
			this.CategoryFormBtn.FlatAppearance.BorderSize = 0;
			this.CategoryFormBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.CategoryFormBtn.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold);
			this.CategoryFormBtn.ForeColor = System.Drawing.Color.DarkRed;
			this.CategoryFormBtn.Location = new System.Drawing.Point(21, 142);
			this.CategoryFormBtn.Name = "CategoryFormBtn";
			this.CategoryFormBtn.Size = new System.Drawing.Size(87, 29);
			this.CategoryFormBtn.TabIndex = 2;
			this.CategoryFormBtn.Text = "Category";
			this.CategoryFormBtn.UseVisualStyleBackColor = true;
			this.CategoryFormBtn.Click += new System.EventHandler(this.CategoryFormBtn_Click);
			// 
			// button3
			// 
			this.button3.FlatAppearance.BorderSize = 0;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold);
			this.button3.ForeColor = System.Drawing.Color.DarkRed;
			this.button3.Location = new System.Drawing.Point(12, 188);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(87, 29);
			this.button3.TabIndex = 3;
			this.button3.Text = "Selling";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// exitBtn
			// 
			this.exitBtn.FlatAppearance.BorderSize = 0;
			this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.exitBtn.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.exitBtn.ForeColor = System.Drawing.Color.DarkRed;
			this.exitBtn.Location = new System.Drawing.Point(889, 5);
			this.exitBtn.Name = "exitBtn";
			this.exitBtn.Size = new System.Drawing.Size(40, 30);
			this.exitBtn.TabIndex = 5;
			this.exitBtn.Text = "x";
			this.exitBtn.UseVisualStyleBackColor = true;
			this.exitBtn.Click += new System.EventHandler(this.button5_Click);
			// 
			// ProductForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(977, 583);
			this.Controls.Add(this.exitBtn);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.CategoryFormBtn);
			this.Controls.Add(this.sellerFormBtn);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "ProductForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ProductForm";
			this.Load += new System.EventHandler(this.ProductForm_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.ProdDGV)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button sellerFormBtn;
		private System.Windows.Forms.Button CategoryFormBtn;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button exitBtn;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button EditBtn;
		private System.Windows.Forms.Button AddBtn;
		private System.Windows.Forms.ComboBox catCB;
		private System.Windows.Forms.Label label6;
		private Bunifu.Framework.UI.BunifuMaterialTextbox ProdPriceTB;
		private System.Windows.Forms.Label label5;
		private Bunifu.Framework.UI.BunifuMaterialTextbox ProdQtyTB;
		private System.Windows.Forms.Label label4;
		private Bunifu.Framework.UI.BunifuMaterialTextbox ProdNameTB;
		private System.Windows.Forms.Label label3;
		private Bunifu.Framework.UI.BunifuMaterialTextbox ProdIdTB;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox comboBox2;
		private Guna.UI2.WinForms.Guna2DataGridView ProdDGV;
		private System.Windows.Forms.Button DelBtn;
		private System.Windows.Forms.Button button8;
	}
}