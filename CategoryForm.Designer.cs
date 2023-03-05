namespace SupermarketTuto1
{
	partial class CategoryForm
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
			this.CartDGV = new Guna.UI2.WinForms.Guna2DataGridView();
			this.DeleteBtn = new System.Windows.Forms.Button();
			this.EditBtn = new System.Windows.Forms.Button();
			this.Addbtn = new System.Windows.Forms.Button();
			this.CartDescTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
			this.label4 = new System.Windows.Forms.Label();
			this.CartNameTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
			this.label3 = new System.Windows.Forms.Label();
			this.CartIdTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.CartExit = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.CartDGV)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.DarkRed;
			this.panel1.Controls.Add(this.button8);
			this.panel1.Controls.Add(this.comboBox2);
			this.panel1.Controls.Add(this.CartDGV);
			this.panel1.Controls.Add(this.DeleteBtn);
			this.panel1.Controls.Add(this.EditBtn);
			this.panel1.Controls.Add(this.Addbtn);
			this.panel1.Controls.Add(this.CartDescTb);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.CartNameTb);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.CartIdTb);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(126, 25);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(839, 546);
			this.panel1.TabIndex = 2;
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
			// CartDGV
			// 
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
			this.CartDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.CartDGV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.IndianRed;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.CartDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.CartDGV.ColumnHeadersHeight = 25;
			this.CartDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.CartDGV.DefaultCellStyle = dataGridViewCellStyle3;
			this.CartDGV.GridColor = System.Drawing.Color.LightGray;
			this.CartDGV.Location = new System.Drawing.Point(320, 85);
			this.CartDGV.Name = "CartDGV";
			this.CartDGV.RowHeadersVisible = false;
			this.CartDGV.RowTemplate.Height = 30;
			this.CartDGV.Size = new System.Drawing.Size(474, 440);
			this.CartDGV.TabIndex = 26;
			this.CartDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
			this.CartDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
			this.CartDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
			this.CartDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
			this.CartDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
			this.CartDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
			this.CartDGV.ThemeStyle.GridColor = System.Drawing.Color.LightGray;
			this.CartDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.CartDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.CartDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CartDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
			this.CartDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.CartDGV.ThemeStyle.HeaderStyle.Height = 25;
			this.CartDGV.ThemeStyle.ReadOnly = false;
			this.CartDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
			this.CartDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.CartDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CartDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.CartDGV.ThemeStyle.RowsStyle.Height = 30;
			this.CartDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.CartDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.CartDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CartDGV_CellContentClick);
			// 
			// DeleteBtn
			// 
			this.DeleteBtn.BackColor = System.Drawing.Color.LightSalmon;
			this.DeleteBtn.FlatAppearance.BorderSize = 2;
			this.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.DeleteBtn.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold);
			this.DeleteBtn.ForeColor = System.Drawing.Color.DarkRed;
			this.DeleteBtn.Location = new System.Drawing.Point(200, 241);
			this.DeleteBtn.Name = "DeleteBtn";
			this.DeleteBtn.Size = new System.Drawing.Size(93, 32);
			this.DeleteBtn.TabIndex = 25;
			this.DeleteBtn.Text = "DELETE";
			this.DeleteBtn.UseVisualStyleBackColor = false;
			this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
			// 
			// EditBtn
			// 
			this.EditBtn.BackColor = System.Drawing.Color.LightSalmon;
			this.EditBtn.FlatAppearance.BorderSize = 2;
			this.EditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.EditBtn.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold);
			this.EditBtn.ForeColor = System.Drawing.Color.DarkRed;
			this.EditBtn.Location = new System.Drawing.Point(107, 241);
			this.EditBtn.Name = "EditBtn";
			this.EditBtn.Size = new System.Drawing.Size(87, 32);
			this.EditBtn.TabIndex = 24;
			this.EditBtn.Text = "EDIT";
			this.EditBtn.UseVisualStyleBackColor = false;
			this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
			// 
			// Addbtn
			// 
			this.Addbtn.BackColor = System.Drawing.Color.LightSalmon;
			this.Addbtn.FlatAppearance.BorderSize = 2;
			this.Addbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Addbtn.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold);
			this.Addbtn.ForeColor = System.Drawing.Color.DarkRed;
			this.Addbtn.Location = new System.Drawing.Point(14, 241);
			this.Addbtn.Name = "Addbtn";
			this.Addbtn.Size = new System.Drawing.Size(87, 32);
			this.Addbtn.TabIndex = 23;
			this.Addbtn.Text = "ADD";
			this.Addbtn.UseVisualStyleBackColor = false;
			this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
			// 
			// CartDescTb
			// 
			this.CartDescTb.BackColor = System.Drawing.Color.DarkRed;
			this.CartDescTb.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.CartDescTb.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CartDescTb.ForeColor = System.Drawing.Color.White;
			this.CartDescTb.HintForeColor = System.Drawing.Color.Empty;
			this.CartDescTb.HintText = "";
			this.CartDescTb.isPassword = false;
			this.CartDescTb.LineFocusedColor = System.Drawing.Color.WhiteSmoke;
			this.CartDescTb.LineIdleColor = System.Drawing.Color.White;
			this.CartDescTb.LineMouseHoverColor = System.Drawing.Color.WhiteSmoke;
			this.CartDescTb.LineThickness = 3;
			this.CartDescTb.Location = new System.Drawing.Point(134, 154);
			this.CartDescTb.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.CartDescTb.Name = "CartDescTb";
			this.CartDescTb.Size = new System.Drawing.Size(178, 33);
			this.CartDescTb.TabIndex = 18;
			this.CartDescTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(9, 171);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(115, 16);
			this.label4.TabIndex = 17;
			this.label4.Text = "DESCRIPTION";
			// 
			// CartNameTb
			// 
			this.CartNameTb.BackColor = System.Drawing.Color.DarkRed;
			this.CartNameTb.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.CartNameTb.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CartNameTb.ForeColor = System.Drawing.Color.White;
			this.CartNameTb.HintForeColor = System.Drawing.Color.Empty;
			this.CartNameTb.HintText = "";
			this.CartNameTb.isPassword = false;
			this.CartNameTb.LineFocusedColor = System.Drawing.Color.WhiteSmoke;
			this.CartNameTb.LineIdleColor = System.Drawing.Color.White;
			this.CartNameTb.LineMouseHoverColor = System.Drawing.Color.WhiteSmoke;
			this.CartNameTb.LineThickness = 3;
			this.CartNameTb.Location = new System.Drawing.Point(134, 109);
			this.CartNameTb.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.CartNameTb.Name = "CartNameTb";
			this.CartNameTb.Size = new System.Drawing.Size(178, 33);
			this.CartNameTb.TabIndex = 16;
			this.CartNameTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
			// CartIdTb
			// 
			this.CartIdTb.BackColor = System.Drawing.Color.DarkRed;
			this.CartIdTb.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.CartIdTb.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CartIdTb.ForeColor = System.Drawing.Color.White;
			this.CartIdTb.HintForeColor = System.Drawing.Color.Empty;
			this.CartIdTb.HintText = "";
			this.CartIdTb.isPassword = false;
			this.CartIdTb.LineFocusedColor = System.Drawing.Color.WhiteSmoke;
			this.CartIdTb.LineIdleColor = System.Drawing.Color.White;
			this.CartIdTb.LineMouseHoverColor = System.Drawing.Color.WhiteSmoke;
			this.CartIdTb.LineThickness = 3;
			this.CartIdTb.Location = new System.Drawing.Point(134, 68);
			this.CartIdTb.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.CartIdTb.Name = "CartIdTb";
			this.CartIdTb.Size = new System.Drawing.Size(178, 33);
			this.CartIdTb.TabIndex = 14;
			this.CartIdTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
			this.label1.Size = new System.Drawing.Size(255, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "MANAGE CATEGORIES";
			// 
			// CartExit
			// 
			this.CartExit.FlatAppearance.BorderSize = 0;
			this.CartExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.CartExit.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CartExit.ForeColor = System.Drawing.Color.DarkRed;
			this.CartExit.Location = new System.Drawing.Point(909, 12);
			this.CartExit.Name = "CartExit";
			this.CartExit.Size = new System.Drawing.Size(40, 30);
			this.CartExit.TabIndex = 30;
			this.CartExit.Text = "x";
			this.CartExit.UseVisualStyleBackColor = true;
			this.CartExit.Click += new System.EventHandler(this.CartExit_Click);
			// 
			// button3
			// 
			this.button3.FlatAppearance.BorderSize = 0;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold);
			this.button3.ForeColor = System.Drawing.Color.DarkRed;
			this.button3.Location = new System.Drawing.Point(12, 196);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(77, 29);
			this.button3.TabIndex = 33;
			this.button3.Text = "Selling";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.FlatAppearance.BorderSize = 0;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold);
			this.button2.ForeColor = System.Drawing.Color.DarkRed;
			this.button2.Location = new System.Drawing.Point(12, 151);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(87, 29);
			this.button2.TabIndex = 32;
			this.button2.Text = "Products";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold);
			this.button1.ForeColor = System.Drawing.Color.DarkRed;
			this.button1.Location = new System.Drawing.Point(2, 110);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(87, 23);
			this.button1.TabIndex = 31;
			this.button1.Text = "Seller";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// CategoryForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(977, 583);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.CartExit);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "CategoryForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "CategoryForm";
			this.Load += new System.EventHandler(this.CategoryForm_Load_1);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.CartDGV)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.ComboBox comboBox2;
		private Guna.UI2.WinForms.Guna2DataGridView CartDGV;
		private System.Windows.Forms.Button DeleteBtn;
		private System.Windows.Forms.Button EditBtn;
		private System.Windows.Forms.Button Addbtn;
		private Bunifu.Framework.UI.BunifuMaterialTextbox CartDescTb;
		private System.Windows.Forms.Label label4;
		private Bunifu.Framework.UI.BunifuMaterialTextbox CartNameTb;
		private System.Windows.Forms.Label label3;
		private Bunifu.Framework.UI.BunifuMaterialTextbox CartIdTb;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button CartExit;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
	}
}