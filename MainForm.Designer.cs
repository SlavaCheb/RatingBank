namespace bank
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.входToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.личныйКабинетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.созданиеМетодикиРейтингованияДеятельностиБанковToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.таблицыБДToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.банкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.показателиДеятельностиБанковToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.деятельностьБанковToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.критерииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.окнаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рейтингБанковToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.входToolStripMenuItem,
            this.личныйКабинетToolStripMenuItem,
            this.созданиеМетодикиРейтингованияДеятельностиБанковToolStripMenuItem,
            this.таблицыБДToolStripMenuItem,
            this.рейтингБанковToolStripMenuItem,
            this.окнаToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.окнаToolStripMenuItem;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1437, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // входToolStripMenuItem
            // 
            this.входToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("входToolStripMenuItem.Image")));
            this.входToolStripMenuItem.Name = "входToolStripMenuItem";
            this.входToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.входToolStripMenuItem.Text = "Вход";
            this.входToolStripMenuItem.Click += new System.EventHandler(this.входToolStripMenuItem_Click);
            // 
            // личныйКабинетToolStripMenuItem
            // 
            this.личныйКабинетToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("личныйКабинетToolStripMenuItem.Image")));
            this.личныйКабинетToolStripMenuItem.Name = "личныйКабинетToolStripMenuItem";
            this.личныйКабинетToolStripMenuItem.Size = new System.Drawing.Size(159, 24);
            this.личныйКабинетToolStripMenuItem.Text = "Личный кабинет";
            this.личныйКабинетToolStripMenuItem.Visible = false;
            this.личныйКабинетToolStripMenuItem.Click += new System.EventHandler(this.личныйКабинетToolStripMenuItem_Click);
            // 
            // созданиеМетодикиРейтингованияДеятельностиБанковToolStripMenuItem
            // 
            this.созданиеМетодикиРейтингованияДеятельностиБанковToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("созданиеМетодикиРейтингованияДеятельностиБанковToolStripMenuItem.Image")));
            this.созданиеМетодикиРейтингованияДеятельностиБанковToolStripMenuItem.Name = "созданиеМетодикиРейтингованияДеятельностиБанковToolStripMenuItem";
            this.созданиеМетодикиРейтингованияДеятельностиБанковToolStripMenuItem.Size = new System.Drawing.Size(444, 24);
            this.созданиеМетодикиРейтингованияДеятельностиБанковToolStripMenuItem.Text = "Создание методики рейтингования деятельности банков";
            this.созданиеМетодикиРейтингованияДеятельностиБанковToolStripMenuItem.Visible = false;
            this.созданиеМетодикиРейтингованияДеятельностиБанковToolStripMenuItem.Click += new System.EventHandler(this.созданиеМетодикиРейтингованияДеятельностиБанковToolStripMenuItem_Click);
            // 
            // таблицыБДToolStripMenuItem
            // 
            this.таблицыБДToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.банкиToolStripMenuItem,
            this.показателиДеятельностиБанковToolStripMenuItem,
            this.деятельностьБанковToolStripMenuItem,
            this.критерииToolStripMenuItem});
            this.таблицыБДToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("таблицыБДToolStripMenuItem.Image")));
            this.таблицыБДToolStripMenuItem.Name = "таблицыБДToolStripMenuItem";
            this.таблицыБДToolStripMenuItem.Size = new System.Drawing.Size(128, 24);
            this.таблицыБДToolStripMenuItem.Text = "Таблицы БД";
            this.таблицыБДToolStripMenuItem.Visible = false;
            // 
            // банкиToolStripMenuItem
            // 
            this.банкиToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("банкиToolStripMenuItem.Image")));
            this.банкиToolStripMenuItem.Name = "банкиToolStripMenuItem";
            this.банкиToolStripMenuItem.Size = new System.Drawing.Size(325, 26);
            this.банкиToolStripMenuItem.Text = "Банки";
            this.банкиToolStripMenuItem.Click += new System.EventHandler(this.банкиToolStripMenuItem_Click);
            // 
            // показателиДеятельностиБанковToolStripMenuItem
            // 
            this.показателиДеятельностиБанковToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("показателиДеятельностиБанковToolStripMenuItem.Image")));
            this.показателиДеятельностиБанковToolStripMenuItem.Name = "показателиДеятельностиБанковToolStripMenuItem";
            this.показателиДеятельностиБанковToolStripMenuItem.Size = new System.Drawing.Size(325, 26);
            this.показателиДеятельностиБанковToolStripMenuItem.Text = "Показатели деятельности банков";
            this.показателиДеятельностиБанковToolStripMenuItem.Click += new System.EventHandler(this.показателиДеятельностиБанковToolStripMenuItem_Click);
            // 
            // деятельностьБанковToolStripMenuItem
            // 
            this.деятельностьБанковToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("деятельностьБанковToolStripMenuItem.Image")));
            this.деятельностьБанковToolStripMenuItem.Name = "деятельностьБанковToolStripMenuItem";
            this.деятельностьБанковToolStripMenuItem.Size = new System.Drawing.Size(325, 26);
            this.деятельностьБанковToolStripMenuItem.Text = "Деятельность банков";
            this.деятельностьБанковToolStripMenuItem.Click += new System.EventHandler(this.деятельностьБанковToolStripMenuItem_Click);
            // 
            // критерииToolStripMenuItem
            // 
            this.критерииToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("критерииToolStripMenuItem.Image")));
            this.критерииToolStripMenuItem.Name = "критерииToolStripMenuItem";
            this.критерииToolStripMenuItem.Size = new System.Drawing.Size(325, 26);
            this.критерииToolStripMenuItem.Text = "Критерии";
            this.критерииToolStripMenuItem.Click += new System.EventHandler(this.критерииToolStripMenuItem_Click);
            // 
            // окнаToolStripMenuItem
            // 
            this.окнаToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("окнаToolStripMenuItem.Image")));
            this.окнаToolStripMenuItem.Name = "окнаToolStripMenuItem";
            this.окнаToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.окнаToolStripMenuItem.Text = "Окна";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("выходToolStripMenuItem.Image")));
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Visible = false;
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // рейтингБанковToolStripMenuItem
            // 
            this.рейтингБанковToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("рейтингБанковToolStripMenuItem.Image")));
            this.рейтингБанковToolStripMenuItem.Name = "рейтингБанковToolStripMenuItem";
            this.рейтингБанковToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.рейтингБанковToolStripMenuItem.Text = "Рейтинг банков";
            this.рейтингБанковToolStripMenuItem.Visible = false;
            this.рейтингБанковToolStripMenuItem.Click += new System.EventHandler(this.рейтингБанковToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1437, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Компьютерная система рейтингования деятельности банков";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem входToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem окнаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem созданиеМетодикиРейтингованияДеятельностиБанковToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem личныйКабинетToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem таблицыБДToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem банкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem показателиДеятельностиБанковToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem деятельностьБанковToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem критерииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem рейтингБанковToolStripMenuItem;
    }
}

