using Npgsql;
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
    public partial class Form1 : Form
    {
        public PSQLCon psql = new PSQLCon();
        string id;
        public Form1(string _id, string stat)
        {
            id = _id;
            InitializeComponent();
            if(stat == "0")
            {
                rb_users.Visible = false;
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
                button4.Visible = false;
            }
            rb_journal.Checked = true;
            Viewtable();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Viewtable();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (rb_auto.Checked)
                psql.delAuto(dgv.SelectedCells[0].Value.ToString());
            if (rb_aper.Checked)
                psql.delAPer(dgv.SelectedCells[0].Value.ToString());
            if (rb_journal.Checked)
                psql.delJournals(dgv.SelectedCells[0].Value.ToString());
            if (rb_routes.Checked)
                psql.delRoutes(dgv.SelectedCells[0].Value.ToString());
            if (rb_users.Checked && dgv.SelectedCells[0].Value.ToString()!=id)
                psql.delUser(dgv.SelectedCells[0].Value.ToString());
            Viewtable();
        }
        private void Viewtable()
        {
            try
            {

                if (rb_users.Checked)
                {
                    dgv.DataSource = psql.getUsers();
                    dgv.Columns[1].HeaderText = "Логин";
                    dgv.Columns[2].HeaderText = "Пароль";
                    dgv.Columns[3].HeaderText = "Доступ";
                }
                if (rb_auto.Checked)
                {
                    dgv.DataSource = psql.getAuto();
                    dgv.Columns[1].HeaderText = "Номер";
                    dgv.Columns[2].HeaderText = "Цвет";
                    dgv.Columns[3].HeaderText = "Марка";
                    dgv.Columns[4].HeaderText = "Водитель";
                }
                if (rb_aper.Checked)
                {
                    dgv.DataSource = psql.getAPer();
                    dgv.Columns[1].HeaderText = "Фамилия";
                    dgv.Columns[2].HeaderText = "Имя";
                    dgv.Columns[3].HeaderText = "Отчество";
                }
                if (rb_journal.Checked)
                {
                    try
                    {
                        dgv.DataSource = psql.getJournals();
                        dgv.Columns[1].HeaderText = "Время выезда";
                        dgv.Columns[2].HeaderText = "Время возвращения";
                        dgv.Columns[3].HeaderText = "Маршрут";
                        dgv.Columns[4].HeaderText = "Номер автомобиля";
                    }
                    catch { }
                }
                if (rb_routes.Checked)
                {
                    dgv.DataSource = psql.getRoutes();
                    dgv.Columns[1].HeaderText = "Маршрут";

                }
                dgv.Sort(dgv.Columns["id"], ListSortDirection.Ascending);
            }
            catch { }
        }

        private void Rb_auto_CheckedChanged(object sender, EventArgs e)
        {
            Viewtable();
        }

        private void Rb_aper_CheckedChanged(object sender, EventArgs e)
        {
            Viewtable();
        }

        private void rb_journal_CheckedChanged(object sender, EventArgs e)
        {
            Viewtable();
        }

        private void rb_routes_CheckedChanged(object sender, EventArgs e)
        {
            Viewtable();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (rb_users.Checked)
            {
                Form f = new User();
                f.FormClosed += updateDB;
                f.ShowDialog();
            }
            if (rb_auto.Checked)
            {
                Form f = new Auto();
                f.FormClosed += updateDB;
                f.ShowDialog();
            }
            if (rb_aper.Checked)
            {
                Form f = new Auto_Personnel();
                f.FormClosed += updateDB;
                f.ShowDialog();
            }
            if (rb_journal.Checked)
            {
                Form f = new Journal();
                f.FormClosed += updateDB;
                f.ShowDialog();
            }
            if (rb_routes.Checked)
            {
                Form f = new Routes();
                f.FormClosed += updateDB;
                f.ShowDialog();
            }
        }
        private void updateDB(object sender, EventArgs e)
        {
            Viewtable();
            
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (rb_users.Checked)
            {
                Form f = new User(dgv.SelectedCells[0].Value.ToString());
                f.FormClosed += updateDB;
                f.ShowDialog();
            }
            if (rb_auto.Checked)
            {
                Form f = new Auto(dgv.SelectedCells[0].Value.ToString());
                f.FormClosed += updateDB;
                f.ShowDialog();
            }
            if (rb_aper.Checked)
            {
                Form f = new Auto_Personnel(dgv.SelectedCells[0].Value.ToString());
                f.FormClosed += updateDB;
                f.ShowDialog();
            }
            if (rb_journal.Checked)
            {
                Form f = new Journal(dgv.SelectedCells[0].Value.ToString());
                f.FormClosed += updateDB;
                f.ShowDialog();
            }
            if (rb_routes.Checked)
            {
                Form f = new Routes(dgv.SelectedCells[0].Value.ToString());
                f.FormClosed += updateDB;
                f.ShowDialog();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form f = new SQL();
            f.FormClosed += updateDB;
            f.ShowDialog();
        }

        private void rb_users_CheckedChanged(object sender, EventArgs e)
        {
            Viewtable();
        }
    }
}
