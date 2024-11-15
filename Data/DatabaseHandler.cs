using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using RestaurantSystem.Models;


namespace RestaurantSystem.Data
{
    internal class DatabaseHandler
    {
        //Connection for the Database
        private readonly string _connectionString = "Server=localhost\\SQLEXPRESS;Database=RestaurantDB;Trusted_Connection=True;";

        public List<MenuItem> GetMenuItems()
        {
            var menuItems = new List<MenuItem>();
            string query = "SELECT * FROM MenuItems";

            using (var connection = new SqlConnection(_connectionString))
            using (var command = new SqlCommand(query, connection))
            {
                connection.Open();
                using (var reader = command.ExecuteReader()) 
                {
                    while (reader.Read())
                    {
                        menuItems.Add(new MenuItem
                        {
                            ItemID = Convert.ToInt32(reader["ItemID"]),
                            Name = reader["Name"].ToString(),
                            ShortDescription = reader["SDescription"].ToString(),
                            Price = Convert.ToDecimal(reader["Price"]),
                            Category = reader["Category"].ToString(),
                            Image = reader["Image"] as byte[],
                            LongDescription = reader["LDescription"].ToString(),
                        });  
                    }
                }
            }

            return menuItems;
        }

        public List<MenuItem> GetMenuItemById(int itemID)
        {
            var menuItems = new List<MenuItem>();
            string query = "SELECT * FROM Item WHERE ItemID = @ItemID";

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ItemID", itemID);
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            menuItems.Add(new MenuItem
                            {
                                ItemID = Convert.ToInt32(reader["ItemID"]),
                                Name = reader["Name"].ToString(),
                                ShortDescription = reader["SDescription"].ToString(),
                                Price = Convert.ToDecimal(reader["Price"]),
                                Category = reader["Category"].ToString(),
                                Image = reader["Image"] as byte[],
                                LongDescription = reader["LDescription"].ToString(),
                            });
                        }
                    }
                }
            }
            return menuItems;
        }

    }
}
