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
    public partial class Auto_Personnel : Form
    {
        PSQLCon psql = new PSQLCon();
        string first;
        string second;
        string pather;
        string id;

        public Auto_Personnel()
        {
            InitializeComponent();
        }
        public Auto_Personnel(string _id)
        {
            InitializeComponent();
            id = _id;
            DataTable dt = psql.getAPerID(_id);
            first = dt.Rows[0].ItemArray[1].ToString();
            second = dt.Rows[0].ItemArray[2].ToString();
            pather = dt.Rows[0].ItemArray[3].ToString();

            tb_first.Text = first;
            tb_second.Text = second;
            tb_pather.Text = pather;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            first = tb_first.Text;
            second = tb_second.Text;
            pather = tb_pather.Text;

            if (id != null)
            {
                psql.editAPer(id, first, second, pather);
            }
            else
            {
                psql.addAPer(first, second, pather);
            }
            this.Close();
        }
    }
}
