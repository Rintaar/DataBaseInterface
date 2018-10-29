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
    public partial class Routes : Form
    {
        string route;
        string idval;
        PSQLCon psql = new PSQLCon();
        public Routes()
        {
            InitializeComponent();
        }
        public Routes(string id)
        {
            InitializeComponent();
            idval = id;
            route = psql.getRoutesID(id).Rows[0].ItemArray[1].ToString();
            textBox1.Text = route;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            route = textBox1.Text;
            
            if (idval != null)
            {
                psql.editRoutes(idval, route);
            }
            else
            {
                psql.addRoutes(route);
            }
            this.Close();
        }
    }
}
