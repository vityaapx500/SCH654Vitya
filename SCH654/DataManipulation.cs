using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SCH654
{
    class DataManipulation
    {
        DBStoredProcedure storedProcedure = new DBStoredProcedure();
        DynamicObjects DOb = new DynamicObjects();
        public void AddOrder(object sender, EventArgs e)
        {
            try
            {
                storedProcedure.SPOrderInsert(DOb.tbOrder.Text, DOb.tbDateOrder.Text, DOb.cbStatus.SelectedItem.ToString());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void UpdateOrder(object sender, EventArgs e)
        {
            try
            {
                storedProcedure.SPEmployeeUpdate(Convert.ToInt32(dgvEmployees.CurrentRow.Cells[0].Value.ToString()), tbSurname.Text, tbName.Text, tbPantronymic.Text, Convert.ToDateTime(tbDateBirth.Text),
            Convert.ToInt32(tbNumUdostov.Text), tbNameUchilisha.Text, Convert.ToDateTime(tbDateOkonch.Text), tbLogin.Text, tbPassword.Text, Convert.ToInt32(cbDolj.SelectedIndex));
            }
            catch
            {
                MessageBox.Show("Ошибка при изменении данных");
            }
            tbSurname.Clear();
            tbName.Clear();
            tbPantronymic.Clear();
            tbDateBirth.Clear();
            tbNumUdostov.Clear();
            tbNameUchilisha.Clear();
            tbDateOkonch.Clear();
            tbLogin.Clear();
            tbPassword.Clear();
            cbDolj.SelectedValue = -1;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Вы действительно желаете полностью удалить запись " + tbSurname.Text + " " + tbName.Text + " " + tbPantronymic.Text + "?", "Удаления данных сотрудника", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    try
                    {
                        storedProcedure.SPEmployeeDelete(Convert.ToInt32(dgvEmployees.CurrentRow.Cells[0].Value.ToString()));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    try
                    {
                        storedProcedure.SPEmployeeLogicalDelete(Convert.ToInt32(dgvEmployees.CurrentRow.Cells[0].Value.ToString()));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    tbSurname.Clear();
                    tbName.Clear();
                    tbPantronymic.Clear();
                    tbDateBirth.Clear();
                    tbNumUdostov.Clear();
                    tbNameUchilisha.Clear();
                    tbDateOkonch.Clear();
                    tbLogin.Clear();
                    tbPassword.Clear();
                    cbDolj.SelectedValue = -1;
                    break;
            }
        }
    }
}
