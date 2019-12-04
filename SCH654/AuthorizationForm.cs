using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SCH654
{
    public partial class AuthorizationForm : Form
    {
        DBTables dbTables = new DBTables();
        private static DBConnection dBConnection = new DBConnection();
        private int checkUser = 0;
        public static int userRole = 0;
        public AuthorizationForm()
        {
            InitializeComponent();
        }
               
        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (tbLogin.TextLength == 0 || tbPassword.TextLength == 0)  //проверка заполненности полей
                MessageBox.Show("Все поля должны быть заполнены", "Школа №654", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                SqlCommand commandSearchUser = new SqlCommand("", DBConnection.sqlConnection);
                SqlCommand commandRoleUser = new SqlCommand("", DBConnection.sqlConnection);
                commandSearchUser.CommandText = "select count(*) from [dbo].[users] where [login_user] = '" + tbLogin.Text + "' and [password_user] = '" + tbPassword.Text + "'";
                commandRoleUser.CommandText = "select [user_role_id] from [dbo].[users] where [login_user] = '" + tbLogin.Text + "' and [password_user] ='" + tbPassword.Text + "'";

                try     //нахождение пользователя таким логином и паролем
                {
                    DBConnection.sqlConnection.Open();
                    checkUser = Convert.ToInt32(commandSearchUser.ExecuteScalar().ToString());
                }
                catch
                {
                    MessageBox.Show("Не правильный логин или пароль", "Ошибки в результате работы", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    DBConnection.sqlConnection.Close();
                }

                if (checkUser == 0)
                    MessageBox.Show("Пользователя с данным логином и паролем не обнаружено! Проверьте правильность ввода данных или зарегистрируйтесь.", "Школа №654", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else     //установление роли данного пользователя
                {
                    DBConnection.sqlConnection.Open();
                    userRole = Convert.ToInt32(commandRoleUser.ExecuteScalar().ToString());
                    DBConnection.sqlConnection.Close();
                    MessageBox.Show("Вы авторизовались в информационной системе.", "Школа №654", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    MainWindow MMF = new MainWindow();
                    MMF.Show();
                }
            }
        }

        private void AuthorizationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.Close();
            Application.Exit();
        }

        private void tbPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                btnEnter_Click(sender, e);
        }

        private void btnRegistr_Click(object sender, EventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.Show();
            this.Hide();
        }
    }
}