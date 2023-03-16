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
    public partial class BanksForm : Form
    {
        public BanksForm()
        {
            InitializeComponent();
        }

        private void banksBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.banksBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.banking_activitiesDataSet);
            ActivityForm activityForm = ActivityForm.getInstance();
            activityForm.banksUpdate();
        }

        private void BanksForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "banking_activitiesDataSet.banks". При необходимости она может быть перемещена или удалена.
            this.banksTableAdapter.Fill(this.banking_activitiesDataSet.banks);

        }
    }
}
