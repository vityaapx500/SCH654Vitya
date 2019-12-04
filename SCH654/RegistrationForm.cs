using System;
using System.Threading;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SCH654
{
    public partial class RegistrationForm : Form
    {
        DBStoredProcedure storedProcedure = new DBStoredProcedure();
        DBConnection dBConnection = new DBConnection();
        Users usersForm = new Users();
        public RegistrationForm()
        {
            InitializeComponent();
        }
        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            Thread threadRole = new Thread(RoleFill);
            threadRole.Start();
        }
        private void RoleFill()
        {
            DBTables dbTables = new DBTables();
            Action action = () =>
            {
                try
                {
                    dbTables.DTRoles.Clear();
                    dbTables.DTRolesForComboBoxFill();
                    dbTables.dependency.OnChange += ChangeRole;

                    cbRole.DataSource = dbTables.DTRoles;
                    cbRole.ValueMember = "ID_role";
                    cbRole.DisplayMember = "role_name";
                    cbRole.SelectedValue = -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            };
            Invoke(action);
        }
        private void ChangeRole(object sender, SqlNotificationEventArgs e)
        {
            if (e.Info != SqlNotificationInfo.Invalid)
                RoleFill();
        }
        private bool CheckOccupancyTextBox()    //функция проверки количества символов в полях для ввода
        {
            if (tbSurname.TextLength == 0 || tbName.TextLength == 0 || tbPantronymic.TextLength == 0 || tbPassword.TextLength == 0 || tbConfirmPass.TextLength == 0)
                MessageBox.Show(MessageUser.AllMargin, MessageUser.TitleApp, MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                return true;

            return false;
        }

        private bool CheckCoincidencePasswords()    //функция проверки одинаковости полей пароль и повторить пароль
        {
            if (tbPassword.Text != tbConfirmPass.Text)
                MessageBox.Show(MessageUser.PasswordRepeatPasswordMustMatch, MessageUser.TitleApp, MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                return true;

            return false;
        }
        private bool CheckLenghtLoginPassword() //функция проверки длины логина и пароля
        {
            if ((tbLogin.TextLength < 8) || (tbPassword.TextLength < 8) || (tbLogin.TextLength > 16) || (tbPassword.TextLength > 16))
                MessageBox.Show(MessageUser.MinLengthPassLog, MessageUser.TitleApp, MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                return true;

            return false;
        }

        //private bool CheckTextLoginPassword()   //функция проверки
        //{
        //    if (usersForm.CheckPasswordUpperLatin() == true || usersForm.CheckPasswordLowerLatin() == true || usersForm.CheckPasswordUpperCyrill() == true || usersForm.CheckPasswordLowerCyrill() == true || usersForm.CheckPasswordNumber() == true || usersForm.CheckPassworSymbol() == true || usersForm.CheckLoginCyrill() == false)
        //        MessageBox.Show(MessageUser.LetterPassLog, MessageUser.TitleApp, MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    else
        //        return true;

        //    return false;
        //}

        //private bool CheckUniqueLogin() //функция проверки уникальности логина
        //{
        //    SqlCommand commandSearchLogin = new SqlCommand("", DBConnection.sqlConnection);
        //    commandSearchLogin.CommandText = "select count(*) from [dbo].[User] where CONVERT([nvarchar] (16), DECRYPTBYKEY([Login_User])) = '" + tbLogin.Text + "'";

        //    DBConnection.sqlConnection.Open();
        //    dbTables.CommandOpenKey.ExecuteNonQuery();
        //    uniqueLogin = Convert.ToInt32(commandSearchLogin.ExecuteScalar().ToString());
        //    dbTables.CommandCloseKey.ExecuteNonQuery();
        //    RegistryData.DBConnectionString.Close();

        //    if (uniqueLogin != 0)
        //        MessageBox.Show(MessageUser.UserAlreadyHave, MessageUser.TitleLibrary, MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    else
        //        return true;

        //    return false;
        //}
        private void btnAuthoriz_Click(object sender, EventArgs e)
        {
            AuthorizationForm authorizationForm = new AuthorizationForm();
            authorizationForm.Show();
            Hide();
        }
        private void btnRegistr_Click(object sender, EventArgs e)
        {
            //Checks
            try
            {
                storedProcedure.SPUsersInsert(tbSurname.Text, tbName.Text, tbPantronymic.Text, tbLogin.Text, tbPassword.Text, Convert.ToInt32(cbRole.SelectedIndex));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
