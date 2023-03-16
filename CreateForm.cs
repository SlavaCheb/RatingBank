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
    public partial class CreateForm : System.Windows.Forms.Form
    {
        static CreateForm instance;
        List<Criteria> criterias;
        public List<Criteria> Criterias
        {
            set
            {
                criterias = new List<Criteria>(value);
            }
        }
        CreateForm()
        {
            InitializeComponent();
        }
        public static CreateForm getInstance()
        {
            if (instance == null)
                instance = new CreateForm();
            return instance;
        }
        public void instanceNull()
        {
            instance = null;
        }
        private void addLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CriteriaForm criteriaForm = CriteriaForm.getInstance();
            criteriaForm.MdiParent = this.MdiParent;
            criteriaForm.LoadCreate();
            criteriaForm.Show();
        }
        public void addCriterias()
        {
            foreach (Criteria criteria in criterias)
                criteriaDataGridView.Rows.Add(criteria.Name, "", "X");
        }

        private void criteriaDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || (e.ColumnIndex != criteriaDataGridView.Columns["delete"].Index))
                return;
            criteriaDataGridView.Rows.RemoveAt(e.RowIndex);
        }

        private void CreateForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
            this.instanceNull();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "" || criteriaDataGridView.Rows.Count == 0)
            {
                MessageBox.Show(
                    "Не все поля заполнены!",
                    "Сообщение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            bool check = false;
            foreach (DataGridViewRow row in criteriaDataGridView.Rows)
                if (row.Cells["weight"].Value.ToString() == "" ||
                    Convert.ToDouble(row.Cells["weight"].Value) <= 0)
                    check = true;
            if (check)
            {
                MessageBox.Show(
                   "Ошибка!\n\nСм. веса критериев!",
                   "Сообщение",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Warning);
                return;
            }
            SqlConnection connection = DBUtils.GetDBConnection();
            connection.Open();
            try
            {
                Expert expert = Expert.getInstance();
                string sql = "Select * from methodology where id_expert = @id and name_methodology = @name";
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = sql;
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = expert.Id;
                cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = nameTextBox.Text;
                using (DbDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        MessageBox.Show(
                            "Вы уже создавали эту методику рейтингования деятельности банков!",
                            "Сообщение",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return;
                    }
                }
                sql = "Insert into methodology (id_expert, name_methodology, description_methodology) "
                                                 + " values (@id, @name, @description) ";
                cmd = connection.CreateCommand();
                cmd.CommandText = sql;
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = expert.Id;
                cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = nameTextBox.Text;
                cmd.Parameters.Add("@description", SqlDbType.NVarChar).Value = descriptionRichTextBox.Text;
                int rowCount = cmd.ExecuteNonQuery();
                sql = "SELECT TOP (1) * FROM methodology ORDER BY id_methodology DESC";
                cmd = connection.CreateCommand();
                cmd.CommandText = sql;
                int id_methodology = 0;
                using (DbDataReader reader = cmd.ExecuteReader())
                {
                    reader.Read();
                    id_methodology = reader.GetInt32(0);
                }
                sql = "Insert into methodology_criteria (id_methodology, id_criteria, weight_criteria) "
                                                     + " values (@idM, @idC, @weight) ";
                for (int i = 0; i < criteriaDataGridView.Rows.Count; i++)
                {
                    cmd = connection.CreateCommand();
                    cmd.CommandText = sql;
                    cmd.Parameters.Add("@idM", SqlDbType.Int).Value = id_methodology;
                    cmd.Parameters.Add("@idC", SqlDbType.Int).Value = criterias[i].Id;
                    cmd.Parameters.Add("@weight", SqlDbType.Float).Value = criteriaDataGridView.Rows[i].Cells["weight"].Value;
                    rowCount = cmd.ExecuteNonQuery();
                }
                MessageBox.Show(
                   "Методика рейтингования деятельности банков создана успешно!",
                   "Сообщение",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
                ExpertForm expertForm = ExpertForm.getInstance();
                expertForm.methodologyUpdate();
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
    }
}
