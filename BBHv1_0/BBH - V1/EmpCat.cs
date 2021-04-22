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
    public partial class EmpCat : Form
    {

        //Sql Connection
        SqlConnection connection = new SqlConnection(@"Data Source=MSI;Initial Catalog=BBHdb;Integrated Security=True");

        public EmpCat()
        {
            InitializeComponent();
        }

        //Exit Application
        private void exitButton_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

     
        //Emp Navigation form
        private void employeesBtn_Click_1(object sender, EventArgs e)
        {
            EmployeeForm empForm = new EmployeeForm();
            empForm.Show();
            this.Hide();
        }

        //Inventory Form Navigation

        private void inventoryBtn_Click_1(object sender, EventArgs e)
        {
            InventoryForm inForm = new InventoryForm();
            inForm.Show();
            this.Hide();
        }

        //Inventory Cagetgories
        private void categoryButton_Click(object sender, EventArgs e)
        {
            CategoryForm catForm = new CategoryForm();
            catForm.Show();
            this.Hide();
        }


        //Populate DGV
        private void populate()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }

            connection.Open();
            string query = "SELECT * FROM EmpCat";
            SqlDataAdapter sda = new SqlDataAdapter(query, connection);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var dataSet = new DataSet();
            sda.Fill(dataSet);
            empDGV.DataSource = dataSet.Tables[0];
            connection.Close();
        }

        //C - Create
        private void addBtn_Click_1(object sender, EventArgs e)
        {
            try
            {

                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }

                connection.Open();
                string query = "insert into EmpCat values(" + EmpIdTextBox.Text + ",'" + EmpNameTextBox.Text + "','" + EmpDescTextBox.Text + "')";
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
                MessageBox.Show("Category Succesfully Added");
                connection.Close();
                populate();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        //U - Update
        private void editBtn_Click_1(object sender, EventArgs e)
        {
            try
            {

                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }

                if (EmpIdTextBox.Text == "" | EmpNameTextBox.Text == "" | EmpDescTextBox.Text == "")
                {
                    MessageBox.Show("Please fill all fields to update records");
                }
                connection.Open();
                string query = "update EmpCat set CatName='" + EmpNameTextBox.Text + "',CatDesc='" + EmpDescTextBox.Text + "' where Id=" + EmpIdTextBox.Text + "";
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

        //D - Delete
        private void deleteBtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }

                if (EmpIdTextBox.Text == "")
                {
                    MessageBox.Show("Select a valid category to delete");
                }
                else
                {
                    connection.Open();
                    string query = "delete from EmpCat where Id=" + EmpIdTextBox.Text + "";
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

        //Initial Load
        private void EmpCat_Load_1(object sender, EventArgs e)
        {
            populate();
        }
    }
}
