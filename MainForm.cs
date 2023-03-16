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
    public partial class MainForm : System.Windows.Forms.Form
    {
        static MainForm instance;
        MainForm()
        {
            InitializeComponent();
        }
        public static MainForm getInstance()
        {
            if (instance == null)
                instance = new MainForm();
            return instance;
        }
        private void входToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InputForm inputForm = new InputForm();
            inputForm.MdiParent = this;
            inputForm.Show();
        }

        private void созданиеМетодикиРейтингованияДеятельностиБанковToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateForm createForm =CreateForm.getInstance();
            createForm.MdiParent = this;
            createForm.Show();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
                form.Close();
            this.Text = "Компьютерная система рейтингования деятельности банков";
            входToolStripMenuItem.Visible = true;
            созданиеМетодикиРейтингованияДеятельностиБанковToolStripMenuItem.Visible = false;
            выходToolStripMenuItem.Visible = false;
            личныйКабинетToolStripMenuItem.Visible = false;
            таблицыБДToolStripMenuItem.Visible = false;
            рейтингБанковToolStripMenuItem.Visible = false;
        }
        public void inputExpert()
        {
            входToolStripMenuItem.Visible = false;
            созданиеМетодикиРейтингованияДеятельностиБанковToolStripMenuItem.Visible = true;
            выходToolStripMenuItem.Visible = true;
            личныйКабинетToolStripMenuItem.Visible = true;
            таблицыБДToolStripMenuItem.Visible = true;
            рейтингБанковToolStripMenuItem.Visible = true;
        }
        public void inputGuest()
        {
            входToolStripMenuItem.Visible = false;
            выходToolStripMenuItem.Visible = true;
            рейтингБанковToolStripMenuItem.Visible = true;
        }

        private void личныйКабинетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExpertForm expertForm = ExpertForm.getInstance();
            expertForm.MdiParent = this;
            expertForm.Show();
        }

        private void банкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BanksForm banksForm = new BanksForm();
            banksForm.MdiParent = this;
            banksForm.Show();
        }

        private void показателиДеятельностиБанковToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IndicatorsForm indicatorsForm = new IndicatorsForm();
            indicatorsForm.MdiParent = this;
            indicatorsForm.Show();
        }

        private void деятельностьБанковToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActivityForm activityForm = ActivityForm.getInstance();
            activityForm.MdiParent = this;
            activityForm.Show();
        }

        private void критерииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CriteriaForm criteriaForm = CriteriaForm.getInstance();
            criteriaForm.MdiParent = this;
            criteriaForm.LoadMain();
            criteriaForm.Show();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (Form form in this.MdiChildren)
                form.Close();
        }

        private void рейтингБанковToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RatingForm ratingForm = RatingForm.getInstance();
            ratingForm.MdiParent = this;
            ratingForm.Show();
        }
    }
}
