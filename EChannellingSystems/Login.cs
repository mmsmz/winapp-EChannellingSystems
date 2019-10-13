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
    public partial class Login : Form
    {
        SqlConnection conn;
        public Login()
        {
            try
            {
                DBConnection dbobj = new DBConnection();
                conn = dbobj.getConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cant open connection !! " + ex);
            }

            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void txtusername_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Close();
            conn.Open();

       

            SqlCommand selectCommand = new SqlCommand("Select * from New_User where Username=@UserId and Password=@PASS", conn);
            selectCommand.Parameters.Add(new SqlParameter("UserId", txtusername.Text));
            selectCommand.Parameters.Add(new SqlParameter("PASS", txtpassword.Text));

            string UserType = null;
            SqlDataReader reader = selectCommand.ExecuteReader();
            errorProvider1.Clear();
            if (txtusername.Text.Length <= 0)
            {
                errorProvider1.SetError(txtusername, "Please Enter the User Name");
            }

            else if (txtpassword.Text.Length <= 0)
            {
                errorProvider1.SetError(txtpassword, "Please Enter the Password");
            }

            else
            {
                while (reader.Read())
                {
                    UserType = reader[3].ToString().Trim();

                    if (UserType == "Receptionist")
                    {
                        MessageBox.Show("Welcome ", "Welcome Receptionist", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        MainMenu from = new MainMenu();
                        from.Show();
                    }

                    else if (UserType == "Consultant")
                    {
                        MessageBox.Show("Welcome ", "Welcome Doctor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        Consultant_MENU from = new Consultant_MENU();
                        from.Show();
                    }
                    }
            }
        }
    }
}
