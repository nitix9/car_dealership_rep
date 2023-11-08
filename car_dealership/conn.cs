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
        public static void UpdateRole(Role rls,string id)
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
                MessageBox.Show("Удаление успешно!" , "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

    }
}
