namespace SupermarketTuto1
{
	partial class Login
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
			this.guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
			this.usernameTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
			this.passwordTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
			this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
			this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
			this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
			this.roleCb = new System.Windows.Forms.ComboBox();
			this.loginBtn = new Bunifu.Framework.UI.BunifuThinButton2();
			this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
			this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
			this.clearlb = new Bunifu.Framework.UI.BunifuCustomLabel();
			this.SuspendLayout();
			// 
			// guna2CircleButton1
			// 
			this.guna2CircleButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.guna2CircleButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.guna2CircleButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.guna2CircleButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.guna2CircleButton1.FillColor = System.Drawing.Color.DarkRed;
			this.guna2CircleButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.guna2CircleButton1.ForeColor = System.Drawing.Color.White;
			this.guna2CircleButton1.Location = new System.Drawing.Point(-346, -12);
			this.guna2CircleButton1.Name = "guna2CircleButton1";
			this.guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
			this.guna2CircleButton1.Size = new System.Drawing.Size(659, 476);
			this.guna2CircleButton1.TabIndex = 0;
			this.guna2CircleButton1.Click += new System.EventHandler(this.guna2CircleButton1_Click);
			// 
			// usernameTb
			// 
			this.usernameTb.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.usernameTb.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.usernameTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
			this.usernameTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.usernameTb.HintForeColor = System.Drawing.Color.Empty;
			this.usernameTb.HintText = "";
			this.usernameTb.isPassword = false;
			this.usernameTb.LineFocusedColor = System.Drawing.Color.LightCoral;
			this.usernameTb.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.usernameTb.LineMouseHoverColor = System.Drawing.Color.LightCoral;
			this.usernameTb.LineThickness = 3;
			this.usernameTb.Location = new System.Drawing.Point(502, 164);
			this.usernameTb.Margin = new System.Windows.Forms.Padding(4);
			this.usernameTb.Name = "usernameTb";
			this.usernameTb.Size = new System.Drawing.Size(224, 33);
			this.usernameTb.TabIndex = 1;
			this.usernameTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.usernameTb.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox1_OnValueChanged);
			// 
			// passwordTb
			// 
			this.passwordTb.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.passwordTb.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.passwordTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
			this.passwordTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.passwordTb.HintForeColor = System.Drawing.Color.Empty;
			this.passwordTb.HintText = "";
			this.passwordTb.isPassword = false;
			this.passwordTb.LineFocusedColor = System.Drawing.Color.LightCoral;
			this.passwordTb.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.passwordTb.LineMouseHoverColor = System.Drawing.Color.LightCoral;
			this.passwordTb.LineThickness = 3;
			this.passwordTb.Location = new System.Drawing.Point(502, 220);
			this.passwordTb.Margin = new System.Windows.Forms.Padding(4);
			this.passwordTb.Name = "passwordTb";
			this.passwordTb.Size = new System.Drawing.Size(224, 33);
			this.passwordTb.TabIndex = 2;
			this.passwordTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			// 
			// bunifuCustomLabel1
			// 
			this.bunifuCustomLabel1.AutoSize = true;
			this.bunifuCustomLabel1.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.DarkRed;
			this.bunifuCustomLabel1.Location = new System.Drawing.Point(486, 105);
			this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
			this.bunifuCustomLabel1.Size = new System.Drawing.Size(80, 23);
			this.bunifuCustomLabel1.TabIndex = 3;
			this.bunifuCustomLabel1.Text = "LOGIN";
			// 
			// bunifuCustomLabel2
			// 
			this.bunifuCustomLabel2.AutoSize = true;
			this.bunifuCustomLabel2.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.DarkRed;
			this.bunifuCustomLabel2.Location = new System.Drawing.Point(390, 181);
			this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
			this.bunifuCustomLabel2.Size = new System.Drawing.Size(105, 16);
			this.bunifuCustomLabel2.TabIndex = 4;
			this.bunifuCustomLabel2.Text = "USERNAME";
			// 
			// bunifuCustomLabel3
			// 
			this.bunifuCustomLabel3.AutoSize = true;
			this.bunifuCustomLabel3.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.DarkRed;
			this.bunifuCustomLabel3.Location = new System.Drawing.Point(390, 237);
			this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
			this.bunifuCustomLabel3.Size = new System.Drawing.Size(104, 16);
			this.bunifuCustomLabel3.TabIndex = 5;
			this.bunifuCustomLabel3.Text = "PASSWORD";
			this.bunifuCustomLabel3.Click += new System.EventHandler(this.bunifuCustomLabel3_Click);
			// 
			// roleCb
			// 
			this.roleCb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.roleCb.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold);
			this.roleCb.ForeColor = System.Drawing.Color.DarkRed;
			this.roleCb.FormattingEnabled = true;
			this.roleCb.Items.AddRange(new object[] {
            "ADMIN",
            "SELLER"});
			this.roleCb.Location = new System.Drawing.Point(605, 288);
			this.roleCb.Name = "roleCb";
			this.roleCb.Size = new System.Drawing.Size(121, 24);
			this.roleCb.TabIndex = 6;
			this.roleCb.Text = "Select Role";
			// 
			// loginBtn
			// 
			this.loginBtn.ActiveBorderThickness = 1;
			this.loginBtn.ActiveCornerRadius = 20;
			this.loginBtn.ActiveFillColor = System.Drawing.Color.LightCoral;
			this.loginBtn.ActiveForecolor = System.Drawing.Color.White;
			this.loginBtn.ActiveLineColor = System.Drawing.Color.DarkRed;
			this.loginBtn.BackColor = System.Drawing.SystemColors.Control;
			this.loginBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("loginBtn.BackgroundImage")));
			this.loginBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.loginBtn.ButtonText = "LOGIN";
			this.loginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.loginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.loginBtn.ForeColor = System.Drawing.Color.DarkRed;
			this.loginBtn.IdleBorderThickness = 1;
			this.loginBtn.IdleCornerRadius = 20;
			this.loginBtn.IdleFillColor = System.Drawing.Color.DarkRed;
			this.loginBtn.IdleForecolor = System.Drawing.Color.White;
			this.loginBtn.IdleLineColor = System.Drawing.Color.RosyBrown;
			this.loginBtn.Location = new System.Drawing.Point(441, 320);
			this.loginBtn.Margin = new System.Windows.Forms.Padding(5);
			this.loginBtn.Name = "loginBtn";
			this.loginBtn.Size = new System.Drawing.Size(187, 41);
			this.loginBtn.TabIndex = 7;
			this.loginBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
			// 
			// bunifuCustomLabel4
			// 
			this.bunifuCustomLabel4.AutoSize = true;
			this.bunifuCustomLabel4.BackColor = System.Drawing.Color.DarkRed;
			this.bunifuCustomLabel4.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.Snow;
			this.bunifuCustomLabel4.Location = new System.Drawing.Point(12, 210);
			this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
			this.bunifuCustomLabel4.Size = new System.Drawing.Size(249, 23);
			this.bunifuCustomLabel4.TabIndex = 8;
			this.bunifuCustomLabel4.Text = "Welcome To FoodLovers";
			// 
			// bunifuCustomLabel5
			// 
			this.bunifuCustomLabel5.AutoSize = true;
			this.bunifuCustomLabel5.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bunifuCustomLabel5.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.DarkRed;
			this.bunifuCustomLabel5.Location = new System.Drawing.Point(766, 9);
			this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
			this.bunifuCustomLabel5.Size = new System.Drawing.Size(22, 23);
			this.bunifuCustomLabel5.TabIndex = 9;
			this.bunifuCustomLabel5.Text = "x";
			this.bunifuCustomLabel5.Click += new System.EventHandler(this.bunifuCustomLabel5_Click);
			// 
			// clearlb
			// 
			this.clearlb.AutoSize = true;
			this.clearlb.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.clearlb.ForeColor = System.Drawing.Color.DarkRed;
			this.clearlb.Location = new System.Drawing.Point(499, 366);
			this.clearlb.Name = "clearlb";
			this.clearlb.Size = new System.Drawing.Size(66, 16);
			this.clearlb.TabIndex = 10;
			this.clearlb.Text = "CLEAR";
			this.clearlb.Click += new System.EventHandler(this.bunifuCustomLabel6_Click);
			// 
			// Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.clearlb);
			this.Controls.Add(this.bunifuCustomLabel5);
			this.Controls.Add(this.bunifuCustomLabel4);
			this.Controls.Add(this.loginBtn);
			this.Controls.Add(this.roleCb);
			this.Controls.Add(this.bunifuCustomLabel3);
			this.Controls.Add(this.bunifuCustomLabel2);
			this.Controls.Add(this.bunifuCustomLabel1);
			this.Controls.Add(this.passwordTb);
			this.Controls.Add(this.usernameTb);
			this.Controls.Add(this.guna2CircleButton1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Login";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
		private Bunifu.Framework.UI.BunifuMaterialTextbox usernameTb;
		private Bunifu.Framework.UI.BunifuMaterialTextbox passwordTb;
		private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
		private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
		private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
		private System.Windows.Forms.ComboBox roleCb;
		private Bunifu.Framework.UI.BunifuThinButton2 loginBtn;
		private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
		private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
		private Bunifu.Framework.UI.BunifuCustomLabel clearlb;
	}
}

