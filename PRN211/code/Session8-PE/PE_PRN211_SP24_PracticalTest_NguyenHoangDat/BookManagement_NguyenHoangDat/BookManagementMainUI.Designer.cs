namespace BookManagement_NguyenHoangDat
{
    partial class BookManagementMainUI
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblHeader = new Label();
            grbSearchCriteria = new GroupBox();
            btnSearch = new Button();
            txtBookDescription = new TextBox();
            txtBookName = new TextBox();
            lblBookName = new Label();
            lblBookDescription = new Label();
            lblBookList = new Label();
            btnCreate = new Button();
            btnExit = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            dgvBookList = new DataGridView();
            lblCopyRight = new Label();
            grbSearchCriteria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBookList).BeginInit();
            SuspendLayout();
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblHeader.Location = new Point(12, 9);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(448, 81);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Book Manager";
            // 
            // grbSearchCriteria
            // 
            grbSearchCriteria.Controls.Add(btnSearch);
            grbSearchCriteria.Controls.Add(txtBookDescription);
            grbSearchCriteria.Controls.Add(txtBookName);
            grbSearchCriteria.Controls.Add(lblBookName);
            grbSearchCriteria.Controls.Add(lblBookDescription);
            grbSearchCriteria.Location = new Point(12, 93);
            grbSearchCriteria.Name = "grbSearchCriteria";
            grbSearchCriteria.Size = new Size(1071, 125);
            grbSearchCriteria.TabIndex = 0;
            grbSearchCriteria.TabStop = false;
            grbSearchCriteria.Text = "Search Criteria";
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnSearch.Location = new Point(801, 48);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(264, 50);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtBookDescription
            // 
            txtBookDescription.Location = new Point(531, 54);
            txtBookDescription.Name = "txtBookDescription";
            txtBookDescription.Size = new Size(167, 27);
            txtBookDescription.TabIndex = 1;
            // 
            // txtBookName
            // 
            txtBookName.Location = new Point(151, 52);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(168, 27);
            txtBookName.TabIndex = 0;
            // 
            // lblBookName
            // 
            lblBookName.AutoSize = true;
            lblBookName.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblBookName.Location = new Point(6, 48);
            lblBookName.Name = "lblBookName";
            lblBookName.Size = new Size(139, 31);
            lblBookName.TabIndex = 4;
            lblBookName.Text = "Book Name";
            // 
            // lblBookDescription
            // 
            lblBookDescription.AutoSize = true;
            lblBookDescription.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblBookDescription.Location = new Point(325, 48);
            lblBookDescription.Name = "lblBookDescription";
            lblBookDescription.Size = new Size(200, 31);
            lblBookDescription.TabIndex = 3;
            lblBookDescription.Text = "Book Description";
            // 
            // lblBookList
            // 
            lblBookList.AutoSize = true;
            lblBookList.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblBookList.Location = new Point(12, 221);
            lblBookList.Name = "lblBookList";
            lblBookList.Size = new Size(114, 31);
            lblBookList.TabIndex = 2;
            lblBookList.Text = "Book List";
            // 
            // btnCreate
            // 
            btnCreate.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnCreate.Location = new Point(813, 272);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(264, 50);
            btnCreate.TabIndex = 2;
            btnCreate.Text = "Create a book";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnExit.Location = new Point(813, 440);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(264, 50);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnDelete.Location = new Point(813, 384);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(264, 50);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete a book";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnUpdate.Location = new Point(813, 328);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(264, 50);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Update a book";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // dgvBookList
            // 
            dgvBookList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBookList.Location = new Point(12, 254);
            dgvBookList.Name = "dgvBookList";
            dgvBookList.RowHeadersWidth = 51;
            dgvBookList.Size = new Size(795, 236);
            dgvBookList.TabIndex = 1;
            dgvBookList.SelectionChanged += dgvBookList_SelectionChanged;
            // 
            // lblCopyRight
            // 
            lblCopyRight.AutoSize = true;
            lblCopyRight.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblCopyRight.Location = new Point(12, 493);
            lblCopyRight.Name = "lblCopyRight";
            lblCopyRight.Size = new Size(146, 25);
            lblCopyRight.TabIndex = 13;
            lblCopyRight.Text = "2024 Copy right";
            // 
            // BookManagementMainUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1130, 527);
            Controls.Add(lblCopyRight);
            Controls.Add(dgvBookList);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnExit);
            Controls.Add(btnCreate);
            Controls.Add(lblBookList);
            Controls.Add(grbSearchCriteria);
            Controls.Add(lblHeader);
            Name = "BookManagementMainUI";
            Text = "Book Manager";
            Load += BookManagementMainUI_Load;
            grbSearchCriteria.ResumeLayout(false);
            grbSearchCriteria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBookList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHeader;
        private GroupBox grbSearchCriteria;
        private Label lblBookList;
        private Button btnSearch;
        private TextBox txtBookDescription;
        private TextBox txtBookName;
        private Label lblBookName;
        private Label lblBookDescription;
        private Button btnCreate;
        private Button btnExit;
        private Button btnDelete;
        private Button btnUpdate;
        private DataGridView dgvBookList;
        private Label lblCopyRight;
    }
}
