namespace MoviesAssesmet
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DGVRentedMovies = new System.Windows.Forms.DataGridView();
            this.TabContol = new System.Windows.Forms.TabControl();
            this.tabRented = new System.Windows.Forms.TabPage();
            this.tabMovies = new System.Windows.Forms.TabPage();
            this.DGVMovies = new System.Windows.Forms.DataGridView();
            this.tabCustomers = new System.Windows.Forms.TabPage();
            this.DGVCustomer = new System.Windows.Forms.DataGridView();
            this.btnAddMovie = new System.Windows.Forms.Button();
            this.txtMovieName = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtMovieID = new System.Windows.Forms.TextBox();
            this.txtPlot = new System.Windows.Forms.TextBox();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.txtRating = new System.Windows.Forms.TextBox();
            this.lblGenre = new System.Windows.Forms.Label();
            this.btnDeleteMovie = new System.Windows.Forms.Button();
            this.btnUpdateMovie = new System.Windows.Forms.Button();
            this.lbllplot = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblMovie = new System.Windows.Forms.Label();
            this.lblRating = new System.Windows.Forms.Label();
            this.MovID = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.lblCustID = new System.Windows.Forms.Label();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.lblFN = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblPh = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnIssueMovie = new System.Windows.Forms.Button();
            this.btnReturnMovie = new System.Windows.Forms.Button();
            this.lblMovCost = new System.Windows.Forms.Label();
            this.txt5 = new System.Windows.Forms.TextBox();
            this.txtcurrentyear = new System.Windows.Forms.TextBox();
            this.txtRentedMovieID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVRentedMovies)).BeginInit();
            this.TabContol.SuspendLayout();
            this.tabRented.SuspendLayout();
            this.tabMovies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMovies)).BeginInit();
            this.tabCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVRentedMovies
            // 
            this.DGVRentedMovies.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.DGVRentedMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVRentedMovies.DefaultCellStyle = dataGridViewCellStyle1;
            this.DGVRentedMovies.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.DGVRentedMovies.Location = new System.Drawing.Point(0, 0);
            this.DGVRentedMovies.Name = "DGVRentedMovies";
            this.DGVRentedMovies.Size = new System.Drawing.Size(364, 206);
            this.DGVRentedMovies.TabIndex = 0;
            this.DGVRentedMovies.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVRentedMovies_CellContentClick);
            // 
            // TabContol
            // 
            this.TabContol.Controls.Add(this.tabRented);
            this.TabContol.Controls.Add(this.tabMovies);
            this.TabContol.Controls.Add(this.tabCustomers);
            this.TabContol.Location = new System.Drawing.Point(12, 12);
            this.TabContol.Name = "TabContol";
            this.TabContol.SelectedIndex = 0;
            this.TabContol.Size = new System.Drawing.Size(375, 232);
            this.TabContol.TabIndex = 4;
            // 
            // tabRented
            // 
            this.tabRented.BackColor = System.Drawing.Color.Khaki;
            this.tabRented.Controls.Add(this.DGVRentedMovies);
            this.tabRented.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.tabRented.Location = new System.Drawing.Point(4, 22);
            this.tabRented.Name = "tabRented";
            this.tabRented.Padding = new System.Windows.Forms.Padding(3);
            this.tabRented.Size = new System.Drawing.Size(367, 206);
            this.tabRented.TabIndex = 0;
            this.tabRented.Text = "Rented";
            // 
            // tabMovies
            // 
            this.tabMovies.Controls.Add(this.DGVMovies);
            this.tabMovies.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.tabMovies.Location = new System.Drawing.Point(4, 22);
            this.tabMovies.Name = "tabMovies";
            this.tabMovies.Padding = new System.Windows.Forms.Padding(3);
            this.tabMovies.Size = new System.Drawing.Size(367, 206);
            this.tabMovies.TabIndex = 1;
            this.tabMovies.Text = "Movies";
            this.tabMovies.UseVisualStyleBackColor = true;
            // 
            // DGVMovies
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVMovies.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVMovies.Location = new System.Drawing.Point(1, 0);
            this.DGVMovies.Name = "DGVMovies";
            this.DGVMovies.Size = new System.Drawing.Size(364, 206);
            this.DGVMovies.TabIndex = 1;
            this.DGVMovies.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVMovies_CellContentClick);
            // 
            // tabCustomers
            // 
            this.tabCustomers.BackColor = System.Drawing.Color.Blue;
            this.tabCustomers.Controls.Add(this.DGVCustomer);
            this.tabCustomers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.tabCustomers.Location = new System.Drawing.Point(4, 22);
            this.tabCustomers.Name = "tabCustomers";
            this.tabCustomers.Padding = new System.Windows.Forms.Padding(3);
            this.tabCustomers.Size = new System.Drawing.Size(367, 206);
            this.tabCustomers.TabIndex = 2;
            this.tabCustomers.Text = "Customers";
            // 
            // DGVCustomer
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVCustomer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DGVCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVCustomer.Location = new System.Drawing.Point(1, 0);
            this.DGVCustomer.Name = "DGVCustomer";
            this.DGVCustomer.Size = new System.Drawing.Size(364, 206);
            this.DGVCustomer.TabIndex = 2;
            this.DGVCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVCustomer_CellContentClick);
            // 
            // btnAddMovie
            // 
            this.btnAddMovie.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAddMovie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnAddMovie.Location = new System.Drawing.Point(12, 373);
            this.btnAddMovie.Name = "btnAddMovie";
            this.btnAddMovie.Size = new System.Drawing.Size(103, 23);
            this.btnAddMovie.TabIndex = 9;
            this.btnAddMovie.Text = "Add Movie";
            this.btnAddMovie.UseVisualStyleBackColor = false;
            this.btnAddMovie.Click += new System.EventHandler(this.btnAddMovie_Click);
            // 
            // txtMovieName
            // 
            this.txtMovieName.BackColor = System.Drawing.Color.LightCyan;
            this.txtMovieName.Location = new System.Drawing.Point(203, 375);
            this.txtMovieName.Name = "txtMovieName";
            this.txtMovieName.Size = new System.Drawing.Size(206, 20);
            this.txtMovieName.TabIndex = 10;
            // 
            // txtYear
            // 
            this.txtYear.BackColor = System.Drawing.Color.LightCyan;
            this.txtYear.Location = new System.Drawing.Point(415, 375);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(100, 20);
            this.txtYear.TabIndex = 11;
            // 
            // txtMovieID
            // 
            this.txtMovieID.BackColor = System.Drawing.Color.LightCyan;
            this.txtMovieID.Location = new System.Drawing.Point(121, 375);
            this.txtMovieID.Name = "txtMovieID";
            this.txtMovieID.Size = new System.Drawing.Size(32, 20);
            this.txtMovieID.TabIndex = 13;
            // 
            // txtPlot
            // 
            this.txtPlot.BackColor = System.Drawing.Color.LightCyan;
            this.txtPlot.Location = new System.Drawing.Point(526, 375);
            this.txtPlot.Name = "txtPlot";
            this.txtPlot.Size = new System.Drawing.Size(206, 20);
            this.txtPlot.TabIndex = 15;
            // 
            // txtGenre
            // 
            this.txtGenre.BackColor = System.Drawing.Color.LightCyan;
            this.txtGenre.Location = new System.Drawing.Point(738, 376);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(100, 20);
            this.txtGenre.TabIndex = 16;
            // 
            // txtRating
            // 
            this.txtRating.BackColor = System.Drawing.Color.LightCyan;
            this.txtRating.Location = new System.Drawing.Point(159, 375);
            this.txtRating.Name = "txtRating";
            this.txtRating.Size = new System.Drawing.Size(32, 20);
            this.txtRating.TabIndex = 17;
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(735, 359);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(36, 13);
            this.lblGenre.TabIndex = 22;
            this.lblGenre.Text = "Genre";
            // 
            // btnDeleteMovie
            // 
            this.btnDeleteMovie.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnDeleteMovie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnDeleteMovie.Location = new System.Drawing.Point(12, 431);
            this.btnDeleteMovie.Name = "btnDeleteMovie";
            this.btnDeleteMovie.Size = new System.Drawing.Size(103, 23);
            this.btnDeleteMovie.TabIndex = 3;
            this.btnDeleteMovie.Text = "Delete Movie";
            this.btnDeleteMovie.UseVisualStyleBackColor = false;
            this.btnDeleteMovie.Click += new System.EventHandler(this.btnDeleteMovie_Click);
            // 
            // btnUpdateMovie
            // 
            this.btnUpdateMovie.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnUpdateMovie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnUpdateMovie.Location = new System.Drawing.Point(12, 402);
            this.btnUpdateMovie.Name = "btnUpdateMovie";
            this.btnUpdateMovie.Size = new System.Drawing.Size(103, 23);
            this.btnUpdateMovie.TabIndex = 4;
            this.btnUpdateMovie.Text = "Update Movie";
            this.btnUpdateMovie.UseVisualStyleBackColor = false;
            this.btnUpdateMovie.Click += new System.EventHandler(this.btnUpdateMovie_Click);
            // 
            // lbllplot
            // 
            this.lbllplot.AutoSize = true;
            this.lbllplot.Location = new System.Drawing.Point(526, 359);
            this.lbllplot.Name = "lbllplot";
            this.lbllplot.Size = new System.Drawing.Size(24, 13);
            this.lbllplot.TabIndex = 23;
            this.lbllplot.Text = "plot";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(412, 359);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(29, 13);
            this.lblYear.TabIndex = 26;
            this.lblYear.Text = "Year";
            // 
            // lblMovie
            // 
            this.lblMovie.AutoSize = true;
            this.lblMovie.Location = new System.Drawing.Point(206, 359);
            this.lblMovie.Name = "lblMovie";
            this.lblMovie.Size = new System.Drawing.Size(61, 13);
            this.lblMovie.TabIndex = 27;
            this.lblMovie.Text = "Movie Titile";
            // 
            // lblRating
            // 
            this.lblRating.AutoSize = true;
            this.lblRating.Location = new System.Drawing.Point(161, 359);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(38, 13);
            this.lblRating.TabIndex = 28;
            this.lblRating.Text = "Rating";
            // 
            // MovID
            // 
            this.MovID.AutoSize = true;
            this.MovID.Location = new System.Drawing.Point(121, 359);
            this.MovID.Name = "MovID";
            this.MovID.Size = new System.Drawing.Size(39, 13);
            this.MovID.TabIndex = 29;
            this.MovID.Text = "MovID";
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.Color.LightCyan;
            this.txtFirstName.Location = new System.Drawing.Point(163, 272);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 1;
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.BackColor = System.Drawing.Color.Lavender;
            this.btnAddCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnAddCustomer.Location = new System.Drawing.Point(12, 269);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(103, 23);
            this.btnAddCustomer.TabIndex = 2;
            this.btnAddCustomer.Text = "Add Customer";
            this.btnAddCustomer.UseVisualStyleBackColor = false;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // lblCustID
            // 
            this.lblCustID.AutoSize = true;
            this.lblCustID.Location = new System.Drawing.Point(118, 256);
            this.lblCustID.Name = "lblCustID";
            this.lblCustID.Size = new System.Drawing.Size(39, 13);
            this.lblCustID.TabIndex = 3;
            this.lblCustID.Text = "CustID";
            // 
            // txtLastname
            // 
            this.txtLastname.BackColor = System.Drawing.Color.LightCyan;
            this.txtLastname.Location = new System.Drawing.Point(269, 272);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(100, 20);
            this.txtLastname.TabIndex = 5;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.BackColor = System.Drawing.Color.LightCyan;
            this.txtPhoneNumber.Location = new System.Drawing.Point(375, 272);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(100, 20);
            this.txtPhoneNumber.TabIndex = 6;
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.LightCyan;
            this.txtAddress.Location = new System.Drawing.Point(481, 272);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(100, 20);
            this.txtAddress.TabIndex = 7;
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.BackColor = System.Drawing.Color.LightCyan;
            this.txtCustomerID.Location = new System.Drawing.Point(121, 272);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(32, 20);
            this.txtCustomerID.TabIndex = 8;
            // 
            // lblFN
            // 
            this.lblFN.AutoSize = true;
            this.lblFN.Location = new System.Drawing.Point(163, 256);
            this.lblFN.Name = "lblFN";
            this.lblFN.Size = new System.Drawing.Size(57, 13);
            this.lblFN.TabIndex = 18;
            this.lblFN.Text = "First Name";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(266, 256);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(51, 13);
            this.lblSurname.TabIndex = 19;
            this.lblSurname.Text = "SurName";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(478, 256);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(45, 13);
            this.lblAddress.TabIndex = 20;
            this.lblAddress.Text = "Address";
            // 
            // lblPh
            // 
            this.lblPh.AutoSize = true;
            this.lblPh.Location = new System.Drawing.Point(372, 256);
            this.lblPh.Name = "lblPh";
            this.lblPh.Size = new System.Drawing.Size(38, 13);
            this.lblPh.TabIndex = 21;
            this.lblPh.Text = "Phone";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Lavender;
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnUpdate.Location = new System.Drawing.Point(12, 298);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(104, 23);
            this.btnUpdate.TabIndex = 30;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Lavender;
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnDelete.Location = new System.Drawing.Point(12, 327);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(103, 23);
            this.btnDelete.TabIndex = 31;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnIssueMovie
            // 
            this.btnIssueMovie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnIssueMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIssueMovie.ForeColor = System.Drawing.Color.Blue;
            this.btnIssueMovie.Location = new System.Drawing.Point(12, 480);
            this.btnIssueMovie.Name = "btnIssueMovie";
            this.btnIssueMovie.Size = new System.Drawing.Size(75, 74);
            this.btnIssueMovie.TabIndex = 32;
            this.btnIssueMovie.Tag = "";
            this.btnIssueMovie.Text = "Issue \r\nMovie ";
            this.btnIssueMovie.UseVisualStyleBackColor = false;
            this.btnIssueMovie.Click += new System.EventHandler(this.btnIssueMovie_Click);
            // 
            // btnReturnMovie
            // 
            this.btnReturnMovie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnReturnMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnMovie.ForeColor = System.Drawing.Color.Red;
            this.btnReturnMovie.Location = new System.Drawing.Point(93, 480);
            this.btnReturnMovie.Name = "btnReturnMovie";
            this.btnReturnMovie.Size = new System.Drawing.Size(75, 74);
            this.btnReturnMovie.TabIndex = 33;
            this.btnReturnMovie.Text = "Return Movie";
            this.btnReturnMovie.UseVisualStyleBackColor = false;
            this.btnReturnMovie.Click += new System.EventHandler(this.btnReturnMovie_Click);
            // 
            // lblMovCost
            // 
            this.lblMovCost.AutoSize = true;
            this.lblMovCost.Location = new System.Drawing.Point(736, 12);
            this.lblMovCost.Name = "lblMovCost";
            this.lblMovCost.Size = new System.Drawing.Size(62, 13);
            this.lblMovCost.TabIndex = 35;
            this.lblMovCost.Text = "Rental Cost";
            // 
            // txt5
            // 
            this.txt5.BackColor = System.Drawing.Color.LightCyan;
            this.txt5.Location = new System.Drawing.Point(710, 622);
            this.txt5.Name = "txt5";
            this.txt5.Size = new System.Drawing.Size(61, 20);
            this.txt5.TabIndex = 36;
            this.txt5.Text = "5";
            // 
            // txtcurrentyear
            // 
            this.txtcurrentyear.BackColor = System.Drawing.Color.LightCyan;
            this.txtcurrentyear.Location = new System.Drawing.Point(576, 620);
            this.txtcurrentyear.Name = "txtcurrentyear";
            this.txtcurrentyear.Size = new System.Drawing.Size(61, 20);
            this.txtcurrentyear.TabIndex = 39;
            this.txtcurrentyear.Text = "5";
            // 
            // txtRentedMovieID
            // 
            this.txtRentedMovieID.Location = new System.Drawing.Point(269, 314);
            this.txtRentedMovieID.Name = "txtRentedMovieID";
            this.txtRentedMovieID.Size = new System.Drawing.Size(100, 20);
            this.txtRentedMovieID.TabIndex = 40;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(861, 617);
            this.Controls.Add(this.txtRentedMovieID);
            this.Controls.Add(this.txtcurrentyear);
            this.Controls.Add(this.txt5);
            this.Controls.Add(this.lblMovCost);
            this.Controls.Add(this.btnReturnMovie);
            this.Controls.Add(this.btnIssueMovie);
            this.Controls.Add(this.btnDeleteMovie);
            this.Controls.Add(this.btnUpdateMovie);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.MovID);
            this.Controls.Add(this.lblRating);
            this.Controls.Add(this.lblMovie);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lbllplot);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.lblPh);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblFN);
            this.Controls.Add(this.txtRating);
            this.Controls.Add(this.txtGenre);
            this.Controls.Add(this.txtPlot);
            this.Controls.Add(this.txtMovieID);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtMovieName);
            this.Controls.Add(this.btnAddMovie);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtLastname);
            this.Controls.Add(this.TabContol);
            this.Controls.Add(this.lblCustID);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.txtFirstName);
            this.Name = "Form1";
            this.Text = "Movies";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVRentedMovies)).EndInit();
            this.TabContol.ResumeLayout(false);
            this.tabRented.ResumeLayout(false);
            this.tabMovies.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVMovies)).EndInit();
            this.tabCustomers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVRentedMovies;
        private System.Windows.Forms.TabControl TabContol;
        private System.Windows.Forms.TabPage tabRented;
        private System.Windows.Forms.TabPage tabMovies;
        private System.Windows.Forms.DataGridView DGVMovies;
        private System.Windows.Forms.TabPage tabCustomers;
        private System.Windows.Forms.DataGridView DGVCustomer;
        private System.Windows.Forms.Button btnAddMovie;
        private System.Windows.Forms.TextBox txtMovieName;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtMovieID;
        private System.Windows.Forms.TextBox txtPlot;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.TextBox txtRating;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Button btnDeleteMovie;
        private System.Windows.Forms.Button btnUpdateMovie;
        private System.Windows.Forms.Label lbllplot;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblMovie;
        private System.Windows.Forms.Label lblRating;
        private System.Windows.Forms.Label MovID;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Label lblCustID;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.Label lblFN;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblPh;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnIssueMovie;
        private System.Windows.Forms.Button btnReturnMovie;
        private System.Windows.Forms.Label lblMovCost;
        private System.Windows.Forms.TextBox txt5;
        private System.Windows.Forms.TextBox txtcurrentyear;
        private System.Windows.Forms.TextBox txtRentedMovieID;
    }
}

