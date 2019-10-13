using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Neeroga_System
{
    public partial class Patient_Registration : Form
    {
        SqlConnection conn;
        String gender = "";

        public Patient_Registration()
        {
            try
            {
                DBConnection db = new DBConnection();
                conn = db.getConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cant open connection !! " + ex);
            }
            InitializeComponent();
            DataTable();
        }
        void DataTable()
        {
            DateTime dateTime = DateTime.Now;
            this.labeldate.Text = dateTime.ToString();

            try
            {

                conn.Close();
                conn.Open();
                SqlDataAdapter sda;
                DataTable dt1;
                sda = new SqlDataAdapter("select * FROM paitent_reg ORDER BY Patient_Id Desc", conn);
                dt1 = new DataTable();
                sda.Fill(dt1);
                dataGridView1.DataSource = dt1;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void refresh()
        {
            txtName.Text = "";
            gender = "";
            txtAge.Text = "";
            txtAddress.Text = "";
            txtContact_No.Text = "";
            txtemailAddress.Text = "";

        }
        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void Patient_Registration_Load(object sender, EventArgs e)
        {

        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (txtName.Text.Length <= 0)
            {
                errorProvider1.SetError(txtName, "Please Enter the Name");
            }

            else if (txtAge.Text.Length <= 0)
            {
                errorProvider1.SetError(txtAge, "Please Enter the Age");
            }
            else if (txtAddress.Text.Length <= 0)
            {
                errorProvider1.SetError(txtAddress, "Please Enter the Address");
            }
            else if (txtContact_No.Text.Length <= 0)
            {
                errorProvider1.SetError(txtContact_No, "Please Enter the Contact No");
            }
            else if (txtemailAddress.Text.Length <= 0)
            {
                errorProvider1.SetError(txtemailAddress, "Please Enter the Email Address");
            }

            else
            {
                try
                {
                    conn.Close();
                    conn.Open();

                    if (rad_male.Checked)
                    {
                        gender = "Male";
                    }
                    if (rad_female.Checked)
                        gender = "Female";

                    String query = "Insert into paitent_reg (Name,Gender,Age,Address,Contact_No,Email_Address,Create_date) values('" + txtName.Text + "','" + gender + "','" + txtAge.Text + "','" + txtAddress.Text + "','" + txtContact_No.Text + "','" + txtemailAddress.Text + "','" + labeldate.Text + "')";
                    SqlDataAdapter execute = new SqlDataAdapter(query, conn);
                    execute.SelectCommand.ExecuteNonQuery();
                    MessageBox.Show("Successfully Record Inserted!!");
                    DataTable();
                    refresh();

                    conn.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;

            if (!dataGridView1.Rows[e.RowIndex].IsNewRow)
            {
            }

            int index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[index];
            patient_id.Text = selectedRow.Cells[0].Value.ToString();
            txtName.Text = selectedRow.Cells[1].Value.ToString();

            gender = selectedRow.Cells[2].Value.ToString();
            if (gender == "Male")
            {
                rad_male.Checked = true;
            }
            else if (gender == "Female")
            {
                rad_female.Checked = true;
            }

                txtAge.Text = selectedRow.Cells[3].Value.ToString();
            txtAddress.Text = selectedRow.Cells[4].Value.ToString();
            txtContact_No.Text = selectedRow.Cells[5].Value.ToString();
            txtemailAddress.Text = selectedRow.Cells[6].Value.ToString();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            if (txtName.Text == "" || txtAge.Text == "")
            {
                MessageBox.Show("Please select row from the Grid-view", "Successful Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                try
                {
                    conn.Close();
                    conn.Open();

                    String UpdateQuery = "Update paitent_reg set  Name ='" + txtName.Text + "', Gender ='" + gender + "', Age ='"
                        + txtAge.Text + "', Address ='" + txtAddress.Text + "', Contact_No ='" + txtContact_No.Text + "', Email_Address ='" + txtemailAddress.Text + "', Create_date ='" + labeldate.Text + "'  where Patient_Id ='" + patient_id.Text + "';";

                    SqlDataAdapter execute = new SqlDataAdapter(UpdateQuery, conn);
                    execute.SelectCommand.ExecuteNonQuery();
                    MessageBox.Show("You've Updated Successfully!", "Successful Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                    DataTable();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {

            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT TOP 10 * FROM paitent_reg Where Contact_No like ('" + textBox1.Text + "%')";

            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();




        }

        private void button1_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void patient_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void labeldate_Click(object sender, EventArgs e)
        {

        }
    }
}
