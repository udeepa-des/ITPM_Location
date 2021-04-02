using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITPM_Location.LocationClasses
{
    class SQL
    {
        //Getters and setters Properties
        //Acts as a Data carrier 
        public int ID { get; set; }
        public string BName { get; set; }
        public string RName { get; set; }
        public string RType { get; set; }
        public string Capacity { get; set; }

        //StatChart Table
        //public int Lab { get; set; }
        //public int Lec { get; set; }


        static string myconnstring = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        //Selecting data from DB
        public DataTable Select()
        {
            //Step 1: DB connection
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {
                //Step 2: Writing sql query
                string sql = "SELECT * FROM Add_Location";
                //Creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Creating SQL DataAdapter using cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }catch(Exception e)
            {

            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        //Inserting Data into DB
        public bool Insert (SQL c)
        {
            //Creating a default return type and setting its value to false
            bool isSuccess = false;

            //STEP 1: Connect DB
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                //Step 2: Create a Sql query to insert data
                string sql = "INSERT INTO Add_Location(BuildingName, RoomName, RoomType, Capacity) VALUES (@BuildingName, @RoomName, @RoomType, @Capacity)";

                //Creating SQL commandusing sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Create Parameter to add data
                cmd.Parameters.AddWithValue("@BuildingName", c.BName);
                cmd.Parameters.AddWithValue("@RoomName", c.RName);
                cmd.Parameters.AddWithValue("@RoomType", c.RType);
                cmd.Parameters.AddWithValue("@Capacity", c.Capacity);

                //Open the connection
                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                //if the query runs successfully then the value of rows will be greater than 0 else its value will be 0
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch(Exception e)
            {

            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }

        //Method to update data in DB from our application
        public bool Update(SQL c)
        {
            //create a default return type and set its default value to false
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                //sql to update data in DB
                string sql = "UPDATE Add_Location SET BuildingName=@BuildingName, RoomName=@RoomName, RoomType=@RoomType, Capacity=@Capacity WHERE ID=@ID";
                SqlCommand cmd = new SqlCommand(sql, conn);
                //create parameters to add value
                cmd.Parameters.AddWithValue("@BuildingName", c.BName);
                cmd.Parameters.AddWithValue("@RoomName", c.RName);
                cmd.Parameters.AddWithValue("@RoomType", c.RType);
                cmd.Parameters.AddWithValue("@Capacity", c.Capacity);
                cmd.Parameters.AddWithValue("@ID", c.ID);

                //open DB connection
                conn.Open();

                int rows = cmd.ExecuteNonQuery();
                //if the query runs successfully then the value of rows will be greater than 0 else its value will be 0
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch(Exception e)
            {

            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }

        //method to delete data from DB
        public bool Delete(SQL c)
        {
            //create a default return value and set its value to false
            bool isSuccess = false;

            //create SQL connection
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                //sql query to delete data
                string sql = "DELETE FROM Add_Location WHERE ID=@ID";

                //creating SQL command
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ID", c.ID);

                //open connection
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                //if the query run successfully then the value of rows is greater than 0 else its value is 0
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch(Exception e)
            {

            }
            finally
            {
                //close the connection
                conn.Close();
            }
            return isSuccess;
        }

        public DataTable LabForChart()
        {
            //Step 1: DB connection
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {
                //Step 2: Writing sql query
                string sql = "SELECT * FROM LabForStat";
                //Creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Creating SQL DataAdapter using cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception e)
            {

            }
            finally
            {
                conn.Close();
            }

            
            return dt;
        }
        public DataTable LecHallForChart()
        {
            //Step 1: DB connection
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {
                //Step 2: Writing sql query
                string sql = "SELECT * FROM LecHallForStat";
                //Creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Creating SQL DataAdapter using cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception e)
            {

            }
            finally
            {
                conn.Close();
            }


            return dt;
        }

        public bool InsertToLabTable(SQL c)
        {
            //create a default return type and set its default value to false
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                //sql to update data in DB
                string sql = "INSERT INTO LabForStat SELECT COUNT(ID) FROM Add_Location WHERE RoomType LIKE 'La%'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                
                //open DB connection
                conn.Open();

                int rows = cmd.ExecuteNonQuery();
                //if the query runs successfully then the value of rows will be greater than 0 else its value will be 0
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception e)
            {

            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }

        public bool InsertToLecTable(SQL c)
        {
            //create a default return type and set its default value to false
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                //sql to update data in DB
                string sql = "INSERT INTO LecHallForStat SELECT COUNT(ID) FROM Add_Location WHERE RoomType LIKE 'Le%'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                
                //open DB connection
                conn.Open();

                int rows = cmd.ExecuteNonQuery();
                //if the query runs successfully then the value of rows will be greater than 0 else its value will be 0
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception e)
            {

            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }

        public int GetNoOfRows()
        {
            //Step 1: DB connection
            SqlConnection conn = new SqlConnection(myconnstring);
            String sqlText = "SELECT COUNT(ID) FROM Add_Location";

            // Create the connection and the command.
            SqlCommand cmd = new SqlCommand(sqlText, conn);
            conn.Open();
            // Execute the scalar SQL statement and store results.
            int count = Convert.ToInt32(cmd.ExecuteScalar());

            conn.Close();

            return count;
        }

        public int GetNoOfRowsOfLab()
        {
            //Step 1: DB connection
            SqlConnection conn = new SqlConnection(myconnstring);
            String sqlText = "SELECT COUNT(Numbers) FROM LabForStat";

            // Create the connection and the command.
            SqlCommand cmd = new SqlCommand(sqlText, conn);
            conn.Open();
            // Execute the scalar SQL statement and store results.
            int count = Convert.ToInt32(cmd.ExecuteScalar());

            conn.Close();

            return count;
        }
        public int GetNoOfRowsofLecHall()
        {
            //Step 1: DB connection
            SqlConnection conn = new SqlConnection(myconnstring);
            String sqlText = "SELECT COUNT(No) FROM LecHallForStat";

            // Create the connection and the command.
            SqlCommand cmd = new SqlCommand(sqlText, conn);
            conn.Open();
            // Execute the scalar SQL statement and store results.
            int count = Convert.ToInt32(cmd.ExecuteScalar());

            conn.Close();

            return count;
        }

    }
}
