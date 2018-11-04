namespace WindowsFormsApp3
{
    partial class Form1
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.rb_auto = new System.Windows.Forms.RadioButton();
            this.rb_aper = new System.Windows.Forms.RadioButton();
            this.rb_journal = new System.Windows.Forms.RadioButton();
            this.rb_routes = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.rb_users = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(146, 12);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(526, 231);
            this.dgv.TabIndex = 1;
            // 
            // rb_auto
            // 
            this.rb_auto.AutoSize = true;
            this.rb_auto.Location = new System.Drawing.Point(29, 25);
            this.rb_auto.Name = "rb_auto";
            this.rb_auto.Size = new System.Drawing.Size(87, 17);
            this.rb_auto.TabIndex = 2;
            this.rb_auto.TabStop = true;
            this.rb_auto.Text = "Автомобили";
            this.rb_auto.UseVisualStyleBackColor = true;
            this.rb_auto.CheckedChanged += new System.EventHandler(this.Rb_auto_CheckedChanged);
            // 
            // rb_aper
            // 
            this.rb_aper.AutoSize = true;
            this.rb_aper.Location = new System.Drawing.Point(29, 58);
            this.rb_aper.Name = "rb_aper";
            this.rb_aper.Size = new System.Drawing.Size(73, 17);
            this.rb_aper.TabIndex = 3;
            this.rb_aper.TabStop = true;
            this.rb_aper.Text = "Водители";
            this.rb_aper.UseVisualStyleBackColor = true;
            this.rb_aper.CheckedChanged += new System.EventHandler(this.Rb_aper_CheckedChanged);
            // 
            // rb_journal
            // 
            this.rb_journal.AutoSize = true;
            this.rb_journal.Location = new System.Drawing.Point(29, 94);
            this.rb_journal.Name = "rb_journal";
            this.rb_journal.Size = new System.Drawing.Size(65, 17);
            this.rb_journal.TabIndex = 4;
            this.rb_journal.TabStop = true;
            this.rb_journal.Text = "Журнал";
            this.rb_journal.UseVisualStyleBackColor = true;
            this.rb_journal.CheckedChanged += new System.EventHandler(this.rb_journal_CheckedChanged);
            // 
            // rb_routes
            // 
            this.rb_routes.AutoSize = true;
            this.rb_routes.Location = new System.Drawing.Point(29, 130);
            this.rb_routes.Name = "rb_routes";
            this.rb_routes.Size = new System.Drawing.Size(78, 17);
            this.rb_routes.TabIndex = 5;
            this.rb_routes.TabStop = true;
            this.rb_routes.Text = "Маршруты";
            this.rb_routes.UseVisualStyleBackColor = true;
            this.rb_routes.CheckedChanged += new System.EventHandler(this.rb_routes_CheckedChanged);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.Location = new System.Drawing.Point(20, 269);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(155, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button3.Location = new System.Drawing.Point(181, 269);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(153, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Редактировать";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button4.Location = new System.Drawing.Point(340, 269);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(167, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "Удалить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(513, 269);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "SQL запрос";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // rb_users
            // 
            this.rb_users.AutoSize = true;
            this.rb_users.Location = new System.Drawing.Point(29, 164);
            this.rb_users.Name = "rb_users";
            this.rb_users.Size = new System.Drawing.Size(98, 17);
            this.rb_users.TabIndex = 10;
            this.rb_users.TabStop = true;
            this.rb_users.Text = "Пользователи";
            this.rb_users.UseVisualStyleBackColor = true;
            this.rb_users.CheckedChanged += new System.EventHandler(this.rb_users_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 315);
            this.Controls.Add(this.rb_users);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.rb_routes);
            this.Controls.Add(this.rb_journal);
            this.Controls.Add(this.rb_aper);
            this.Controls.Add(this.rb_auto);
            this.Controls.Add(this.dgv);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.RadioButton rb_auto;
        private System.Windows.Forms.RadioButton rb_aper;
        private System.Windows.Forms.RadioButton rb_journal;
        private System.Windows.Forms.RadioButton rb_routes;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rb_users;
    }
}

