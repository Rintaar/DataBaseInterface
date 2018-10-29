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
    public partial class Journal : Form
    {
        List<string> l1 = new List<string>();
        List<string> l2 = new List<string>();
        PSQLCon psql = new PSQLCon();

        string id;
        string time_out;
        string time_in;
        string auto_id;
        string route_id;
        public Journal()
        {
            prestart();
        }
        public Journal(string _id)
        {
            prestart();
            //запись уже существующих данных
            DataTable dt = psql.getJournalsID(_id);
            id = dt.Rows[0].ItemArray[0].ToString();
            time_out = dt.Rows[0].ItemArray[1].ToString();
            time_in = dt.Rows[0].ItemArray[2].ToString();
            auto_id = dt.Rows[0].ItemArray[3].ToString();
            route_id = dt.Rows[0].ItemArray[4].ToString();

            int index1 = l1.FindIndex(x => x.Substring(0, auto_id.Length) == auto_id);
            int index2 = l2.FindIndex(x => x.Substring(0, route_id.Length) == route_id);
            tb_start.Text = time_out;
            tb_end.Text = time_in;
            cb_auto.SelectedIndex = index1;
            cb_route.SelectedIndex = index2;
        }
        private void prestart()
        {
            InitializeComponent();
            precreate();
            cb_auto.DataSource = l1;
            cb_route.DataSource = l2;
        }
        private void precreate()
        {
            DataTable dt = psql.getAuto();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                l1.Add(dt.Rows[i].ItemArray[0].ToString() + ". " + dt.Rows[i].ItemArray[1].ToString());
            }
            dt = psql.getRoutes();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                l2.Add(dt.Rows[i].ItemArray[0].ToString() + ". " + dt.Rows[i].ItemArray[1].ToString());
            }
            l1.Sort();
            l2.Sort();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            time_out = tb_start.Text;
            time_in = tb_end.Text;
            auto_id = cb_auto.SelectedItem.ToString().Substring(0, cb_auto.SelectedItem.ToString().IndexOf('.'));
            route_id = cb_route.SelectedItem.ToString().Substring(0, cb_route.SelectedItem.ToString().IndexOf('.'));
            if (id != null)
            {
                psql.editJournal(time_out, time_in, auto_id, route_id, id);
            }
            else
            {
                psql.addJournal(time_out, time_in, auto_id, route_id);
            }
            this.Close();
        }
    }
}
