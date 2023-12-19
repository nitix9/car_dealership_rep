using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace car_dealership
{
    internal class conn
    {
        public static MySqlConnection GetConnection()
        {
            string sql = "datasource=26.176.43.176;port=3306;username=denis;password=123456781;database=autocar";
            MySqlConnection con = new MySqlConnection(sql);
            try
            {
                con.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("MySQL Connection! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return con;
        }

        public static void display(string qrt, DataGridView dgv)
        {
            string sql = qrt;

            MySqlConnection con = GetConnection();

            MySqlCommand com = new MySqlCommand(sql, con);

            MySqlDataAdapter adp = new MySqlDataAdapter(com);

            DataTable dt = new DataTable();

            adp.Fill(dt);

            carstore.dt = dt;

            dgv.DataSource = dt;

            con.Close();

        }
        public static void InsertRole(Role rls)
        {
            string sql4 = "INSERT INTO roles VALUES (NULL,@name)";
            MySqlConnection con = GetConnection();
            MySqlCommand cmdd1 = new MySqlCommand(sql4, con);
            cmdd1.Parameters.Add("@name", MySqlDbType.VarChar).Value = rls.Name;
            try
            {
                cmdd1.ExecuteNonQuery();
                MessageBox.Show("Добавление успешно!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Запись не добавлена.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }
        public static void UpdateRole(Role rls, string id)
        {
            string sql3 = "UPDATE roles SET name=@RoleName WHERE id=@RoleID";
            MySqlConnection con = GetConnection();
            MySqlCommand cmdd = new MySqlCommand(sql3, con);
            cmdd.Parameters.Add("@RoleName", MySqlDbType.VarChar).Value = rls.Name;
            cmdd.Parameters.Add("@RoleID", MySqlDbType.VarChar).Value = id;
            try
            {
                cmdd.ExecuteNonQuery();
                MessageBox.Show("Обновление успешно!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Запись не обновлена.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();

        }
        public static void DeleteRoles(string id)
        {
            string sqll2 = "DELETE FROM autocar.roles WHERE ID=@RoleID";
            MySqlConnection con = GetConnection();
            MySqlCommand cmdd = new MySqlCommand(sqll2, con);
            cmdd.CommandType = CommandType.Text;
            cmdd.Parameters.Add("@RoleID", MySqlDbType.VarChar).Value = id;
            try
            {
                cmdd.ExecuteNonQuery();
                MessageBox.Show("Удаление успешно!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Запись не удалена.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }
        public static void InsertUser(Useridu usr)
        {
            string sql4 = "INSERT INTO users VALUES (NULL,@last_name,@name,@patronymic,@adress,@mobile_phone,@password,@id_roles)";
            MySqlConnection con = GetConnection();
            MySqlCommand cmddu = new MySqlCommand(sql4, con);
            cmddu.Parameters.Add("@last_name", MySqlDbType.VarChar).Value = usr.Last_Name;
            cmddu.Parameters.Add("@name", MySqlDbType.VarChar).Value = usr.Name;
            cmddu.Parameters.Add("@patronymic", MySqlDbType.VarChar).Value = usr.Patronymic;
            cmddu.Parameters.Add("@adress", MySqlDbType.VarChar).Value = usr.Adress;
            cmddu.Parameters.Add("@mobile_phone", MySqlDbType.VarChar).Value = usr.Mobile_Phone;
            cmddu.Parameters.Add("@password", MySqlDbType.VarChar).Value = BCrypt.Net.BCrypt.HashPassword(usr.Password);
            cmddu.Parameters.Add("@id_roles", MySqlDbType.VarChar).Value = usr.Id_Roles;
            try
            {
                cmddu.ExecuteNonQuery();
                MessageBox.Show("Добавление успешно!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Запись не добавлена.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }
        public static void UpdateUser(Useridu usr, string id)
        {
            string sqlu = "UPDATE users SET last_name=@last_name,name=@name,patronymic=@patronymic,adress=@adress,mobile_phone=@mobile_phone,id_roles=@id_roles WHERE id=@UserID";
            MySqlConnection con = GetConnection();
            MySqlCommand cmdduu = new MySqlCommand(sqlu, con);
            cmdduu.Parameters.Add("@last_name", MySqlDbType.VarChar).Value = usr.Last_Name;
            cmdduu.Parameters.Add("@name", MySqlDbType.VarChar).Value = usr.Name;
            cmdduu.Parameters.Add("@patronymic", MySqlDbType.VarChar).Value = usr.Patronymic;
            cmdduu.Parameters.Add("@adress", MySqlDbType.VarChar).Value = usr.Adress;
            cmdduu.Parameters.Add("@mobile_phone", MySqlDbType.VarChar).Value = usr.Mobile_Phone;
            cmdduu.Parameters.Add("@id_roles", MySqlDbType.VarChar).Value = usr.Id_Roles;
            cmdduu.Parameters.Add("@UserID", MySqlDbType.VarChar).Value = id;
            try
            {
                cmdduu.ExecuteNonQuery();
                MessageBox.Show("Обновление успешно!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Запись не обновлена.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();

        }
        public static void DeleteUser(string id)
        {
            string sqlld = "DELETE FROM autocar.users WHERE ID=@UserID";
            MySqlConnection con = GetConnection();
            MySqlCommand cmdd = new MySqlCommand(sqlld, con);
            cmdd.CommandType = CommandType.Text;
            cmdd.Parameters.Add("@UserID", MySqlDbType.VarChar).Value = id;
            try
            {
                cmdd.ExecuteNonQuery();
                MessageBox.Show("Удаление успешно!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Запись не удалена.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }
        public static void InsertCar(Caridu car)
        {
            string sqlci = "INSERT INTO cars VALUES (NULL,@number,@brand,@model,@year_release,@id_types,@cost,@discription)";
            MySqlConnection con = GetConnection();
            MySqlCommand cmdc = new MySqlCommand(sqlci, con);
            cmdc.Parameters.Add("@number", MySqlDbType.VarChar).Value = car.Number;
            cmdc.Parameters.Add("@brand", MySqlDbType.VarChar).Value = car.Brand;
            cmdc.Parameters.Add("@model", MySqlDbType.VarChar).Value = car.Model;
            cmdc.Parameters.Add("@year_release", MySqlDbType.VarChar).Value = car.Year_release;
            cmdc.Parameters.Add("@id_types", MySqlDbType.VarChar).Value = car.Id_types;
            cmdc.Parameters.Add("@cost", MySqlDbType.VarChar).Value = car.Cost;
            cmdc.Parameters.Add("@discription", MySqlDbType.VarChar).Value = car.Discription;
            try
            {
                cmdc.ExecuteNonQuery();
                MessageBox.Show("Добавление успешно!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Запись не добавлена.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }
        public static void UpdateCar(Caridu car, string id)
        {
            string sqlcu = "UPDATE cars SET number=@number,brand=@brand,model=@model,year_release=@year_release,id_types=@id_types,cost=@cost,discription=@discription WHERE id=@CarID";
            MySqlConnection con = GetConnection();
            MySqlCommand cmdcu = new MySqlCommand(sqlcu, con);
            cmdcu.Parameters.Add("@number", MySqlDbType.VarChar).Value = car.Number;
            cmdcu.Parameters.Add("@brand", MySqlDbType.VarChar).Value = car.Brand;
            cmdcu.Parameters.Add("@model", MySqlDbType.VarChar).Value = car.Model;
            cmdcu.Parameters.Add("@year_release", MySqlDbType.VarChar).Value = car.Year_release;
            cmdcu.Parameters.Add("@id_types", MySqlDbType.VarChar).Value = car.Id_types;
            cmdcu.Parameters.Add("@cost", MySqlDbType.VarChar).Value = car.Cost;
            cmdcu.Parameters.Add("@discription", MySqlDbType.VarChar).Value = car.Discription;
            cmdcu.Parameters.Add("@CarID", MySqlDbType.VarChar).Value = id;
            try
            {
                cmdcu.ExecuteNonQuery();
                MessageBox.Show("Обновление успешно!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Запись не обновлена.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();

        }
        public static void DeleteCar(string id)
        {
            string sqllcd = "DELETE FROM autocar.cars WHERE ID=@CarID";
            MySqlConnection con = GetConnection();
            MySqlCommand cmdcd = new MySqlCommand(sqllcd, con);
            cmdcd.CommandType = CommandType.Text;
            cmdcd.Parameters.Add("@CarID", MySqlDbType.VarChar).Value = id;
            try
            {
                cmdcd.ExecuteNonQuery();
                MessageBox.Show("Удаление успешно!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Запись не удалена.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }
        public static void InsertHistsl(Histidu hst)
        {
            string sqlh = "INSERT INTO sold_cars VALUES (NULL,@id_users,@id_car,NULL,NULL)";
            MySqlConnection con = GetConnection();
            MySqlCommand cmdh = new MySqlCommand(sqlh, con);
            cmdh.Parameters.Add("@id_users", MySqlDbType.VarChar).Value = hst.Id_users;
            cmdh.Parameters.Add("@id_car", MySqlDbType.VarChar).Value = hst.Id_car;
            try
            {
                cmdh.ExecuteNonQuery();
                MessageBox.Show("Добавление успешно!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Запись не добавлена.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }
        public static void UpdateHistsl(Histidu hst, string id)
        {
            string sqlhu = "UPDATE sold_cars SET id_users=@id_users,id_car=@id_car,date_sale=@date_sale WHERE id=@HistID";
            MySqlConnection con = GetConnection();
            MySqlCommand cmdhu = new MySqlCommand(sqlhu, con);
            cmdhu.Parameters.Add("@id_users", MySqlDbType.VarChar).Value = hst.Id_users;
            cmdhu.Parameters.Add("@id_car", MySqlDbType.VarChar).Value = hst.Id_car;
            cmdhu.Parameters.Add("@date_sale", MySqlDbType.VarChar).Value = hst.Date_sale;
            cmdhu.Parameters.Add("@HistID", MySqlDbType.VarChar).Value = id;
            try
            {
                cmdhu.ExecuteNonQuery();
                MessageBox.Show("Обновление успешно!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Запись не обновлена.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();

        }
        public static void DeleteHistsl(string id)
        {
            string sqllhd = "DELETE FROM autocar.sold_cars WHERE ID=@HistID";
            MySqlConnection con = GetConnection();
            MySqlCommand cmdhd = new MySqlCommand(sqllhd, con);
            cmdhd.CommandType = CommandType.Text;
            cmdhd.Parameters.Add("@HistID", MySqlDbType.VarChar).Value = id;
            try
            {
                cmdhd.ExecuteNonQuery();
                MessageBox.Show("Удаление успешно!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Запись не удалена.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }
        public static void InsertPhoto(Photoidu pht)
        {
            string sqlp = "INSERT INTO photo_car VALUES (NULL,@way,@id_cars)";
            MySqlConnection con = GetConnection();
            MySqlCommand cmdp = new MySqlCommand(sqlp, con);
            cmdp.Parameters.Add("@way", MySqlDbType.VarChar).Value = pht.Way;
            cmdp.Parameters.Add("@id_cars", MySqlDbType.VarChar).Value = pht.Id_cars;
            try
            {
                cmdp.ExecuteNonQuery();
                MessageBox.Show("Добавление успешно!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Запись не добавлена.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }
        public static void UpdatePhoto(Photoidu pht, string id)
        {
            string sqlpd = "UPDATE photo_car SET way=@way,id_cars=@id_cars WHERE id=@PhotoID";
            MySqlConnection con = GetConnection();
            MySqlCommand cmdpu = new MySqlCommand(sqlpd, con);
            cmdpu.Parameters.Add("@way", MySqlDbType.VarChar).Value = pht.Way;
            cmdpu.Parameters.Add("@id_cars", MySqlDbType.VarChar).Value = pht.Id_cars;
            cmdpu.Parameters.Add("@PhotoID", MySqlDbType.VarChar).Value = id;
            try
            {
                cmdpu.ExecuteNonQuery();
                MessageBox.Show("Обновление успешно!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Запись не обновлена.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();

        }
        public static void DeletePhoto(string id)
        {
            string sqlpd = "DELETE FROM photo_car WHERE ID=@PhotoID";
            MySqlConnection con = GetConnection();
            MySqlCommand cmdpd = new MySqlCommand(sqlpd, con);
            cmdpd.CommandType = CommandType.Text;
            cmdpd.Parameters.Add("@PhotoID", MySqlDbType.VarChar).Value = id;
            try
            {
                cmdpd.ExecuteNonQuery();
                MessageBox.Show("Удаление успешно!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Запись не удалена.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }
        public static void InsertType(Typeidu tp)
        {
            string sqlt = "INSERT INTO types_car VALUES (NULL,@name_types)";
            MySqlConnection con = GetConnection();
            MySqlCommand cmdt = new MySqlCommand(sqlt, con);
            cmdt.Parameters.Add("@name_types", MySqlDbType.VarChar).Value = tp.Name_types;
            try
            {
                cmdt.ExecuteNonQuery();
                MessageBox.Show("Добавление успешно!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Запись не добавлена.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }
        public static void UpdateType(Typeidu tp, string id)
        {
            string sqltu = "UPDATE types_car SET name_types=@name_types WHERE id=@TypeID";
            MySqlConnection con = GetConnection();
            MySqlCommand cmdtu = new MySqlCommand(sqltu, con);
            cmdtu.Parameters.Add("@name_types", MySqlDbType.VarChar).Value = tp.Name_types;
            cmdtu.Parameters.Add("@TypeID", MySqlDbType.VarChar).Value = id;
            try
            {
                cmdtu.ExecuteNonQuery();
                MessageBox.Show("Обновление успешно!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Запись не обновлена.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();

        }
        public static void DeleteType(string id)
        {
            string sqltd = "DELETE FROM types_car WHERE ID=@TypeID";
            MySqlConnection con = GetConnection();
            MySqlCommand cmdtd = new MySqlCommand(sqltd, con);
            cmdtd.CommandType = CommandType.Text;
            cmdtd.Parameters.Add("@TypeID", MySqlDbType.VarChar).Value = id;
            try
            {
                cmdtd.ExecuteNonQuery();
                MessageBox.Show("Удаление успешно!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Запись не удалена.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }
    }
}
