﻿
namespace playerRegistration
{
    partial class frmCustomer
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
            this.tabCustomer = new System.Windows.Forms.TabControl();
            this.tabDisplay = new System.Windows.Forms.TabPage();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.tabAdd = new System.Windows.Forms.TabPage();
            this.cmbAddTitle = new System.Windows.Forms.ComboBox();
            this.lblAddCustNo = new System.Windows.Forms.Label();
            this.txtAddTelNo = new System.Windows.Forms.TextBox();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.txtAddPostcode = new System.Windows.Forms.TextBox();
            this.txtPostcode = new System.Windows.Forms.TextBox();
            this.txtAddCounty = new System.Windows.Forms.TextBox();
            this.txtAddTown = new System.Windows.Forms.TextBox();
            this.txtAddStreet = new System.Windows.Forms.TextBox();
            this.txtAddSurname = new System.Windows.Forms.TextBox();
            this.txtEditCustNo = new System.Windows.Forms.TextBox();
            this.txtAddForename = new System.Windows.Forms.TextBox();
            this.txtCustmerNo = new System.Windows.Forms.TextBox();
            this.txtCounty = new System.Windows.Forms.TextBox();
            this.txtTown = new System.Windows.Forms.TextBox();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtForename = new System.Windows.Forms.TextBox();
            this.btnCancelAdd = new System.Windows.Forms.Button();
            this.btnAddAdd = new System.Windows.Forms.Button();
            this.tabEdit = new System.Windows.Forms.TabPage();
            this.lblEditCustNo = new System.Windows.Forms.Label();
            this.cmbEditTitle = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEditTelNo = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txtEditPostcode = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.txtEditCounty = new System.Windows.Forms.TextBox();
            this.txtEditTown = new System.Windows.Forms.TextBox();
            this.txtEditStreet = new System.Windows.Forms.TextBox();
            this.txtEditSurname = new System.Windows.Forms.TextBox();
            this.txtEditForename = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.btnCancel2 = new System.Windows.Forms.Button();
            this.btnEdit2 = new System.Windows.Forms.Button();
            this.txtHeading = new System.Windows.Forms.TextBox();
            this.errP = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabCustomer.SuspendLayout();
            this.tabDisplay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.tabAdd.SuspendLayout();
            this.tabEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errP)).BeginInit();
            this.SuspendLayout();
            // 
            // tabCustomer
            // 
            this.tabCustomer.Controls.Add(this.tabDisplay);
            this.tabCustomer.Controls.Add(this.tabAdd);
            this.tabCustomer.Controls.Add(this.tabEdit);
            this.tabCustomer.Location = new System.Drawing.Point(12, 94);
            this.tabCustomer.Name = "tabCustomer";
            this.tabCustomer.SelectedIndex = 0;
            this.tabCustomer.Size = new System.Drawing.Size(776, 445);
            this.tabCustomer.TabIndex = 0;
            // 
            // tabDisplay
            // 
            this.tabDisplay.Controls.Add(this.btnExit);
            this.tabDisplay.Controls.Add(this.btnDelete);
            this.tabDisplay.Controls.Add(this.btnEdit);
            this.tabDisplay.Controls.Add(this.btnAdd);
            this.tabDisplay.Controls.Add(this.dgvCustomers);
            this.tabDisplay.Location = new System.Drawing.Point(4, 22);
            this.tabDisplay.Name = "tabDisplay";
            this.tabDisplay.Padding = new System.Windows.Forms.Padding(3);
            this.tabDisplay.Size = new System.Drawing.Size(768, 419);
            this.tabDisplay.TabIndex = 0;
            this.tabDisplay.Text = "Display";
            this.tabDisplay.UseVisualStyleBackColor = true;
            this.tabDisplay.Click += new System.EventHandler(this.tabDisplay_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(0)))), ((int)(((byte)(82)))));
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnExit.FlatAppearance.BorderSize = 5;
            this.btnExit.Font = new System.Drawing.Font("Trebuchet MS", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(532, 169);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(232, 50);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(133)))));
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDelete.FlatAppearance.BorderSize = 5;
            this.btnDelete.Font = new System.Drawing.Font("Trebuchet MS", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(532, 115);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(232, 50);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEdit.FlatAppearance.BorderSize = 5;
            this.btnEdit.Font = new System.Drawing.Font("Trebuchet MS", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.Black;
            this.btnEdit.Location = new System.Drawing.Point(532, 60);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(232, 50);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(25)))), ((int)(((byte)(91)))));
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAdd.FlatAppearance.BorderSize = 5;
            this.btnAdd.Font = new System.Drawing.Font("Trebuchet MS", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(532, 6);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(232, 50);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Location = new System.Drawing.Point(6, 6);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.RowHeadersWidth = 51;
            this.dgvCustomers.Size = new System.Drawing.Size(521, 407);
            this.dgvCustomers.TabIndex = 0;
            // 
            // tabAdd
            // 
            this.tabAdd.Controls.Add(this.cmbAddTitle);
            this.tabAdd.Controls.Add(this.lblAddCustNo);
            this.tabAdd.Controls.Add(this.txtAddTelNo);
            this.tabAdd.Controls.Add(this.txtTelephone);
            this.tabAdd.Controls.Add(this.txtAddPostcode);
            this.tabAdd.Controls.Add(this.txtPostcode);
            this.tabAdd.Controls.Add(this.txtAddCounty);
            this.tabAdd.Controls.Add(this.txtAddTown);
            this.tabAdd.Controls.Add(this.txtAddStreet);
            this.tabAdd.Controls.Add(this.txtAddSurname);
            this.tabAdd.Controls.Add(this.txtEditCustNo);
            this.tabAdd.Controls.Add(this.txtAddForename);
            this.tabAdd.Controls.Add(this.txtCustmerNo);
            this.tabAdd.Controls.Add(this.txtCounty);
            this.tabAdd.Controls.Add(this.txtTown);
            this.tabAdd.Controls.Add(this.txtStreet);
            this.tabAdd.Controls.Add(this.txtSurname);
            this.tabAdd.Controls.Add(this.txtTitle);
            this.tabAdd.Controls.Add(this.txtForename);
            this.tabAdd.Controls.Add(this.btnCancelAdd);
            this.tabAdd.Controls.Add(this.btnAddAdd);
            this.tabAdd.Location = new System.Drawing.Point(4, 22);
            this.tabAdd.Name = "tabAdd";
            this.tabAdd.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdd.Size = new System.Drawing.Size(768, 419);
            this.tabAdd.TabIndex = 1;
            this.tabAdd.Text = "Add";
            this.tabAdd.UseVisualStyleBackColor = true;
            // 
            // cmbAddTitle
            // 
            this.cmbAddTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAddTitle.FormattingEnabled = true;
            this.cmbAddTitle.Location = new System.Drawing.Point(179, 54);
            this.cmbAddTitle.Margin = new System.Windows.Forms.Padding(2);
            this.cmbAddTitle.Name = "cmbAddTitle";
            this.cmbAddTitle.Size = new System.Drawing.Size(92, 33);
            this.cmbAddTitle.TabIndex = 10;
            // 
            // lblAddCustNo
            // 
            this.lblAddCustNo.AutoSize = true;
            this.lblAddCustNo.Location = new System.Drawing.Point(188, 32);
            this.lblAddCustNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddCustNo.Name = "lblAddCustNo";
            this.lblAddCustNo.Size = new System.Drawing.Size(0, 13);
            this.lblAddCustNo.TabIndex = 9;
            // 
            // txtAddTelNo
            // 
            this.txtAddTelNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddTelNo.Location = new System.Drawing.Point(179, 295);
            this.txtAddTelNo.Margin = new System.Windows.Forms.Padding(2);
            this.txtAddTelNo.Name = "txtAddTelNo";
            this.txtAddTelNo.Size = new System.Drawing.Size(216, 30);
            this.txtAddTelNo.TabIndex = 8;
            // 
            // txtTelephone
            // 
            this.txtTelephone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelephone.Location = new System.Drawing.Point(5, 295);
            this.txtTelephone.Margin = new System.Windows.Forms.Padding(2);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(142, 23);
            this.txtTelephone.TabIndex = 7;
            this.txtTelephone.Text = "Telelphone";
            // 
            // txtAddPostcode
            // 
            this.txtAddPostcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddPostcode.Location = new System.Drawing.Point(179, 261);
            this.txtAddPostcode.Margin = new System.Windows.Forms.Padding(2);
            this.txtAddPostcode.Name = "txtAddPostcode";
            this.txtAddPostcode.Size = new System.Drawing.Size(216, 30);
            this.txtAddPostcode.TabIndex = 8;
            // 
            // txtPostcode
            // 
            this.txtPostcode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPostcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPostcode.Location = new System.Drawing.Point(5, 261);
            this.txtPostcode.Margin = new System.Windows.Forms.Padding(2);
            this.txtPostcode.Name = "txtPostcode";
            this.txtPostcode.Size = new System.Drawing.Size(126, 23);
            this.txtPostcode.TabIndex = 7;
            this.txtPostcode.Text = "Postcode";
            // 
            // txtAddCounty
            // 
            this.txtAddCounty.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddCounty.Location = new System.Drawing.Point(179, 227);
            this.txtAddCounty.Margin = new System.Windows.Forms.Padding(2);
            this.txtAddCounty.Name = "txtAddCounty";
            this.txtAddCounty.Size = new System.Drawing.Size(216, 30);
            this.txtAddCounty.TabIndex = 6;
            // 
            // txtAddTown
            // 
            this.txtAddTown.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddTown.Location = new System.Drawing.Point(179, 193);
            this.txtAddTown.Margin = new System.Windows.Forms.Padding(2);
            this.txtAddTown.Name = "txtAddTown";
            this.txtAddTown.Size = new System.Drawing.Size(216, 30);
            this.txtAddTown.TabIndex = 6;
            // 
            // txtAddStreet
            // 
            this.txtAddStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddStreet.Location = new System.Drawing.Point(179, 159);
            this.txtAddStreet.Margin = new System.Windows.Forms.Padding(2);
            this.txtAddStreet.Name = "txtAddStreet";
            this.txtAddStreet.Size = new System.Drawing.Size(216, 30);
            this.txtAddStreet.TabIndex = 6;
            // 
            // txtAddSurname
            // 
            this.txtAddSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddSurname.Location = new System.Drawing.Point(179, 125);
            this.txtAddSurname.Margin = new System.Windows.Forms.Padding(2);
            this.txtAddSurname.Name = "txtAddSurname";
            this.txtAddSurname.Size = new System.Drawing.Size(216, 30);
            this.txtAddSurname.TabIndex = 6;
            // 
            // txtEditCustNo
            // 
            this.txtEditCustNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditCustNo.Location = new System.Drawing.Point(179, 11);
            this.txtEditCustNo.Margin = new System.Windows.Forms.Padding(2);
            this.txtEditCustNo.Name = "txtEditCustNo";
            this.txtEditCustNo.Size = new System.Drawing.Size(216, 30);
            this.txtEditCustNo.TabIndex = 6;
            // 
            // txtAddForename
            // 
            this.txtAddForename.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddForename.Location = new System.Drawing.Point(179, 91);
            this.txtAddForename.Margin = new System.Windows.Forms.Padding(2);
            this.txtAddForename.Name = "txtAddForename";
            this.txtAddForename.Size = new System.Drawing.Size(216, 30);
            this.txtAddForename.TabIndex = 6;
            // 
            // txtCustmerNo
            // 
            this.txtCustmerNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCustmerNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustmerNo.Location = new System.Drawing.Point(5, 11);
            this.txtCustmerNo.Margin = new System.Windows.Forms.Padding(2);
            this.txtCustmerNo.Name = "txtCustmerNo";
            this.txtCustmerNo.Size = new System.Drawing.Size(170, 23);
            this.txtCustmerNo.TabIndex = 4;
            this.txtCustmerNo.Text = "Customer No";
            // 
            // txtCounty
            // 
            this.txtCounty.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCounty.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCounty.Location = new System.Drawing.Point(5, 227);
            this.txtCounty.Margin = new System.Windows.Forms.Padding(2);
            this.txtCounty.Name = "txtCounty";
            this.txtCounty.Size = new System.Drawing.Size(126, 23);
            this.txtCounty.TabIndex = 4;
            this.txtCounty.Text = "County";
            this.txtCounty.TextChanged += new System.EventHandler(this.txtKitNumber_TextChanged);
            // 
            // txtTown
            // 
            this.txtTown.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTown.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTown.Location = new System.Drawing.Point(5, 193);
            this.txtTown.Margin = new System.Windows.Forms.Padding(2);
            this.txtTown.Name = "txtTown";
            this.txtTown.Size = new System.Drawing.Size(126, 23);
            this.txtTown.TabIndex = 4;
            this.txtTown.Text = "Town";
            // 
            // txtStreet
            // 
            this.txtStreet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStreet.Location = new System.Drawing.Point(5, 159);
            this.txtStreet.Margin = new System.Windows.Forms.Padding(2);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(126, 23);
            this.txtStreet.TabIndex = 4;
            this.txtStreet.Text = "Street";
            // 
            // txtSurname
            // 
            this.txtSurname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSurname.Location = new System.Drawing.Point(5, 125);
            this.txtSurname.Margin = new System.Windows.Forms.Padding(2);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(126, 23);
            this.txtSurname.TabIndex = 4;
            this.txtSurname.Text = "Surname";
            // 
            // txtTitle
            // 
            this.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.Location = new System.Drawing.Point(5, 57);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(2);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(126, 23);
            this.txtTitle.TabIndex = 4;
            this.txtTitle.Text = "Title";
            this.txtTitle.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtForename
            // 
            this.txtForename.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtForename.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtForename.Location = new System.Drawing.Point(5, 91);
            this.txtForename.Margin = new System.Windows.Forms.Padding(2);
            this.txtForename.Name = "txtForename";
            this.txtForename.Size = new System.Drawing.Size(126, 23);
            this.txtForename.TabIndex = 4;
            this.txtForename.Text = "Forename";
            // 
            // btnCancelAdd
            // 
            this.btnCancelAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.btnCancelAdd.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCancelAdd.FlatAppearance.BorderSize = 5;
            this.btnCancelAdd.Font = new System.Drawing.Font("Trebuchet MS", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelAdd.ForeColor = System.Drawing.Color.Black;
            this.btnCancelAdd.Location = new System.Drawing.Point(532, 60);
            this.btnCancelAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelAdd.Name = "btnCancelAdd";
            this.btnCancelAdd.Size = new System.Drawing.Size(232, 50);
            this.btnCancelAdd.TabIndex = 2;
            this.btnCancelAdd.Text = "Cancel";
            this.btnCancelAdd.UseVisualStyleBackColor = false;
            // 
            // btnAddAdd
            // 
            this.btnAddAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(25)))), ((int)(((byte)(91)))));
            this.btnAddAdd.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAddAdd.FlatAppearance.BorderSize = 5;
            this.btnAddAdd.Font = new System.Drawing.Font("Trebuchet MS", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAdd.ForeColor = System.Drawing.Color.White;
            this.btnAddAdd.Location = new System.Drawing.Point(532, 6);
            this.btnAddAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddAdd.Name = "btnAddAdd";
            this.btnAddAdd.Size = new System.Drawing.Size(232, 50);
            this.btnAddAdd.TabIndex = 3;
            this.btnAddAdd.Text = "Add";
            this.btnAddAdd.UseVisualStyleBackColor = false;
            this.btnAddAdd.Click += new System.EventHandler(this.btnAddAdd_Click);
            // 
            // tabEdit
            // 
            this.tabEdit.Controls.Add(this.lblEditCustNo);
            this.tabEdit.Controls.Add(this.cmbEditTitle);
            this.tabEdit.Controls.Add(this.label1);
            this.tabEdit.Controls.Add(this.txtEditTelNo);
            this.tabEdit.Controls.Add(this.textBox3);
            this.tabEdit.Controls.Add(this.txtEditPostcode);
            this.tabEdit.Controls.Add(this.textBox5);
            this.tabEdit.Controls.Add(this.txtEditCounty);
            this.tabEdit.Controls.Add(this.txtEditTown);
            this.tabEdit.Controls.Add(this.txtEditStreet);
            this.tabEdit.Controls.Add(this.txtEditSurname);
            this.tabEdit.Controls.Add(this.txtEditForename);
            this.tabEdit.Controls.Add(this.textBox12);
            this.tabEdit.Controls.Add(this.textBox13);
            this.tabEdit.Controls.Add(this.textBox14);
            this.tabEdit.Controls.Add(this.textBox15);
            this.tabEdit.Controls.Add(this.textBox16);
            this.tabEdit.Controls.Add(this.textBox17);
            this.tabEdit.Controls.Add(this.textBox18);
            this.tabEdit.Controls.Add(this.btnCancel2);
            this.tabEdit.Controls.Add(this.btnEdit2);
            this.tabEdit.Location = new System.Drawing.Point(4, 22);
            this.tabEdit.Name = "tabEdit";
            this.tabEdit.Padding = new System.Windows.Forms.Padding(3);
            this.tabEdit.Size = new System.Drawing.Size(768, 419);
            this.tabEdit.TabIndex = 2;
            this.tabEdit.Text = "Edit";
            this.tabEdit.UseVisualStyleBackColor = true;
            this.tabEdit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // lblEditCustNo
            // 
            this.lblEditCustNo.AutoSize = true;
            this.lblEditCustNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditCustNo.Location = new System.Drawing.Point(180, 11);
            this.lblEditCustNo.Name = "lblEditCustNo";
            this.lblEditCustNo.Size = new System.Drawing.Size(0, 25);
            this.lblEditCustNo.TabIndex = 30;
            // 
            // cmbEditTitle
            // 
            this.cmbEditTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEditTitle.FormattingEnabled = true;
            this.cmbEditTitle.Location = new System.Drawing.Point(179, 54);
            this.cmbEditTitle.Margin = new System.Windows.Forms.Padding(2);
            this.cmbEditTitle.Name = "cmbEditTitle";
            this.cmbEditTitle.Size = new System.Drawing.Size(92, 33);
            this.cmbEditTitle.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 28;
            // 
            // txtEditTelNo
            // 
            this.txtEditTelNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditTelNo.Location = new System.Drawing.Point(179, 295);
            this.txtEditTelNo.Margin = new System.Windows.Forms.Padding(2);
            this.txtEditTelNo.Name = "txtEditTelNo";
            this.txtEditTelNo.Size = new System.Drawing.Size(216, 30);
            this.txtEditTelNo.TabIndex = 27;
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(5, 295);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(142, 23);
            this.textBox3.TabIndex = 25;
            this.textBox3.Text = "Telelphone";
            // 
            // txtEditPostcode
            // 
            this.txtEditPostcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditPostcode.Location = new System.Drawing.Point(179, 261);
            this.txtEditPostcode.Margin = new System.Windows.Forms.Padding(2);
            this.txtEditPostcode.Name = "txtEditPostcode";
            this.txtEditPostcode.Size = new System.Drawing.Size(216, 30);
            this.txtEditPostcode.TabIndex = 26;
            // 
            // textBox5
            // 
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(5, 261);
            this.textBox5.Margin = new System.Windows.Forms.Padding(2);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(126, 23);
            this.textBox5.TabIndex = 24;
            this.textBox5.Text = "Postcode";
            // 
            // txtEditCounty
            // 
            this.txtEditCounty.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditCounty.Location = new System.Drawing.Point(179, 227);
            this.txtEditCounty.Margin = new System.Windows.Forms.Padding(2);
            this.txtEditCounty.Name = "txtEditCounty";
            this.txtEditCounty.Size = new System.Drawing.Size(216, 30);
            this.txtEditCounty.TabIndex = 22;
            // 
            // txtEditTown
            // 
            this.txtEditTown.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditTown.Location = new System.Drawing.Point(179, 193);
            this.txtEditTown.Margin = new System.Windows.Forms.Padding(2);
            this.txtEditTown.Name = "txtEditTown";
            this.txtEditTown.Size = new System.Drawing.Size(216, 30);
            this.txtEditTown.TabIndex = 21;
            // 
            // txtEditStreet
            // 
            this.txtEditStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditStreet.Location = new System.Drawing.Point(179, 159);
            this.txtEditStreet.Margin = new System.Windows.Forms.Padding(2);
            this.txtEditStreet.Name = "txtEditStreet";
            this.txtEditStreet.Size = new System.Drawing.Size(216, 30);
            this.txtEditStreet.TabIndex = 23;
            // 
            // txtEditSurname
            // 
            this.txtEditSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditSurname.Location = new System.Drawing.Point(179, 125);
            this.txtEditSurname.Margin = new System.Windows.Forms.Padding(2);
            this.txtEditSurname.Name = "txtEditSurname";
            this.txtEditSurname.Size = new System.Drawing.Size(216, 30);
            this.txtEditSurname.TabIndex = 20;
            // 
            // txtEditForename
            // 
            this.txtEditForename.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditForename.Location = new System.Drawing.Point(179, 91);
            this.txtEditForename.Margin = new System.Windows.Forms.Padding(2);
            this.txtEditForename.Name = "txtEditForename";
            this.txtEditForename.Size = new System.Drawing.Size(216, 30);
            this.txtEditForename.TabIndex = 19;
            // 
            // textBox12
            // 
            this.textBox12.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox12.Location = new System.Drawing.Point(5, 11);
            this.textBox12.Margin = new System.Windows.Forms.Padding(2);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(170, 23);
            this.textBox12.TabIndex = 16;
            this.textBox12.Text = "Customer No";
            // 
            // textBox13
            // 
            this.textBox13.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox13.Location = new System.Drawing.Point(5, 227);
            this.textBox13.Margin = new System.Windows.Forms.Padding(2);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(126, 23);
            this.textBox13.TabIndex = 15;
            this.textBox13.Text = "County";
            // 
            // textBox14
            // 
            this.textBox14.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox14.Location = new System.Drawing.Point(5, 193);
            this.textBox14.Margin = new System.Windows.Forms.Padding(2);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(126, 23);
            this.textBox14.TabIndex = 14;
            this.textBox14.Text = "Town";
            // 
            // textBox15
            // 
            this.textBox15.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox15.Location = new System.Drawing.Point(5, 159);
            this.textBox15.Margin = new System.Windows.Forms.Padding(2);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(126, 23);
            this.textBox15.TabIndex = 13;
            this.textBox15.Text = "Street";
            // 
            // textBox16
            // 
            this.textBox16.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox16.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox16.Location = new System.Drawing.Point(5, 125);
            this.textBox16.Margin = new System.Windows.Forms.Padding(2);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(126, 23);
            this.textBox16.TabIndex = 12;
            this.textBox16.Text = "Surname";
            // 
            // textBox17
            // 
            this.textBox17.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox17.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox17.Location = new System.Drawing.Point(5, 57);
            this.textBox17.Margin = new System.Windows.Forms.Padding(2);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(126, 23);
            this.textBox17.TabIndex = 17;
            this.textBox17.Text = "Title";
            // 
            // textBox18
            // 
            this.textBox18.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox18.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox18.Location = new System.Drawing.Point(5, 91);
            this.textBox18.Margin = new System.Windows.Forms.Padding(2);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(126, 23);
            this.textBox18.TabIndex = 11;
            this.textBox18.Text = "Forename";
            // 
            // btnCancel2
            // 
            this.btnCancel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.btnCancel2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCancel2.FlatAppearance.BorderSize = 5;
            this.btnCancel2.Font = new System.Drawing.Font("Trebuchet MS", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel2.ForeColor = System.Drawing.Color.Black;
            this.btnCancel2.Location = new System.Drawing.Point(532, 60);
            this.btnCancel2.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel2.Name = "btnCancel2";
            this.btnCancel2.Size = new System.Drawing.Size(232, 50);
            this.btnCancel2.TabIndex = 4;
            this.btnCancel2.Text = "Cancel";
            this.btnCancel2.UseVisualStyleBackColor = false;
            // 
            // btnEdit2
            // 
            this.btnEdit2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(25)))), ((int)(((byte)(91)))));
            this.btnEdit2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEdit2.FlatAppearance.BorderSize = 5;
            this.btnEdit2.Font = new System.Drawing.Font("Trebuchet MS", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit2.ForeColor = System.Drawing.Color.White;
            this.btnEdit2.Location = new System.Drawing.Point(532, 6);
            this.btnEdit2.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdit2.Name = "btnEdit2";
            this.btnEdit2.Size = new System.Drawing.Size(232, 50);
            this.btnEdit2.TabIndex = 5;
            this.btnEdit2.Text = "Edit";
            this.btnEdit2.UseVisualStyleBackColor = false;
            // 
            // txtHeading
            // 
            this.txtHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHeading.Location = new System.Drawing.Point(125, 5);
            this.txtHeading.Name = "txtHeading";
            this.txtHeading.Size = new System.Drawing.Size(555, 83);
            this.txtHeading.TabIndex = 9;
            this.txtHeading.Text = "In The Dog House";
            // 
            // errP
            // 
            this.errP.ContainerControl = this;
            // 
            // frmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::playerRegistration.Properties.Resources.premier_league_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(805, 551);
            this.Controls.Add(this.tabCustomer);
            this.Controls.Add(this.txtHeading);
            this.Name = "frmCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "In The Dog House";
            this.Load += new System.EventHandler(this.frmCustomer_Load);
            this.tabCustomer.ResumeLayout(false);
            this.tabDisplay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.tabAdd.ResumeLayout(false);
            this.tabAdd.PerformLayout();
            this.tabEdit.ResumeLayout(false);
            this.tabEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabCustomer;
        private System.Windows.Forms.TabPage tabDisplay;
        private System.Windows.Forms.TabPage tabAdd;
        private System.Windows.Forms.TabPage tabEdit;
        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancelAdd;
        private System.Windows.Forms.Button btnAddAdd;
        private System.Windows.Forms.Button btnCancel2;
        private System.Windows.Forms.Button btnEdit2;
        private System.Windows.Forms.TextBox txtAddCounty;
        private System.Windows.Forms.TextBox txtAddTown;
        private System.Windows.Forms.TextBox txtAddStreet;
        private System.Windows.Forms.TextBox txtAddSurname;
        private System.Windows.Forms.TextBox txtAddForename;
        private System.Windows.Forms.TextBox txtCustmerNo;
        private System.Windows.Forms.TextBox txtCounty;
        private System.Windows.Forms.TextBox txtTown;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtForename;
        private System.Windows.Forms.TextBox txtAddTelNo;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.TextBox txtAddPostcode;
        private System.Windows.Forms.TextBox txtPostcode;
        private System.Windows.Forms.TextBox txtHeading;
        private System.Windows.Forms.ErrorProvider errP;
        private System.Windows.Forms.Label lblAddCustNo;
        private System.Windows.Forms.ComboBox cmbAddTitle;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.ComboBox cmbEditTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEditTelNo;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox txtEditPostcode;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox txtEditCounty;
        private System.Windows.Forms.TextBox txtEditTown;
        private System.Windows.Forms.TextBox txtEditStreet;
        private System.Windows.Forms.TextBox txtEditSurname;
        private System.Windows.Forms.TextBox txtEditForename;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.Label lblEditCustNo;
        private System.Windows.Forms.TextBox txtEditCustNo;
    }
}

