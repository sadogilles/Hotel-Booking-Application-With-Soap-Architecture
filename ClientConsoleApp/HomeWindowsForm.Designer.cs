namespace ClientConsoleApp
{
    partial class HomeWindowsForm
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
            this.components = new System.ComponentModel.Container();
            this.submitClientInformation = new System.Windows.Forms.Button();
            this.clientCardInformationTextBox = new System.Windows.Forms.TextBox();
            this.clientCardInformationLabel = new System.Windows.Forms.Label();
            this.clientFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.clientLastNameTextBox = new System.Windows.Forms.TextBox();
            this.clientLastNameLabel = new System.Windows.Forms.Label();
            this.clientFirstNameLabel = new System.Windows.Forms.Label();
            this.ClientInformationLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.submitButton = new System.Windows.Forms.Button();
            this.tableHotelInformation = new System.Windows.Forms.TableLayoutPanel();
            this.townLabel = new System.Windows.Forms.Label();
            this.arrivalDateLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.minimumPriceLabel = new System.Windows.Forms.Label();
            this.maximumPriceLabel = new System.Windows.Forms.Label();
            this.ArrivalDateTextBox = new System.Windows.Forms.TextBox();
            this.depatureDateTextBox = new System.Windows.Forms.TextBox();
            this.minimumPriceTextBox = new System.Windows.Forms.TextBox();
            this.maximumPriceTextBox = new System.Windows.Forms.TextBox();
            this.numberOfPersonToHostLabel = new System.Windows.Forms.Label();
            this.numberOfStarsTextBox = new System.Windows.Forms.TextBox();
            this.numberOfPersonToHostTextBox = new System.Windows.Forms.TextBox();
            this.townTextBox = new System.Windows.Forms.TextBox();
            this.numberOfStarsLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listHotelGrid = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.town = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberOfStars = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceRange = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberOfBed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chooseHotel = new System.Windows.Forms.DataGridViewButtonColumn();
            this.findHotelButton = new System.Windows.Forms.Button();
            this.listHotelButton = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.roomDataGridView = new System.Windows.Forms.DataGridView();
            this.roomId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomNumberOfBed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomCapacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomChoose = new System.Windows.Forms.DataGridViewButtonColumn();
            this.notification = new System.Windows.Forms.Label();
            this.g = new System.Windows.Forms.GroupBox();
            this.ClientInformationLayoutPanel.SuspendLayout();
            this.tableHotelInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listHotelGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomDataGridView)).BeginInit();
            this.g.SuspendLayout();
            this.SuspendLayout();
            // 
            // submitClientInformation
            // 
            this.submitClientInformation.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.submitClientInformation.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.submitClientInformation.Location = new System.Drawing.Point(742, 159);
            this.submitClientInformation.Name = "submitClientInformation";
            this.submitClientInformation.Size = new System.Drawing.Size(75, 40);
            this.submitClientInformation.TabIndex = 7;
            this.submitClientInformation.Text = "Submit";
            this.submitClientInformation.UseVisualStyleBackColor = false;
            this.submitClientInformation.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // clientCardInformationTextBox
            // 
            this.clientCardInformationTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clientCardInformationTextBox.Location = new System.Drawing.Point(742, 107);
            this.clientCardInformationTextBox.Name = "clientCardInformationTextBox";
            this.clientCardInformationTextBox.Size = new System.Drawing.Size(733, 26);
            this.clientCardInformationTextBox.TabIndex = 6;
            // 
            // clientCardInformationLabel
            // 
            this.clientCardInformationLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.clientCardInformationLabel.AutoSize = true;
            this.clientCardInformationLabel.Location = new System.Drawing.Point(600, 120);
            this.clientCardInformationLabel.Name = "clientCardInformationLabel";
            this.clientCardInformationLabel.Size = new System.Drawing.Size(136, 20);
            this.clientCardInformationLabel.TabIndex = 5;
            this.clientCardInformationLabel.Text = "Card Information :";
            // 
            // clientFirstNameTextBox
            // 
            this.clientFirstNameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clientFirstNameTextBox.Location = new System.Drawing.Point(742, 3);
            this.clientFirstNameTextBox.Name = "clientFirstNameTextBox";
            this.clientFirstNameTextBox.Size = new System.Drawing.Size(733, 26);
            this.clientFirstNameTextBox.TabIndex = 4;
            this.clientFirstNameTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // clientLastNameTextBox
            // 
            this.clientLastNameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clientLastNameTextBox.Location = new System.Drawing.Point(742, 55);
            this.clientLastNameTextBox.Name = "clientLastNameTextBox";
            this.clientLastNameTextBox.Size = new System.Drawing.Size(733, 26);
            this.clientLastNameTextBox.TabIndex = 3;
            // 
            // clientLastNameLabel
            // 
            this.clientLastNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.clientLastNameLabel.AutoSize = true;
            this.clientLastNameLabel.Location = new System.Drawing.Point(642, 68);
            this.clientLastNameLabel.Name = "clientLastNameLabel";
            this.clientLastNameLabel.Size = new System.Drawing.Size(94, 20);
            this.clientLastNameLabel.TabIndex = 2;
            this.clientLastNameLabel.Text = "Last Name :";
            this.clientLastNameLabel.Click += new System.EventHandler(this.clientLastName_Click);
            // 
            // clientFirstNameLabel
            // 
            this.clientFirstNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.clientFirstNameLabel.AutoSize = true;
            this.clientFirstNameLabel.Location = new System.Drawing.Point(642, 16);
            this.clientFirstNameLabel.Name = "clientFirstNameLabel";
            this.clientFirstNameLabel.Size = new System.Drawing.Size(94, 20);
            this.clientFirstNameLabel.TabIndex = 0;
            this.clientFirstNameLabel.Text = "First Name :";
            this.clientFirstNameLabel.Click += new System.EventHandler(this.clientFirstName_Click);
            // 
            // ClientInformationLayoutPanel
            // 
            this.ClientInformationLayoutPanel.ColumnCount = 2;
            this.ClientInformationLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ClientInformationLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ClientInformationLayoutPanel.Controls.Add(this.clientFirstNameLabel, 0, 0);
            this.ClientInformationLayoutPanel.Controls.Add(this.clientLastNameLabel, 0, 1);
            this.ClientInformationLayoutPanel.Controls.Add(this.clientLastNameTextBox, 1, 1);
            this.ClientInformationLayoutPanel.Controls.Add(this.clientFirstNameTextBox, 1, 0);
            this.ClientInformationLayoutPanel.Controls.Add(this.clientCardInformationLabel, 0, 2);
            this.ClientInformationLayoutPanel.Controls.Add(this.clientCardInformationTextBox, 1, 2);
            this.ClientInformationLayoutPanel.Controls.Add(this.submitClientInformation, 1, 3);
            this.ClientInformationLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ClientInformationLayoutPanel.Location = new System.Drawing.Point(3, 22);
            this.ClientInformationLayoutPanel.Name = "ClientInformationLayoutPanel";
            this.ClientInformationLayoutPanel.RowCount = 4;
            this.ClientInformationLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ClientInformationLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ClientInformationLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ClientInformationLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ClientInformationLayoutPanel.Size = new System.Drawing.Size(1478, 211);
            this.ClientInformationLayoutPanel.TabIndex = 10;
            this.ClientInformationLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ClientInformationLayoutPanel_Paint);
            // 
            // submitButton
            // 
            this.submitButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.submitButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.submitButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.submitButton.Location = new System.Drawing.Point(694, 311);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(686, 38);
            this.submitButton.TabIndex = 18;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // tableHotelInformation
            // 
            this.tableHotelInformation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableHotelInformation.ColumnCount = 2;
            this.tableHotelInformation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableHotelInformation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableHotelInformation.Controls.Add(this.townLabel, 0, 0);
            this.tableHotelInformation.Controls.Add(this.arrivalDateLabel, 0, 1);
            this.tableHotelInformation.Controls.Add(this.label5, 0, 2);
            this.tableHotelInformation.Controls.Add(this.minimumPriceLabel, 0, 3);
            this.tableHotelInformation.Controls.Add(this.maximumPriceLabel, 0, 4);
            this.tableHotelInformation.Controls.Add(this.ArrivalDateTextBox, 1, 1);
            this.tableHotelInformation.Controls.Add(this.depatureDateTextBox, 1, 2);
            this.tableHotelInformation.Controls.Add(this.minimumPriceTextBox, 1, 3);
            this.tableHotelInformation.Controls.Add(this.maximumPriceTextBox, 1, 4);
            this.tableHotelInformation.Controls.Add(this.numberOfPersonToHostLabel, 0, 6);
            this.tableHotelInformation.Controls.Add(this.numberOfStarsTextBox, 1, 5);
            this.tableHotelInformation.Controls.Add(this.numberOfPersonToHostTextBox, 1, 6);
            this.tableHotelInformation.Controls.Add(this.submitButton, 1, 7);
            this.tableHotelInformation.Controls.Add(this.townTextBox, 1, 0);
            this.tableHotelInformation.Controls.Add(this.numberOfStarsLabel, 0, 5);
            this.tableHotelInformation.Location = new System.Drawing.Point(31, 25);
            this.tableHotelInformation.Name = "tableHotelInformation";
            this.tableHotelInformation.RowCount = 8;
            this.tableHotelInformation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableHotelInformation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableHotelInformation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableHotelInformation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableHotelInformation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableHotelInformation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableHotelInformation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableHotelInformation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableHotelInformation.Size = new System.Drawing.Size(1383, 352);
            this.tableHotelInformation.TabIndex = 6;
            this.tableHotelInformation.Paint += new System.Windows.Forms.PaintEventHandler(this.tableHotelInformation_Paint);
            // 
            // townLabel
            // 
            this.townLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.townLabel.AutoSize = true;
            this.townLabel.Location = new System.Drawing.Point(633, 12);
            this.townLabel.Name = "townLabel";
            this.townLabel.Size = new System.Drawing.Size(55, 20);
            this.townLabel.TabIndex = 0;
            this.townLabel.Text = "Town :";
            // 
            // arrivalDateLabel
            // 
            this.arrivalDateLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.arrivalDateLabel.AutoSize = true;
            this.arrivalDateLabel.Location = new System.Drawing.Point(589, 56);
            this.arrivalDateLabel.Name = "arrivalDateLabel";
            this.arrivalDateLabel.Size = new System.Drawing.Size(99, 20);
            this.arrivalDateLabel.TabIndex = 2;
            this.arrivalDateLabel.Text = "Arrival Date :";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(565, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Depature Date :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // minimumPriceLabel
            // 
            this.minimumPriceLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.minimumPriceLabel.AutoSize = true;
            this.minimumPriceLabel.Location = new System.Drawing.Point(577, 144);
            this.minimumPriceLabel.Name = "minimumPriceLabel";
            this.minimumPriceLabel.Size = new System.Drawing.Size(111, 20);
            this.minimumPriceLabel.TabIndex = 6;
            this.minimumPriceLabel.Text = "Minimum Price";
            this.minimumPriceLabel.Click += new System.EventHandler(this.minimumPriceLabel_Click);
            // 
            // maximumPriceLabel
            // 
            this.maximumPriceLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.maximumPriceLabel.AutoSize = true;
            this.maximumPriceLabel.Location = new System.Drawing.Point(573, 188);
            this.maximumPriceLabel.Name = "maximumPriceLabel";
            this.maximumPriceLabel.Size = new System.Drawing.Size(115, 20);
            this.maximumPriceLabel.TabIndex = 8;
            this.maximumPriceLabel.Text = "Maximum Price";
            // 
            // ArrivalDateTextBox
            // 
            this.ArrivalDateTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ArrivalDateTextBox.Location = new System.Drawing.Point(694, 53);
            this.ArrivalDateTextBox.Name = "ArrivalDateTextBox";
            this.ArrivalDateTextBox.Size = new System.Drawing.Size(686, 26);
            this.ArrivalDateTextBox.TabIndex = 10;
            // 
            // depatureDateTextBox
            // 
            this.depatureDateTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.depatureDateTextBox.Location = new System.Drawing.Point(694, 97);
            this.depatureDateTextBox.Name = "depatureDateTextBox";
            this.depatureDateTextBox.Size = new System.Drawing.Size(686, 26);
            this.depatureDateTextBox.TabIndex = 11;
            // 
            // minimumPriceTextBox
            // 
            this.minimumPriceTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.minimumPriceTextBox.Location = new System.Drawing.Point(694, 141);
            this.minimumPriceTextBox.Name = "minimumPriceTextBox";
            this.minimumPriceTextBox.Size = new System.Drawing.Size(686, 26);
            this.minimumPriceTextBox.TabIndex = 12;
            // 
            // maximumPriceTextBox
            // 
            this.maximumPriceTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.maximumPriceTextBox.Location = new System.Drawing.Point(694, 185);
            this.maximumPriceTextBox.Name = "maximumPriceTextBox";
            this.maximumPriceTextBox.Size = new System.Drawing.Size(686, 26);
            this.maximumPriceTextBox.TabIndex = 13;
            // 
            // numberOfPersonToHostLabel
            // 
            this.numberOfPersonToHostLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.numberOfPersonToHostLabel.AutoSize = true;
            this.numberOfPersonToHostLabel.Location = new System.Drawing.Point(483, 276);
            this.numberOfPersonToHostLabel.Name = "numberOfPersonToHostLabel";
            this.numberOfPersonToHostLabel.Size = new System.Drawing.Size(205, 20);
            this.numberOfPersonToHostLabel.TabIndex = 15;
            this.numberOfPersonToHostLabel.Text = "Number of Person To Host :";
            this.numberOfPersonToHostLabel.Click += new System.EventHandler(this.numberOfPersonToHostLabel_Click);
            // 
            // numberOfStarsTextBox
            // 
            this.numberOfStarsTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numberOfStarsTextBox.Location = new System.Drawing.Point(694, 223);
            this.numberOfStarsTextBox.Name = "numberOfStarsTextBox";
            this.numberOfStarsTextBox.Size = new System.Drawing.Size(686, 26);
            this.numberOfStarsTextBox.TabIndex = 16;
            // 
            // numberOfPersonToHostTextBox
            // 
            this.numberOfPersonToHostTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numberOfPersonToHostTextBox.Location = new System.Drawing.Point(694, 267);
            this.numberOfPersonToHostTextBox.Name = "numberOfPersonToHostTextBox";
            this.numberOfPersonToHostTextBox.Size = new System.Drawing.Size(686, 26);
            this.numberOfPersonToHostTextBox.TabIndex = 17;
            // 
            // townTextBox
            // 
            this.townTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.townTextBox.Location = new System.Drawing.Point(694, 9);
            this.townTextBox.Name = "townTextBox";
            this.townTextBox.Size = new System.Drawing.Size(686, 26);
            this.townTextBox.TabIndex = 9;
            this.townTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // numberOfStarsLabel
            // 
            this.numberOfStarsLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.numberOfStarsLabel.AutoSize = true;
            this.numberOfStarsLabel.Location = new System.Drawing.Point(552, 232);
            this.numberOfStarsLabel.Name = "numberOfStarsLabel";
            this.numberOfStarsLabel.Size = new System.Drawing.Size(136, 20);
            this.numberOfStarsLabel.TabIndex = 14;
            this.numberOfStarsLabel.Text = "Number Of Stars :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(469, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 3;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // listHotelGrid
            // 
            this.listHotelGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listHotelGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listHotelGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.address,
            this.town,
            this.country,
            this.numberOfStars,
            this.priceRange,
            this.numberOfBed,
            this.phoneNumber,
            this.chooseHotel});
            this.listHotelGrid.Location = new System.Drawing.Point(31, 17);
            this.listHotelGrid.Name = "listHotelGrid";
            this.listHotelGrid.RowTemplate.Height = 28;
            this.listHotelGrid.Size = new System.Drawing.Size(1431, 435);
            this.listHotelGrid.TabIndex = 5;
            this.listHotelGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listHotelGrid_CellContentClick);
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            // 
            // address
            // 
            this.address.HeaderText = "Address";
            this.address.Name = "address";
            this.address.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // town
            // 
            this.town.HeaderText = "Town";
            this.town.Name = "town";
            // 
            // country
            // 
            this.country.HeaderText = "Country";
            this.country.Name = "country";
            // 
            // numberOfStars
            // 
            this.numberOfStars.HeaderText = "Number Of Stars";
            this.numberOfStars.Name = "numberOfStars";
            // 
            // priceRange
            // 
            this.priceRange.HeaderText = "Price Range";
            this.priceRange.Name = "priceRange";
            // 
            // numberOfBed
            // 
            this.numberOfBed.HeaderText = "Number Of Bed";
            this.numberOfBed.Name = "numberOfBed";
            // 
            // phoneNumber
            // 
            this.phoneNumber.HeaderText = "Phone Number";
            this.phoneNumber.Name = "phoneNumber";
            // 
            // chooseHotel
            // 
            this.chooseHotel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.chooseHotel.HeaderText = "Choose Hotel";
            this.chooseHotel.Name = "chooseHotel";
            this.chooseHotel.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.chooseHotel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.chooseHotel.Text = "Choose";
            this.chooseHotel.ToolTipText = "Choose an Hotel";
            this.chooseHotel.UseColumnTextForButtonValue = true;
            // 
            // findHotelButton
            // 
            this.findHotelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.findHotelButton.Location = new System.Drawing.Point(773, 134);
            this.findHotelButton.Name = "findHotelButton";
            this.findHotelButton.Size = new System.Drawing.Size(616, 50);
            this.findHotelButton.TabIndex = 4;
            this.findHotelButton.Text = "Find An Hotel";
            this.findHotelButton.UseVisualStyleBackColor = true;
            this.findHotelButton.Click += new System.EventHandler(this.findHotelButton_Click);
            // 
            // listHotelButton
            // 
            this.listHotelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listHotelButton.Location = new System.Drawing.Point(31, 137);
            this.listHotelButton.Name = "listHotelButton";
            this.listHotelButton.Size = new System.Drawing.Size(593, 47);
            this.listHotelButton.TabIndex = 3;
            this.listHotelButton.Text = "Find All Hotels";
            this.listHotelButton.UseVisualStyleBackColor = true;
            this.listHotelButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // title
            // 
            this.title.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.title.Location = new System.Drawing.Point(557, 35);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(307, 36);
            this.title.TabIndex = 2;
            this.title.Text = "Hotel Booking System";
            this.title.Click += new System.EventHandler(this.title_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listHotelButton);
            this.groupBox1.Controls.Add(this.findHotelButton);
            this.groupBox1.Controls.Add(this.title);
            this.groupBox1.Location = new System.Drawing.Point(33, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1441, 256);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listHotelGrid);
            this.groupBox2.Controls.Add(this.ClientInformationLayoutPanel);
            this.groupBox2.Controls.Add(this.roomDataGridView);
            this.groupBox2.Controls.Add(this.tableHotelInformation);
            this.groupBox2.Location = new System.Drawing.Point(12, 355);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1484, 452);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // roomDataGridView
            // 
            this.roomDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.roomDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.roomId,
            this.roomPrice,
            this.roomNumberOfBed,
            this.roomCapacity,
            this.roomStatus,
            this.roomChoose});
            this.roomDataGridView.Location = new System.Drawing.Point(31, 66);
            this.roomDataGridView.Name = "roomDataGridView";
            this.roomDataGridView.RowTemplate.Height = 28;
            this.roomDataGridView.Size = new System.Drawing.Size(1109, 245);
            this.roomDataGridView.TabIndex = 11;
            this.roomDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.roomDataGridView_CellContentClick);
            // 
            // roomId
            // 
            this.roomId.HeaderText = "Room ID";
            this.roomId.Name = "roomId";
            // 
            // roomPrice
            // 
            this.roomPrice.HeaderText = "Price";
            this.roomPrice.Name = "roomPrice";
            // 
            // roomNumberOfBed
            // 
            this.roomNumberOfBed.HeaderText = "Number Of Bed";
            this.roomNumberOfBed.Name = "roomNumberOfBed";
            // 
            // roomCapacity
            // 
            this.roomCapacity.HeaderText = "Type of Bed";
            this.roomCapacity.Name = "roomCapacity";
            // 
            // roomStatus
            // 
            this.roomStatus.HeaderText = "Status";
            this.roomStatus.Name = "roomStatus";
            // 
            // roomChoose
            // 
            this.roomChoose.HeaderText = "Choose Room";
            this.roomChoose.Name = "roomChoose";
            this.roomChoose.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.roomChoose.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.roomChoose.Text = "Choose ";
            this.roomChoose.ToolTipText = "Choose a room";
            this.roomChoose.UseColumnTextForButtonValue = true;
            // 
            // notification
            // 
            this.notification.AutoSize = true;
            this.notification.Location = new System.Drawing.Point(6, 22);
            this.notification.Name = "notification";
            this.notification.Size = new System.Drawing.Size(127, 20);
            this.notification.TabIndex = 0;
            this.notification.Text = "Notification Here";
            // 
            // g
            // 
            this.g.Controls.Add(this.notification);
            this.g.Location = new System.Drawing.Point(964, 310);
            this.g.Name = "g";
            this.g.Size = new System.Drawing.Size(239, 57);
            this.g.TabIndex = 12;
            this.g.TabStop = false;
            // 
            // HomeWindowsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1529, 857);
            this.Controls.Add(this.g);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Name = "HomeWindowsForm";
            this.Text = "HomeWindowsForm";
            this.Load += new System.EventHandler(this.HomeWindowsForm_Load);
            this.ClientInformationLayoutPanel.ResumeLayout(false);
            this.ClientInformationLayoutPanel.PerformLayout();
            this.tableHotelInformation.ResumeLayout(false);
            this.tableHotelInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listHotelGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.roomDataGridView)).EndInit();
            this.g.ResumeLayout(false);
            this.g.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submitClientInformation;
        private System.Windows.Forms.TextBox clientCardInformationTextBox;
        private System.Windows.Forms.Label clientCardInformationLabel;
        private System.Windows.Forms.TextBox clientFirstNameTextBox;
        private System.Windows.Forms.TextBox clientLastNameTextBox;
        private System.Windows.Forms.Label clientLastNameLabel;
        private System.Windows.Forms.Label clientFirstNameLabel;
        private System.Windows.Forms.TableLayoutPanel ClientInformationLayoutPanel;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.TableLayoutPanel tableHotelInformation;
        private System.Windows.Forms.Label townLabel;
        private System.Windows.Forms.Label arrivalDateLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label minimumPriceLabel;
        private System.Windows.Forms.Label maximumPriceLabel;
        private System.Windows.Forms.TextBox townTextBox;
        private System.Windows.Forms.TextBox ArrivalDateTextBox;
        private System.Windows.Forms.TextBox depatureDateTextBox;
        private System.Windows.Forms.TextBox minimumPriceTextBox;
        private System.Windows.Forms.TextBox maximumPriceTextBox;
        private System.Windows.Forms.Label numberOfStarsLabel;
        private System.Windows.Forms.Label numberOfPersonToHostLabel;
        private System.Windows.Forms.TextBox numberOfStarsTextBox;
        private System.Windows.Forms.TextBox numberOfPersonToHostTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView listHotelGrid;
        private System.Windows.Forms.Button findHotelButton;
        private System.Windows.Forms.Button listHotelButton;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn town;
        private System.Windows.Forms.DataGridViewTextBoxColumn country;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfStars;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceRange;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfBed;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumber;
        private System.Windows.Forms.DataGridViewButtonColumn chooseHotel;
        private System.Windows.Forms.DataGridView roomDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomId;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomNumberOfBed;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomCapacity;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomStatus;
        private System.Windows.Forms.DataGridViewButtonColumn roomChoose;
        private System.Windows.Forms.Label notification;
        private System.Windows.Forms.GroupBox g;
    }
}