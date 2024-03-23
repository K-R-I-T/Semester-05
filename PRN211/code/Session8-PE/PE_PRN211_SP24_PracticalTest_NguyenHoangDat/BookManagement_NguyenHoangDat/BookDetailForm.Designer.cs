namespace BookManagement_NguyenHoangDat
{
    partial class BookDetailForm
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
            grbBookInfo = new GroupBox();
            cboCategory = new ComboBox();
            dtpPublicationDate = new DateTimePicker();
            txtQuantity = new TextBox();
            txtPrice = new TextBox();
            txtAuthor = new TextBox();
            lblCategory = new Label();
            lblAuthor = new Label();
            lblPrice = new Label();
            txtBookDescription = new TextBox();
            lblQuantity = new Label();
            lblPublicationDate = new Label();
            lblDescription = new Label();
            txtBookName = new TextBox();
            txtBookId = new TextBox();
            lblBookId = new Label();
            lblBookName = new Label();
            btnSave = new Button();
            lblHeader = new Label();
            btnCancel = new Button();
            grbBookInfo.SuspendLayout();
            SuspendLayout();
            // 
            // grbBookInfo
            // 
            grbBookInfo.Controls.Add(cboCategory);
            grbBookInfo.Controls.Add(dtpPublicationDate);
            grbBookInfo.Controls.Add(txtQuantity);
            grbBookInfo.Controls.Add(txtPrice);
            grbBookInfo.Controls.Add(txtAuthor);
            grbBookInfo.Controls.Add(lblCategory);
            grbBookInfo.Controls.Add(lblAuthor);
            grbBookInfo.Controls.Add(lblPrice);
            grbBookInfo.Controls.Add(txtBookDescription);
            grbBookInfo.Controls.Add(lblQuantity);
            grbBookInfo.Controls.Add(lblPublicationDate);
            grbBookInfo.Controls.Add(lblDescription);
            grbBookInfo.Controls.Add(txtBookName);
            grbBookInfo.Controls.Add(txtBookId);
            grbBookInfo.Controls.Add(lblBookId);
            grbBookInfo.Controls.Add(lblBookName);
            grbBookInfo.Location = new Point(12, 93);
            grbBookInfo.Name = "grbBookInfo";
            grbBookInfo.Size = new Size(784, 425);
            grbBookInfo.TabIndex = 0;
            grbBookInfo.TabStop = false;
            grbBookInfo.Text = "Book Info";
            // 
            // cboCategory
            // 
            cboCategory.FormattingEnabled = true;
            cboCategory.Location = new Point(212, 380);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(163, 28);
            cboCategory.TabIndex = 7;
            // 
            // dtpPublicationDate
            // 
            dtpPublicationDate.Format = DateTimePickerFormat.Short;
            dtpPublicationDate.Location = new Point(212, 242);
            dtpPublicationDate.Name = "dtpPublicationDate";
            dtpPublicationDate.Size = new Size(163, 27);
            dtpPublicationDate.TabIndex = 3;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(212, 275);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(163, 27);
            txtQuantity.TabIndex = 4;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(454, 275);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(167, 27);
            txtPrice.TabIndex = 5;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(212, 326);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(565, 27);
            txtAuthor.TabIndex = 6;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblCategory.Location = new Point(6, 374);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(111, 31);
            lblCategory.TabIndex = 11;
            lblCategory.Text = "Category";
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblAuthor.Location = new Point(6, 320);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(90, 31);
            lblAuthor.TabIndex = 10;
            lblAuthor.Text = "Author";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblPrice.Location = new Point(381, 269);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(67, 31);
            lblPrice.TabIndex = 9;
            lblPrice.Text = "Price";
            // 
            // txtBookDescription
            // 
            txtBookDescription.Location = new Point(212, 133);
            txtBookDescription.Multiline = true;
            txtBookDescription.Name = "txtBookDescription";
            txtBookDescription.ScrollBars = ScrollBars.Vertical;
            txtBookDescription.Size = new Size(565, 103);
            txtBookDescription.TabIndex = 2;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblQuantity.Location = new Point(6, 269);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(108, 31);
            lblQuantity.TabIndex = 7;
            lblQuantity.Text = "Quantity";
            // 
            // lblPublicationDate
            // 
            lblPublicationDate.AutoSize = true;
            lblPublicationDate.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblPublicationDate.Location = new Point(6, 238);
            lblPublicationDate.Name = "lblPublicationDate";
            lblPublicationDate.Size = new Size(193, 31);
            lblPublicationDate.TabIndex = 6;
            lblPublicationDate.Text = "Publication Date";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblDescription.Location = new Point(6, 133);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(200, 31);
            lblDescription.TabIndex = 5;
            lblDescription.Text = "Book Description";
            // 
            // txtBookName
            // 
            txtBookName.Location = new Point(212, 94);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(566, 27);
            txtBookName.TabIndex = 1;
            // 
            // txtBookId
            // 
            txtBookId.Location = new Point(212, 54);
            txtBookId.Name = "txtBookId";
            txtBookId.Size = new Size(566, 27);
            txtBookId.TabIndex = 0;
            // 
            // lblBookId
            // 
            lblBookId.AutoSize = true;
            lblBookId.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblBookId.Location = new Point(6, 48);
            lblBookId.Name = "lblBookId";
            lblBookId.Size = new Size(100, 31);
            lblBookId.TabIndex = 4;
            lblBookId.Text = "Book ID";
            lblBookId.Click += lblBookName_Click;
            // 
            // lblBookName
            // 
            lblBookName.AutoSize = true;
            lblBookName.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblBookName.Location = new Point(6, 88);
            lblBookName.Name = "lblBookName";
            lblBookName.Size = new Size(139, 31);
            lblBookName.TabIndex = 3;
            lblBookName.Text = "Book Name";
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnSave.Location = new Point(845, 124);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(264, 50);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblHeader.Location = new Point(12, 9);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(621, 81);
            lblHeader.TabIndex = 15;
            lblHeader.Text = "Add | Update a Book";
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnCancel.Location = new Point(845, 190);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(264, 50);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // BookDetailForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1141, 530);
            Controls.Add(btnCancel);
            Controls.Add(grbBookInfo);
            Controls.Add(lblHeader);
            Controls.Add(btnSave);
            Name = "BookDetailForm";
            Text = "Add | Update a book";
            Load += BookDetailForm_Load;
            grbBookInfo.ResumeLayout(false);
            grbBookInfo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox grbBookInfo;
        private Button btnSave;
        private TextBox txtBookName;
        private TextBox txtBookId;
        private Label lblBookId;
        private Label lblBookName;
        private Label lblHeader;
        private Label lblQuantity;
        private Label lblPublicationDate;
        private Label lblDescription;
        private TextBox txtQuantity;
        private TextBox txtPrice;
        private TextBox txtAuthor;
        private Label lblCategory;
        private Label lblAuthor;
        private Label lblPrice;
        private TextBox txtBookDescription;
        private ComboBox cboCategory;
        private DateTimePicker dtpPublicationDate;
        private Button btnCancel;
    }
}