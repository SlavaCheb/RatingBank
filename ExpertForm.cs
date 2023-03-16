using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bank
{
    public partial class ExpertForm : Form
    {
        static ExpertForm instance;
        ExpertForm()
        {
            InitializeComponent();
        }
        public static ExpertForm getInstance()
        {
            if (instance == null)
                instance = new ExpertForm();
            return instance;
        }
        public void instanceNull()
        {
            instance = null;
        }
        public void methodologyUpdate()
        {
            this.methodologyTableAdapter.Fill(this.banking_activitiesDataSet.methodology);
        }
        private void ExpertForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "banking_activitiesDataSet.criteria". При необходимости она может быть перемещена или удалена.
            this.criteriaTableAdapter.Fill(this.banking_activitiesDataSet.criteria);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "banking_activitiesDataSet.methodology_criteria". При необходимости она может быть перемещена или удалена.
            this.methodology_criteriaTableAdapter.Fill(this.banking_activitiesDataSet.methodology_criteria);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "banking_activitiesDataSet.methodology". При необходимости она может быть перемещена или удалена.
            this.methodologyTableAdapter.Fill(this.banking_activitiesDataSet.methodology);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "banking_activitiesDataSet.experts". При необходимости она может быть перемещена или удалена.
            this.expertsTableAdapter.Fill(this.banking_activitiesDataSet.experts);
            Expert expert = Expert.getInstance();
            expertsBindingSource.Filter = "id_expert = " + expert.Id;
            methodologyBindingSource.Filter = "id_expert = " + expert.Id;
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.expertsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.banking_activitiesDataSet);
            Expert expert = new Expert(Convert.ToInt32(id_expertTextBox.Text), fIOTextBox.Text);
            this.MdiParent.Text = "Компьютерная система рейтингования деятельности банков (" + expert.Id.ToString() + ". " + expert.Name + ")";
            RatingForm ratingForm = RatingForm.getInstance();
            ratingForm.methodologyUpdate();
        }

        private void createLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateForm createForm = CreateForm.getInstance();
            createForm.MdiParent = this.MdiParent;
            createForm.Show();
        }

        private void ExpertForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
            this.instanceNull();
        }

        private void ratingButton_Click(object sender, EventArgs e)
        {
            if (methodologyDataGridView.SelectedRows.Count != 1)
            {
                MessageBox.Show(
                    "Выберите необходмую Вам методику для рейтингования деятельности банков.",
                    "Сообщение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            RatingForm ratingForm = RatingForm.getInstance();
            ratingForm.MdiParent = this.MdiParent;
            ratingForm.methodologyFilter(Convert.ToInt32(methodologyDataGridView.Rows[methodologyDataGridView.SelectedRows[0].Index].Cells["dataGridViewTextBoxColumn1"].Value));
            ratingForm.Show();
        }
    }
}
