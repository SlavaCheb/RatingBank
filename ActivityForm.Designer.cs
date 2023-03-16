namespace bank
{
    partial class ActivityForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActivityForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.banking_activitiesDataSet = new bank.banking_activitiesDataSet();
            this.banking_activitiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.banking_activitiesTableAdapter = new bank.banking_activitiesDataSetTableAdapters.banking_activitiesTableAdapter();
            this.tableAdapterManager = new bank.banking_activitiesDataSetTableAdapters.TableAdapterManager();
            this.banksTableAdapter = new bank.banking_activitiesDataSetTableAdapters.banksTableAdapter();
            this.indicatorsTableAdapter = new bank.banking_activitiesDataSetTableAdapters.indicatorsTableAdapter();
            this.banking_activitiesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.banking_activitiesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.IndicatorsToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.BanksToolStripLabel = new System.Windows.Forms.ToolStripButton();
            this.banking_activitiesDataGridView = new System.Windows.Forms.DataGridView();
            this.banksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.indicatorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.banking_activitiesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banking_activitiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banking_activitiesBindingNavigator)).BeginInit();
            this.banking_activitiesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.banking_activitiesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.indicatorsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // banking_activitiesDataSet
            // 
            this.banking_activitiesDataSet.DataSetName = "banking_activitiesDataSet";
            this.banking_activitiesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // banking_activitiesBindingSource
            // 
            this.banking_activitiesBindingSource.DataMember = "banking_activities";
            this.banking_activitiesBindingSource.DataSource = this.banking_activitiesDataSet;
            // 
            // banking_activitiesTableAdapter
            // 
            this.banking_activitiesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.banking_activitiesTableAdapter = this.banking_activitiesTableAdapter;
            this.tableAdapterManager.banksTableAdapter = this.banksTableAdapter;
            this.tableAdapterManager.criteriaTableAdapter = null;
            this.tableAdapterManager.expertsTableAdapter = null;
            this.tableAdapterManager.indicatorsTableAdapter = this.indicatorsTableAdapter;
            this.tableAdapterManager.methodology_criteriaTableAdapter = null;
            this.tableAdapterManager.methodologyTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = bank.banking_activitiesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // banksTableAdapter
            // 
            this.banksTableAdapter.ClearBeforeFill = true;
            // 
            // indicatorsTableAdapter
            // 
            this.indicatorsTableAdapter.ClearBeforeFill = true;
            // 
            // banking_activitiesBindingNavigator
            // 
            this.banking_activitiesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.banking_activitiesBindingNavigator.BindingSource = this.banking_activitiesBindingSource;
            this.banking_activitiesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.banking_activitiesBindingNavigator.DeleteItem = null;
            this.banking_activitiesBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.banking_activitiesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.banking_activitiesBindingNavigatorSaveItem,
            this.IndicatorsToolStripLabel,
            this.BanksToolStripLabel});
            this.banking_activitiesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.banking_activitiesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.banking_activitiesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.banking_activitiesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.banking_activitiesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.banking_activitiesBindingNavigator.Name = "banking_activitiesBindingNavigator";
            this.banking_activitiesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.banking_activitiesBindingNavigator.Size = new System.Drawing.Size(800, 31);
            this.banking_activitiesBindingNavigator.TabIndex = 0;
            this.banking_activitiesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 28);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // banking_activitiesBindingNavigatorSaveItem
            // 
            this.banking_activitiesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.banking_activitiesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("banking_activitiesBindingNavigatorSaveItem.Image")));
            this.banking_activitiesBindingNavigatorSaveItem.Name = "banking_activitiesBindingNavigatorSaveItem";
            this.banking_activitiesBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 28);
            this.banking_activitiesBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.banking_activitiesBindingNavigatorSaveItem.Click += new System.EventHandler(this.banking_activitiesBindingNavigatorSaveItem_Click);
            // 
            // IndicatorsToolStripLabel
            // 
            this.IndicatorsToolStripLabel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.IndicatorsToolStripLabel.Image = ((System.Drawing.Image)(resources.GetObject("IndicatorsToolStripLabel.Image")));
            this.IndicatorsToolStripLabel.Name = "IndicatorsToolStripLabel";
            this.IndicatorsToolStripLabel.Size = new System.Drawing.Size(262, 28);
            this.IndicatorsToolStripLabel.Text = "Показатели деятельности банков";
            this.IndicatorsToolStripLabel.Click += new System.EventHandler(this.IndicatorsToolStripLabel_Click);
            // 
            // BanksToolStripLabel
            // 
            this.BanksToolStripLabel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.BanksToolStripLabel.Image = ((System.Drawing.Image)(resources.GetObject("BanksToolStripLabel.Image")));
            this.BanksToolStripLabel.Name = "BanksToolStripLabel";
            this.BanksToolStripLabel.Size = new System.Drawing.Size(75, 28);
            this.BanksToolStripLabel.Text = "Банки";
            this.BanksToolStripLabel.Click += new System.EventHandler(this.BanksToolStripLabel_Click);
            // 
            // banking_activitiesDataGridView
            // 
            this.banking_activitiesDataGridView.AllowUserToDeleteRows = false;
            this.banking_activitiesDataGridView.AutoGenerateColumns = false;
            this.banking_activitiesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.banking_activitiesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.banking_activitiesDataGridView.DataSource = this.banking_activitiesBindingSource;
            this.banking_activitiesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.banking_activitiesDataGridView.Location = new System.Drawing.Point(0, 31);
            this.banking_activitiesDataGridView.Name = "banking_activitiesDataGridView";
            this.banking_activitiesDataGridView.RowHeadersWidth = 51;
            this.banking_activitiesDataGridView.RowTemplate.Height = 24;
            this.banking_activitiesDataGridView.Size = new System.Drawing.Size(800, 419);
            this.banking_activitiesDataGridView.TabIndex = 1;
            // 
            // banksBindingSource
            // 
            this.banksBindingSource.DataMember = "banks";
            this.banksBindingSource.DataSource = this.banking_activitiesDataSet;
            // 
            // indicatorsBindingSource
            // 
            this.indicatorsBindingSource.DataMember = "indicators";
            this.indicatorsBindingSource.DataSource = this.banking_activitiesDataSet;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "bank_RK";
            this.dataGridViewTextBoxColumn1.DataSource = this.banksBindingSource;
            this.dataGridViewTextBoxColumn1.DisplayMember = "abbreviated_name";
            this.dataGridViewTextBoxColumn1.HeaderText = "Банк";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn1.ValueMember = "bank_RK";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "period";
            dataGridViewCellStyle1.NullValue = null;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn2.HeaderText = "Период";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "id_indicator";
            this.dataGridViewTextBoxColumn3.DataSource = this.indicatorsBindingSource;
            this.dataGridViewTextBoxColumn3.DisplayMember = "name_indicator";
            this.dataGridViewTextBoxColumn3.HeaderText = "Показатель";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn3.ValueMember = "id_indicator";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "value";
            this.dataGridViewTextBoxColumn4.HeaderText = "Значение";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // ActivityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.banking_activitiesDataGridView);
            this.Controls.Add(this.banking_activitiesBindingNavigator);
            this.Name = "ActivityForm";
            this.Text = "Деятельноть банков";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ActivityForm_FormClosing);
            this.Load += new System.EventHandler(this.ActivityForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.banking_activitiesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.banking_activitiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.banking_activitiesBindingNavigator)).EndInit();
            this.banking_activitiesBindingNavigator.ResumeLayout(false);
            this.banking_activitiesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.banking_activitiesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.banksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.indicatorsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private banking_activitiesDataSet banking_activitiesDataSet;
        private System.Windows.Forms.BindingSource banking_activitiesBindingSource;
        private banking_activitiesDataSetTableAdapters.banking_activitiesTableAdapter banking_activitiesTableAdapter;
        private banking_activitiesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator banking_activitiesBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton banking_activitiesBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView banking_activitiesDataGridView;
        private banking_activitiesDataSetTableAdapters.banksTableAdapter banksTableAdapter;
        private System.Windows.Forms.BindingSource banksBindingSource;
        private banking_activitiesDataSetTableAdapters.indicatorsTableAdapter indicatorsTableAdapter;
        private System.Windows.Forms.BindingSource indicatorsBindingSource;
        private System.Windows.Forms.ToolStripButton BanksToolStripLabel;
        private System.Windows.Forms.ToolStripLabel IndicatorsToolStripLabel;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}