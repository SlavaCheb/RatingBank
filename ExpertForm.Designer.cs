namespace bank
{
    partial class ExpertForm
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
            System.Windows.Forms.Label id_expertLabel;
            System.Windows.Forms.Label fIOLabel;
            System.Windows.Forms.Label loginLabel;
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.updateButton = new System.Windows.Forms.Button();
            this.id_expertTextBox = new System.Windows.Forms.TextBox();
            this.expertsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.banking_activitiesDataSet = new bank.banking_activitiesDataSet();
            this.fIOTextBox = new System.Windows.Forms.TextBox();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.ratingButton = new System.Windows.Forms.Button();
            this.createLinkLabel = new System.Windows.Forms.LinkLabel();
            this.methodology_criteriaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.criteriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.methodology_criteriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.methodologyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.methodologyDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expertsTableAdapter = new bank.banking_activitiesDataSetTableAdapters.expertsTableAdapter();
            this.tableAdapterManager = new bank.banking_activitiesDataSetTableAdapters.TableAdapterManager();
            this.methodologyTableAdapter = new bank.banking_activitiesDataSetTableAdapters.methodologyTableAdapter();
            this.methodology_criteriaTableAdapter = new bank.banking_activitiesDataSetTableAdapters.methodology_criteriaTableAdapter();
            this.criteriaTableAdapter = new bank.banking_activitiesDataSetTableAdapters.criteriaTableAdapter();
            id_expertLabel = new System.Windows.Forms.Label();
            fIOLabel = new System.Windows.Forms.Label();
            loginLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.expertsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banking_activitiesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.methodology_criteriaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.criteriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.methodology_criteriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.methodologyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.methodologyDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // id_expertLabel
            // 
            id_expertLabel.AutoSize = true;
            id_expertLabel.Location = new System.Drawing.Point(12, 15);
            id_expertLabel.Name = "id_expertLabel";
            id_expertLabel.Size = new System.Drawing.Size(118, 17);
            id_expertLabel.TabIndex = 0;
            id_expertLabel.Text = "Идентификатор:";
            // 
            // fIOLabel
            // 
            fIOLabel.AutoSize = true;
            fIOLabel.Location = new System.Drawing.Point(12, 43);
            fIOLabel.Name = "fIOLabel";
            fIOLabel.Size = new System.Drawing.Size(46, 17);
            fIOLabel.TabIndex = 2;
            fIOLabel.Text = "ФИО:";
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Location = new System.Drawing.Point(12, 71);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new System.Drawing.Size(51, 17);
            loginLabel.TabIndex = 4;
            loginLabel.Text = "Логин:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(12, 99);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(61, 17);
            passwordLabel.TabIndex = 6;
            passwordLabel.Text = "Пароль:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(3, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(153, 17);
            label1.TabIndex = 1;
            label1.Text = "Созданные методики:";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.updateButton);
            this.splitContainer1.Panel1.Controls.Add(id_expertLabel);
            this.splitContainer1.Panel1.Controls.Add(this.id_expertTextBox);
            this.splitContainer1.Panel1.Controls.Add(fIOLabel);
            this.splitContainer1.Panel1.Controls.Add(this.fIOTextBox);
            this.splitContainer1.Panel1.Controls.Add(loginLabel);
            this.splitContainer1.Panel1.Controls.Add(this.loginTextBox);
            this.splitContainer1.Panel1.Controls.Add(passwordLabel);
            this.splitContainer1.Panel1.Controls.Add(this.passwordTextBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(this.ratingButton);
            this.splitContainer1.Panel2.Controls.Add(this.createLinkLabel);
            this.splitContainer1.Panel2.Controls.Add(this.methodology_criteriaDataGridView);
            this.splitContainer1.Panel2.Controls.Add(label1);
            this.splitContainer1.Panel2.Controls.Add(this.methodologyDataGridView);
            this.splitContainer1.Size = new System.Drawing.Size(800, 523);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 0;
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(12, 481);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(251, 30);
            this.updateButton.TabIndex = 8;
            this.updateButton.Text = "Изменить данные";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // id_expertTextBox
            // 
            this.id_expertTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.expertsBindingSource, "id_expert", true));
            this.id_expertTextBox.Location = new System.Drawing.Point(136, 12);
            this.id_expertTextBox.Name = "id_expertTextBox";
            this.id_expertTextBox.ReadOnly = true;
            this.id_expertTextBox.Size = new System.Drawing.Size(127, 22);
            this.id_expertTextBox.TabIndex = 1;
            // 
            // expertsBindingSource
            // 
            this.expertsBindingSource.DataMember = "experts";
            this.expertsBindingSource.DataSource = this.banking_activitiesDataSet;
            // 
            // banking_activitiesDataSet
            // 
            this.banking_activitiesDataSet.DataSetName = "banking_activitiesDataSet";
            this.banking_activitiesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fIOTextBox
            // 
            this.fIOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.expertsBindingSource, "FIO", true));
            this.fIOTextBox.Location = new System.Drawing.Point(64, 40);
            this.fIOTextBox.Name = "fIOTextBox";
            this.fIOTextBox.Size = new System.Drawing.Size(199, 22);
            this.fIOTextBox.TabIndex = 3;
            // 
            // loginTextBox
            // 
            this.loginTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.expertsBindingSource, "login", true));
            this.loginTextBox.Location = new System.Drawing.Point(69, 68);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.ReadOnly = true;
            this.loginTextBox.Size = new System.Drawing.Size(194, 22);
            this.loginTextBox.TabIndex = 5;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.expertsBindingSource, "password", true));
            this.passwordTextBox.Location = new System.Drawing.Point(79, 96);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(184, 22);
            this.passwordTextBox.TabIndex = 7;
            // 
            // ratingButton
            // 
            this.ratingButton.Location = new System.Drawing.Point(3, 255);
            this.ratingButton.Name = "ratingButton";
            this.ratingButton.Size = new System.Drawing.Size(515, 30);
            this.ratingButton.TabIndex = 4;
            this.ratingButton.Text = "Рейтинг банков";
            this.ratingButton.UseVisualStyleBackColor = true;
            this.ratingButton.Click += new System.EventHandler(this.ratingButton_Click);
            // 
            // createLinkLabel
            // 
            this.createLinkLabel.AutoSize = true;
            this.createLinkLabel.Location = new System.Drawing.Point(346, 9);
            this.createLinkLabel.Name = "createLinkLabel";
            this.createLinkLabel.Size = new System.Drawing.Size(172, 17);
            this.createLinkLabel.TabIndex = 3;
            this.createLinkLabel.TabStop = true;
            this.createLinkLabel.Text = "Создать новую методику";
            this.createLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.createLinkLabel_LinkClicked);
            // 
            // methodology_criteriaDataGridView
            // 
            this.methodology_criteriaDataGridView.AllowUserToAddRows = false;
            this.methodology_criteriaDataGridView.AllowUserToDeleteRows = false;
            this.methodology_criteriaDataGridView.AutoGenerateColumns = false;
            this.methodology_criteriaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.methodology_criteriaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.methodology_criteriaDataGridView.DataSource = this.methodology_criteriaBindingSource;
            this.methodology_criteriaDataGridView.Location = new System.Drawing.Point(3, 291);
            this.methodology_criteriaDataGridView.Name = "methodology_criteriaDataGridView";
            this.methodology_criteriaDataGridView.ReadOnly = true;
            this.methodology_criteriaDataGridView.RowHeadersWidth = 51;
            this.methodology_criteriaDataGridView.RowTemplate.Height = 24;
            this.methodology_criteriaDataGridView.Size = new System.Drawing.Size(515, 220);
            this.methodology_criteriaDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "id_methodology";
            this.dataGridViewTextBoxColumn5.HeaderText = "id_methodology";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Visible = false;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "id_criteria";
            this.dataGridViewTextBoxColumn6.DataSource = this.criteriaBindingSource;
            this.dataGridViewTextBoxColumn6.DisplayMember = "name_criteria";
            this.dataGridViewTextBoxColumn6.HeaderText = "Критерий";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn6.ValueMember = "id_criteria";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // criteriaBindingSource
            // 
            this.criteriaBindingSource.DataMember = "criteria";
            this.criteriaBindingSource.DataSource = this.banking_activitiesDataSet;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "weight_criteria";
            this.dataGridViewTextBoxColumn7.HeaderText = "Вес";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // methodology_criteriaBindingSource
            // 
            this.methodology_criteriaBindingSource.DataMember = "R_9";
            this.methodology_criteriaBindingSource.DataSource = this.methodologyBindingSource;
            // 
            // methodologyBindingSource
            // 
            this.methodologyBindingSource.DataMember = "methodology";
            this.methodologyBindingSource.DataSource = this.banking_activitiesDataSet;
            // 
            // methodologyDataGridView
            // 
            this.methodologyDataGridView.AllowUserToAddRows = false;
            this.methodologyDataGridView.AllowUserToDeleteRows = false;
            this.methodologyDataGridView.AutoGenerateColumns = false;
            this.methodologyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.methodologyDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.methodologyDataGridView.DataSource = this.methodologyBindingSource;
            this.methodologyDataGridView.Location = new System.Drawing.Point(3, 29);
            this.methodologyDataGridView.Name = "methodologyDataGridView";
            this.methodologyDataGridView.ReadOnly = true;
            this.methodologyDataGridView.RowHeadersWidth = 51;
            this.methodologyDataGridView.RowTemplate.Height = 48;
            this.methodologyDataGridView.Size = new System.Drawing.Size(515, 220);
            this.methodologyDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_methodology";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_methodology";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "id_expert";
            this.dataGridViewTextBoxColumn2.HeaderText = "id_expert";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "name_methodology";
            this.dataGridViewTextBoxColumn3.HeaderText = "Методика";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "description_methodology";
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn4.HeaderText = "Описание";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // expertsTableAdapter
            // 
            this.expertsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.banking_activitiesTableAdapter = null;
            this.tableAdapterManager.banksTableAdapter = null;
            this.tableAdapterManager.criteriaTableAdapter = null;
            this.tableAdapterManager.expertsTableAdapter = this.expertsTableAdapter;
            this.tableAdapterManager.indicatorsTableAdapter = null;
            this.tableAdapterManager.methodology_criteriaTableAdapter = null;
            this.tableAdapterManager.methodologyTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = bank.banking_activitiesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // methodologyTableAdapter
            // 
            this.methodologyTableAdapter.ClearBeforeFill = true;
            // 
            // methodology_criteriaTableAdapter
            // 
            this.methodology_criteriaTableAdapter.ClearBeforeFill = true;
            // 
            // criteriaTableAdapter
            // 
            this.criteriaTableAdapter.ClearBeforeFill = true;
            // 
            // ExpertForm
            // 
            this.AcceptButton = this.updateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 523);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ExpertForm";
            this.Text = "Личный кабинет";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ExpertForm_FormClosing);
            this.Load += new System.EventHandler(this.ExpertForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.expertsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.banking_activitiesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.methodology_criteriaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.criteriaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.methodology_criteriaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.methodologyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.methodologyDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private banking_activitiesDataSet banking_activitiesDataSet;
        private System.Windows.Forms.BindingSource expertsBindingSource;
        private banking_activitiesDataSetTableAdapters.expertsTableAdapter expertsTableAdapter;
        private banking_activitiesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox id_expertTextBox;
        private System.Windows.Forms.TextBox fIOTextBox;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.BindingSource methodologyBindingSource;
        private banking_activitiesDataSetTableAdapters.methodologyTableAdapter methodologyTableAdapter;
        private System.Windows.Forms.DataGridView methodologyDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.BindingSource methodology_criteriaBindingSource;
        private banking_activitiesDataSetTableAdapters.methodology_criteriaTableAdapter methodology_criteriaTableAdapter;
        private System.Windows.Forms.DataGridView methodology_criteriaDataGridView;
        private System.Windows.Forms.BindingSource criteriaBindingSource;
        private banking_activitiesDataSetTableAdapters.criteriaTableAdapter criteriaTableAdapter;
        private System.Windows.Forms.Button ratingButton;
        private System.Windows.Forms.LinkLabel createLinkLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}