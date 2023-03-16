using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bank
{
    public partial class InputForm : System.Windows.Forms.Form
    {
        public InputForm()
        {
            InitializeComponent();
        }

        private void registerlinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.MdiParent = this.MdiParent;
            this.Hide();
            registrationForm.Show();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            SqlConnection connection = DBUtils.GetDBConnection();
            connection.Open();
            try
            {
                string sql = "Select * from experts where login = @login and password = @password";
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = sql;
                cmd.Parameters.Add("@login", SqlDbType.VarChar).Value = loginTextBox.Text;
                cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = passwordTextBox.Text;
                using (DbDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        reader.Read();
                        Expert expert = new Expert(reader.GetInt32(0), reader.GetString(1));
                        this.MdiParent.Text += " (" + expert.Id.ToString() + ". " + expert.Name + ")";
                        MainForm mainForm = MainForm.getInstance();
                        this.Hide();
                        mainForm.inputExpert();
                    }
                    else
                        MessageBox.Show(
                            "Вы ввели неверный логин или пароль!",
                            "Сообщение",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                }
            }
            catch (Exception _e)
            {
                MessageBox.Show(
                    "Ошибка: " + _e + "\n\n" + _e.StackTrace,
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
                connection.Dispose();
                connection = null;
            }
        }

        private void guestButton_Click(object sender, EventArgs e)
        {
            MainForm mainForm = MainForm.getInstance();
            this.Hide();
            mainForm.inputGuest();
        }
    }
}
