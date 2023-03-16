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
    public partial class ActivityForm : Form
    {
        static ActivityForm instance;
        ActivityForm()
        {
            InitializeComponent();
        }
        public static ActivityForm getInstance()
        {
            if (instance == null)
                instance = new ActivityForm();
            return instance;
        }
        public void instanceNull()
        {
            instance = null;
        }
        private void banking_activitiesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.banking_activitiesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.banking_activitiesDataSet);

        }
        public void banksUpdate()
        {
            this.banksTableAdapter.Fill(this.banking_activitiesDataSet.banks);
        }
        public void indicatorsUpdate()
        {
            this.indicatorsTableAdapter.Fill(this.banking_activitiesDataSet.indicators);
        }
        private void ActivityForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "banking_activitiesDataSet.indicators". При необходимости она может быть перемещена или удалена.
            this.indicatorsTableAdapter.Fill(this.banking_activitiesDataSet.indicators);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "banking_activitiesDataSet.banks". При необходимости она может быть перемещена или удалена.
            this.banksTableAdapter.Fill(this.banking_activitiesDataSet.banks);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "banking_activitiesDataSet.banking_activities". При необходимости она может быть перемещена или удалена.
            this.banking_activitiesTableAdapter.Fill(this.banking_activitiesDataSet.banking_activities);

        }

        private void BanksToolStripLabel_Click(object sender, EventArgs e)
        {
            BanksForm banksForm = new BanksForm();
            banksForm.MdiParent = this.MdiParent;
            banksForm.Show();
        }

        private void IndicatorsToolStripLabel_Click(object sender, EventArgs e)
        {
            IndicatorsForm indicatorsForm = new IndicatorsForm();
            indicatorsForm.MdiParent = this.MdiParent;
            indicatorsForm.Show();
        }

        private void ActivityForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
            this.instanceNull();
        }
    }
}
