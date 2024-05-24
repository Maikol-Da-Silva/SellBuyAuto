/*
 * file          : DBConnection.cs
 * brief         : This file contains the connection to the database
 * author        : Created by Maikol Correia Da Silva
 * creation Date : 07.05.2024
 * update Date   : 24.05.2024
*/

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

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

        // Méthode qui permet de récuprer le login
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

        // Méthode qui permet d'ajouter un utilisateur
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

        // Méthode qui permet de récupérer les marques
        public List<Brand> GetBrands()
        {
            MySqlDataReader rdr = null;
            List<Brand> brands = new List<Brand>();
            // Open the SQL connection
            connection.Open();

            // SQL Command creation according to the connection object
            MySqlCommand cmd = this.connection.CreateCommand();

            // SQL request
            cmd.CommandText = "SELECT id, Name FROM Brands ORDER BY Name Asc";

            // Execution of the SQL command
            rdr = cmd.ExecuteReader();

            rdr.Read();
            do
            {
                Brand brand = new Brand(rdr.GetInt32(0), rdr.GetString(1));
                brands.Add(brand);
            } while (rdr.Read());


                //we close the SQL connection
                if (connection != null)
            {
                connection.Close();
            }

            return brands;
        }

        // Méthode qui permet de récupérer les modèles
        public List<Model> GetModels()
        {
            MySqlDataReader rdr = null;
            List<Model> models = new List<Model>();
            // Open the SQL connection
            connection.Open();

            // SQL Command creation according to the connection object
            MySqlCommand cmd = this.connection.CreateCommand();

            // SQL request
            cmd.CommandText = "SELECT id, Name, brand_id FROM Models ORDER BY Name Asc";

            // Execution of the SQL command
            rdr = cmd.ExecuteReader();

            rdr.Read();
            do
            {
                Model model = new Model(rdr.GetInt32(2), rdr.GetInt32(0), rdr.GetString(1));
                models.Add(model);
            } while (rdr.Read());


            //we close the SQL connection
            if (connection != null)
            {
                connection.Close();
            }

            return models;
        }

        // Méthode qui permet de récupérer les types de motorisation
        public List<string> GetEngineTypes()
        {
            MySqlDataReader rdr = null;
            List<string> engineTypes = new List<string>();
            // Open the SQL connection
            connection.Open();

            // SQL Command creation according to the connection object
            MySqlCommand cmd = this.connection.CreateCommand();

            // SQL request
            cmd.CommandText = "SELECT Type FROM EngineTypes ORDER BY id Asc";

            // Execution of the SQL command
            rdr = cmd.ExecuteReader();

            rdr.Read();
            do
            {
                engineTypes.Add(rdr.GetString(0));
            } while (rdr.Read());


            //we close the SQL connection
            if (connection != null)
            {
                connection.Close();
            }

            return engineTypes;
        }

        // Méthode qui permet de récupérer les annonces
        public List<Notice> GetNotices(string endResquest)
        {
            MySqlDataReader rdr = null;
            List<Notice> notices = new List<Notice>();
            // Open the SQL connection
            connection.Open();

            // SQL Command creation according to the connection object
            MySqlCommand cmd = this.connection.CreateCommand();

            // SQL request
            cmd.CommandText = "SELECT Notices.id, Notices.PublicationDate, Notices.Price, Notices.seller_id, " +
                "Cars.id, Cars.`Year`, Cars.mileage, Cars.Description, " +
                "Models.Name, Brands.Name, EngineTypes.`Type` FROM Notices " +
                "INNER JOIN Cars ON Notices.car_id = Cars.id " +
                "INNER JOIN EngineTypes ON Cars.engineType_id = EngineTypes.id " +
                "INNER JOIN Models ON Cars.model_id = Models.id " +
                "INNER JOIN Brands ON Models.brand_id = Brands.id WHERE Active = 1 AND Blocked = 0 AND Notices.buyer_id is NULL AND" + endResquest;
            
            // Execution of the SQL command
            rdr = cmd.ExecuteReader();

            rdr.Read();
            do
            {
                Notice notice = new Notice(rdr.GetInt32(0), rdr.GetInt32(4), rdr.GetInt32(3), rdr.GetDateTime(1), rdr.GetInt32(2), rdr.GetString(9),
                                            rdr.GetString(8), rdr.GetInt32(5), rdr.GetInt32(6), rdr.GetString(7), rdr.GetString(10));
                notices.Add(notice);
            } while (rdr.Read());


            //we close the SQL connection
            if (connection != null)
            {
                connection.Close();
            }

            return notices;
        }

        // Méthode qui permet de récupérer le nom des images
        public string GetImages(int idCar)
        {
            MySqlDataReader rdr = null;
            string images;
            // Open the SQL connection
            connection.Open();

            // SQL Command creation according to the connection object
            MySqlCommand cmd = this.connection.CreateCommand();

            // SQL request
            cmd.CommandText = "SELECT Images FROM Cars WHERE Cars.id = @idCar";

            // we set the value for our query, we use the parameter of the method, which is a Contact object
            cmd.Parameters.AddWithValue("@idCar", idCar);

            // Execution of the SQL command
            rdr = cmd.ExecuteReader();

            rdr.Read();
            images = rdr.GetString(0);


            //we close the SQL connection
            if (connection != null)
            {
                connection.Close();
                connection.Dispose();
            }

            return images;
        }

        // Méthode qui permet de récuprer l'id de la table Brands ou Models
        public int GetId(string table, string name)
        {
            MySqlDataReader rdr = null;
            int id;
            // Open the SQL connection
            connection.Open();

            // SQL Command creation according to the connection object
            MySqlCommand cmd = this.connection.CreateCommand();

            // SQL request
            cmd.CommandText = $"SELECT id FROM {table} WHERE Name = @name";

            // we set the value for our query, we use the parameter of the method, which is a Contact object
            cmd.Parameters.AddWithValue("@name", name);

            // Execution of the SQL command
            rdr = cmd.ExecuteReader();

            rdr.Read();
            id = rdr.GetInt32(0);


            //we close the SQL connection
            if (connection != null)
            {
                connection.Close();
            }

            return id;
        }

        // Méthode qui permet d'ajouter une marque
        public int AddBrand(string name)
        {
            // Open the SQL connection
            connection.Open();

            // SQL Command creation according to the connection object
            MySqlCommand cmd = connection.CreateCommand();

            cmd.CommandText = "INSERT INTO Brands (Name) VALUES (@name)";

            // we set the value for our query, we use the parameter of the method, which is a Contact object
            cmd.Parameters.AddWithValue("@name", name);

            // SQL cmd execution
            cmd.ExecuteNonQuery();

            int id = (int)cmd.LastInsertedId;

            //we close the SQL connection
            if (connection != null)
            {
                connection.Close();
            }

            return id;
        }

        // Méthode qui permet d'ajouter un modèle
        public int AddModel(string name, int idBrand)
        {
            // Open the SQL connection
            connection.Open();            

            // SQL Command creation according to the connection object
            MySqlCommand cmd = connection.CreateCommand();

            cmd.CommandText = "INSERT INTO Models (Name, brand_id) VALUES (@name, @brand_id)";

            // we set the value for our query, we use the parameter of the method, which is a Contact object
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@brand_id", idBrand);

            // SQL cmd execution
            cmd.ExecuteNonQuery();

            int id = (int)cmd.LastInsertedId;

            //we close the SQL connection
            if (connection != null)
            {
                connection.Close();
            }

            return id;
        }

        // Méthode qui permet d'ajouter un véhicule
        public int AddCar(int year, int mileage, string description, int model_id, int engineType_id)
        {
            // Open the SQL connection
            connection.Open();

            // SQL Command creation according to the connection object
            MySqlCommand cmd = connection.CreateCommand();

            cmd.CommandText = "INSERT INTO Cars (Year, Mileage, Description, model_id, engineType_id) VALUES (@year, @mileage, @description, @model_id, @engineType_id)";

            // we set the value for our query, we use the parameter of the method, which is a Contact object
            cmd.Parameters.AddWithValue("@Year", year);
            cmd.Parameters.AddWithValue("@Mileage", mileage);
            cmd.Parameters.AddWithValue("@Description", description);
            cmd.Parameters.AddWithValue("@model_id", model_id);
            cmd.Parameters.AddWithValue("@engineType_id", engineType_id);

            // SQL cmd execution
            cmd.ExecuteNonQuery();

            int id = (int)cmd.LastInsertedId;

            //we close the SQL connection
            if (connection != null)
            {
                connection.Close();
            }

            return id;
        }

        // Méthode qui permet d'ajouter les images aux véhicules
        public void UpdateImages(string images, int carId)
        {
            // Open the SQL connection
            connection.Open();

            // SQL Command creation according to the connection object
            MySqlCommand cmd = connection.CreateCommand();

            cmd.CommandText = "Update Cars SET Images = @Images WHERE id = @CarId";

            // we set the value for our query, we use the parameter of the method, which is a Contact object
            cmd.Parameters.AddWithValue("@Images", images);
            cmd.Parameters.AddWithValue("@CarId", carId);

            // SQL cmd execution
            cmd.ExecuteNonQuery();

            //we close the SQL connection
            if (connection != null)
            {
                connection.Close();
            }
        }

        // Méthode qui permet d'ajouter une annonce
        public int AddNotice(string publicationDate, int price, int seller_id, int car_id)
        {
            // Open the SQL connection
            connection.Open();

            // SQL Command creation according to the connection object
            MySqlCommand cmd = connection.CreateCommand();

            cmd.CommandText = "INSERT INTO Notices (PublicationDate, Price, seller_id, car_id) VALUES (@publicationDate, @price, @seller_id, @car_id)";

            // we set the value for our query, we use the parameter of the method, which is a Contact object
            cmd.Parameters.AddWithValue("@PublicationDate", publicationDate);
            cmd.Parameters.AddWithValue("@Price", price);
            cmd.Parameters.AddWithValue("@seller_id", seller_id);
            cmd.Parameters.AddWithValue("@car_id", car_id);

            // SQL cmd execution
            cmd.ExecuteNonQuery();

            int id = (int)cmd.LastInsertedId;

            //we close the SQL connection
            if (connection != null)
            {
                connection.Close();
            }

            return id;
        }

        public void CloseConnection()
        {
            if (connection != null)
            {
                connection.Close();
            }
        }

        // Méthode qui permet de récupérer les annonces d'un vendeur
        public List<Notice> GetSells(int userId)
        {
            MySqlDataReader rdr = null;
            List<Notice> notices = new List<Notice>();
            // Open the SQL connection
            connection.Open();

            // SQL Command creation according to the connection object
            MySqlCommand cmd = this.connection.CreateCommand();

            // SQL request
            cmd.CommandText = "SELECT Notices.id, Notices.PublicationDate, Notices.BuyDate, Notices.Price, Notices.seller_id, Notices.buyer_id, Notices.Active, Notices.Blocked, " +
                "Cars.id, Cars.`Year`, Cars.mileage, Cars.Description, " +
                "Models.Name, Brands.Name, EngineTypes.`Type` FROM Notices " +
                "INNER JOIN Cars ON Notices.car_id = Cars.id " +
                "INNER JOIN EngineTypes ON Cars.engineType_id = EngineTypes.id " +
                "INNER JOIN Models ON Cars.model_id = Models.id " +
                "INNER JOIN Brands ON Models.brand_id = Brands.id WHERE Active = 1 AND Notices.seller_id = @userId";

            // we set the value for our query, we use the parameter of the method, which is a Contact object
            cmd.Parameters.AddWithValue("@userId", userId);

            // Execution of the SQL command
            rdr = cmd.ExecuteReader();

            rdr.Read();
            do
            {
                Notice notice;
                if (!rdr.IsDBNull(5))
                {
                    notice = new Notice(rdr.GetInt32(0), rdr.GetInt32(8), rdr.GetInt32(5), rdr.GetInt32(4), rdr.GetDateTime(1), rdr.GetDateTime(2), rdr.GetInt32(3),
                    rdr.GetBoolean(6), rdr.GetBoolean(7), rdr.GetString(13), rdr.GetString(12), rdr.GetInt32(9), rdr.GetInt32(10),
                    rdr.GetString(11), rdr.GetString(14));
                }
                else
                {
                    notice = new Notice(rdr.GetInt32(0), rdr.GetInt32(8), rdr.GetInt32(4), rdr.GetDateTime(1), rdr.GetInt32(3),
                    rdr.GetBoolean(6), rdr.GetBoolean(7), rdr.GetString(13), rdr.GetString(12), rdr.GetInt32(9), rdr.GetInt32(10),
                    rdr.GetString(11), rdr.GetString(14));
                }
                    
                notices.Add(notice);
            } while (rdr.Read());


            //we close the SQL connection
            if (connection != null)
            {
                connection.Close();
            }

            return notices;
        }

        // Méthode qui permet de modifier les annonces
        public void UpdateNotices(int carId, int price)
        {
            // Open the SQL connection
            connection.Open();

            // SQL Command creation according to the connection object
            MySqlCommand cmd = connection.CreateCommand();

            cmd.CommandText = "Update Notices SET Price = @Price WHERE car_id = @CarId";

            // we set the value for our query, we use the parameter of the method, which is a Contact object
            cmd.Parameters.AddWithValue("@Price", price);
            cmd.Parameters.AddWithValue("@CarId", carId);

            // SQL cmd execution
            cmd.ExecuteNonQuery();

            //we close the SQL connection
            if (connection != null)
            {
                connection.Close();
            }
        }

        // Méthode qui permet de modifier les véhicules
        public void UpdateCars(int carId, int year, int mileage, string description, int model_id, int engineType_id)
        {
            // Open the SQL connection
            connection.Open();

            // SQL Command creation according to the connection object
            MySqlCommand cmd = connection.CreateCommand();

            cmd.CommandText = "Update Cars SET Year = @Year, Mileage = @Mileage, Description = @Description, model_id = @model_id, engineType_id = @engineType_id WHERE id = @CarId";

            // we set the value for our query, we use the parameter of the method, which is a Contact object
            cmd.Parameters.AddWithValue("@Year", year);
            cmd.Parameters.AddWithValue("@Mileage", mileage);
            cmd.Parameters.AddWithValue("@Description", description);
            cmd.Parameters.AddWithValue("@model_id", model_id);
            cmd.Parameters.AddWithValue("@engineType_id", engineType_id);
            cmd.Parameters.AddWithValue("@CarId", carId);

            // SQL cmd execution
            cmd.ExecuteNonQuery();

            //we close the SQL connection
            if (connection != null)
            {
                connection.Close();
            }
        }

        // Méthode qui permet de récupérer les users qui ont mis une annonce en favoris
        public List<int> GetUsersBookMark(int noticeId)
        {
            MySqlDataReader rdr = null;
            List<int> users = new List<int>();
            // Open the SQL connection
            connection.Open();

            // SQL Command creation according to the connection object
            MySqlCommand cmd = this.connection.CreateCommand();

            // SQL request
            cmd.CommandText = "SELECT user_id FROM Users_Bookmark_Notice WHERE notice_id = @notice_id";

            // we set the value for our query, we use the parameter of the method, which is a Contact object
            cmd.Parameters.AddWithValue("@notice_id", noticeId);

            // Execution of the SQL command
            rdr = cmd.ExecuteReader();

            if (rdr.HasRows)
            {
                do
                {
                    rdr.Read();
                    users.Add(rdr.GetInt32(0));
                } while (rdr.Read());
            }
               


            //we close the SQL connection
            if (connection != null)
            {
                connection.Close();
            }

            return users;
        }

        // Méthode qui permet de supprimer les annonces
        public void DeleteNotices(int noticeId)
        {
            // Open the SQL connection
            connection.Open();

            // SQL Command creation according to the connection object
            MySqlCommand cmd = connection.CreateCommand();

            cmd.CommandText = "Update Notices SET Active = 0 WHERE id = @noticeId";

            // we set the value for our query, we use the parameter of the method, which is a Contact object
            cmd.Parameters.AddWithValue("@noticeId", noticeId);

            // SQL cmd execution
            cmd.ExecuteNonQuery();

            //we close the SQL connection
            if (connection != null)
            {
                connection.Close();
            }
        }

        // Méthode qui permet de récupérer les users qui ont mis une annonce en favoris
        public string GetMailFromUser(int sellerId)
        {
            MySqlDataReader rdr = null;
            // Open the SQL connection
            connection.Open();

            // SQL Command creation according to the connection object
            MySqlCommand cmd = this.connection.CreateCommand();

            // SQL request
            cmd.CommandText = "SELECT Email FROM Users WHERE id = @seller_id";

            // we set the value for our query, we use the parameter of the method, which is a Contact object
            cmd.Parameters.AddWithValue("@seller_id", sellerId);

            // Execution of the SQL command
            rdr = cmd.ExecuteReader();

            rdr.Read();

            string mail = rdr.GetString(0);


            //we close the SQL connection
            if (connection != null)
            {
                connection.Close();
            }

            return mail;
        }


        // Méthode qui permet de récuprer un utilisateur
        public User GetUser(string email)
        {
            MySqlDataReader rdr = null;
            // Open the SQL connection
            connection.Open();

            // SQL Command creation according to the connection object
            MySqlCommand cmd = this.connection.CreateCommand();

            // SQL request
            cmd.CommandText = "SELECT id, Email, Username, Blocked FROM Users WHERE Email = @email";

            // we set the value for our query, we use the parameter of the method, which is a Contact object
            cmd.Parameters.AddWithValue("@email", email);

            // Execution of the SQL command
            rdr = cmd.ExecuteReader();

            rdr.Read();
            User user = new User(rdr.GetInt32(0), rdr.GetString(1), rdr.GetString(2), rdr.GetBoolean(3));


            //we close the SQL connection
            if (connection != null)
            {
                connection.Close();
            }

            return user;
        }

        // Méthode qui permet de modifier la table Notices et ainsi rajouté un acheteur
        public void AddBuyerToNotices(int noticeId, string buyDate, int buyerId)
        {
            // Open the SQL connection
            connection.Open();

            // SQL Command creation according to the connection object
            MySqlCommand cmd = connection.CreateCommand();

            cmd.CommandText = "Update Notices SET BuyDate = @buyDate, buyer_id = @buyerId WHERE id = @noticeId";

            // we set the value for our query, we use the parameter of the method, which is a Contact object
            cmd.Parameters.AddWithValue("@buyDate", buyDate);
            cmd.Parameters.AddWithValue("@buyerId", buyerId);
            cmd.Parameters.AddWithValue("@noticeId", noticeId);

            // SQL cmd execution
            cmd.ExecuteNonQuery();

            //we close the SQL connection
            if (connection != null)
            {
                connection.Close();
            }
        }

        // Méthode qui permet de récupérer les annonces favorites d'un utilisateur
        public List<Notice> GetBookmarks(int userId)
        {
            MySqlDataReader rdr = null;
            List<Notice> notices = new List<Notice>();
            // Open the SQL connection
            connection.Open();

            // SQL Command creation according to the connection object
            MySqlCommand cmd = this.connection.CreateCommand();

            // SQL request
            cmd.CommandText = "SELECT Notices.id, Notices.PublicationDate, Notices.BuyDate, Notices.Price, Notices.seller_id, Notices.buyer_id, Notices.Active, Notices.Blocked, " +
                "Cars.id, Cars.`Year`, Cars.mileage, Cars.Description, " +
                "Models.Name, Brands.Name, EngineTypes.`Type` FROM Notices " +
                "INNER JOIN Cars ON Notices.car_id = Cars.id " +
                "INNER JOIN EngineTypes ON Cars.engineType_id = EngineTypes.id " +
                "INNER JOIN Models ON Cars.model_id = Models.id " +
                "INNER JOIN Brands ON Models.brand_id = Brands.id " +
                "INNER JOIN Users_Bookmark_Notice ON Notices.id = Users_Bookmark_Notice.notice_id " +
                "WHERE Notices.Active = 1 AND Users_Bookmark_Notice.user_id = @userId";

            // we set the value for our query, we use the parameter of the method, which is a Contact object
            cmd.Parameters.AddWithValue("@userId", userId);

            // Execution of the SQL command
            rdr = cmd.ExecuteReader();

            rdr.Read();
            do
            {
                Notice notice;
                if (!rdr.IsDBNull(5))
                {
                    notice = new Notice(rdr.GetInt32(0), rdr.GetInt32(8), rdr.GetInt32(5), rdr.GetInt32(4), rdr.GetDateTime(1), rdr.GetDateTime(2), rdr.GetInt32(3),
                    rdr.GetBoolean(6), rdr.GetBoolean(7), rdr.GetString(13), rdr.GetString(12), rdr.GetInt32(9), rdr.GetInt32(10),
                    rdr.GetString(11), rdr.GetString(14));
                }
                else
                {
                    notice = new Notice(rdr.GetInt32(0), rdr.GetInt32(8), rdr.GetInt32(4), rdr.GetDateTime(1), rdr.GetInt32(3),
                    rdr.GetBoolean(6), rdr.GetBoolean(7), rdr.GetString(13), rdr.GetString(12), rdr.GetInt32(9), rdr.GetInt32(10),
                    rdr.GetString(11), rdr.GetString(14));
                }

                notices.Add(notice);
            } while (rdr.Read());


            //we close the SQL connection
            if (connection != null)
            {
                connection.Close();
            }

            return notices;
        }

        // Méthode qui permet de supprimer un favoris
        public void DeleteBookmark(int noticeId, int userId)
        {
            // Open the SQL connection
            connection.Open();

            // SQL Command creation according to the connection object
            MySqlCommand cmd = connection.CreateCommand();

            cmd.CommandText = "DELETE FROM Users_Bookmark_Notice WHERE notice_id = @noticeId AND user_id = @userId";

            // we set the value for our query, we use the parameter of the method, which is a Contact object
            cmd.Parameters.AddWithValue("@noticeId", noticeId);
            cmd.Parameters.AddWithValue("@userId", userId);

            // SQL cmd execution
            cmd.ExecuteNonQuery();

            //we close the SQL connection
            if (connection != null)
            {
                connection.Close();
            }
        }

        // Méthode qui permet d'ajouter des favoris
        public void AddBookmark(int noticeId, int userId)
        {
            // Open the SQL connection
            connection.Open();

            // SQL Command creation according to the connection object
            MySqlCommand cmd = connection.CreateCommand();

            cmd.CommandText = "INSERT INTO Users_Bookmark_Notice (user_id, notice_id) VALUES (@userId, @noticeId)";

            // we set the value for our query, we use the parameter of the method, which is a Contact object
            cmd.Parameters.AddWithValue("@userId", userId);
            cmd.Parameters.AddWithValue("@noticeId", noticeId);

            // SQL cmd execution
            cmd.ExecuteNonQuery();

            //we close the SQL connection
            if (connection != null)
            {
                connection.Close();
            }
        }

        // Méthode qui permet de récupérer les véhicules achetés d'un acheteur
        public List<Notice> GetPurchases(int userId)
        {
            MySqlDataReader rdr = null;
            List<Notice> notices = new List<Notice>();
            // Open the SQL connection
            connection.Open();

            // SQL Command creation according to the connection object
            MySqlCommand cmd = this.connection.CreateCommand();

            // SQL request
            cmd.CommandText = "SELECT Notices.id, Notices.PublicationDate, Notices.BuyDate, Notices.Price, Notices.seller_id, Notices.buyer_id, Notices.Active, Notices.Blocked, " +
                "Cars.id, Cars.`Year`, Cars.mileage, Cars.Description, " +
                "Models.Name, Brands.Name, EngineTypes.`Type` FROM Notices " +
                "INNER JOIN Cars ON Notices.car_id = Cars.id " +
                "INNER JOIN EngineTypes ON Cars.engineType_id = EngineTypes.id " +
                "INNER JOIN Models ON Cars.model_id = Models.id " +
                "INNER JOIN Brands ON Models.brand_id = Brands.id WHERE Active = 1 AND Notices.buyer_id = @userId";

            // we set the value for our query, we use the parameter of the method, which is a Contact object
            cmd.Parameters.AddWithValue("@userId", userId);

            // Execution of the SQL command
            rdr = cmd.ExecuteReader();

            rdr.Read();
            do
            {
                Notice notice;
                if (!rdr.IsDBNull(5))
                {
                    notice = new Notice(rdr.GetInt32(0), rdr.GetInt32(8), rdr.GetInt32(5), rdr.GetInt32(4), rdr.GetDateTime(1), rdr.GetDateTime(2), rdr.GetInt32(3),
                    rdr.GetBoolean(6), rdr.GetBoolean(7), rdr.GetString(13), rdr.GetString(12), rdr.GetInt32(9), rdr.GetInt32(10),
                    rdr.GetString(11), rdr.GetString(14));
                }
                else
                {
                    notice = new Notice(rdr.GetInt32(0), rdr.GetInt32(8), rdr.GetInt32(4), rdr.GetDateTime(1), rdr.GetInt32(3),
                    rdr.GetBoolean(6), rdr.GetBoolean(7), rdr.GetString(13), rdr.GetString(12), rdr.GetInt32(9), rdr.GetInt32(10),
                    rdr.GetString(11), rdr.GetString(14));
                }

                notices.Add(notice);
            } while (rdr.Read());


            //we close the SQL connection
            if (connection != null)
            {
                connection.Close();
            }

            return notices;
        }

        // Méthode qui permet de bloquer une annonce
        public void BlockNotice(int noticeId)
        {
            // Open the SQL connection
            connection.Open();

            // SQL Command creation according to the connection object
            MySqlCommand cmd = connection.CreateCommand();

            cmd.CommandText = "Update Notices SET Blocked = 1 WHERE id = @noticeId";

            // we set the value for our query, we use the parameter of the method, which is a Contact object
            cmd.Parameters.AddWithValue("@noticeId", noticeId);

            // SQL cmd execution
            cmd.ExecuteNonQuery();

            //we close the SQL connection
            if (connection != null)
            {
                connection.Close();
            }
        }

        // Méthode qui permet de récuprer un utilisateur
        public User GetUserFromId(int userId)
        {
            MySqlDataReader rdr = null;
            // Open the SQL connection
            connection.Open();

            // SQL Command creation according to the connection object
            MySqlCommand cmd = this.connection.CreateCommand();

            // SQL request
            cmd.CommandText = "SELECT id, Email, Username, Blocked FROM Users WHERE id = @userId";

            // we set the value for our query, we use the parameter of the method, which is a Contact object
            cmd.Parameters.AddWithValue("@userId", userId);

            // Execution of the SQL command
            rdr = cmd.ExecuteReader();

            rdr.Read();
            User user = new User(rdr.GetInt32(0), rdr.GetString(1), rdr.GetString(2), rdr.GetBoolean(3));


            //we close the SQL connection
            if (connection != null)
            {
                connection.Close();
            }

            return user;
        }

        // Méthode qui permet de bloquer une annonce
        public void BlockUser(int userId)
        {
            // Open the SQL connection
            connection.Open();

            // SQL Command creation according to the connection object
            MySqlCommand cmd = connection.CreateCommand();

            cmd.CommandText = "Update Users SET Blocked = 1 WHERE id = @userId";

            // we set the value for our query, we use the parameter of the method, which is a Contact object
            cmd.Parameters.AddWithValue("@userId", userId);

            // SQL cmd execution
            cmd.ExecuteNonQuery();

            //we close the SQL connection
            if (connection != null)
            {
                connection.Close();
            }
        }
    }
}
