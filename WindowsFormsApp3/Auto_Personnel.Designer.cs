namespace WindowsFormsApp3
{
    partial class Auto_Personnel
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
            this.tb_first = new System.Windows.Forms.TextBox();
            this.tb_second = new System.Windows.Forms.TextBox();
            this.tb_pather = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_first
            // 
            this.tb_first.Location = new System.Drawing.Point(90, 40);
            this.tb_first.Name = "tb_first";
            this.tb_first.Size = new System.Drawing.Size(182, 20);
            this.tb_first.TabIndex = 0;
            // 
            // tb_second
            // 
            this.tb_second.Location = new System.Drawing.Point(90, 81);
            this.tb_second.Name = "tb_second";
            this.tb_second.Size = new System.Drawing.Size(182, 20);
            this.tb_second.TabIndex = 1;
            // 
            // tb_pather
            // 
            this.tb_pather.Location = new System.Drawing.Point(90, 121);
            this.tb_pather.Name = "tb_pather";
            this.tb_pather.Size = new System.Drawing.Size(182, 20);
            this.tb_pather.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Фамилия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Имя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Отчество";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 200);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(257, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "ОК";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Auto_Personnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_pather);
            this.Controls.Add(this.tb_second);
            this.Controls.Add(this.tb_first);
            this.Name = "Auto_Personnel";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Водитель";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_first;
        private System.Windows.Forms.TextBox tb_second;
        private System.Windows.Forms.TextBox tb_pather;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}