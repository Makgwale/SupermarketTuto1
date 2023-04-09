using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SupermarketTuto1
{
	public partial class SellingForm : Form
	{
		SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Apple Lady\Documents\smarketdb.mdf"";Integrated Security=True;Connect Timeout=30");
		
			public SellingForm()
		{
			InitializeComponent();
		}
		public void populate()
		{
			Con.Open();
			string query = "select ProductName,ProductQty from ProductTbl";
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, Con);
			SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
			var ds = new DataSet();
			sqlDataAdapter.Fill(ds);
			ProdDGV1.DataSource = ds.Tables[0];
			Con.Close();
		}

		private void exitBtn_Click(object sender, EventArgs e)
		{

		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{
			Datelbl.Text = DateTime.Today.Day.ToString() + "/" + DateTime.Today.Month.ToString() + "/" + DateTime.Today.Year.ToString();
		}

		private void SellingForm_Load(object sender, EventArgs e)
		{
			populate();
		}

		private void ProdIdTB_OnValueChanged(object sender, EventArgs e)
		{

		}

		private void ProdDGV1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			ProdNameTB.Text = ProdDGV1.SelectedRows[0].Cells[0].Value.ToString();
			ProdPriceTb.Text = ProdDGV1.SelectedRows[0].Cells[1].Value.ToString();
		}
	}
}
