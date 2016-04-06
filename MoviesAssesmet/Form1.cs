using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace MoviesAssesmet
{
    public partial class Form1 : Form
    {

        Class1 myClass = new Class1();
        //create an instance of the database class
        Class1 mydatabase = new Class1();

        public Form1()
        {
            InitializeComponent();
            //DisplayDatagridViewMovies rented movies, customer
            loadDB();
            

        }

        public void loadDB()
        {
            //load the movie dvg
            DisplayDataGridViewMovies();
            //load customer dgv
            DisplayDataGridViewCustomer();
            //load rented movies
            DisplayDataGridViewRentedMovies();
            
          
        }

        private void DisplayDataGridViewMovies()
        {
            //clear old data before entering new data
            DGVMovies.DataSource = null;
            try
            {
                DGVMovies.DataSource = mydatabase.fillDVGMoviesWithMovies();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void DisplayDataGridViewCustomer()
        {
            //clear data
            DGVCustomer.DataSource = null;
            try
            {
                DGVCustomer.DataSource = mydatabase.FillDGVCustomerWithCustomer();
                //pass the database data to DGV
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
             
        }
        private void DisplayDataGridViewRentedMovies()
        {

            try
            {
                DGVRentedMovies.DataSource = mydatabase.FillDGVRentedMoviesWithRentedMovies();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }






        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            //hold the success or failiure result
            //only run if there is something inserted
            string result = null;

            if ((txtFirstName.Text != string.Empty) && (txtLastname.Text != string.Empty))
            {

                try
                {
                    result = mydatabase.InsertOrUpdateCustomer(txtFirstName.Text, txtLastname.Text, txtAddress.Text, txtPhoneNumber.Text, txtCustomerID.Text, "Add");
                    MessageBox.Show(txtFirstName.Text + " " + txtLastname.Text + " Updating " + result);
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);

                }

                //updating the DGV to see new entries
                DisplayDataGridViewCustomer();
                txtFirstName.Text = "";
                txtLastname.Text = "";
                txtAddress.Text  = "";
                txtPhoneNumber.Text = "";
            }
            else
            {
                MessageBox.Show("fiLL ALL  fields");
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //only run if there is something in the textboxes
            if((!object.ReferenceEquals(txtCustomerID.Text, string.Empty)) && 
                (!object.ReferenceEquals(txtFirstName.Text, string.Empty)) && 
                (!object.ReferenceEquals(txtLastname.Text, string.Empty))&&
                !object.ReferenceEquals(txtAddress.Text, string.Empty)&&
                !object.ReferenceEquals(txtPhoneNumber.Text, string.Empty))
            {

                string result = null;
                try
                {
                    result = mydatabase.InsertOrUpdateCustomer(txtCustomerID.Text, txtFirstName.Text, txtLastname.Text, txtAddress.Text, txtPhoneNumber.Text,  "Update");
                    MessageBox.Show(txtFirstName.Text + txtLastname.Text + txtAddress.Text + txtPhoneNumber.Text + "Updating" + result);
                    DisplayDataGridViewCustomer();
                    DGVCustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("owner Not Updated" + ex.Message);
                }
                DisplayDataGridViewCustomer();
                txtFirstName.Text = "";
                txtLastname.Text = "";
                txtAddress.Text = "";
                txtPhoneNumber.Text = "";

            }
            else
            {
                
            }

        }

        private void DGVCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string Firstname, Lastname, Phonenumber, Address, ID = null;
            try
            {
                ID = DGVCustomer.Rows[e.RowIndex].Cells[0].Value.ToString();
                 Firstname = DGVCustomer.Rows[e.RowIndex].Cells[1].Value.ToString();
                 Lastname = DGVCustomer.Rows[e.RowIndex].Cells[2].Value.ToString();
                 Phonenumber = DGVCustomer.Rows[e.RowIndex].Cells[4].Value.ToString();
                 Address = DGVCustomer.Rows[e.RowIndex].Cells[3].Value.ToString();
                if (e.RowIndex >0)
                {

                    //DGVCustomer.DataSource = mydatabase.FillDGVCustomerWithOwnerClick();
                    txtCustomerID.Text = ID;
                    txtFirstName.Text = Firstname;
                    txtLastname.Text = Lastname;
                    txtPhoneNumber.Text = Phonenumber;
                    txtAddress.Text = Address;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //hold the ID of the movie
            string InputID = String.Empty;
            string Result = null;
            string TableName = string.Empty;

            Button fakebutton = (Button)sender;

            try
            {
                switch (fakebutton.Name)
                {
                    case "btnDelete":
                        InputID = txtCustomerID.Text;
                        TableName = "Customer";
                        break;
                }

                //delete the customer and return back succes or failiure
                Result = mydatabase.DeleteCustomer(InputID, TableName);
                MessageBox.Show(fakebutton.Tag + "delete" + Result);

                DisplayDataGridViewCustomer();
                mydatabase.ClearAllTextBoxes(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show("please select customer" + ex.Message);
            }

        }

        private void btnAddMovie_Click(object sender, EventArgs e)
        {
            //hold the success or failiure result
            //only run if there is something inserted
            string result = null;

            if ((txtMovieName.Text != string.Empty) && (txtRating.Text != string.Empty) && (txtYear.Text != string.Empty) && (txtPlot.Text != string.Empty) && (txtGenre.Text != string.Empty))
            {

                try
                {
                    result = mydatabase.InsertOrUpdateMovie(txtMovieID.Text, txtRating.Text, txtMovieName.Text,  txtYear.Text, txtPlot.Text, txtGenre.Text, "Add");
                    MessageBox.Show(txtMovieID.Text + " " + txtRating.Text + " Updating " + result);
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);

                }

                //updating the DGV to see new entries
                DisplayDataGridViewMovies();
                txtMovieName.Text = "";
                txtYear.Text = "";
                txtPlot.Text = "";
                txtGenre.Text = "";
            }
            else
            {
                MessageBox.Show("fill All fields");
            }
        }

        private void btnUpdateMovie_Click(object sender, EventArgs e)
        {
            //only run if there is something in the textboxes
            if ((!object.ReferenceEquals(txtMovieID.Text, string.Empty)) &&
                (!object.ReferenceEquals(txtRating.Text, string.Empty)) &&
                (!object.ReferenceEquals(txtMovieName.Text, string.Empty)) &&
                !object.ReferenceEquals(txtYear.Text, string.Empty) &&
                !object.ReferenceEquals(txtPlot.Text, string.Empty) &&
                (!object.ReferenceEquals(txtGenre.Text, string.Empty)))
            {

                string result = null;
                try
                {
                    result = mydatabase.InsertOrUpdateMovie(txtMovieID.Text, txtRating.Text, txtMovieName.Text, txtYear.Text, txtPlot.Text, txtGenre.Text, "Update");
                    MessageBox.Show(txtMovieID.Text + txtRating.Text + txtMovieName.Text + txtYear.Text + "Updating" + result);
                    DisplayDataGridViewMovies();
                    DGVMovies.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("owner Not Updated" + ex.Message);
                }
                DisplayDataGridViewCustomer();
                txtMovieID.Text = "";
                txtRating.Text = "";
                txtYear.Text = "";
                txtPlot.Text = "";
                txtGenre.Text = "";


            }
            else
            {

            }
        }

        private void btnDeleteMovie_Click(object sender, EventArgs e)
        {
            //hold the ID of the movie
            string InpuID = String.Empty;
            string Result = null;
            string TableName = string.Empty;

            Button fakebutton = (Button)sender;

            try
            {
                switch (fakebutton.Name)
                {
                    case "btnDeleteMovie":
                        InpuID = txtMovieID.Text;
                        TableName = "Movies";
                        break;
                }

                //delete the customer and return back succes or failiure
                Result = mydatabase.DeleteMovie(InpuID, TableName);
                MessageBox.Show(fakebutton.Tag + "delete" + Result);

                DisplayDataGridViewMovies();
                mydatabase.ClearAllTextBoxes(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show("please select customer" + ex.Message);
            }
        }

        private void DGVMovies_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string MovieID, Rating, Title, Year, Plot, Genre = null;
            try
            {
                MovieID = DGVMovies.Rows[e.RowIndex].Cells[0].Value.ToString();
                Rating = DGVMovies.Rows[e.RowIndex].Cells[1].Value.ToString();
                Title = DGVMovies.Rows[e.RowIndex].Cells[2].Value.ToString();
                Year = DGVMovies.Rows[e.RowIndex].Cells[3].Value.ToString();
                Plot = DGVMovies.Rows[e.RowIndex].Cells[4].Value.ToString();
                Genre = DGVMovies.Rows[e.RowIndex].Cells[5].Value.ToString();


                if (e.RowIndex > 0)
                {

                    //DGVCustomer.DataSource = mydatabase.FillDGVCustomerWithOwnerClick();
                    txtMovieID.Text = MovieID;
                    txtRating.Text = Rating;
                    txtMovieName.Text = Title;
                    txtYear.Text = Year;
                    txtPlot.Text = Plot;
                    txtGenre.Text = Genre;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void btnIssueMovie_Click(object sender, EventArgs e)
        {

            string result = null;
            if ((txtFirstName.Text != string.Empty) && (txtLastname.Text != string.Empty))
            {
                try
                {
                    result = mydatabase.IssueMovie(txtMovieID.Text, txtCustomerID.Text, "Issue");
                    MessageBox.Show("Movie Succesfully issued");


                }
                catch (Exception ex)
                {


                    MessageBox.Show(ex.Message);
                }

                DisplayDataGridViewRentedMovies();
                txtCustomerID.Text = "";
                txtMovieID.Text = "";
            }
            else
            {
                MessageBox.Show("Enter Required Data");
            }

        }

        private void btnReturnMovie_Click(object sender, EventArgs e)
        {

        }
    }
}
