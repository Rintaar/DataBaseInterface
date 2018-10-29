using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public class PSQLCon
    {
// конструкторы класса
    #region constructors
            public PSQLCon()
            { }
        #endregion
 //функции получения таблиц
     #region get_fullinfo
        /// <summary>
        /// получение списка автомобилей
        /// </summary>
        /// <returns></returns>
        public DataTable getAuto()
        {
            return MainSQL("SELECT * FROM auto");
        }
        /// <summary>
        /// получение списка пользователей
        /// </summary>
        /// <returns></returns>
        public DataTable getUsers()
        {
            return MainSQL("SELECT * FROM users");
        }
        /// <summary>
        /// получение журнала
        /// </summary>
        /// <returns></returns>
        public DataTable getJournals()
        {
            return MainSQL("SELECT * FROM journal");
        }
        /// <summary>
        /// получение списка водителей
        /// </summary>
        /// <returns></returns>
        public DataTable getAPer()
        {
            return MainSQL("SELECT * FROM auto_personnel");
        }
        /// <summary>
        /// полученеи списка маршрутов
        /// </summary>
        /// <returns></returns>
        public DataTable getRoutes()
        {
            return MainSQL("SELECT * FROM routes");
        }
        #endregion
//функции получения частичных данных
    #region get_info
        /// <summary>
        /// получение авто по ID
        /// </summary>
        /// <param name="id">id удаляемой записи</param>

        public DataTable getAutoID(string id)
    {
        return MainSQL(String.Format("SELECT * FROM auto WHERE id ={0}",id));
    }
        /// <summary>
        /// получение пользователя по ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public DataTable getUserID(string id)
        {
            return MainSQL(String.Format("SELECT * FROM users WHERE id ={0}", id));
        }
        /// <summary>
        /// получение журнала
        /// </summary>
        /// <returns></returns>
        public DataTable getJournalsID(string id)
    {
        return MainSQL(String.Format("SELECT * FROM journal WHERE id ={0}", id));
    }
    /// <summary>
    /// получение списка водителей
    /// </summary>
    /// <returns></returns>
    public DataTable getAPerID(string id)
    {
        return MainSQL(String.Format("SELECT * FROM auto_personnel WHERE id ={0}", id));
    }
    /// <summary>
    /// полученеи списка маршрутов
    /// </summary>
    /// <returns></returns>
    public DataTable getRoutesID(string id)
    {
        return MainSQL(String.Format("SELECT * FROM routes WHERE id ={0}", id));
    }
    #endregion
//функции удаления данных
    #region delete
        /// <summary>
        /// удаление выбранного автомобиля
        /// </summary>
        /// <param name="id">id удаляемой записи</param>
        public void delAuto(string id)
        {
            deleteSql(id, "auto");
        }
        public void delUser(string id)
        {
            deleteSql(id, "users");
        }
        /// <summary>
        /// удаление записи из журнала
        /// </summary>
        /// <param name="id">id удаляемой записи</param>
        public void delJournals(string id)
        {
            deleteSql(id, "journal");
        }
        /// <summary>
        /// удаление водителя
        /// </summary>
        /// <param name="id">id удаляемой записи</param>
        public void delAPer(string id)
        {
            deleteSql(id, "auto_personnel");
        }
        /// <summary>
        /// удаление маршрута
        /// </summary>
        /// <param name="id">id удаляемой записи</param>
        public void delRoutes(string id)
        {
            deleteSql(id, "routes");
        }
        #endregion
//функции редактирования данных
    #region edit
        /// <summary>
        /// изменение по ID автомобиля
        /// </summary>
        /// <param name="id"></param>
        /// <param name="num">номер</param>
        /// <param name="color">цвет</param>
        /// <param name="mark">марка</param>
        /// <param name="p_id">ID водителя</param>
        public void editAuto(string id, string num, string color, string mark, string p_id)
        {
            string sql = String.Format("UPDATE auto SET num = '{0}',  color = '{1}', mark = '{2}', personnel_id = {3}  WHERE id = {4} ;", num, color, mark, p_id, id);
            nrMainSQL(sql);
        }
        public void editUser(string id, string login, string password, string status)
        {
            string sql = String.Format("UPDATE users SET login = '{0}',  password = '{1}', statut = '{2}'  WHERE id = {3} ;", login,password, status, id);
            nrMainSQL(sql);
        }
        /// <summary>
        /// изменение по ID водителя
        /// </summary>
        /// <param name="id"></param>
        /// <param name="first">фамилия</param>
        /// <param name="second">имя</param>
        /// <param name="pather">отчество</param>
        public void editAPer(string id, string first, string second, string pather)
        {
            string sql = String.Format("UPDATE auto_personnel SET first_name = '{0}',  last_name = '{1}', pather_name = '{2}' WHERE id = {3} ;", first, second, pather, id);
            nrMainSQL(sql);
        }
        /// <summary>
        /// изменение по ID записи журнала
        /// </summary>
        /// <param name="time_out">время выезда</param>
        /// <param name="time_in">время возвращения</param>
        /// <param name="auto_id">ID авто</param>
        /// <param name="route_id">ID маршрута</param>
        /// <param name="id"></param>
        public void editJournal(string time_out, string time_in, string auto_id, string route_id, string id)
        {
            string sql = String.Format("UPDATE journal SET time_out = '{0}',  time_in = '{1}', auto_id = {2}, route_id = {3}  WHERE id = {4} ;", time_out, time_in, auto_id, route_id, id);
            nrMainSQL(sql);
        }
        /// <summary>
        /// изменение по ID маршрута
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name">название маршрута</param>
        public void editRoutes(string id, string name)
        {
            string sql = String.Format("UPDATE routes SET name = '{0}'  WHERE id = {1} ;", name, id);
            nrMainSQL(sql);
        }
        #endregion
 //функции добавления данных
    #region add
    /// <summary>
    /// добавление пользователя
    /// </summary>
    /// <param name="login">логин</param>
    /// <param name="password">пароль</param>
    /// <param name="status">статус 1 - админ, 0 - пользователь</param>
    public void addUser(string login, string password, string status)
    {
        string sql = String.Format("INSERT INTO users(login, password, statut) VALUES ('{0}', '{1}', {2});", login, password, status);
        nrMainSQL(sql);
    }
    /// <summary>
    /// добавление автомобиля
    /// </summary>
    /// <param name="num">номер авто</param>
    /// <param name="color">цвет</param>
    /// <param name="mark">марка</param>
    /// <param name="p_id">id водителя</param>
    public void addAuto(string num, string color, string mark, string p_id)
    {
        string sql = String.Format("INSERT INTO auto(num, color, mark, personnel_id) VALUES ('{0}', '{1}', '{2}', {3});", num, color, mark, p_id);
        nrMainSQL(sql);
    }
    /// <summary>
    /// добавление маршрута
    /// </summary>
    /// <param name="name">название маршрута</param>
    public void addRoutes(string name)
    {
        string sql = String.Format("INSERT INTO routes(name) VALUES ('{0}');", name);
        nrMainSQL(sql);
    }
    /// <summary>
    /// добавление записи в журнал
    /// </summary>
    /// <param name="time_out">время выезда</param>
    /// <param name="time_in">время возвращения</param>
    /// <param name="auto_id">id автомобиля</param>
    /// <param name="route_id">id маршрута</param>
    public void addJournal(string time_out, string time_in, string auto_id, string route_id)
    {
        string sql = String.Format("INSERT INTO journal(time_out, time_in, auto_id, route_id) VALUES ('{0}', '{1}', {2}, {3});", time_out, time_in, auto_id, route_id);
        nrMainSQL(sql);
    }
    /// <summary>
    /// добавление нового водителя
    /// </summary>
    /// <param name="first">фамилия</param>
    /// <param name="second">имя</param>
    /// <param name="pather">отчество</param>
    public void addAPer(string first, string second, string pather)
    {
        string sql = String.Format("INSERT INTO auto_personnel(first_name, last_name, pather_name) VALUES ('{0}', '{1}', '{2}');", first, second,pather);
        nrMainSQL(sql);
    }
        #endregion
//служебные функции
    #region private
        /// <summary>
        /// основная функция на удаление
        /// </summary>
        /// <param name="id">id удаляемой записи</param>
        /// <param name="table">таблица для удаляемой записи</param>
        private void deleteSql(string id, string table)
        {
            string sql = String.Format("DELETE FROM {0} WHERE id = {1}", table, id);
            MainSQL(sql);
        }     
        /// <summary>
        /// основная функция работы с БД со вшитыми параметрами возвращает данные
        /// </summary>
        /// <param name="sql">sql запрос</param>
        /// <returns></returns>
        public DataTable MainSQL(string sql)
        {
            DataTable DT = new DataTable();
            try
            {
                NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres; Password= ;Database=auto_b;");
                NpgsqlCommand comm = new NpgsqlCommand(sql, conn);
                conn.Open(); //Открываем соединение.
                NpgsqlDataReader reader = comm.ExecuteReader();
                if (reader.HasRows)
                {
                    DT.Load(reader);
                }
                conn.Close(); //Закрываем соединение.}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            return DT;
        }
        /// <summary>
        /// основная функция работы с БД со вшитыми параметрами не возвращает данные
        /// </summary>
        /// <param name="sql">sql запро</param>
        private void nrMainSQL(string sql)
        {
            DataTable DT = new DataTable();
            try
            {
                NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres; Password= ;Database=auto_b;");
                NpgsqlCommand comm = new NpgsqlCommand(sql, conn);
                conn.Open(); //Открываем соединение.
                comm.ExecuteNonQuery();               
                conn.Close(); //Закрываем соединение.}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
    }
}
