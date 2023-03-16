﻿namespace bank
{
    partial class IndicatorsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IndicatorsForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.banking_activitiesDataSet = new bank.banking_activitiesDataSet();
            this.indicatorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.indicatorsTableAdapter = new bank.banking_activitiesDataSetTableAdapters.indicatorsTableAdapter();
            this.tableAdapterManager = new bank.banking_activitiesDataSetTableAdapters.TableAdapterManager();
            this.indicatorsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.indicatorsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.indicatorsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.banking_activitiesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.indicatorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.indicatorsBindingNavigator)).BeginInit();
            this.indicatorsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.indicatorsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // banking_activitiesDataSet
            // 
            this.banking_activitiesDataSet.DataSetName = "banking_activitiesDataSet";
            this.banking_activitiesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // indicatorsBindingSource
            // 
            this.indicatorsBindingSource.DataMember = "indicators";
            this.indicatorsBindingSource.DataSource = this.banking_activitiesDataSet;
            // 
            // indicatorsTableAdapter
            // 
            this.indicatorsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.banking_activitiesTableAdapter = null;
            this.tableAdapterManager.banksTableAdapter = null;
            this.tableAdapterManager.criteriaTableAdapter = null;
            this.tableAdapterManager.expertsTableAdapter = null;
            this.tableAdapterManager.indicatorsTableAdapter = this.indicatorsTableAdapter;
            this.tableAdapterManager.methodology_criteriaTableAdapter = null;
            this.tableAdapterManager.methodologyTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = bank.banking_activitiesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // indicatorsBindingNavigator
            // 
            this.indicatorsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.indicatorsBindingNavigator.BindingSource = this.indicatorsBindingSource;
            this.indicatorsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.indicatorsBindingNavigator.DeleteItem = null;
            this.indicatorsBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.indicatorsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.indicatorsBindingNavigatorSaveItem});
            this.indicatorsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.indicatorsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.indicatorsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.indicatorsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.indicatorsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.indicatorsBindingNavigator.Name = "indicatorsBindingNavigator";
            this.indicatorsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.indicatorsBindingNavigator.Size = new System.Drawing.Size(800, 27);
            this.indicatorsBindingNavigator.TabIndex = 0;
            this.indicatorsBindingNavigator.Text = "bindingNavigator1";
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
            // indicatorsBindingNavigatorSaveItem
            // 
            this.indicatorsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.indicatorsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("indicatorsBindingNavigatorSaveItem.Image")));
            this.indicatorsBindingNavigatorSaveItem.Name = "indicatorsBindingNavigatorSaveItem";
            this.indicatorsBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.indicatorsBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.indicatorsBindingNavigatorSaveItem.Click += new System.EventHandler(this.indicatorsBindingNavigatorSaveItem_Click);
            // 
            // indicatorsDataGridView
            // 
            this.indicatorsDataGridView.AllowUserToDeleteRows = false;
            this.indicatorsDataGridView.AutoGenerateColumns = false;
            this.indicatorsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.indicatorsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.indicatorsDataGridView.DataSource = this.indicatorsBindingSource;
            this.indicatorsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.indicatorsDataGridView.Location = new System.Drawing.Point(0, 27);
            this.indicatorsDataGridView.Name = "indicatorsDataGridView";
            this.indicatorsDataGridView.RowHeadersWidth = 51;
            this.indicatorsDataGridView.RowTemplate.Height = 48;
            this.indicatorsDataGridView.Size = new System.Drawing.Size(800, 423);
            this.indicatorsDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_indicator";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_indicator";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "name_indicator";
            this.dataGridViewTextBoxColumn2.HeaderText = "Показатель";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "description_indicator";
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn3.HeaderText = "Описание";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // IndicatorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.indicatorsDataGridView);
            this.Controls.Add(this.indicatorsBindingNavigator);
            this.Name = "IndicatorsForm";
            this.Text = "Показатели деятельности банков";
            this.Load += new System.EventHandler(this.IndicatorsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.banking_activitiesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.indicatorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.indicatorsBindingNavigator)).EndInit();
            this.indicatorsBindingNavigator.ResumeLayout(false);
            this.indicatorsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.indicatorsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private banking_activitiesDataSet banking_activitiesDataSet;
        private System.Windows.Forms.BindingSource indicatorsBindingSource;
        private banking_activitiesDataSetTableAdapters.indicatorsTableAdapter indicatorsTableAdapter;
        private banking_activitiesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator indicatorsBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton indicatorsBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView indicatorsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}