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

		private void SellerFormBtn(object sender, EventArgs e)
		{
			SellerForm sellerForm = new SellerForm();
			sellerForm.Show();
			this.Hide();

		}
		SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Apple Lady\Documents\smarketdb.mdf"";Integrated Security=True;Connect Timeout=30");
		private void button5_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

	
		private void CategoryFormBtn_Click(object sender, EventArgs e)
		{
			CategoryForm categoryForm = new CategoryForm();
			categoryForm.Show();
			this.Hide();
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
			Con.Open();
			SqlCommand cmd = new SqlCommand("select CategoryName from CategoryTbl", Con);
			SqlDataReader sqlDataReader;
			sqlDataReader = cmd.ExecuteReader();
			DataTable dt = new DataTable();
			dt.Columns.Add("CatName", typeof(string));
			dt.Load(sqlDataReader);
			catCB.ValueMember = "CategoryName";
			catCB.DataSource = dt;
			Con.Close();

		}

		private void ProductForm_Load(object sender, EventArgs e)
		{
			fillcombo();
			populate();
		}

		private void AddBtn_Click(object sender, EventArgs e)
		{
			try
			{
				Con.Open();
				string query = "insert into ProductTbl values(" + ProdIdTB.Text + ",'" + ProdNameTB.Text + "'," + ProdQtyTB.Text + ","+ProdPriceTB.Text+",'"+catCB.SelectedValue.ToString()+"')";
				SqlCommand cmd = new SqlCommand(query, Con);
				cmd.ExecuteNonQuery();
				MessageBox.Show("Product Added Successfully");
				Con.Close();
				populate();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void ProdDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
              ProdIdTB.Text = ProdDGV.SelectedRows[0].Cells[0].Value.ToString();
			ProdNameTB.Text = ProdDGV.SelectedRows[0].Cells[1].Value.ToString();
			ProdQtyTB.Text = ProdDGV.SelectedRows[0].Cells[2].Value.ToString();
			ProdPriceTB.Text = ProdDGV.SelectedRows[0].Cells[3].Value.ToString();
			catCB.SelectedValue = ProdDGV.SelectedRows[0].Cells[4].Value.ToString();

		}
		private void populate()
		{
			Con.Open();
			string query = "select * from ProductTbl";
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, Con);
			SqlCommandBuilder builder = new SqlCommandBuilder(sqlDataAdapter);
			var dataSet = new DataSet();
			sqlDataAdapter.Fill(dataSet);
			ProdDGV.DataSource = dataSet.Tables[0];
			Con.Close();

		}

		private void EditBtn_Click(object sender, EventArgs e)
		{

			try
			{
				if (ProdIdTB.Text == "" || ProdNameTB.Text == "" || ProdQtyTB.Text == "" || ProdPriceTB.Text == "" || catCB.SelectedValue.ToString() == "")
				{
					MessageBox.Show("Missing Information");
				}
				else
					Con.Open();
				string query = "update ProductTbl set ProductName='" + ProdNameTB.Text + "',ProductQty=" + ProdQtyTB.Text + ",ProductPrice=" + ProdPriceTB.Text + ",ProductCat='" + catCB.Text + "' where ProductId=" + ProdIdTB.Text + ";";
				SqlCommand cmd = new SqlCommand(query, Con);
				cmd.ExecuteNonQuery();
				MessageBox.Show("Product Successfully Updated");
				Con.Close();
				populate();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void DelBtn_Click(object sender, EventArgs e)
		{
			try
			{
				if (ProdIdTB.Text == "")
				{
					MessageBox.Show("Select The product To Delete");
				}
				else
				{
					Con.Open();
					string query = "delete from ProductTbl where ProductId= "+ProdIdTB.Text+" ";
					SqlCommand cmd = new SqlCommand(query, Con);
					cmd.ExecuteNonQuery();
					MessageBox.Show("Product successfully deleted");
					Con.Close();
					populate();

				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
	}
}
