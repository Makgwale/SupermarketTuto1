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
	public partial class CategoryForm : Form
	{
		public CategoryForm()
		{
			InitializeComponent();
		}
		SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Apple Lady\Documents\smarketdb.mdf"";Integrated Security=True;Connect Timeout=30");

		private void Addbtn_Click(object sender, EventArgs e)
		{
			try
			{
				Con.Open();
				string query = "insert into CategoryTbl values(" + CartIdTb.Text + ",'" + CartNameTb.Text + "','" + CartDescTb.Text + "')";
				SqlCommand cmd = new SqlCommand(query, Con);
				cmd.ExecuteNonQuery();
				MessageBox.Show("Category Added Successfully");
				Con.Close();
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void CartExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
		private void populate()
		{
			Con.Open();
			string query = "select * from CategoryTbl";
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, Con);
			SqlCommandBuilder builder = new SqlCommandBuilder(sqlDataAdapter);
			var dataSet = new DataSet(); 
			sqlDataAdapter.Fill(dataSet);
			CartDGV.DataSource = dataSet.Tables[0];
			Con.Close();

		}

		private void CategoryForm_Load(object sender, EventArgs e)
		{
			
		}

		private void CategoryForm_Load_1(object sender, EventArgs e)
		{
			populate();
		}

		private void CartDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			CartIdTb.Text = CartDGV.SelectedRows[0].Cells[0].Value.ToString();
			CartNameTb.Text = CartDGV.SelectedRows[0].Cells[1].Value.ToString();
			CartDescTb.Text = CartDGV.SelectedRows[0].Cells[2].Value.ToString();

		}

		private void DeleteBtn_Click(object sender, EventArgs e)
		{
			try
			{
				if(CartIdTb.Text == "")
				{
					MessageBox.Show("Select The Category To Delete");
				}
				else
				{
					Con.Open();
					string query ="delete from categoryTbl where categoryId=" +CartIdTb.Text+ "";
					SqlCommand cmd = new SqlCommand(query, Con);
					cmd.ExecuteNonQuery();
					MessageBox.Show("Category Deleted Successfully.");
					Con.Close();
					populate(); 
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void EditBtn_Click(object sender, EventArgs e)
		{
			try
			{
				if(CartIdTb.Text == "" || CartNameTb.Text=="" || CartDescTb.Text == "")
				{
					MessageBox.Show("Missing Information");
				}
				else
				Con.Open();
				string query = "update CategoryTbl set CategoryName='" + CartNameTb.Text + "',CategoryDesc='" + CartDescTb.Text + "' where CategoryId=" + CartIdTb.Text + ";";
				SqlCommand cmd = new SqlCommand(query, Con);
				cmd.ExecuteNonQuery();
				MessageBox.Show("Category Successfully Updated");
				Con.Close();
				populate(); 
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
	}
}
