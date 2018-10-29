using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class StartWindow : Form
    {
        public PSQLCon psql = new PSQLCon();
        public StartWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = psql.MainSQL(String.Format("SELECT * FROM users WHERE login = '{0}' AND password = '{1}'", textBox1.Text, textBox2.Text));
            if (dt.Rows.Count == 0)
                MessageBox.Show("Неправильно введенные данные");
            else
            {
                Form f = new Form1(dt.Rows[0].ItemArray[0].ToString(), dt.Rows[0].ItemArray[3].ToString());
                f.FormClosed += updateDB;
                f.Show();
                this.Hide();
            }
        }
        private void updateDB(object sender, EventArgs e)
        {
            this.Show();
        }
    }
}
