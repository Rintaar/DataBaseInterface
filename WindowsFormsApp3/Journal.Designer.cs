namespace WindowsFormsApp3
{
    partial class Journal
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
            this.tb_start = new System.Windows.Forms.MaskedTextBox();
            this.tb_end = new System.Windows.Forms.MaskedTextBox();
            this.cb_auto = new System.Windows.Forms.ComboBox();
            this.cb_route = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_start
            // 
            this.tb_start.Location = new System.Drawing.Point(109, 31);
            this.tb_start.Mask = "00/00/0000 90:00";
            this.tb_start.Name = "tb_start";
            this.tb_start.Size = new System.Drawing.Size(163, 20);
            this.tb_start.TabIndex = 0;
            this.tb_start.ValidatingType = typeof(System.DateTime);
            // 
            // tb_end
            // 
            this.tb_end.Location = new System.Drawing.Point(109, 68);
            this.tb_end.Mask = "00/00/0000 90:00";
            this.tb_end.Name = "tb_end";
            this.tb_end.Size = new System.Drawing.Size(163, 20);
            this.tb_end.TabIndex = 1;
            this.tb_end.ValidatingType = typeof(System.DateTime);
            // 
            // cb_auto
            // 
            this.cb_auto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_auto.FormattingEnabled = true;
            this.cb_auto.Location = new System.Drawing.Point(109, 106);
            this.cb_auto.Name = "cb_auto";
            this.cb_auto.Size = new System.Drawing.Size(163, 21);
            this.cb_auto.TabIndex = 2;
            // 
            // cb_route
            // 
            this.cb_route.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_route.FormattingEnabled = true;
            this.cb_route.Location = new System.Drawing.Point(109, 145);
            this.cb_route.Name = "cb_route";
            this.cb_route.Size = new System.Drawing.Size(163, 21);
            this.cb_route.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Начало";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Конец";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Автомобиль";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Маршрут";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(257, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "ОК";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Journal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_route);
            this.Controls.Add(this.cb_auto);
            this.Controls.Add(this.tb_end);
            this.Controls.Add(this.tb_start);
            this.Name = "Journal";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Запись журнала";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox tb_start;
        private System.Windows.Forms.MaskedTextBox tb_end;
        private System.Windows.Forms.ComboBox cb_auto;
        private System.Windows.Forms.ComboBox cb_route;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}