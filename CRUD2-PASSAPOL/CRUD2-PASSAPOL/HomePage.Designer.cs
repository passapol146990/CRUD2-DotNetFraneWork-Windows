namespace CRUD2_PASSAPOL
{
    partial class HomePage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            contextMenuStrip1 = new ContextMenuStrip(components);
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            Button_Update_Customer = new Button();
            Button_Delete_Customer = new Button();
            Button_Add_Customer = new Button();
            Input_tel = new TextBox();
            label4 = new Label();
            Input_Address = new TextBox();
            label3 = new Label();
            Input_Name = new TextBox();
            label2 = new Label();
            Input_ID = new TextBox();
            label1 = new Label();
            GrideView_Show_Customers = new DataGridView();
            tabPage2 = new TabPage();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GrideView_Show_Customers).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(914, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(890, 497);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(Button_Update_Customer);
            tabPage1.Controls.Add(Button_Delete_Customer);
            tabPage1.Controls.Add(Button_Add_Customer);
            tabPage1.Controls.Add(Input_tel);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(Input_Address);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(Input_Name);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(Input_ID);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(GrideView_Show_Customers);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(882, 464);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Customers";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // Button_Update_Customer
            // 
            Button_Update_Customer.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Button_Update_Customer.Location = new Point(767, 411);
            Button_Update_Customer.Name = "Button_Update_Customer";
            Button_Update_Customer.Size = new Size(94, 29);
            Button_Update_Customer.TabIndex = 3;
            Button_Update_Customer.Text = "Update";
            Button_Update_Customer.UseVisualStyleBackColor = true;
            Button_Update_Customer.Click += Button_Update_Customer_Click;
            // 
            // Button_Delete_Customer
            // 
            Button_Delete_Customer.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Button_Delete_Customer.ForeColor = Color.Red;
            Button_Delete_Customer.Location = new Point(658, 411);
            Button_Delete_Customer.Name = "Button_Delete_Customer";
            Button_Delete_Customer.Size = new Size(94, 29);
            Button_Delete_Customer.TabIndex = 3;
            Button_Delete_Customer.Text = "Delete";
            Button_Delete_Customer.UseVisualStyleBackColor = true;
            Button_Delete_Customer.Click += Button_Delete_Customer_Click;
            // 
            // Button_Add_Customer
            // 
            Button_Add_Customer.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Button_Add_Customer.Location = new Point(542, 411);
            Button_Add_Customer.Name = "Button_Add_Customer";
            Button_Add_Customer.Size = new Size(94, 29);
            Button_Add_Customer.TabIndex = 3;
            Button_Add_Customer.Text = "Add";
            Button_Add_Customer.UseVisualStyleBackColor = true;
            Button_Add_Customer.Click += Button_Add_Customer_Click;
            // 
            // Input_tel
            // 
            Input_tel.Location = new Point(677, 320);
            Input_tel.Name = "Input_tel";
            Input_tel.Size = new Size(184, 27);
            Input_tel.TabIndex = 2;
            Input_tel.TextChanged += textBox4_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(572, 320);
            label4.Name = "label4";
            label4.Size = new Size(35, 28);
            label4.TabIndex = 1;
            label4.Text = "Tel";
            // 
            // Input_Address
            // 
            Input_Address.Location = new Point(677, 170);
            Input_Address.Multiline = true;
            Input_Address.Name = "Input_Address";
            Input_Address.Size = new Size(184, 113);
            Input_Address.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(572, 170);
            label3.Name = "label3";
            label3.Size = new Size(82, 28);
            label3.TabIndex = 1;
            label3.Text = "Address";
            // 
            // Input_Name
            // 
            Input_Name.Location = new Point(677, 123);
            Input_Name.Name = "Input_Name";
            Input_Name.Size = new Size(184, 27);
            Input_Name.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(572, 123);
            label2.Name = "label2";
            label2.Size = new Size(64, 28);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // Input_ID
            // 
            Input_ID.Location = new Point(677, 75);
            Input_ID.Name = "Input_ID";
            Input_ID.Size = new Size(184, 27);
            Input_ID.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(572, 75);
            label1.Name = "label1";
            label1.Size = new Size(31, 28);
            label1.TabIndex = 1;
            label1.Text = "ID";
            // 
            // GrideView_Show_Customers
            // 
            GrideView_Show_Customers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GrideView_Show_Customers.Location = new Point(19, 24);
            GrideView_Show_Customers.Name = "GrideView_Show_Customers";
            GrideView_Show_Customers.RowHeadersWidth = 51;
            GrideView_Show_Customers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            GrideView_Show_Customers.Size = new Size(514, 416);
            GrideView_Show_Customers.TabIndex = 0;
            GrideView_Show_Customers.CellClick += GrideView_Show_Customers_CellClick;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(882, 464);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Products";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 534);
            Controls.Add(tabControl1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "HomePage";
            Text = "HomePage";
            Load += HomePage_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)GrideView_Show_Customers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ContextMenuStrip contextMenuStrip1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView GrideView_Show_Customers;
        private TextBox Input_ID;
        private Label label1;
        private TextBox Input_tel;
        private Label label4;
        private TextBox Input_Address;
        private Label label3;
        private TextBox Input_Name;
        private Label label2;
        private Button Button_Update_Customer;
        private Button Button_Delete_Customer;
        private Button Button_Add_Customer;
    }
}
