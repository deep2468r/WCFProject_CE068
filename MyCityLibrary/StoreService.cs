using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace MyCityLibrary
{
    public class StoreService : IStoreService
    {

        DataSet IStoreService.GetStores()
        {

            SqlDataAdapter da = new SqlDataAdapter("SELECT StoreID,Name,Description,Rating,Category FROM Stores",
                @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=mycity;Integrated Security=True;
                Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;
                MultiSubnetFailover=False");

            DataSet ds = new DataSet();

            da.Fill(ds, "Stores");

            return ds;
        }

        public Store GetStoreByID( string ID )
        {
            SqlConnection cnn = new SqlConnection(
                @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=mycity;Integrated Security=True;
                Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;
                MultiSubnetFailover=False");

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandText = "SELECT StoreID,Name,Description,Rating,Category FROM Stores WHERE StoreID = @StoreID";

            int StoreID = int.Parse(ID);

            SqlParameter p = new SqlParameter("@StoreID", StoreID);
            cmd.Parameters.Add(p);

            cnn.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            Store store = new Store();

            while( reader.Read() )
            {
                store.StoreID = reader.GetInt32(0);
                store.Name = reader.GetString(1);
                store.Description = reader.GetString(2);
                store.Rating = reader.GetString(3);
                store.Category = reader.GetString(4);
            }

            reader.Close();
            cnn.Close();

            return store;
        }

        public DataSet GetStoresByName( string Name )
        {

            string cmd = "SELECT StoreID,Name,Description,Rating,Category FROM Stores WHERE Name = '" + Name + "'";

            SqlDataAdapter da = new SqlDataAdapter(cmd,
                @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=mycity;Integrated Security=True;
                Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;
                MultiSubnetFailover=False");

            DataSet ds = new DataSet();

            da.Fill(ds, "Stores");

            return ds;
        }

        public DataSet GetStoresByCategory( string Category )
        {
            string cmd;

            if( Category == "All" )
            {
                cmd = "SELECT StoreID,Name,Description,Rating,Category FROM Stores";
            }
            else
            {
                cmd = "SELECT StoreID,Name,Description,Rating,Category FROM Stores WHERE Category = '" + Category + "'";
            }


            SqlDataAdapter da = new SqlDataAdapter(cmd,
                @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=mycity;Integrated Security=True;
                Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;
                MultiSubnetFailover=False");

            DataSet ds = new DataSet();

            da.Fill(ds, "Stores");

            return ds;
        }
    }

    public class UserService : IUserService
    {

        public User GetUser( string UserID )
        {
            SqlConnection cnn = new SqlConnection(
                @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=mycity;Integrated Security=True;
                Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;
                MultiSubnetFailover=False");

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandText = "SELECT UserID,Password FROM Users WHERE UserID = @UserID";

            SqlParameter p = new SqlParameter("@UserID", UserID);
            cmd.Parameters.Add(p);

            cnn.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            User user = new User();

            while( reader.Read() )
            {
                user.UserID = reader.GetString(0);
                user.Password = reader.GetString(1);
            }

            reader.Close();
            cnn.Close();

            return user;

        }

        public void AddUser( User user )
        {
            SqlConnection cnn = new SqlConnection(
                @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=mycity;Integrated Security=True;
                Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;
                MultiSubnetFailover=False");

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandText = @"INSERT INTO Users (UserID,Password) VALUES (@UserID,@Password)";

            cmd.Parameters.AddWithValue("@UserID", user.UserID);
            cmd.Parameters.AddWithValue("@Password", user.Password);

            cnn.Open();

            cmd.ExecuteNonQuery();

            cnn.Close();

        }

    }
}
