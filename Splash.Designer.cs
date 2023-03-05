namespace SupermarketTuto1
{
	partial class Splash
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
			this.components = new System.ComponentModel.Container();
			this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
			this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
			this.MyProgressBar = new Bunifu.Framework.UI.BunifuProgressBar();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// bunifuCustomLabel1
			// 
			this.bunifuCustomLabel1.AutoSize = true;
			this.bunifuCustomLabel1.Font = new System.Drawing.Font("Georgia", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
			this.bunifuCustomLabel1.Location = new System.Drawing.Point(184, 187);
			this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
			this.bunifuCustomLabel1.Size = new System.Drawing.Size(429, 29);
			this.bunifuCustomLabel1.TabIndex = 4;
			this.bunifuCustomLabel1.Text = "FoodLovers Management System";
			// 
			// bunifuCustomLabel2
			// 
			this.bunifuCustomLabel2.AutoSize = true;
			this.bunifuCustomLabel2.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.White;
			this.bunifuCustomLabel2.Location = new System.Drawing.Point(339, 216);
			this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
			this.bunifuCustomLabel2.Size = new System.Drawing.Size(81, 18);
			this.bunifuCustomLabel2.TabIndex = 5;
			this.bunifuCustomLabel2.Text = "version 1.0";
			// 
			// MyProgressBar
			// 
			this.MyProgressBar.BackColor = System.Drawing.Color.DarkRed;
			this.MyProgressBar.BorderRadius = 5;
			this.MyProgressBar.Location = new System.Drawing.Point(200, 278);
			this.MyProgressBar.MaximumValue = 100;
			this.MyProgressBar.Name = "MyProgressBar";
			this.MyProgressBar.ProgressColor = System.Drawing.Color.LightCoral;
			this.MyProgressBar.Size = new System.Drawing.Size(390, 10);
			this.MyProgressBar.TabIndex = 6;
			this.MyProgressBar.Value = 0;
			this.MyProgressBar.progressChanged += new System.EventHandler(this.MyProgressBar_progressChanged);
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// Splash
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DarkRed;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.MyProgressBar);
			this.Controls.Add(this.bunifuCustomLabel2);
			this.Controls.Add(this.bunifuCustomLabel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Splash";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Splash";
			this.Load += new System.EventHandler(this.Splash_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
		private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
		private Bunifu.Framework.UI.BunifuProgressBar MyProgressBar;
		private System.Windows.Forms.Timer timer1;
	}
}