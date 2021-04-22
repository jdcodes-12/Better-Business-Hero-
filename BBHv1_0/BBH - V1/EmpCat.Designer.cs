
namespace BBH___V1
{
    partial class EmpCat
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
            this.refreshButton = new System.Windows.Forms.Button();
            this.positionGridComboBox = new System.Windows.Forms.ComboBox();
            this.empDGV = new System.Windows.Forms.DataGridView();
            this.employeeLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.inventoryBtn = new System.Windows.Forms.Button();
            this.employeesBtn = new System.Windows.Forms.Button();
            this.categoryButton = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.EmpDescTextBox = new System.Windows.Forms.TextBox();
            this.EmpNameTextBox = new System.Windows.Forms.TextBox();
            this.EmpIdTextBox = new System.Windows.Forms.TextBox();
            this.catNameLabel = new System.Windows.Forms.Label();
            this.catDescLabel = new System.Windows.Forms.Label();
            this.IdLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(23)))), ((int)(((byte)(53)))));
            this.panel1.Controls.Add(this.editBtn);
            this.panel1.Controls.Add(this.deleteBtn);
            this.panel1.Controls.Add(this.addBtn);
            this.panel1.Controls.Add(this.EmpDescTextBox);
            this.panel1.Controls.Add(this.EmpNameTextBox);
            this.panel1.Controls.Add(this.EmpIdTextBox);
            this.panel1.Controls.Add(this.catNameLabel);
            this.panel1.Controls.Add(this.catDescLabel);
            this.panel1.Controls.Add(this.IdLabel);
            this.panel1.Controls.Add(this.refreshButton);
            this.panel1.Controls.Add(this.positionGridComboBox);
            this.panel1.Controls.Add(this.empDGV);
            this.panel1.Controls.Add(this.employeeLabel);
            this.panel1.Controls.Add(this.exitButton);
            this.panel1.Location = new System.Drawing.Point(193, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1158, 809);
            this.panel1.TabIndex = 1;
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
            // 
            // employeeLabel
            // 
            this.employeeLabel.AutoSize = true;
            this.employeeLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(76)))), ((int)(((byte)(112)))));
            this.employeeLabel.Location = new System.Drawing.Point(451, 43);
            this.employeeLabel.Name = "employeeLabel";
            this.employeeLabel.Size = new System.Drawing.Size(328, 32);
            this.employeeLabel.TabIndex = 3;
            this.employeeLabel.Text = "MANAGE EMP CATEGORIES";
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
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // inventoryBtn
            // 
            this.inventoryBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.inventoryBtn.FlatAppearance.BorderSize = 0;
            this.inventoryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inventoryBtn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(76)))), ((int)(((byte)(112)))));
            this.inventoryBtn.Location = new System.Drawing.Point(12, 231);
            this.inventoryBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.inventoryBtn.Name = "inventoryBtn";
            this.inventoryBtn.Size = new System.Drawing.Size(173, 68);
            this.inventoryBtn.TabIndex = 4;
            this.inventoryBtn.Text = "Inventory";
            this.inventoryBtn.UseVisualStyleBackColor = true;
            this.inventoryBtn.Click += new System.EventHandler(this.inventoryBtn_Click_1);
            // 
            // employeesBtn
            // 
            this.employeesBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.employeesBtn.FlatAppearance.BorderSize = 0;
            this.employeesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.employeesBtn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeesBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(76)))), ((int)(((byte)(112)))));
            this.employeesBtn.Location = new System.Drawing.Point(14, 147);
            this.employeesBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.employeesBtn.Name = "employeesBtn";
            this.employeesBtn.Size = new System.Drawing.Size(173, 68);
            this.employeesBtn.TabIndex = 5;
            this.employeesBtn.Text = "Employees";
            this.employeesBtn.UseVisualStyleBackColor = true;
            this.employeesBtn.Click += new System.EventHandler(this.employeesBtn_Click_1);
            // 
            // categoryButton
            // 
            this.categoryButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.categoryButton.FlatAppearance.BorderSize = 0;
            this.categoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.categoryButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(76)))), ((int)(((byte)(112)))));
            this.categoryButton.Location = new System.Drawing.Point(12, 318);
            this.categoryButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.categoryButton.Name = "categoryButton";
            this.categoryButton.Size = new System.Drawing.Size(173, 98);
            this.categoryButton.TabIndex = 6;
            this.categoryButton.Text = "Inv. Categories";
            this.categoryButton.UseVisualStyleBackColor = true;
            this.categoryButton.Click += new System.EventHandler(this.categoryButton_Click);
            // 
            // editBtn
            // 
            this.editBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editBtn.FlatAppearance.BorderSize = 0;
            this.editBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(54)))), ((int)(((byte)(96)))));
            this.editBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editBtn.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.editBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(204)))), ((int)(((byte)(210)))));
            this.editBtn.Location = new System.Drawing.Point(223, 629);
            this.editBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(173, 64);
            this.editBtn.TabIndex = 30;
            this.editBtn.Text = "Edit";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click_1);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteBtn.FlatAppearance.BorderSize = 0;
            this.deleteBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(54)))), ((int)(((byte)(96)))));
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.deleteBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(204)))), ((int)(((byte)(210)))));
            this.deleteBtn.Location = new System.Drawing.Point(136, 731);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(173, 64);
            this.deleteBtn.TabIndex = 29;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click_1);
            // 
            // addBtn
            // 
            this.addBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBtn.FlatAppearance.BorderSize = 0;
            this.addBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(54)))), ((int)(((byte)(96)))));
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBtn.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.addBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(204)))), ((int)(((byte)(210)))));
            this.addBtn.Location = new System.Drawing.Point(49, 635);
            this.addBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(168, 58);
            this.addBtn.TabIndex = 28;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click_1);
            // 
            // EmpDescTextBox
            // 
            this.EmpDescTextBox.BackColor = System.Drawing.Color.MintCream;
            this.EmpDescTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmpDescTextBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.EmpDescTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(76)))), ((int)(((byte)(112)))));
            this.EmpDescTextBox.Location = new System.Drawing.Point(223, 522);
            this.EmpDescTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EmpDescTextBox.Name = "EmpDescTextBox";
            this.EmpDescTextBox.Size = new System.Drawing.Size(206, 23);
            this.EmpDescTextBox.TabIndex = 27;
            // 
            // EmpNameTextBox
            // 
            this.EmpNameTextBox.BackColor = System.Drawing.Color.MintCream;
            this.EmpNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmpNameTextBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.EmpNameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(76)))), ((int)(((byte)(112)))));
            this.EmpNameTextBox.Location = new System.Drawing.Point(223, 459);
            this.EmpNameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EmpNameTextBox.Name = "EmpNameTextBox";
            this.EmpNameTextBox.Size = new System.Drawing.Size(206, 23);
            this.EmpNameTextBox.TabIndex = 26;
            // 
            // EmpIdTextBox
            // 
            this.EmpIdTextBox.BackColor = System.Drawing.Color.MintCream;
            this.EmpIdTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmpIdTextBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpIdTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(76)))), ((int)(((byte)(112)))));
            this.EmpIdTextBox.Location = new System.Drawing.Point(223, 397);
            this.EmpIdTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EmpIdTextBox.Name = "EmpIdTextBox";
            this.EmpIdTextBox.Size = new System.Drawing.Size(206, 23);
            this.EmpIdTextBox.TabIndex = 25;
            // 
            // catNameLabel
            // 
            this.catNameLabel.AutoSize = true;
            this.catNameLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.catNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(76)))), ((int)(((byte)(112)))));
            this.catNameLabel.Location = new System.Drawing.Point(45, 459);
            this.catNameLabel.Name = "catNameLabel";
            this.catNameLabel.Size = new System.Drawing.Size(136, 23);
            this.catNameLabel.TabIndex = 24;
            this.catNameLabel.Text = "Category Name";
            // 
            // catDescLabel
            // 
            this.catDescLabel.AutoSize = true;
            this.catDescLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.catDescLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(76)))), ((int)(((byte)(112)))));
            this.catDescLabel.Location = new System.Drawing.Point(45, 525);
            this.catDescLabel.Name = "catDescLabel";
            this.catDescLabel.Size = new System.Drawing.Size(131, 23);
            this.catDescLabel.TabIndex = 23;
            this.catDescLabel.Text = "Category Desc.";
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.IdLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(76)))), ((int)(((byte)(112)))));
            this.IdLabel.Location = new System.Drawing.Point(45, 397);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(26, 23);
            this.IdLabel.TabIndex = 22;
            this.IdLabel.Text = "Id";
            // 
            // EmpCat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(54)))), ((int)(((byte)(96)))));
            this.ClientSize = new System.Drawing.Size(1346, 811);
            this.Controls.Add(this.categoryButton);
            this.Controls.Add(this.employeesBtn);
            this.Controls.Add(this.inventoryBtn);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "EmpCat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmpCat";
            this.Load += new System.EventHandler(this.EmpCat_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.ComboBox positionGridComboBox;
        private System.Windows.Forms.DataGridView empDGV;
        private System.Windows.Forms.Label employeeLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button inventoryBtn;
        private System.Windows.Forms.Button employeesBtn;
        private System.Windows.Forms.Button categoryButton;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.TextBox EmpDescTextBox;
        private System.Windows.Forms.TextBox EmpNameTextBox;
        private System.Windows.Forms.TextBox EmpIdTextBox;
        private System.Windows.Forms.Label catNameLabel;
        private System.Windows.Forms.Label catDescLabel;
        private System.Windows.Forms.Label IdLabel;
    }
}