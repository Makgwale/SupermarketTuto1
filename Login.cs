using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupermarketTuto1
{
	public partial class Login : Form
	{
		public Login()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void guna2CircleButton1_Click(object sender, EventArgs e)
		{

		}

		private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
		{

		}

		private void bunifuCustomLabel3_Click(object sender, EventArgs e)
		{

		}

		private void bunifuCustomLabel5_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void bunifuCustomLabel6_Click(object sender, EventArgs e)
		{
			usernameTb.Text = "";
			passwordTb.Text = "";
		}

		private void loginBtn_Click(object sender, EventArgs e)
		{
			if(usernameTb.Text == "" || passwordTb.Text == "")
			{
				MessageBox.Show("Please enter all fields");
			}
			else
			{
				if (roleCb.SelectedIndex > -1)
				{

					if (roleCb.SelectedItem.ToString() == "ADMIN")
					{
						if (usernameTb.Text == "Admin" && passwordTb.Text == "Admin")
						{
							ProductForm prod = new ProductForm();
							prod.Show();
							this.Hide();

						}
						else
						{
							MessageBox.Show("If You Are The Admin, Enter The Correct Username and Password");

						}
					}
				}
				else
				{
					MessageBox.Show("Select a role");
				}
			}
		}
	}
}
