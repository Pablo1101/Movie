using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MoviesAssesmet
{
    public class Class1
    {
        //Create a Data Adapter, Connection & SQL command.
        private SqlDataAdapter DA = new SqlDataAdapter();
        private SqlConnection Connection = new SqlConnection();
        private SqlCommand Command = new SqlCommand(); 


        public Class1()
        {
            ConnectToDB();


        }
        private void ConnectToDB()
        {
            //Set connection String to your own
            string connectionstring = @"Data Source=LAPTOP-IDFUQ2VT\SQLEXPRESS;Initial Catalog=VBMoviesFullData;Integrated Security=True";
            Connection.ConnectionString = connectionstring;
            Command.Connection = Connection;

        }

        public DataTable fillDVGMoviesWithMovies()
        {
            DataTable DT = new DataTable();
            using (DA = new SqlDataAdapter("Select MovieID, Rating, Title, Year, Plot, Genre from Movies ", Connection))
            {
                // connect to the DB and get the SQL
                Connection.Open();
                //fill the datatable from the Sql
                DA.Fill(DT);
                //close the connection
                Connection.Close();

                //pass the datatable to the DGV
                return DT;
            }


           
        }

        public DataTable FillDGVRentedMoviesWithRentedMovies()
        {
            DataTable dt = new DataTable();
            using (DA = new SqlDataAdapter("select * from CustomerAndMoviesRented", Connection))

          {
            // connect to the DB and get the SQL
            Connection.Open();
            //fill the datatable from the Sql
            DA.Fill(dt);
            //close the connection
            Connection.Close();

            //pass the datatable to the DGV
          
            return dt;

          }
            
           

        }

        public DataTable FillDGVCustomerWithCustomer()
        {
            DataTable Dt = new DataTable();
            using (DA = new SqlDataAdapter("select * from Customer", Connection))
            {
                // connect to the DB and get the SQL
                Connection.Open();
                //fill the datatable from the Sql
                DA.Fill(Dt);
                //close the connection
                Connection.Close();

            }return Dt;



        }

        public string InsertOrUpdateCustomer(string Firstname, string Lastname, string Address, string PhoneNumber, string ID, string AddOrUpdate)
        {
            try
            {
                if (AddOrUpdate == "Add")
                {
                    //create a command object  // create a query. create and open a connectin to the sql server
                    var mycommand = new SqlCommand("Insert INTO Customer (FirstName, Lastname, Address, Phone)" + "Values(@Firstname, @Lastname, @Address, @PhoneNumber)", Connection);
                    // create parameters
                    mycommand.Parameters.AddWithValue("Firstname", Firstname);
                    mycommand.Parameters.AddWithValue("Lastname", Lastname);
                    mycommand.Parameters.AddWithValue("Address", Address);
                    mycommand.Parameters.AddWithValue("PhoneNumber", PhoneNumber);

                    Connection.Open();
                    //open connection to the sql
                    mycommand.ExecuteNonQuery();
                    Connection.Close();


                }
                else if (AddOrUpdate == "Update")
                {   //prevent Sql injections
                    var myCommand = new SqlCommand("UPDATE Customer set FirstName = @FirstName, LastName = @LastName, Address = @Address, PhoneNumber = @PhoneNumber where CustID = @ID", Connection);
                    myCommand.Parameters.AddWithValue("Firstname", Firstname);
                    myCommand.Parameters.AddWithValue("Lastname", Lastname);
                    myCommand.Parameters.AddWithValue("Address", Address);
                    myCommand.Parameters.AddWithValue("PhoneNumber", PhoneNumber);
                    myCommand.Parameters.AddWithValue("ID", ID);
                    Connection.Open();
                    myCommand.ExecuteNonQuery();
                    Connection.Close();

                }
                return "  Is Successful"; 

            }

            catch (Exception e)
            {
                Connection.Close();
                return "Has Failed With  " + e;
            }


           
        }
             public string DeleteCustomer(string ID, String Table)
        {

            //only run if there is something in the txtbox
            if (!object.ReferenceEquals(ID, string.Empty))
            {
                var myCommand = new SqlCommand();
                switch (Table)
                {

                    case "Customer":
                        myCommand = new SqlCommand("DELETE FROM Customer WHERE CustID = @ID");
                        break;
                        
                }


                myCommand.Connection = Connection;
                //prevent sql injections
                myCommand.Parameters.AddWithValue("ID", ID);

                Connection.Open();
                myCommand.ExecuteNonQuery();
                Connection.Close();
                return "success";
            }

            else
            {

                Connection.Close(); ;
                return "Failed";
            }
        }

        public void ClearAllTextBoxes(Control root)
        {
            foreach (Control ctrl in root.Controls)
            {if(ctrl is TextBox)
                {
                    ((TextBox)ctrl).Text = string.Empty;

                }


            }
        }

        public string InsertOrUpdateMovie(string MovieID, string Rating, string Title, string Year, string Plot, string Genre, string InsertOrUpdateMovie)
        {
            try
            {
                if (InsertOrUpdateMovie == "Add")
                {
                    //create a command object  // create a query. create and open a connectin to the sql server
                    var mycommand = new SqlCommand("Insert INTO Movies (Rating, Title, Year, Plot, Genre)" + "Values(@Rating, @Title, @Year, @Plot, @Genre)", Connection);
                    // create parameters
                    mycommand.Parameters.AddWithValue("Rating", Rating);
                    mycommand.Parameters.AddWithValue("Title", Title);
                    mycommand.Parameters.AddWithValue("Year", Year);
                    mycommand.Parameters.AddWithValue("Genre", Genre);
                    mycommand.Parameters.AddWithValue("Plot", Plot);

                    Connection.Open();
                    //open connection to the sql
                    mycommand.ExecuteNonQuery();
                    Connection.Close();
                }
                else if (InsertOrUpdateMovie == "Update")
                {
                    var myCommand = new SqlCommand("UPDATE Movies set Rating = @Rating, Title = @Title, Year = @year, plot = @plot, genre = @Genre where MovieID = @ID ", Connection);
                    //use parameters to prevent SQL injections
                    myCommand.Parameters.AddWithValue("Rating", Rating);
                    myCommand.Parameters.AddWithValue("Title", Title);
                    myCommand.Parameters.AddWithValue("Year", Year);
                    myCommand.Parameters.AddWithValue("Genre", Genre);
                    myCommand.Parameters.AddWithValue("Plot", Plot);
                    myCommand.Parameters.AddWithValue("ID", MovieID);
                    Connection.Open();
                    // open connection add in the SQL
                    myCommand.ExecuteNonQuery();
                    Connection.Close();
                }

                return " is Successful";
            }
            catch (Exception e)
            {
                //need to get it to close a second time as it jumps the first connection.close when ExecuteNonQuery fails.
                Connection.Close();
                return " has Failed with " + e;
            }

        }

        public string DeleteMovie(string ID, String Table)
        {

            //only run if there is something in the txtbox
            if (!object.ReferenceEquals(ID, string.Empty))
            {
                var myCommand = new SqlCommand();
                switch (Table)
                {

                    case "Movies":
                        myCommand = new SqlCommand("DELETE FROM Movies WHERE MovieID = @ID");
                        break;

                }


                myCommand.Connection = Connection;
                //prevent sql injections
                myCommand.Parameters.AddWithValue("ID", ID);

                Connection.Open();
                myCommand.ExecuteNonQuery();
                Connection.Close();
                return "success";
            }

            else
            {

                Connection.Close(); ;
                return "Failed";
            }
        }

        //==================ISSUE MOVIE======================\\

        public string IssueMovie(string CustID, string MovID, string DateIssued)
        {



            //only run if textbox is used
            if (!object.ReferenceEquals(CustID, string.Empty) && (!object.ReferenceEquals(MovID, string.Empty)))
            {
                var myCommand = new SqlCommand("INSERT into RentedMovies (CustIDFK, MovieIDFK, DateRented)" + "Values( @CustID, @MovieID, @Today)", Connection);

            DateTime today = DateTime.Now;

                //prevent SQL Injections
                myCommand.Parameters.AddWithValue("CustID", CustID);
                myCommand.Parameters.AddWithValue("MovieID", MovID);
                myCommand.Parameters.AddWithValue("Today", today);


                //open connection to add SQL
                Connection.Open();
                myCommand.ExecuteNonQuery();
                Connection.Close();
                return " is Successful";

            }
            else
            {
                Connection.Close();
                return " Failed";
            }
            

        }


        public string ReturnMovie(string CustID, string MovID, string ID)
        {
                DateTime today = DateTime.Now;

            if (!object.ReferenceEquals(CustID, string.Empty) && (!object.ReferenceEquals(MovID, string.Empty)))
            {
                var myCommand = new SqlCommand("Update RentedMovies set MovieIDFK = @MovID, CustIDFK = @CustID, DateReturned = @today Where RMID = @ID ",Connection );
                //var myCommand = new SqlCommand("UPDATE Movies set Rating = @Rating, Title = @Title, Year = @year, plot = @plot, genre = @Genre where MovieID = @ID ", Connection);


                //prevent SQL Injections
                myCommand.Parameters.AddWithValue("today", today);
                myCommand.Parameters.AddWithValue("MovID", MovID);
                myCommand.Parameters.AddWithValue("CustID", CustID);
                myCommand.Parameters.AddWithValue("ID", ID);






                //open connection to add SQL
                Connection.Open();
                myCommand.ExecuteNonQuery();
                Connection.Close();
                return " is Successful";

            } 
            else
            {
                Connection.Close();
                return " Failed";
            }

        }

        public string Cost(String movieYear)
        {

            int yearNow = (Convert.ToInt32(DateTime.Now.Year));
            int yearsOld = (yearNow - (Convert.ToInt32(movieYear)));

            if (yearsOld <= 5)
            {
                return "$5";

            }
            else
            {
                return "$2";

            }
        }
    }
}


