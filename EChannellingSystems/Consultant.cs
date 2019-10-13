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
    public partial class Consultant : Form
    {
        SqlConnection conn;
        public Consultant()
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
                sda = new SqlDataAdapter("select * FROM Consultant ORDER BY Doctor_Id Desc", conn);
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
            /* txtName.Text = "";
             gender = "";
             txtAge.Text = "";
             txtAddress.Text = "";
             txtContact_No.Text = "";
             txtemailAddress.Text = "";*/
        }

        private void consultantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Appointment app = new Appointment();
            app.Show();
        }

        private void textBox6_KeyUp(object sender, KeyEventArgs e)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT TOP 10 * FROM paitent_reg Where Contact_No like ('" + doctor_name.Text + "%')";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            var datestring = dateTimePicker1.Value.ToShortDateString();
            if (doc_id.Text == "" || doctor_name.Text == "")
            {
                MessageBox.Show("Please select row from the Grid-view", "Successful Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                try
                {
                    conn.Close();
                    conn.Open();

                    String UpdateQuery = "Update Consultant set   Doc_Name ='" + doctor_name.Text + "', Category ='"
                        + Category.Text + "', Doc_Address ='" + txtAddress.Text + "', Contact_No ='" + Contactno.Text + "', Email ='" + email.Text + "', joined_date ='" + datestring + "'  where Doctor_Id ='" + doc_id.Text + "';";

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

        private void btninsert_Click(object sender, EventArgs e)
        {
            var datestring = dateTimePicker1.Value.ToShortDateString();
            errorProvider1.Clear();
            if (doc_id.Text.Length <= 0)
            {
                errorProvider1.SetError(doc_id, "Please Enter Doctor_ID");
            }
            if (doctor_name.Text.Length <= 0)
            {
                errorProvider1.SetError(doctor_name, "Please Enter Doctor Name");
            }

            else if (Category.Text.Length <= 0)
            {
                errorProvider1.SetError(Category, "Please Enter the Category");
            }
            else if (txtAddress.Text.Length <= 0)
            {
                errorProvider1.SetError(txtAddress, "Please Enter the Address");
            }
            else if (this.dateTimePicker1.Text.Length <= 0)
            {
                errorProvider1.SetError(this.dateTimePicker1, "This field cannot be empty");
            }

            else
            {
                try
                {
                    conn.Close();
                    conn.Open();
                    String query = "Insert into Consultant (Doctor_Id,Doc_Name,Category,Doc_Address,Contact_No,Email,joined_date) values('" + doc_id.Text + "','" + doctor_name.Text + "','" + Category.Text + "','" + txtAddress.Text + "','" + Contactno.Text + "','" + email + "','" + datestring + "')";
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
            doc_id.Text = selectedRow.Cells[0].Value.ToString();
            doctor_name.Text = selectedRow.Cells[1].Value.ToString();
            Category.Text = selectedRow.Cells[2].Value.ToString();
            txtAddress.Text = selectedRow.Cells[3].Value.ToString();
            Contactno.Text = selectedRow.Cells[4].Value.ToString();
            email.Text = selectedRow.Cells[5].Value.ToString();
            dateTimePicker1.Text = selectedRow.Cells[6].Value.ToString();
        }

        private void Consultant_Load(object sender, EventArgs e)
        {

        }
    }
}
