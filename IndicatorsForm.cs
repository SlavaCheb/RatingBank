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
    public partial class IndicatorsForm : Form
    {
        public IndicatorsForm()
        {
            InitializeComponent();
        }

        private void indicatorsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.indicatorsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.banking_activitiesDataSet);
            ActivityForm activityForm = ActivityForm.getInstance();
            activityForm.indicatorsUpdate();
            CriteriaForm criteriaForm = CriteriaForm.getInstance();
            criteriaForm.indicatorsUpdate();
        }

        private void IndicatorsForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "banking_activitiesDataSet.indicators". При необходимости она может быть перемещена или удалена.
            this.indicatorsTableAdapter.Fill(this.banking_activitiesDataSet.indicators);

        }
    }
}
