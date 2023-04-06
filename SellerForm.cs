using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SupermarketTuto1
{
	public partial class SellerForm : Form
	{
		public SellerForm()
		{
			InitializeComponent();
		}
		SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Apple Lady\Documents\smarketdb.mdf"";Integrated Security=True;Connect Timeout=30");

		private void addBtn_Click(object sender, EventArgs e)
		{
			try
			{
				Con.Open();
				string query = "insert into SellerTbl values (" + sellerIdTb.Text + ", '" + sellerNameTb.Text + "'," + sellerAgeTb.Text + ",'" + sellerCellTb.Text + "','" + sellerPasTb.Text + "')";
				SqlCommand cmd = new SqlCommand(query, Con);
				cmd.ExecuteNonQuery();
				MessageBox.Show("Seller Added Successfully");
				Con.Close();
				populate();

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void exitBtn_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void editBtn_Click(object sender, EventArgs e)
		{
			try
			{
				if (sellerIdTb.Text == "" || sellerNameTb.Text == "" || sellerAgeTb.Text == "" || sellerCellTb.Text == "" || sellerPasTb.Text == "")
				{
					MessageBox.Show("Please complete all fields in the form");
				}
				else
				{
					Con.Open();
					string query = "update SellerTbl set SellerName='" + sellerNameTb.Text + "', SellerAge='" + sellerAgeTb.Text + "',SellerPhone='" + sellerCellTb.Text + "',SellerPass='" + sellerPasTb.Text + "' where SellerId= " + sellerIdTb.Text + ";";
					SqlCommand cmd = new SqlCommand(query, Con);
					cmd.ExecuteNonQuery();
					MessageBox.Show("Seller updated successfully");
					Con.Close();
					populate();
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		
		}

		private void sellerGDV_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			sellerIdTb.Text = sellerGDV.SelectedRows[0].Cells[0].Value.ToString();
			sellerNameTb.Text = sellerGDV.SelectedRows[0].Cells[1].Value.ToString();
			sellerAgeTb.Text = sellerGDV.SelectedRows[0].Cells[2].Value.ToString();
			sellerCellTb.Text = sellerGDV.SelectedRows[0].Cells[3].Value.ToString();
			sellerPasTb.Text = sellerGDV.SelectedRows[0].Cells[4].Value.ToString();
		}
		private void populate()
		{
			Con.Open();
			string query = "select * from SellerTbl";
			SqlDataAdapter dataAdapter = new SqlDataAdapter(query, Con);
			SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
			var dataset = new DataSet();
			dataAdapter.Fill(dataset);
			sellerGDV.DataSource = dataset.Tables[0];
			Con.Close();
		}

		private void delBtn_Click(object sender, EventArgs e)
		{
			try
			{
				if (sellerIdTb.Text == "")
				{
					MessageBox.Show("Please select row to delete");
				}
				else
				{
					Con.Open();
					string query = "delete from SellerTbl where SellerId = " + sellerIdTb.Text + "";
					SqlCommand cmd = new SqlCommand(query, Con);
					cmd.ExecuteNonQuery();
					MessageBox.Show("Seller successfully deleted");
					Con.Close();
					populate();
					sellerIdTb.Text = "";
					sellerNameTb.Text = "";
					sellerAgeTb.Text = "";
					sellerCellTb.Text = "";
					sellerPasTb.Text = "";
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void SellerForm_Load(object sender, EventArgs e)
		{
			populate();
		}

		private void productFormBtn_Click(object sender, EventArgs e)
		{
			ProductForm productForm = new ProductForm();
			productForm.Show();
			this.Hide();
		}

		private void categoryFomBtn_Click(object sender, EventArgs e)
		{
			CategoryForm categoryForm = new CategoryForm();
			categoryForm.Show();
			this.Hide();
		}
	}
}
