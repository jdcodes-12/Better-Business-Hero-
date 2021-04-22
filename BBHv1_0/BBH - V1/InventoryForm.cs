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

namespace BBH___V1
{
    public partial class InventoryForm : Form
    {

        //Sql Connection
        SqlConnection connection = new SqlConnection(@"Data Source=MSI;Initial Catalog=BBHdb;Integrated Security=True");

        public InventoryForm()
        {
            InitializeComponent();
        }

        //Exit App
        private void exitButton_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        //Inventory Category Navigation
        private void categoryButton_Click(object sender, EventArgs e)
        {
            CategoryForm catForm = new CategoryForm();
            catForm.Show();
            this.Hide();
        }

        //Employee Navigation
        private void employeesBtn_Click(object sender, EventArgs e)
        {
            EmployeeForm empForm = new EmployeeForm();
            empForm.Show();
            this.Hide();
        }

        //Fill ComboBox
        private void fillComboBox()
        {
            connection.Open();
            SqlCommand command = new SqlCommand("select catName from invenCategories", connection);
            SqlDataReader reader;
            reader = command.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("catName", typeof(string));
            dataTable.Load(reader);
            itemCatCb.ValueMember = "catName";
            itemCatCb.DataSource = dataTable;
            connection.Close();
        }

        //Emp Cat Navigation
        private void empCatBtn_Click(object sender, EventArgs e)
        {
            EmpCat eCatForm = new EmpCat();
            eCatForm.Show();
            this.Hide();
        } 

        //Initial Load Data
        private void InventoryForm_Load(object sender, EventArgs e)
        {
            populate();
            fillComboBox();
        }

        //Populate DGV
        private void populate()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }

            connection.Open();
            string query = "SELECT * FROM InventorySheets";
            SqlDataAdapter sda = new SqlDataAdapter(query, connection);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var dataSet = new DataSet();
            sda.Fill(dataSet);
            invDGV.DataSource = dataSet.Tables[0];
            connection.Close();
        }

        //C - Create Inventory Item
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }

                connection.Open();
                string query = "insert into InventorySheets values("+idTb.Text+
                                                                   ",'"+itemNameTb.Text+
                                                                   "',"+unitCostTb.Text+
                                                                   ","+itemQtyTb.Text+
                                                                   ",'"+purchaseDateLabel.Text+
                                                                   "','"+itemCatCb.SelectedValue.ToString()+"')";

                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
                MessageBox.Show("Item Succesfully Added");
                connection.Close();
                populate();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Edit Inventory Item
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }

                if (idTb.Text == "")
                {
                    MessageBox.Show("Please select an Id to edit");
                }

                connection.Open();
                string query =  "update inventorySheets"+
                                "set Id='"+idTb.Text+
                                "',ItemName='"+itemNameTb.Text+"" +
                                "',UnitCost="+unitCostTb.Text+
                                ",ItemQty="+itemQtyTb.Text+
                                ",PurchaseDate="+purchaseTb.Text+
                                ",CatId="+itemCatCb.SelectedValue.ToString()+
                                ", where id="+idTb.Text +" ";


                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
                MessageBox.Show("Category Updated Successfully");
                connection.Close();
                populate();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Delete Item 
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }

                if (idTb.Text == "")
                {
                    MessageBox.Show("Select a valid category to delete");
                }
                else
                {
                    connection.Open();
                    string query = "delete from InventorySheets where Id="+idTb.Text +"";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Category Successfully Deleted");
                    connection.Close();
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
