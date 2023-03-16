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
    public partial class CriteriaForm : Form
    {
        static CriteriaForm instance;
        CriteriaForm()
        {
            InitializeComponent();
        }
        public static CriteriaForm getInstance()
        {
            if (instance == null)
                instance = new CriteriaForm();
            return instance;
        }
        public void instanceNull()
        {
            instance = null;
        }
        public void LoadMain()
        {
            OKtoolStripLabel.Visible = false;
            ok.Visible = false;
        }
        public void LoadCreate()
        {
            OKtoolStripLabel.Visible = true;
            ok.Visible = true;
        }
        private void criteriaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.criteriaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.banking_activitiesDataSet);

        }
        public void indicatorsUpdate()
        {
            this.indicatorsTableAdapter.Fill(this.banking_activitiesDataSet.indicators);
        }
        private void CriteriaForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "banking_activitiesDataSet.indicators". При необходимости она может быть перемещена или удалена.
            this.indicatorsTableAdapter.Fill(this.banking_activitiesDataSet.indicators);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "banking_activitiesDataSet.criteria". При необходимости она может быть перемещена или удалена.
            this.criteriaTableAdapter.Fill(this.banking_activitiesDataSet.criteria);

        }

        private void indicatorsToolStripLabel_Click(object sender, EventArgs e)
        {
            IndicatorsForm indicatorsForm = new IndicatorsForm();
            indicatorsForm.MdiParent = this.MdiParent;
            indicatorsForm.Show();
        }

        private void OKtoolStripLabel_Click(object sender, EventArgs e)
        {
            List<Criteria> criterias = new List<Criteria>();
            for (int i = 0; i < criteriaDataGridView.RowCount; i++)
                if (Convert.ToBoolean(criteriaDataGridView.Rows[i].Cells["ok"].Value))
                    criterias.Add(new Criteria(Convert.ToInt32(criteriaDataGridView.Rows[i].Cells["dataGridViewTextBoxColumn1"].Value),
                        criteriaDataGridView.Rows[i].Cells["dataGridViewTextBoxColumn2"].Value.ToString()));
            CreateForm createForm = CreateForm.getInstance();
            createForm.Criterias = criterias;
            createForm.addCriterias();
        }

        private void CriteriaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
            this.instanceNull();
        }
    }
}
