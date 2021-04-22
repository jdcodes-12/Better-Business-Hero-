
namespace BBH___V1
{
    partial class CategoryForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.refreshButton = new System.Windows.Forms.Button();
            this.positionGridComboBox = new System.Windows.Forms.ComboBox();
            this.CatDGV = new System.Windows.Forms.DataGridView();
            this.editBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.addCatBtn = new System.Windows.Forms.Button();
            this.CatDescTextBox = new System.Windows.Forms.TextBox();
            this.CatNameTextBox = new System.Windows.Forms.TextBox();
            this.CatIdTextBox = new System.Windows.Forms.TextBox();
            this.catNameLabel = new System.Windows.Forms.Label();
            this.catDescLabel = new System.Windows.Forms.Label();
            this.CatIdLabel = new System.Windows.Forms.Label();
            this.inventoryLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.inventoryBtn = new System.Windows.Forms.Button();
            this.employeesBtn = new System.Windows.Forms.Button();
            this.empCatBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CatDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(23)))), ((int)(((byte)(53)))));
            this.panel1.Controls.Add(this.refreshButton);
            this.panel1.Controls.Add(this.positionGridComboBox);
            this.panel1.Controls.Add(this.CatDGV);
            this.panel1.Controls.Add(this.editBtn);
            this.panel1.Controls.Add(this.deleteBtn);
            this.panel1.Controls.Add(this.addCatBtn);
            this.panel1.Controls.Add(this.CatDescTextBox);
            this.panel1.Controls.Add(this.CatNameTextBox);
            this.panel1.Controls.Add(this.CatIdTextBox);
            this.panel1.Controls.Add(this.catNameLabel);
            this.panel1.Controls.Add(this.catDescLabel);
            this.panel1.Controls.Add(this.CatIdLabel);
            this.panel1.Controls.Add(this.inventoryLabel);
            this.panel1.Controls.Add(this.exitButton);
            this.panel1.Location = new System.Drawing.Point(184, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1161, 829);
            this.panel1.TabIndex = 2;
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
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
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
            this.positionGridComboBox.SelectedIndexChanged += new System.EventHandler(this.positionGridComboBox_SelectedIndexChanged);
            // 
            // CatDGV
            // 
            this.CatDGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(54)))), ((int)(((byte)(96)))));
            this.CatDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CatDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.CatDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(204)))), ((int)(((byte)(210)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(76)))), ((int)(((byte)(112)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(54)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CatDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.CatDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CatDGV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CatDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(23)))), ((int)(((byte)(53)))));
            this.CatDGV.Location = new System.Drawing.Point(458, 210);
            this.CatDGV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CatDGV.Name = "CatDGV";
            this.CatDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.CatDGV.RowHeadersWidth = 51;
            this.CatDGV.RowTemplate.Height = 24;
            this.CatDGV.Size = new System.Drawing.Size(688, 582);
            this.CatDGV.TabIndex = 19;
            this.CatDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CatDGV_CellContentClick);
            // 
            // editBtn
            // 
            this.editBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editBtn.FlatAppearance.BorderSize = 0;
            this.editBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(54)))), ((int)(((byte)(96)))));
            this.editBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editBtn.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.editBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(204)))), ((int)(((byte)(210)))));
            this.editBtn.Location = new System.Drawing.Point(204, 621);
            this.editBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(173, 68);
            this.editBtn.TabIndex = 18;
            this.editBtn.Text = "Edit";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteBtn.FlatAppearance.BorderSize = 0;
            this.deleteBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(54)))), ((int)(((byte)(96)))));
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.deleteBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(204)))), ((int)(((byte)(210)))));
            this.deleteBtn.Location = new System.Drawing.Point(117, 724);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(173, 68);
            this.deleteBtn.TabIndex = 17;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // addCatBtn
            // 
            this.addCatBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addCatBtn.FlatAppearance.BorderSize = 0;
            this.addCatBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(54)))), ((int)(((byte)(96)))));
            this.addCatBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCatBtn.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.addCatBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(204)))), ((int)(((byte)(210)))));
            this.addCatBtn.Location = new System.Drawing.Point(30, 628);
            this.addCatBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addCatBtn.Name = "addCatBtn";
            this.addCatBtn.Size = new System.Drawing.Size(168, 62);
            this.addCatBtn.TabIndex = 16;
            this.addCatBtn.Text = "Add";
            this.addCatBtn.UseVisualStyleBackColor = true;
            this.addCatBtn.Click += new System.EventHandler(this.addCatBtn_Click);
            // 
            // CatDescTextBox
            // 
            this.CatDescTextBox.BackColor = System.Drawing.Color.MintCream;
            this.CatDescTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CatDescTextBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CatDescTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(76)))), ((int)(((byte)(112)))));
            this.CatDescTextBox.Location = new System.Drawing.Point(204, 519);
            this.CatDescTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CatDescTextBox.Name = "CatDescTextBox";
            this.CatDescTextBox.Size = new System.Drawing.Size(206, 23);
            this.CatDescTextBox.TabIndex = 13;
            this.CatDescTextBox.TextChanged += new System.EventHandler(this.CatDescTextBox_TextChanged);
            // 
            // CatNameTextBox
            // 
            this.CatNameTextBox.BackColor = System.Drawing.Color.MintCream;
            this.CatNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CatNameTextBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CatNameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(76)))), ((int)(((byte)(112)))));
            this.CatNameTextBox.Location = new System.Drawing.Point(204, 456);
            this.CatNameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CatNameTextBox.Name = "CatNameTextBox";
            this.CatNameTextBox.Size = new System.Drawing.Size(206, 23);
            this.CatNameTextBox.TabIndex = 12;
            this.CatNameTextBox.TextChanged += new System.EventHandler(this.CatNameTextBox_TextChanged);
            // 
            // CatIdTextBox
            // 
            this.CatIdTextBox.BackColor = System.Drawing.Color.MintCream;
            this.CatIdTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CatIdTextBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CatIdTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(76)))), ((int)(((byte)(112)))));
            this.CatIdTextBox.Location = new System.Drawing.Point(204, 394);
            this.CatIdTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CatIdTextBox.Name = "CatIdTextBox";
            this.CatIdTextBox.Size = new System.Drawing.Size(206, 23);
            this.CatIdTextBox.TabIndex = 11;
            this.CatIdTextBox.TextChanged += new System.EventHandler(this.CatIdTextBox_TextChanged);
            // 
            // catNameLabel
            // 
            this.catNameLabel.AutoSize = true;
            this.catNameLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.catNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(76)))), ((int)(((byte)(112)))));
            this.catNameLabel.Location = new System.Drawing.Point(26, 456);
            this.catNameLabel.Name = "catNameLabel";
            this.catNameLabel.Size = new System.Drawing.Size(136, 23);
            this.catNameLabel.TabIndex = 6;
            this.catNameLabel.Text = "Category Name";
            this.catNameLabel.Click += new System.EventHandler(this.catNameLabel_Click);
            // 
            // catDescLabel
            // 
            this.catDescLabel.AutoSize = true;
            this.catDescLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.catDescLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(76)))), ((int)(((byte)(112)))));
            this.catDescLabel.Location = new System.Drawing.Point(26, 522);
            this.catDescLabel.Name = "catDescLabel";
            this.catDescLabel.Size = new System.Drawing.Size(131, 23);
            this.catDescLabel.TabIndex = 5;
            this.catDescLabel.Text = "Category Desc.";
            this.catDescLabel.Click += new System.EventHandler(this.catDescLabel_Click);
            // 
            // CatIdLabel
            // 
            this.CatIdLabel.AutoSize = true;
            this.CatIdLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.CatIdLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(76)))), ((int)(((byte)(112)))));
            this.CatIdLabel.Location = new System.Drawing.Point(26, 394);
            this.CatIdLabel.Name = "CatIdLabel";
            this.CatIdLabel.Size = new System.Drawing.Size(26, 23);
            this.CatIdLabel.TabIndex = 4;
            this.CatIdLabel.Text = "Id";
            this.CatIdLabel.Click += new System.EventHandler(this.CatIdLabel_Click);
            // 
            // inventoryLabel
            // 
            this.inventoryLabel.AutoSize = true;
            this.inventoryLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(76)))), ((int)(((byte)(112)))));
            this.inventoryLabel.Location = new System.Drawing.Point(451, 43);
            this.inventoryLabel.Name = "inventoryLabel";
            this.inventoryLabel.Size = new System.Drawing.Size(320, 32);
            this.inventoryLabel.TabIndex = 3;
            this.inventoryLabel.Text = "MANAGE INV CATEGORIES";
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(54)))), ((int)(((byte)(96)))));
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(204)))), ((int)(((byte)(210)))));
            this.exitButton.Location = new System.Drawing.Point(1102, 4);
            this.exitButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(55, 68);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "X";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // inventoryBtn
            // 
            this.inventoryBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.inventoryBtn.FlatAppearance.BorderSize = 0;
            this.inventoryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inventoryBtn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(76)))), ((int)(((byte)(112)))));
            this.inventoryBtn.Location = new System.Drawing.Point(5, 133);
            this.inventoryBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.inventoryBtn.Name = "inventoryBtn";
            this.inventoryBtn.Size = new System.Drawing.Size(173, 68);
            this.inventoryBtn.TabIndex = 3;
            this.inventoryBtn.Text = "Inventory";
            this.inventoryBtn.UseVisualStyleBackColor = true;
            this.inventoryBtn.Click += new System.EventHandler(this.inventoryBtn_Click);
            // 
            // employeesBtn
            // 
            this.employeesBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.employeesBtn.FlatAppearance.BorderSize = 0;
            this.employeesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.employeesBtn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeesBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(76)))), ((int)(((byte)(112)))));
            this.employeesBtn.Location = new System.Drawing.Point(5, 230);
            this.employeesBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.employeesBtn.Name = "employeesBtn";
            this.employeesBtn.Size = new System.Drawing.Size(173, 68);
            this.employeesBtn.TabIndex = 4;
            this.employeesBtn.Text = "Employees";
            this.employeesBtn.UseVisualStyleBackColor = true;
            this.employeesBtn.Click += new System.EventHandler(this.employeesBtn_Click);
            // 
            // empCatBtn
            // 
            this.empCatBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.empCatBtn.FlatAppearance.BorderSize = 0;
            this.empCatBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.empCatBtn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empCatBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(76)))), ((int)(((byte)(112)))));
            this.empCatBtn.Location = new System.Drawing.Point(5, 326);
            this.empCatBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.empCatBtn.Name = "empCatBtn";
            this.empCatBtn.Size = new System.Drawing.Size(173, 90);
            this.empCatBtn.TabIndex = 5;
            this.empCatBtn.Text = "Emp. Categories";
            this.empCatBtn.UseVisualStyleBackColor = true;
            this.empCatBtn.Click += new System.EventHandler(this.empCatBtn_Click);
            // 
            // CategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(54)))), ((int)(((byte)(96)))));
            this.ClientSize = new System.Drawing.Size(1346, 811);
            this.Controls.Add(this.empCatBtn);
            this.Controls.Add(this.employeesBtn);
            this.Controls.Add(this.inventoryBtn);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CategoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CategoryForm";
            this.Load += new System.EventHandler(this.CategoryForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CatDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.ComboBox positionGridComboBox;
        private System.Windows.Forms.DataGridView CatDGV;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button addCatBtn;
        private System.Windows.Forms.TextBox CatDescTextBox;
        private System.Windows.Forms.TextBox CatNameTextBox;
        private System.Windows.Forms.TextBox CatIdTextBox;
        private System.Windows.Forms.Label catNameLabel;
        private System.Windows.Forms.Label catDescLabel;
        private System.Windows.Forms.Label CatIdLabel;
        private System.Windows.Forms.Label inventoryLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button inventoryBtn;
        private System.Windows.Forms.Button employeesBtn;
        private System.Windows.Forms.Button empCatBtn;
    }
}