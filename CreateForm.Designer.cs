namespace bank
{
    partial class CreateForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.descriptionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.criteriaDataGridView = new System.Windows.Forms.DataGridView();
            this.criteria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addLinkLabel = new System.Windows.Forms.LinkLabel();
            this.okButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.criteriaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(426, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Наименование методики рейтингования деятельности банков:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(12, 29);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(776, 22);
            this.nameTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(394, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Описание методики рейтингования деятельности банков:";
            // 
            // descriptionRichTextBox
            // 
            this.descriptionRichTextBox.Location = new System.Drawing.Point(12, 74);
            this.descriptionRichTextBox.Name = "descriptionRichTextBox";
            this.descriptionRichTextBox.Size = new System.Drawing.Size(776, 96);
            this.descriptionRichTextBox.TabIndex = 3;
            this.descriptionRichTextBox.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(392, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Критерии методики рейтингования деятельности банков:";
            // 
            // criteriaDataGridView
            // 
            this.criteriaDataGridView.AllowUserToAddRows = false;
            this.criteriaDataGridView.AllowUserToDeleteRows = false;
            this.criteriaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.criteriaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.criteria,
            this.weight,
            this.delete});
            this.criteriaDataGridView.Location = new System.Drawing.Point(12, 193);
            this.criteriaDataGridView.Name = "criteriaDataGridView";
            this.criteriaDataGridView.RowHeadersWidth = 51;
            this.criteriaDataGridView.RowTemplate.Height = 24;
            this.criteriaDataGridView.Size = new System.Drawing.Size(776, 209);
            this.criteriaDataGridView.TabIndex = 5;
            this.criteriaDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.criteriaDataGridView_CellClick);
            // 
            // criteria
            // 
            this.criteria.HeaderText = "Критерий";
            this.criteria.MinimumWidth = 6;
            this.criteria.Name = "criteria";
            this.criteria.ReadOnly = true;
            this.criteria.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.criteria.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.criteria.Width = 125;
            // 
            // weight
            // 
            this.weight.HeaderText = "Вес критерия";
            this.weight.MinimumWidth = 6;
            this.weight.Name = "weight";
            this.weight.Width = 125;
            // 
            // delete
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.delete.DefaultCellStyle = dataGridViewCellStyle1;
            this.delete.HeaderText = "";
            this.delete.MinimumWidth = 23;
            this.delete.Name = "delete";
            this.delete.ReadOnly = true;
            this.delete.Width = 23;
            // 
            // addLinkLabel
            // 
            this.addLinkLabel.AutoSize = true;
            this.addLinkLabel.Location = new System.Drawing.Point(650, 173);
            this.addLinkLabel.Name = "addLinkLabel";
            this.addLinkLabel.Size = new System.Drawing.Size(138, 17);
            this.addLinkLabel.TabIndex = 6;
            this.addLinkLabel.TabStop = true;
            this.addLinkLabel.Text = "Добавить критерии";
            this.addLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.addLinkLabel_LinkClicked);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(12, 408);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(776, 30);
            this.okButton.TabIndex = 7;
            this.okButton.Text = "Создать методику рейтингования деятельности банков";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // CreateForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.addLinkLabel);
            this.Controls.Add(this.criteriaDataGridView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.descriptionRichTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CreateForm";
            this.Text = "Создание методики рейтингования деятельности банков";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CreateForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.criteriaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox descriptionRichTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView criteriaDataGridView;
        private System.Windows.Forms.LinkLabel addLinkLabel;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn criteria;
        private System.Windows.Forms.DataGridViewTextBoxColumn weight;
        private System.Windows.Forms.DataGridViewTextBoxColumn delete;
    }
}