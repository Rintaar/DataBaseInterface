using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class SQL : Form
    {
        PSQLCon psql = new PSQLCon();
        DataTable dt;
        public SQL()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dt = psql.MainSQL(textBox1.Text.Replace(Environment.NewLine, " "));
            if (dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;
                button3.Enabled = true;
            }
            else
            {
                MessageBox.Show("Запрос завершен");
                button3.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter("log.doc", false, System.Text.Encoding.Default))
                {
                    //оформляем шапку
                    string text = "Отчет по выполнению запроса: \n\n";
                    text += textBox1.Text;
                    text += "\n\n\nРезультат:\n\n";
                    //записываем результат
                    foreach (DataRow items in dt.Rows)
                    {
                        for (int i = 0; i < items.ItemArray.Length; i++)
                        {
                            text += items.ItemArray[i].ToString() + "|";
                        }
                        text += "\n";
                    }
                    sw.WriteLine(text);
                }
                System.Diagnostics.Process.Start("log.doc");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
