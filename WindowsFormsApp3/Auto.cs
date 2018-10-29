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
    public partial class Auto : Form
    {
        PSQLCon psql = new PSQLCon();
        List<string> personnel = new List<string>();
        string id;
        string num;
        string color;
        string mark;
        string personnel_id;
        private void prestart()
        {
            InitializeComponent();
            precreate();
            comboBox1.DataSource = personnel;
            comboBox1.SelectedIndex = 0;
        }
        public Auto()
        {
            prestart();            
        }
        public Auto(string _id)
        {
            prestart();
            //запись уже существующих данных
            DataTable dt = psql.getAutoID(_id);
            id = dt.Rows[0].ItemArray[0].ToString();
            num = dt.Rows[0].ItemArray[1].ToString();
            color = dt.Rows[0].ItemArray[2].ToString();
            mark = dt.Rows[0].ItemArray[3].ToString();
            personnel_id = dt.Rows[0].ItemArray[4].ToString();
            int index = personnel.FindIndex(x => x.Substring(0, personnel_id.Length) == personnel_id);

            tb_col.Text = color;
            tb_num.Text = num;
            tb_mar.Text = mark;
            comboBox1.SelectedIndex = index;
        }
        //забиваем список водителей
        private void precreate()
        {
            DataTable dt = psql.getAPer();
            for(int i = 0; i< dt.Rows.Count; i++)
            {                
                personnel.Add(dt.Rows[i].ItemArray[0].ToString() + ". " + dt.Rows[i].ItemArray[1].ToString() + " " + dt.Rows[i].ItemArray[2].ToString() + " " + dt.Rows[i].ItemArray[3].ToString());
            }
            personnel.Sort();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            num = tb_num.Text;
            color = tb_col.Text;
            mark = tb_mar.Text;
            personnel_id = comboBox1.SelectedItem.ToString().Substring(0, comboBox1.SelectedItem.ToString().IndexOf('.'));
            if(id!=null)
            {
                psql.editAuto(id, num, color, mark, personnel_id);
            }
            else
            {
                psql.addAuto(num, color, mark, personnel_id);
            }
            this.Close();
        }

        private void Auto_Load(object sender, EventArgs e)
        {

        }
    }
}
