using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Neeroga_System
{
    public partial class New_User : Form
    {

        SqlConnection conn;
        public New_User()
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
            this.labeltime.Text = dateTime.ToString();

            try
            {
                conn.Close();
                conn.Open();
                SqlDataAdapter sda;
                DataTable dt1;
                sda = new SqlDataAdapter("select * FROM New_User ORDER BY User_ID Desc", conn);
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
          //  combo_usertype.Text = "";
            txtusername.Text = "";
            password.Text = "";
            txtconfirmpassword.Text = "";



        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void New_User_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (combo_usertype.Text.Length <= 0)
            {
                errorProvider1.SetError(combo_usertype, "Please Select Usser Type");
            }
            else if (txtusername.Text.Length <= 0)
            {
                errorProvider1.SetError(txtusername, "Enter User Name");
            }

            else if (password.Text.Length <= 0)
            {
                errorProvider1.SetError(password, "Please Enter the Password ");
            }
            else if (password.Text != txtconfirmpassword.Text)
            {
                errorProvider1.SetError(txtconfirmpassword, "Password Mismatch");
            }

            else
            {
                try
                {
                    conn.Close();
                    conn.Open();

                    String password1 = password.Text;
                    // byte[] hash = null;

                    using (SHA1 sha1 = SHA1.Create())
                    {
                        // sha1.Initialize();
                        byte[] hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(password1));
                        StringBuilder sb = new StringBuilder();

                        for (int i = 0; i < hash.Length; ++i)
                        {
                            sb.Append(hash[i].ToString("x2"));
                        }
                        password1 = sb.ToString();
                    }


                    String query = "Insert into New_User (Username,Password,User_Type,Created_Date) values('" + txtusername.Text + "','" + password1 + "','" + combo_usertype.Text + "','" + labeltime.Text + "')";
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            if (combo_usertype.Text == "" || txtusername.Text == "")
            {
                MessageBox.Show("Select the Row & Delete", "Successful Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    conn.Close();
                    conn.Open();
                    String DeleteQuery = "delete from New_User where User_ID ='" + user_id.Text + "';";
                    SqlDataAdapter execute = new SqlDataAdapter(DeleteQuery, conn);
                    execute.SelectCommand.ExecuteNonQuery();
                    MessageBox.Show("You've deleted successfully!", "Successful Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                    DataTable();
                    refresh();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            conn.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;

            if (!dataGridView1.Rows[e.RowIndex].IsNewRow)
            {
            }

            int index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[index];

            user_id.Text = selectedRow.Cells[0].Value.ToString();
            txtusername.Text = selectedRow.Cells[1].Value.ToString();

            password.Text = selectedRow.Cells[2].Value.ToString();
            

            combo_usertype.Text = selectedRow.Cells[3].Value.ToString();
            labeltime.Text = selectedRow.Cells[4].Value.ToString();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            if (combo_usertype.Text == "" || txtusername.Text == "")
            {
                MessageBox.Show("Please select UserType to update changes!", "Successful Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (password.Text != txtconfirmpassword.Text)
            {
                errorProvider1.SetError(txtconfirmpassword, "Password Mismatch");
            }
            else
            {
                try
                {
                    conn.Close();
                    conn.Open();
                
                    String UpdateQuery = "Update New_User set  Username ='"+ txtusername.Text + "', Password ='" + password.Text + "', User_Type ='" 
                        + combo_usertype.Text + "', Created_Date ='" + labeltime.Text + "'  where User_ID ='" + user_id.Text + "';";

                    SqlDataAdapter execute = new SqlDataAdapter(UpdateQuery, conn);
                    execute.SelectCommand.ExecuteNonQuery();
                    MessageBox.Show("You've Updated Successfully!", "Successful Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                    DataTable();
                    refresh();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
