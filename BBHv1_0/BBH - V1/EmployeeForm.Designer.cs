
namespace BBH___V1
{
    partial class EmployeeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.idTb = new System.Windows.Forms.TextBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.refreshButton = new System.Windows.Forms.Button();
            this.positionGridComboBox = new System.Windows.Forms.ComboBox();
            this.empDGV = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.hourlyWageTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.EINTextBox = new System.Windows.Forms.TextBox();
            this.positionComboBox = new System.Windows.Forms.ComboBox();
            this.jobPositionLabel = new System.Windows.Forms.Label();
            this.hourlyWageLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.EINLabel = new System.Windows.Forms.Label();
            this.employeeLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.inventoryBtn = new System.Windows.Forms.Button();
            this.categoryButton = new System.Windows.Forms.Button();
            this.passwordTb = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.empCatBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(23)))), ((int)(((byte)(53)))));
            this.panel1.Controls.Add(this.passwordTb);
            this.panel1.Controls.Add(this.passwordLabel);
            this.panel1.Controls.Add(this.idTb);
            this.panel1.Controls.Add(this.idLabel);
            this.panel1.Controls.Add(this.refreshButton);
            this.panel1.Controls.Add(this.positionGridComboBox);
            this.panel1.Controls.Add(this.empDGV);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.addBtn);
            this.panel1.Controls.Add(this.hourlyWageTextBox);
            this.panel1.Controls.Add(this.lastNameTextBox);
            this.panel1.Controls.Add(this.firstNameTextBox);
            this.panel1.Controls.Add(this.EINTextBox);
            this.panel1.Controls.Add(this.positionComboBox);
            this.panel1.Controls.Add(this.jobPositionLabel);
            this.panel1.Controls.Add(this.hourlyWageLabel);
            this.panel1.Controls.Add(this.firstNameLabel);
            this.panel1.Controls.Add(this.lastNameLabel);
            this.panel1.Controls.Add(this.EINLabel);
            this.panel1.Controls.Add(this.employeeLabel);
            this.panel1.Controls.Add(this.exitButton);
            this.panel1.Location = new System.Drawing.Point(186, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1158, 809);
            this.panel1.TabIndex = 0;
            // 
            // idTb
            // 
            this.idTb.BackColor = System.Drawing.Color.MintCream;
            this.idTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.idTb.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(76)))), ((int)(((byte)(112)))));
            this.idTb.Location = new System.Drawing.Point(204, 225);
            this.idTb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.idTb.Name = "idTb";
            this.idTb.Size = new System.Drawing.Size(206, 23);
            this.idTb.TabIndex = 23;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.idLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(76)))), ((int)(((byte)(112)))));
            this.idLabel.Location = new System.Drawing.Point(43, 223);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(26, 23);
            this.idLabel.TabIndex = 22;
            this.idLabel.Text = "id";
            // 
            // refreshButton
            // 
            this.refreshButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshButton.FlatAppearance.BorderSize = 0;
            this.refreshButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(54)))), ((int)(((byte)(96)))));
            this.refreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.refreshButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(204)))), ((int)(((byte)(210)))));
            this.refreshButton.Location = new System.Drawing.Point(979, 157);
            this.refreshButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(168, 50);
            this.refreshButton.TabIndex = 21;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            // 
            // positionGridComboBox
            // 
            this.positionGridComboBox.BackColor = System.Drawing.Color.MintCream;
            this.positionGridComboBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.positionGridComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.positionGridComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.positionGridComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(76)))), ((int)(((byte)(112)))));
            this.positionGridComboBox.FormattingEnabled = true;
            this.positionGridComboBox.Location = new System.Drawing.Point(745, 157);
            this.positionGridComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.positionGridComboBox.Name = "positionGridComboBox";
            this.positionGridComboBox.Size = new System.Drawing.Size(205, 31);
            this.positionGridComboBox.TabIndex = 20;
            this.positionGridComboBox.Text = "Select Role";
            // 
            // empDGV
            // 
            this.empDGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(54)))), ((int)(((byte)(96)))));
            this.empDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.empDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.empDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.empDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.empDGV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.empDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(23)))), ((int)(((byte)(53)))));
            this.empDGV.Location = new System.Drawing.Point(458, 210);
            this.empDGV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.empDGV.Name = "empDGV";
            this.empDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.empDGV.RowHeadersWidth = 51;
            this.empDGV.RowTemplate.Height = 24;
            this.empDGV.Size = new System.Drawing.Size(688, 582);
            this.empDGV.TabIndex = 19;
            this.empDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.empDGV_CellContentClick);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(54)))), ((int)(((byte)(96)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(204)))), ((int)(((byte)(210)))));
            this.button3.Location = new System.Drawing.Point(315, 730);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(136, 68);
            this.button3.TabIndex = 18;
            this.button3.Text = "Edit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(54)))), ((int)(((byte)(96)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(204)))), ((int)(((byte)(210)))));
            this.button2.Location = new System.Drawing.Point(170, 730);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 68);
            this.button2.TabIndex = 17;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // addBtn
            // 
            this.addBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBtn.FlatAppearance.BorderSize = 0;
            this.addBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(54)))), ((int)(((byte)(96)))));
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBtn.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.addBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(204)))), ((int)(((byte)(210)))));
            this.addBtn.Location = new System.Drawing.Point(18, 730);
            this.addBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(145, 62);
            this.addBtn.TabIndex = 16;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // hourlyWageTextBox
            // 
            this.hourlyWageTextBox.BackColor = System.Drawing.Color.MintCream;
            this.hourlyWageTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.hourlyWageTextBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.hourlyWageTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(76)))), ((int)(((byte)(112)))));
            this.hourlyWageTextBox.Location = new System.Drawing.Point(204, 528);
            this.hourlyWageTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.hourlyWageTextBox.Name = "hourlyWageTextBox";
            this.hourlyWageTextBox.Size = new System.Drawing.Size(206, 23);
            this.hourlyWageTextBox.TabIndex = 14;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.BackColor = System.Drawing.Color.MintCream;
            this.lastNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lastNameTextBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lastNameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(76)))), ((int)(((byte)(112)))));
            this.lastNameTextBox.Location = new System.Drawing.Point(204, 460);
            this.lastNameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(206, 23);
            this.lastNameTextBox.TabIndex = 13;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.BackColor = System.Drawing.Color.MintCream;
            this.firstNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.firstNameTextBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.firstNameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(76)))), ((int)(((byte)(112)))));
            this.firstNameTextBox.Location = new System.Drawing.Point(204, 402);
            this.firstNameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(206, 23);
            this.firstNameTextBox.TabIndex = 12;
            // 
            // EINTextBox
            // 
            this.EINTextBox.BackColor = System.Drawing.Color.MintCream;
            this.EINTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EINTextBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EINTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(76)))), ((int)(((byte)(112)))));
            this.EINTextBox.Location = new System.Drawing.Point(204, 279);
            this.EINTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EINTextBox.Name = "EINTextBox";
            this.EINTextBox.Size = new System.Drawing.Size(206, 23);
            this.EINTextBox.TabIndex = 11;
            // 
            // positionComboBox
            // 
            this.positionComboBox.BackColor = System.Drawing.Color.MintCream;
            this.positionComboBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.positionComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.positionComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.positionComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(76)))), ((int)(((byte)(112)))));
            this.positionComboBox.FormattingEnabled = true;
            this.positionComboBox.Items.AddRange(new object[] {
            "Associate",
            "Shift Lead",
            "Manager"});
            this.positionComboBox.Location = new System.Drawing.Point(204, 595);
            this.positionComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.positionComboBox.Name = "positionComboBox";
            this.positionComboBox.Size = new System.Drawing.Size(205, 31);
            this.positionComboBox.TabIndex = 10;
            this.positionComboBox.Text = "Select Role";
            // 
            // jobPositionLabel
            // 
            this.jobPositionLabel.AutoSize = true;
            this.jobPositionLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.jobPositionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(76)))), ((int)(((byte)(112)))));
            this.jobPositionLabel.Location = new System.Drawing.Point(43, 607);
            this.jobPositionLabel.Name = "jobPositionLabel";
            this.jobPositionLabel.Size = new System.Drawing.Size(107, 23);
            this.jobPositionLabel.TabIndex = 9;
            this.jobPositionLabel.Text = "Job Position";
            // 
            // hourlyWageLabel
            // 
            this.hourlyWageLabel.AutoSize = true;
            this.hourlyWageLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.hourlyWageLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(76)))), ((int)(((byte)(112)))));
            this.hourlyWageLabel.Location = new System.Drawing.Point(43, 528);
            this.hourlyWageLabel.Name = "hourlyWageLabel";
            this.hourlyWageLabel.Size = new System.Drawing.Size(114, 23);
            this.hourlyWageLabel.TabIndex = 7;
            this.hourlyWageLabel.Text = "Hourly Wage";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.firstNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(76)))), ((int)(((byte)(112)))));
            this.firstNameLabel.Location = new System.Drawing.Point(46, 402);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(97, 23);
            this.firstNameLabel.TabIndex = 6;
            this.firstNameLabel.Text = "First Name";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lastNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(76)))), ((int)(((byte)(112)))));
            this.lastNameLabel.Location = new System.Drawing.Point(46, 460);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(94, 23);
            this.lastNameLabel.TabIndex = 5;
            this.lastNameLabel.Text = "Last Name";
            // 
            // EINLabel
            // 
            this.EINLabel.AutoSize = true;
            this.EINLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.EINLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(76)))), ((int)(((byte)(112)))));
            this.EINLabel.Location = new System.Drawing.Point(43, 278);
            this.EINLabel.Name = "EINLabel";
            this.EINLabel.Size = new System.Drawing.Size(52, 23);
            this.EINLabel.TabIndex = 4;
            this.EINLabel.Text = "EIN #";
            // 
            // employeeLabel
            // 
            this.employeeLabel.AutoSize = true;
            this.employeeLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(76)))), ((int)(((byte)(112)))));
            this.employeeLabel.Location = new System.Drawing.Point(451, 43);
            this.employeeLabel.Name = "employeeLabel";
            this.employeeLabel.Size = new System.Drawing.Size(262, 32);
            this.employeeLabel.TabIndex = 3;
            this.employeeLabel.Text = "MANAGE EMPLOYEES";
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(54)))), ((int)(((byte)(96)))));
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(204)))), ((int)(((byte)(210)))));
            this.exitButton.Location = new System.Drawing.Point(1099, 4);
            this.exitButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(55, 68);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "X";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click_1);
            // 
            // inventoryBtn
            // 
            this.inventoryBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.inventoryBtn.FlatAppearance.BorderSize = 0;
            this.inventoryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inventoryBtn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(76)))), ((int)(((byte)(112)))));
            this.inventoryBtn.Location = new System.Drawing.Point(6, 147);
            this.inventoryBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.inventoryBtn.Name = "inventoryBtn";
            this.inventoryBtn.Size = new System.Drawing.Size(173, 68);
            this.inventoryBtn.TabIndex = 0;
            this.inventoryBtn.Text = "Inventory";
            this.inventoryBtn.UseVisualStyleBackColor = true;
            this.inventoryBtn.Click += new System.EventHandler(this.inventoryBtn_Click);
            // 
            // categoryButton
            // 
            this.categoryButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.categoryButton.FlatAppearance.BorderSize = 0;
            this.categoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.categoryButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(76)))), ((int)(((byte)(112)))));
            this.categoryButton.Location = new System.Drawing.Point(6, 242);
            this.categoryButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.categoryButton.Name = "categoryButton";
            this.categoryButton.Size = new System.Drawing.Size(173, 75);
            this.categoryButton.TabIndex = 1;
            this.categoryButton.Text = "Inv. Categories";
            this.categoryButton.UseVisualStyleBackColor = true;
            this.categoryButton.Click += new System.EventHandler(this.categoryButton_Click);
            // 
            // passwordTb
            // 
            this.passwordTb.BackColor = System.Drawing.Color.MintCream;
            this.passwordTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTb.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.passwordTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(76)))), ((int)(((byte)(112)))));
            this.passwordTb.Location = new System.Drawing.Point(204, 343);
            this.passwordTb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.passwordTb.Name = "passwordTb";
            this.passwordTb.Size = new System.Drawing.Size(206, 23);
            this.passwordTb.TabIndex = 25;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.passwordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(76)))), ((int)(((byte)(112)))));
            this.passwordLabel.Location = new System.Drawing.Point(46, 343);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(85, 23);
            this.passwordLabel.TabIndex = 24;
            this.passwordLabel.Text = "Password";
            // 
            // empCatBtn
            // 
            this.empCatBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.empCatBtn.FlatAppearance.BorderSize = 0;
            this.empCatBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.empCatBtn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empCatBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(76)))), ((int)(((byte)(112)))));
            this.empCatBtn.Location = new System.Drawing.Point(7, 335);
            this.empCatBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.empCatBtn.Name = "empCatBtn";
            this.empCatBtn.Size = new System.Drawing.Size(173, 90);
            this.empCatBtn.TabIndex = 6;
            this.empCatBtn.Text = "Emp. Categories";
            this.empCatBtn.UseVisualStyleBackColor = true;
            this.empCatBtn.Click += new System.EventHandler(this.empCatBtn_Click);
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(54)))), ((int)(((byte)(96)))));
            this.ClientSize = new System.Drawing.Size(1346, 811);
            this.Controls.Add(this.empCatBtn);
            this.Controls.Add(this.categoryButton);
            this.Controls.Add(this.inventoryBtn);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "EmployeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.EmployeeForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button inventoryBtn;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label jobPositionLabel;
        private System.Windows.Forms.Label hourlyWageLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label EINLabel;
        private System.Windows.Forms.Label employeeLabel;
        private System.Windows.Forms.TextBox hourlyWageTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox EINTextBox;
        private System.Windows.Forms.ComboBox positionComboBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.ComboBox positionGridComboBox;
        private System.Windows.Forms.DataGridView empDGV;
        private System.Windows.Forms.TextBox idTb;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Button categoryButton;
        private System.Windows.Forms.TextBox passwordTb;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Button empCatBtn;
    }
}