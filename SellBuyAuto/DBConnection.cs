using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace SellBuyAuto
{
    class DBConnection
    {
        private MySqlConnection connection;

        public DBConnection()
        {
            InitConnexion();
        }

        private void InitConnexion()
        {
            // connection string creation : contact the DB server
            string connectionString = "SERVER=web24.swisscenter.com; PORT=3306; DATABASE=2024mca_auto; UID=2024mca_auto; PASSWORD=TPI2024_SellBuyAuto";
            connection = new MySqlConnection(connectionString);
        }

        public User GetLogin(string username)
        {
            MySqlDataReader rdr = null;
            // Open the SQL connection
            connection.Open();

            // SQL Command creation according to the connection object
            MySqlCommand cmd = this.connection.CreateCommand();

            // SQL request
            cmd.CommandText = "SELECT id, Email, Username, Password, Admin, Blocked FROM Users WHERE Email = @Username OR Username = @Username";

            // we set the value for our query, we use the parameter of the method, which is a Contact object
            cmd.Parameters.AddWithValue("@Username", username);

            // Execution of the SQL command
            rdr = cmd.ExecuteReader();

            rdr.Read();
            User user = new User(rdr.GetInt32(0), rdr.GetString(1), rdr.GetString(2), rdr.GetString(3), rdr.GetBoolean(4), rdr.GetBoolean(5));


            //we close the SQL connection
            if (connection != null)
            {
                connection.Close();
            }

            return user;
        }

        public int AddUser(User user)
        {
            // Open the SQL connection
            connection.Open();

            // SQL Command creation according to the connection object
            MySqlCommand cmd = connection.CreateCommand();

            cmd.CommandText = "INSERT INTO Users (Email, Username, Password, Admin, Blocked) VALUES (@Email, @Username, @Password, @Admin, @Blocked)";

            // we set the value for our query, we use the parameter of the method, which is a Contact object
            cmd.Parameters.AddWithValue("@Email", user.Email);
            cmd.Parameters.AddWithValue("@Username", user.Username);
            cmd.Parameters.AddWithValue("@Password", user.Password);
            cmd.Parameters.AddWithValue("@Admin", user.IsAdmin);
            cmd.Parameters.AddWithValue("@Blocked", user.IsBlocked);

            // SQL cmd execution
            cmd.ExecuteNonQuery();

            int idUser = (int)cmd.LastInsertedId;

            //we close the SQL connection
            if (connection != null)
            {
                connection.Close();
            }

            return idUser;
        }
    }
}
