using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace AdoNetConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // new Program().CreateTable();
            //new Program().InsertRecord();
            //new Program().DataReader1();
            new Program().DataAdpter1();
            Console.ReadKey();
        }
        public void CreateTable()
        {
            
            SqlConnection con = null;
            try
            {
                // Creating Connection  
                string connstring = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString;

                con = new SqlConnection(connstring);
                // writing sql query  
                SqlCommand cm = new SqlCommand("create table student(id int not null, name varchar(100), email varchar(50), join_date date)", con);

                // Opening Connection  
                con.Open();

                // Executing the SQL query  
                cm.ExecuteNonQuery();

                // Displaying a message  
                Console.WriteLine("Table created Successfully");
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong." + e);
            }
            // Closing the connection  
            finally
            {
                con.Close();
            }
        }
        public void InsertRecord()
        {
            SqlConnection con = null;
            try
            {
                // Creating Connection  
                string connstring = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString;

                con = new SqlConnection(connstring);                // writing sql query  
                SqlCommand cm = new SqlCommand("insert into student (id, name, email, join_date) values ('102', 'Messi', 'messi@example.com', '1/12/2023')", con);

                // Opening Connection  
                con.Open();
                // Executing the SQL query  
                cm.ExecuteNonQuery();
                // Displaying a message  
                Console.WriteLine("Record Inserted Successfully");
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong." + e);
            }
            // Closing the connection  
            finally
            {
                con.Close();
            }
        }
       
        public void DataReader1() {
            //SqlConnection con = null;
            try
                {
                string connstring = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString;

                //con = new SqlConnection(connstring);
                    using (SqlConnection connection = new SqlConnection(connstring))
                    {
                        // Creating SqlCommand objcet   
                        SqlCommand cm = new SqlCommand("select * from student", connection);

                        // Opening Connection  
                        connection.Open();

                    //ExecuteScalar
                    int TotalRows = (int)cm.ExecuteScalar();
                    Console.WriteLine("TotalRows in Student Table :  " + TotalRows);

                    //SqlDataReader
                    SqlDataReader sdr = cm.ExecuteReader();
                    
                        while (sdr.Read())
                        {
                            Console.WriteLine(sdr["Name"] + ",  " + sdr["Email"] + ",  " + sdr["join_date"]);

                    }
                }
                }
                catch (Exception e)
                {
                    Console.WriteLine("OOPs, something went wrong.\n" + e);
                }
                Console.ReadKey();
            }

       public void DataAdpter1() { 

                try
                {
                    string ConString = "Data Source=COGNINE-L35;Database=Jayanth; integrated security=True";
                    using (SqlConnection connection = new SqlConnection(ConString))
                    {

                        SqlDataAdapter da = new SqlDataAdapter("select * from student", connection);
                    //da.SelectCommand.CommandType = CommandType.StoredProcedure;

                    //DataTable dt = new DataTable();
                    //da.Fill(dt);
                    //foreach (DataColumn row in dt.Columns)
                    //{
                    //// Console.WriteLine(row["Name"] + ",  " + row["Email"] );
                    //Console.WriteLine(row);
                    //}
                    DataSet ds = new DataSet();
                    da.Fill(ds,"Table1");
                    DataTable dt=new DataSet().Tables["Table1"];
                        
                        //THis gives the column names of the table
                    //foreach (DataColumn column in dt.Columns)
                    //{
                    //    Console.WriteLine(column);
                    //}
                }
            }
                catch (Exception e)
                {
                    Console.WriteLine("OOPs, something went wrong.\n" + e);
                }

                Console.ReadKey();
            }
        public void Isert1()
        {
            string ConString = "Data Source=COGNINE-L35;Database=Jayanth; integrated security=True";
            using (SqlConnection connection = new SqlConnection(ConString))
            {

                SqlDataAdapter adapter = new SqlDataAdapter("select * from student", connection);
                SqlCommand command = new SqlCommand("SELECT CustomerID FROM Customers " +
        "WHERE Country = ? AND City = ?", connection);

                command.Parameters.Add("Country", SqlDbType.VarChar, 15);
                command.Parameters.Add("City", SqlDbType.VarChar, 15);

                adapter.SelectCommand = command;

                // Create the InsertCommand.
                command = new SqlCommand(
                    "INSERT INTO Customers (CustomerID, CompanyName) " +
                    "VALUES (?, ?)", connection);

                command.Parameters.Add(
                    "CustomerID", SqlDbType.Char, 5, "CustomerID");
                command.Parameters.Add(
                    "CompanyName", SqlDbType.VarChar, 40, "CompanyName");

                adapter.InsertCommand = command;
            }
        }
        }
    }