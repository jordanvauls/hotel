using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

using System.Windows.Forms;

namespace HotelManagementSystem
{
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
            metroLabel1.Text = String.Format("My Application Version {0}", version);
        }

        private void usernameTextBox_Click(object sender, EventArgs e)
        {
            if (usernameTextBox.Text == string.Empty)
            {
                usernameLabel.Visible = true;
            }
            if (usernameTextBox.Text != "Username" && usernameTextBox.Text != string.Empty)
            {
                usernameLabel.Visible = false;
            }
        }
        public bool verifier(string tableName, string username, string password)
        {
          
            bool success = false;
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Con"].ConnectionString);
            string sql = "SELECT* FROM " + tableName + " WHERE user_name=@userName AND pass_word=@password";
            try
            {
                SqlCommand sqlCommand = new SqlCommand(sql, connection);
                sqlCommand.CommandText = sql;
                SqlParameter UsernameParametar = new SqlParameter("@username", SqlDbType.VarChar);
                SqlParameter PassParametar = new SqlParameter("@password", SqlDbType.VarChar);
                sqlCommand.Parameters.Add(UsernameParametar);
                sqlCommand.Parameters.Add(PassParametar);
                UsernameParametar.Value = username;
                PassParametar.Value = password;
                connection.Open();
                SqlDataReader sqlReader = sqlCommand.ExecuteReader();

                if (sqlReader.HasRows)
                    success = true;
                connection.Close();
            }
            catch (Exception e)
            {
                MetroFramework.MetroMessageBox.Show(this, e.ToString(), "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            return success;
        }
        private void passwordTextBox_Click(object sender, EventArgs e)
        {
            if (passwordTextBox.Text == string.Empty)
            {
                passwordLabel.Visible = true;
            }
            if (passwordTextBox.Text != "Password" && passwordTextBox.Text != string.Empty)
            {
                passwordLabel.Visible = false;
            }
        }

        private void signinButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (verifier("frontend".Trim(), usernameTextBox.Text.Trim(), passwordTextBox.Text.Trim()))
                {
                    this.Hide();
                    Hotel_Manager.Form1 hotel_management = new Hotel_Manager.Form1();
                    hotel_management.Show();
                }
                //else if (verifier("kitchen".Trim(), usernameTextBox.Text.Trim(), passwordTextBox.Text.Trim()))
                //{
                //    this.Hide();
                //    Kitchen kitchen_management = new Kitchen();
                //    kitchen_management.Show();
                //}
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Username or Password is wrong, try again", "Login Failed", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.ToString(), "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }
    }
}
