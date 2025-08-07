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
            dataGridView1 = new DataGridView();
            label5 = new Label();
            P_input_name = new TextBox();
            label6 = new Label();
            P_input_type = new TextBox();
            label7 = new Label();
            P_input_price = new TextBox();
            label8 = new Label();
            P_input_description = new TextBox();
            label9 = new Label();
            Show_image = new PictureBox();
            P_button_add = new Button();
            P_delete = new Button();
            button3 = new Button();
            button4 = new Button();
            openFileDialog1 = new OpenFileDialog();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GrideView_Show_Customers).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Show_image).BeginInit();
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
            tabPage2.Controls.Add(button3);
            tabPage2.Controls.Add(P_delete);
            tabPage2.Controls.Add(button4);
            tabPage2.Controls.Add(P_button_add);
            tabPage2.Controls.Add(Show_image);
            tabPage2.Controls.Add(P_input_description);
            tabPage2.Controls.Add(P_input_price);
            tabPage2.Controls.Add(P_input_type);
            tabPage2.Controls.Add(P_input_name);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(dataGridView1);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(882, 464);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Products";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(436, 17);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(424, 427);
            dataGridView1.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(25, 44);
            label5.Name = "label5";
            label5.Size = new Size(51, 20);
            label5.TabIndex = 1;
            label5.Text = "Name";
            // 
            // P_input_name
            // 
            P_input_name.Location = new Point(148, 41);
            P_input_name.Name = "P_input_name";
            P_input_name.Size = new Size(210, 27);
            P_input_name.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(25, 89);
            label6.Name = "label6";
            label6.Size = new Size(42, 20);
            label6.TabIndex = 1;
            label6.Text = "Type";
            // 
            // P_input_type
            // 
            P_input_type.Location = new Point(148, 86);
            P_input_type.Name = "P_input_type";
            P_input_type.Size = new Size(210, 27);
            P_input_type.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.Location = new Point(25, 133);
            label7.Name = "label7";
            label7.Size = new Size(43, 20);
            label7.TabIndex = 1;
            label7.Text = "Price";
            // 
            // P_input_price
            // 
            P_input_price.Location = new Point(148, 130);
            P_input_price.Name = "P_input_price";
            P_input_price.Size = new Size(210, 27);
            P_input_price.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label8.Location = new Point(25, 176);
            label8.Name = "label8";
            label8.Size = new Size(89, 20);
            label8.TabIndex = 1;
            label8.Text = "Description";
            // 
            // P_input_description
            // 
            P_input_description.Location = new Point(148, 173);
            P_input_description.Multiline = true;
            P_input_description.Name = "P_input_description";
            P_input_description.Size = new Size(210, 105);
            P_input_description.TabIndex = 2;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label9.Location = new Point(25, 287);
            label9.Name = "label9";
            label9.Size = new Size(53, 20);
            label9.TabIndex = 1;
            label9.Text = "Image";
            // 
            // Show_image
            // 
            Show_image.BackColor = Color.DarkGray;
            Show_image.Location = new Point(148, 287);
            Show_image.Name = "Show_image";
            Show_image.Size = new Size(210, 123);
            Show_image.TabIndex = 3;
            Show_image.TabStop = false;
            // 
            // P_button_add
            // 
            P_button_add.Location = new Point(25, 429);
            P_button_add.Name = "P_button_add";
            P_button_add.Size = new Size(94, 29);
            P_button_add.TabIndex = 4;
            P_button_add.Text = "Add";
            P_button_add.UseVisualStyleBackColor = true;
            // 
            // P_delete
            // 
            P_delete.Location = new Point(138, 429);
            P_delete.Name = "P_delete";
            P_delete.Size = new Size(94, 29);
            P_delete.TabIndex = 4;
            P_delete.Text = "Delete";
            P_delete.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(251, 429);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 4;
            button3.Text = "Update";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(25, 310);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 4;
            button4.Text = "Open File";
            button4.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
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
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Show_image).EndInit();
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
        private TextBox P_input_name;
        private Label label5;
        private DataGridView dataGridView1;
        private TextBox P_input_description;
        private TextBox P_input_price;
        private TextBox P_input_type;
        private Label label8;
        private Label label7;
        private Label label6;
        private Button button3;
        private Button P_delete;
        private Button button4;
        private Button P_button_add;
        private PictureBox Show_image;
        private Label label9;
        private OpenFileDialog openFileDialog1;
    }
}
