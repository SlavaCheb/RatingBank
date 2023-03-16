namespace bank
{
    partial class CriteriaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CriteriaForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.banking_activitiesDataSet = new bank.banking_activitiesDataSet();
            this.criteriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.criteriaTableAdapter = new bank.banking_activitiesDataSetTableAdapters.criteriaTableAdapter();
            this.tableAdapterManager = new bank.banking_activitiesDataSetTableAdapters.TableAdapterManager();
            this.indicatorsTableAdapter = new bank.banking_activitiesDataSetTableAdapters.indicatorsTableAdapter();
            this.criteriaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.criteriaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.OKtoolStripLabel = new System.Windows.Forms.ToolStripButton();
            this.indicatorsToolStripLabel = new System.Windows.Forms.ToolStripButton();
            this.criteriaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.indicatorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.indicatorsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ok = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.banking_activitiesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.criteriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.criteriaBindingNavigator)).BeginInit();
            this.criteriaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.criteriaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.indicatorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.indicatorsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // banking_activitiesDataSet
            // 
            this.banking_activitiesDataSet.DataSetName = "banking_activitiesDataSet";
            this.banking_activitiesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // criteriaBindingSource
            // 
            this.criteriaBindingSource.DataMember = "criteria";
            this.criteriaBindingSource.DataSource = this.banking_activitiesDataSet;
            // 
            // criteriaTableAdapter
            // 
            this.criteriaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.banking_activitiesTableAdapter = null;
            this.tableAdapterManager.banksTableAdapter = null;
            this.tableAdapterManager.criteriaTableAdapter = this.criteriaTableAdapter;
            this.tableAdapterManager.expertsTableAdapter = null;
            this.tableAdapterManager.indicatorsTableAdapter = this.indicatorsTableAdapter;
            this.tableAdapterManager.methodology_criteriaTableAdapter = null;
            this.tableAdapterManager.methodologyTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = bank.banking_activitiesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // indicatorsTableAdapter
            // 
            this.indicatorsTableAdapter.ClearBeforeFill = true;
            // 
            // criteriaBindingNavigator
            // 
            this.criteriaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.criteriaBindingNavigator.BindingSource = this.criteriaBindingSource;
            this.criteriaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.criteriaBindingNavigator.DeleteItem = null;
            this.criteriaBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.criteriaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.criteriaBindingNavigatorSaveItem,
            this.toolStripSeparator1,
            this.OKtoolStripLabel,
            this.indicatorsToolStripLabel});
            this.criteriaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.criteriaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.criteriaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.criteriaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.criteriaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.criteriaBindingNavigator.Name = "criteriaBindingNavigator";
            this.criteriaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.criteriaBindingNavigator.Size = new System.Drawing.Size(800, 27);
            this.criteriaBindingNavigator.TabIndex = 0;
            this.criteriaBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 24);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // criteriaBindingNavigatorSaveItem
            // 
            this.criteriaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.criteriaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("criteriaBindingNavigatorSaveItem.Image")));
            this.criteriaBindingNavigatorSaveItem.Name = "criteriaBindingNavigatorSaveItem";
            this.criteriaBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.criteriaBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.criteriaBindingNavigatorSaveItem.Click += new System.EventHandler(this.criteriaBindingNavigatorSaveItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // OKtoolStripLabel
            // 
            this.OKtoolStripLabel.Image = ((System.Drawing.Image)(resources.GetObject("OKtoolStripLabel.Image")));
            this.OKtoolStripLabel.Name = "OKtoolStripLabel";
            this.OKtoolStripLabel.Size = new System.Drawing.Size(93, 24);
            this.OKtoolStripLabel.Text = "Выбрать";
            this.OKtoolStripLabel.Click += new System.EventHandler(this.OKtoolStripLabel_Click);
            // 
            // indicatorsToolStripLabel
            // 
            this.indicatorsToolStripLabel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.indicatorsToolStripLabel.Image = ((System.Drawing.Image)(resources.GetObject("indicatorsToolStripLabel.Image")));
            this.indicatorsToolStripLabel.Name = "indicatorsToolStripLabel";
            this.indicatorsToolStripLabel.Size = new System.Drawing.Size(266, 24);
            this.indicatorsToolStripLabel.Text = "Показатели деятельности банков";
            this.indicatorsToolStripLabel.Click += new System.EventHandler(this.indicatorsToolStripLabel_Click);
            // 
            // criteriaDataGridView
            // 
            this.criteriaDataGridView.AllowUserToDeleteRows = false;
            this.criteriaDataGridView.AutoGenerateColumns = false;
            this.criteriaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.criteriaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.ok});
            this.criteriaDataGridView.DataSource = this.criteriaBindingSource;
            this.criteriaDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.criteriaDataGridView.Location = new System.Drawing.Point(0, 27);
            this.criteriaDataGridView.Name = "criteriaDataGridView";
            this.criteriaDataGridView.RowHeadersWidth = 51;
            this.criteriaDataGridView.RowTemplate.Height = 48;
            this.criteriaDataGridView.Size = new System.Drawing.Size(800, 423);
            this.criteriaDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_criteria";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_criteria";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "name_criteria";
            this.dataGridViewTextBoxColumn2.HeaderText = "Критерий";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "id_indicator1";
            this.dataGridViewTextBoxColumn3.DataSource = this.indicatorsBindingSource;
            this.dataGridViewTextBoxColumn3.DisplayMember = "name_indicator";
            this.dataGridViewTextBoxColumn3.HeaderText = "Показатель №1";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn3.ValueMember = "id_indicator";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // indicatorsBindingSource
            // 
            this.indicatorsBindingSource.DataMember = "indicators";
            this.indicatorsBindingSource.DataSource = this.banking_activitiesDataSet;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "id_indicator2";
            this.dataGridViewTextBoxColumn4.DataSource = this.indicatorsBindingSource1;
            this.dataGridViewTextBoxColumn4.DisplayMember = "name_indicator";
            this.dataGridViewTextBoxColumn4.HeaderText = "Показатель №2";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn4.ValueMember = "id_indicator";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // indicatorsBindingSource1
            // 
            this.indicatorsBindingSource1.DataMember = "indicators";
            this.indicatorsBindingSource1.DataSource = this.banking_activitiesDataSet;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "description_criteria";
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn5.HeaderText = "Описание";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // ok
            // 
            this.ok.HeaderText = "Выбрать";
            this.ok.MinimumWidth = 6;
            this.ok.Name = "ok";
            this.ok.Width = 125;
            // 
            // CriteriaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.criteriaDataGridView);
            this.Controls.Add(this.criteriaBindingNavigator);
            this.Name = "CriteriaForm";
            this.Text = "Критерии";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CriteriaForm_FormClosing);
            this.Load += new System.EventHandler(this.CriteriaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.banking_activitiesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.criteriaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.criteriaBindingNavigator)).EndInit();
            this.criteriaBindingNavigator.ResumeLayout(false);
            this.criteriaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.criteriaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.indicatorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.indicatorsBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private banking_activitiesDataSet banking_activitiesDataSet;
        private System.Windows.Forms.BindingSource criteriaBindingSource;
        private banking_activitiesDataSetTableAdapters.criteriaTableAdapter criteriaTableAdapter;
        private banking_activitiesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator criteriaBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton criteriaBindingNavigatorSaveItem;
        private banking_activitiesDataSetTableAdapters.indicatorsTableAdapter indicatorsTableAdapter;
        private System.Windows.Forms.DataGridView criteriaDataGridView;
        private System.Windows.Forms.BindingSource indicatorsBindingSource;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.BindingSource indicatorsBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ok;
        private System.Windows.Forms.ToolStripButton OKtoolStripLabel;
        private System.Windows.Forms.ToolStripButton indicatorsToolStripLabel;
    }
}