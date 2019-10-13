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
    public partial class Appointment : Form
    {
        SqlConnection conn;
        string timeslot = "";
        public Appointment()
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
           
           // checktime();

            using (var conn = new DBConnection().getConnection())
            {
                using (var cmd = new SqlCommand("SELECT Doc_Name FROM Consultant", conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            doc_name.Items.Add(reader["Doc_Name"].ToString());
                        }
                    }
                }
            }

            using (var conn = new DBConnection().getConnection())
            {
                using (var cmd = new SqlCommand("SELECT Contact_No FROM paitent_reg", conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            patient_id.Items.Add(reader["Contact_No"].ToString());
                        }
                    }
                }
            }


            
        }

        public void DataTable()
        {
         try {
                conn.Close();
                conn.Open();
                SqlDataAdapter sda;
                DataTable dt1;
                sda = new SqlDataAdapter("Select * FROM Appointment ORDER BY P_ID Desc", conn);
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
            patient_id.Text = "";
            patient_name.Text = "";
            doc_name.Text = "";
            //AvailabelDate.Text = "";
           // dateTimePicker1.Text = "dd-MM-yyyy";
            category.Text = "";
            
        }

        private void Appointment_Load(object sender, EventArgs e)
        {
            //checktime();
            // TODO: This line of code loads data into the 'neeroga_SystemDataSet1.Appointment' table. You can move, or remove it, as needed.
            //this.appointmentTableAdapter1.Fill(this.neeroga_SystemDataSet1.Appointment);
            // TODO: This line of code loads data into the 'neeroga_SystemDataSet.Appointment' table. You can move, or remove it, as needed.
            // this.appointmentTableAdapter.Fill(this.neeroga_SystemDataSet.Appointment);
            //  DataTable();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

       

        private void btninsert_Click(object sender, EventArgs e)
        {
            var datestring = dateTimePicker1.Value.ToShortDateString();
            errorProvider1.Clear();
            if (patient_id.Text.Length <= 0)
            {
                errorProvider1.SetError(patient_id, "Please Enter Patient Id");
            }

            else if (patient_name.Text.Length <= 0)
            {
                errorProvider1.SetError(patient_name, "Please Enter Patient Name");
            }
            else if (doc_name.Text.Length <= 0)
            {
                errorProvider1.SetError(doc_name, "Please Enter Doctor Name");
            }
          
            
            else
            {
                try
                {
                    conn.Close();
                    conn.Open();
                    
                    if (CBtime1_3.Checked)
                    {
                        timeslot = "1:00PM-1:30PM";
                    }
                    else if (CBtime2_3.Checked)
                    {
                        timeslot = "2:00PM-2:30PM";
                    }
                    else if (CBtime3_3.Checked)
                    {
                        timeslot = "3:00PM-3:30PM";
                    }
                    else if (CBtime4_3.Checked)
                    {
                        timeslot = "4:00PM-4:30PM";
                    }
                    else if (CBtime5_3.Checked)
                    {
                        timeslot = "5:00PM-5:30PM";
                    }
                    else if (CBtime6_3.Checked)
                    {
                        timeslot = "6:00PM-6:30PM";
                    }

                    String query = "Insert into Appointment (P_ContactID,Paitent_Name,Doctor_Name,Category,Date,Time_slot) values('" + patient_id.Text + "','" + patient_name.Text + "','" + doc_name.Text + "','" + category.Text + "','"+ datestring + "','"+ timeslot + "')";
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            TextBox txt;
            
            if (sender == doc_name)
            {
                txt = category;
            }
            else
            {
                txt = null;
             
            }
            ///  Doc_Name
            /// 
            conn.Close();
            conn.Open();
            using (var cmd = new SqlCommand("SELECT Category FROM Consultant WHERE Doc_Name=@docname", conn))
            {
                cmd.Parameters.AddWithValue("docname", ((ComboBox)sender).SelectedItem.ToString());
                txt.Text = cmd.ExecuteScalar().ToString();
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void patient_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextBox txt;

            if (sender == patient_id)
            {
                txt = patient_name;
            }
            else
            {
                txt = null;
            }
            conn.Close();
            conn.Open();

            using (var cmd = new SqlCommand("SELECT Name FROM paitent_reg WHERE Contact_No=@patientname", conn))
            {
                cmd.Parameters.AddWithValue("patientname", ((ComboBox)sender).SelectedItem.ToString());
                txt.Text = cmd.ExecuteScalar().ToString();
            }
            

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged_2(object sender, EventArgs e)
        {
            
        }

        private void AvailabelDate_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void CBtime1_3_CheckedChanged(object sender, EventArgs e)
        {
            
            

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;

            if (!dataGridView1.Rows[e.RowIndex].IsNewRow)
            {
            }


            int index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[index];
            Pt_id.Text = selectedRow.Cells[0].Value.ToString();
            patient_id.Text = selectedRow.Cells[1].Value.ToString();
            patient_name.Text = selectedRow.Cells[2].Value.ToString();
            doc_name.Text = selectedRow.Cells[3].Value.ToString();
            category.Text = selectedRow.Cells[4].Value.ToString();
            dateTimePicker1.Text = selectedRow.Cells[5].Value.ToString();


            /*if (gender == "Male")
            {
                rad_male.Checked = true;
            }
            else if (gender == "Female")
            {
                rad_female.Checked = true;
            }*/
            if (timeslot == "1:00PM-1:30PM")
            {
                CBtime1_3.Checked = true;
            }
            else if (timeslot == "2:00PM-2:30PM")
            {
                CBtime2_3.Checked = true;
            }
            else if (timeslot == "3:00PM-3:30PM")
            {
                CBtime3_3.Checked = true;
                
            }
            else if (timeslot == "4:00PM-4:30PM")
            {
                CBtime4_3.Checked = true;
                
            }
            else if (timeslot == "5:00PM-5:30PM")
            {
                CBtime5_3.Checked = true;
                
            }
            else if (timeslot == "6:00PM-6:30PM")
            {
                CBtime6_3.Checked = true;
                
            }
            timeslot = selectedRow.Cells[6].Value.ToString();

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_KeyUp(object sender, KeyEventArgs e)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT TOP 10 * FROM Appointment Where P_ContactID like ('" + patient_id.Text + "%')";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            var datestring = dateTimePicker1.Value.ToShortDateString();
            if (doc_name.Text == "")
            {
                MessageBox.Show("Please select row from the Grid-view", "Successful Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                try
                {
                    conn.Close();
                    conn.Open();
                    if (CBtime1_3.Checked)
                    {
                        timeslot = "1:00PM-1:30PM";
                        
                    }
                    else if (CBtime2_3.Checked)
                    {
                        timeslot = "2:00PM-2:30PM";
                    }
                    else if (CBtime3_3.Checked)
                    {
                        timeslot = "3:00PM-3:30PM";
                    }
                    else if (CBtime4_3.Checked)
                    {
                        timeslot = "4:00PM-4:30PM";
                    }
                    else if (CBtime5_3.Checked)
                    {
                        timeslot = "5:00PM-5:30PM";
                    }
                    else if (CBtime6_3.Checked)
                    {
                        timeslot = "6:00PM-6:30PM";
                    }

                    String UpdateQuery = "Update Appointment set   P_ContactID ='" + patient_id.Text + "', Paitent_Name ='"
                        + patient_name.Text + "', Doctor_Name ='" + doc_name.Text + "', Category ='" + category.Text + "', Date ='" + datestring + "', Time_slot ='" + timeslot + "'  where P_ID ='" + Pt_id.Text + "';";

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
    }
}
