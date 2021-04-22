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
    public partial class EmployeeForm : Form
    {

        //SQL Connection
        SqlConnection connection = new SqlConnection(@"Data Source=MSI;Initial Catalog=BBHdb;Integrated Security=True");

        public EmployeeForm()
        {
            InitializeComponent();
        }

        //Initial Load Data
        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            fillComboBox();
            populate();
        }


        //Exit Application
        private void exitButton_Click_1(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        //Inventory Category Form Navigation
        private void categoryButton_Click(object sender, EventArgs e)
        {
            CategoryForm catForm = new CategoryForm();
            catForm.Show();
            this.Hide();
        }

        //Inventory Form Navigation
        private void inventoryBtn_Click(object sender, EventArgs e)
        {
            InventoryForm inForm = new InventoryForm();
            inForm.Show();
            this.Hide();
        }

        //Emp Category navigation
        private void empCatBtn_Click(object sender, EventArgs e)
        {
            EmpCat eCatForm = new EmpCat();
            eCatForm.Show();
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
            string query = "SELECT * FROM Employees";
            SqlDataAdapter sda = new SqlDataAdapter(query, connection);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var dataSet = new DataSet();
            sda.Fill(dataSet);
            empDGV.DataSource = dataSet.Tables[0];
            connection.Close();
        }

        //Fill ComboBox
        private void fillComboBox()
        {
            connection.Open();
            SqlCommand command = new SqlCommand("select catName from EmpCat", connection);
            SqlDataReader reader;
            reader = command.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("catName", typeof(string));
            dataTable.Load(reader);
            positionComboBox.ValueMember = "catName";
            positionComboBox.DataSource = dataTable;
            connection.Close();
        }
       
        //C - Create
        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {

                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }

                connection.Open();
                string query = "insert into Employees values(" + idTb.Text + "," + EINTextBox.Text + ",'" +passwordTb.Text+"','" + firstNameTextBox.Text +
                    "','" + lastNameTextBox + "'," + hourlyWageTextBox.Text + "," + positionComboBox.SelectedValue.ToString() + ")";

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

        private void empDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //Delete
        private void button2_Click(object sender, EventArgs e)
        {

        }


        //U - Edit & Read
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }

                if (idTb.Text == "" | passwordTb.Text == "" | firstNameTextBox.Text == "" | lastNameTextBox.Text == "")
                {
                    MessageBox.Show("Please fill all required fields to update records");
                }

                connection.Open();
                string query = ("update Employees set Id=" + idTb.Text + ",EIN=" + EINTextBox.Text + "',Password='"+passwordTb.Text+
                                "',FirstName='"+firstNameTextBox.Text+"',LastName='" + lastNameTextBox+ "',HourlyWage="+hourlyWageTextBox.Text+
                                ",Position="+positionComboBox.Text+", where id="+idTb.Text+""); 

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
    }
}
