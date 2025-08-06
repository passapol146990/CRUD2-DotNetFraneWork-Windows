namespace CRUD2_PASSAPOL
{
    public partial class HomePage : Form
    {
        DbShopRealContext db = new DbShopRealContext();
        public HomePage()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void SETUP_SQL_CUSTOMERS()
        {
            var result = db.TbCustomers.Select(e => new
            {
                ID = e.CusId,
                FName = e.CusName,
                LName = e.CusLname,
                gender = e.Sex,
                Username = e.Username,
                TelPhone = e.CusTel,
                BirthDay = e.Bdate,
                Address = e.CusAdd,
            });
            ;
            GrideView_Show_Customers.DataSource = result.ToList();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            SETUP_SQL_CUSTOMERS();
        }

        private void GrideView_Show_Customers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                Input_ID.Text = GrideView_Show_Customers.Rows[e.RowIndex].Cells["ID"].FormattedValue.ToString();
                Input_Name.Text = GrideView_Show_Customers.Rows[e.RowIndex].Cells["FName"].FormattedValue.ToString();
                Input_Address.Text = GrideView_Show_Customers.Rows[e.RowIndex].Cells["Address"].FormattedValue.ToString();
                Input_tel.Text = GrideView_Show_Customers.Rows[e.RowIndex].Cells["TelPhone"].FormattedValue.ToString();
            }
        }

        private void Button_Delete_Customer_Click(object sender, EventArgs e)
        {
            int id;
            if (!int.TryParse(Input_ID.Text, out id))
            {
                MessageBox.Show("Please enter a valid ID.");
                return;
            }
            var confirm = MessageBox.Show("Are you sure you want to delete?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm == DialogResult.Yes)
            {
                var result = db.TbCustomers.FirstOrDefault(g => g.CusId == id);
                if (result != null)
                {
                    db.TbCustomers.Remove(result);
                    int change = db.SaveChanges();
                    if (change > 0)
                    {
                        MessageBox.Show("Delete Successfully.");
                        SETUP_SQL_CUSTOMERS();
                    }
                    else
                    {
                        MessageBox.Show("No Delete.");
                    }
                }
                else
                {
                    MessageBox.Show("Data not in db.");
                }
            }
        }

        private void Button_Add_Customer_Click(object sender, EventArgs e)
        {

        }

        private void Button_Update_Customer_Click(object sender, EventArgs e)
        {
            var strID = Input_ID.Text;
            if (strID.Length <= 0)
            {
                return;
            }
            int ID = int.Parse(strID);
            var result = db.TbCustomers.Select(e => e).Where(e => e.CusId == ID);
            result.ToList().ForEach(e => e.CusName = Input_Name.Text);
            result.ToList().ForEach(e => e.CusAdd = Input_Address.Text);
            result.ToList().ForEach(e => e.CusTel = Input_tel.Text);
            int change = db.SaveChanges();
            if(change > 0)
            {
                MessageBox.Show("Update Successfully.");
                SETUP_SQL_CUSTOMERS();
            }
        }
    }
}
