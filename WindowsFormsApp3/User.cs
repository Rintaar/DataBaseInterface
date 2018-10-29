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
    public partial class User : Form
    {
        PSQLCon psql = new PSQLCon();
        string id;
        string login;
        string password;
        string statut;


        public User()
        {
            InitializeComponent();
        }
        public User(string _id)
        {
            InitializeComponent();
            //запись уже существующих данных
            DataTable dt = psql.getUserID(_id);
            id = _id;
            textBox1.Text = dt.Rows[0].ItemArray[1].ToString();
            textBox2.Text = dt.Rows[0].ItemArray[2].ToString();
            if (Convert.ToInt32(dt.Rows[0].ItemArray[3].ToString()) > 0)
                cb_admin.Checked = true;
            else
                cb_admin.Checked = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cb_admin.Checked)
                statut = "1";
            else
                statut = "0";
            login = textBox1.Text;
            password = textBox2.Text;
            if (id != null)
            {
                psql.editUser(id, login,password,statut);
            }
            else
            {
                psql.addUser(login, password, statut);
            }
            this.Close();
        }
    }
}
