using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SupermarketTuto1
{
	public partial class ProductForm : Form
	{
		public ProductForm()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{

		}
		SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Apple Lady\Documents\smarketdb.mdf"";Integrated Security=True;Connect Timeout=30");
		private void button5_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

	
		private void button2_Click(object sender, EventArgs e)
		{

		}

		private void button3_Click(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}
		private void fillcombo()
		{
			//This method will bind the combobox with the database

		}

		private void ProductForm_Load(object sender, EventArgs e)
		{

		}

		private void button4_Click(object sender, EventArgs e)
		{

		}
	}
}
