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
    public partial class CategoryForm : Form
    {

        SqlConnection connection = new SqlConnection(@"Data Source=MSI;Initial Catalog=BBHdb;Integrated Security=True");

        public CategoryForm()
        {
            InitializeComponent();
        }

        //Initial Load
        private void CategoryForm_Load(object sender, EventArgs e)
        {
            populate();
        }

        //Exit Application
        private void exitButton_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }


        //Employee Form Navigation
        private void employeesBtn_Click(object sender, EventArgs e)
        {
            EmployeeForm empForm = new EmployeeForm();
            empForm.Show();
            this.Hide();
        }

        //Inventory Form Navigation
        private void inventoryBtn_Click(object sender, EventArgs e)
        {
            InventoryForm inForm = new InventoryForm();
            inForm.Show();
            this.Hide();
        }

        //Emp categories Navigation
        private void empCatBtn_Click(object sender, EventArgs e)
        {
            EmpCat eCatForm = new EmpCat();
            eCatForm.Show();
            this.Hide();
        }

        //Populate DGV
        private void populate()
        {
            if(connection.State == ConnectionState.Open)
            {
                connection.Close();
            }

            connection.Open();
            string query = "SELECT * FROM invenCategories";
            SqlDataAdapter sda = new SqlDataAdapter(query, connection);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var dataSet = new DataSet();
            sda.Fill(dataSet);
            CatDGV.DataSource = dataSet.Tables[0];
            connection.Close();
        }

       
        //Selected Cell Functionality
        private void CatDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                CatIdTextBox.Text = CatDGV.SelectedRows[0].Cells[0].Value.ToString();
                CatNameTextBox.Text = CatDGV.SelectedRows[0].Cells[1].Value.ToString();
                CatDescTextBox.Text = CatDGV.SelectedRows[0].Cells[2].Value.ToString();
        }

        //ComboBox Functionality
        private void positionGridComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //Refresh Button Functionality
        private void refreshButton_Click(object sender, EventArgs e)
        {

        }


        //C - Create
        private void addCatBtn_Click(object sender, EventArgs e)
        {
            try
            {

                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }

                connection.Open();
                string query = "insert into invenCategories values("+CatIdTextBox.Text+
                                                                   ",'"+CatNameTextBox.Text+
                                                                   "','"+CatDescTextBox.Text+"')";

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


        //D - Delete
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if(connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }

                if(CatIdTextBox.Text == "")
                {
                    MessageBox.Show("Select a valid category to delete");
                }
                else
                {
                    connection.Open();
                    string query = "delete from invenCategories where CatId="+CatIdTextBox.Text+"";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Category Successfully Deleted");
                    connection.Close();
                    populate();
                }
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //U - Update & Read
        private void editBtn_Click(object sender, EventArgs e)
        {
            try{

                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }

                if (CatIdTextBox.Text =="")
                {
                    MessageBox.Show("Please select a record's Id to delete");
                }

                connection.Open();
                string query = "update invenCategories set CatName='"+CatNameTextBox.Text+ 
                                                                   "',CatDesc='"+CatDescTextBox.Text+ 
                                                                   "' where CatId="+CatIdTextBox.Text+"";

                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
                MessageBox.Show("Category Updated Successfully");
                connection.Close();
                populate();

            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
        private void CatDescTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CatNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CatIdTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void catNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void catDescLabel_Click(object sender, EventArgs e)
        {

        }

        private void CatIdLabel_Click(object sender, EventArgs e)
        {

        }
        
    }
}
