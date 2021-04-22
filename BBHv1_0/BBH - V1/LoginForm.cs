using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BBH___V1
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }


        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void clearLabel_Click(object sender, EventArgs e)
        {
            usernameTb.Text = "";
            passwordTb.Text = "";
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if(usernameTb.Text=="" || passwordTb.Text=="")
            {
                MessageBox.Show("Enter a username and password");
            }
            else
            {
                try { 
                    if(roleCb.SelectedItem.ToString() =="Admin")
                    {
                        if(usernameTb.Text =="Admin" && passwordTb.Text =="Admin")
                        {
                            EmployeeForm employeeForm = new EmployeeForm();
                            employeeForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("If you are the Admin, Enter correct credentials");
                        }
                    
                    }
                    else if(roleCb.SelectedItem.ToString() == "Financial Dept.")
                    {
                        if(usernameTb.Text=="fd12" && passwordTb.Text=="fd12")
                        {
                            InventoryForm inventoryForm = new InventoryForm();
                            inventoryForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("If you are Financial Dept, Enter correct credientials");
                        }
                    }
                    else if(roleCb.SelectedItem == null)
                    {
                        MessageBox.Show("Please select a role");
                    }

                } catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }    
        }
    }
}
