namespace BookManagerGUIForms
{
    partial class BookListForm
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
            btnAbout = new Button();
            btnQuit = new Button();
            dgvBookList = new DataGridView();
            lblBookList = new Label();
            btnLoadData = new Button();
            btnCreateBook = new Button();
            btnEditBook = new Button();
            cboCategory = new ComboBox();
            btnFillCategory = new Button();
            btnShowCate = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvBookList).BeginInit();
            SuspendLayout();
            // 
            // btnAbout
            // 
            btnAbout.Location = new Point(878, 527);
            btnAbout.Name = "btnAbout";
            btnAbout.Size = new Size(143, 39);
            btnAbout.TabIndex = 0;
            btnAbout.Text = "About us";
            btnAbout.UseVisualStyleBackColor = false;
            btnAbout.Click += btnAbout_Click;
            // 
            // btnQuit
            // 
            btnQuit.Location = new Point(1027, 528);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(145, 38);
            btnQuit.TabIndex = 1;
            btnQuit.Text = "Quit";
            btnQuit.UseVisualStyleBackColor = false;
            btnQuit.Click += btnQuit_Click;
            // 
            // dgvBookList
            // 
            dgvBookList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBookList.Location = new Point(25, 208);
            dgvBookList.Name = "dgvBookList";
            dgvBookList.RowHeadersWidth = 51;
            dgvBookList.Size = new Size(847, 358);
            dgvBookList.TabIndex = 2;
            // 
            // lblBookList
            // 
            lblBookList.AutoSize = true;
            lblBookList.BackColor = Color.OrangeRed;
            lblBookList.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBookList.ForeColor = SystemColors.ActiveCaptionText;
            lblBookList.ImageAlign = ContentAlignment.BottomCenter;
            lblBookList.Location = new Point(25, 98);
            lblBookList.Name = "lblBookList";
            lblBookList.Size = new Size(276, 50);
            lblBookList.TabIndex = 3;
            lblBookList.Text = "The list of book";
            // 
            // btnLoadData
            // 
            btnLoadData.Location = new Point(899, 99);
            btnLoadData.Name = "btnLoadData";
            btnLoadData.Size = new Size(211, 66);
            btnLoadData.TabIndex = 4;
            btnLoadData.Text = "Load Data";
            btnLoadData.UseVisualStyleBackColor = false;
            btnLoadData.Click += btnLoadData_Click;
            // 
            // btnCreateBook
            // 
            btnCreateBook.Location = new Point(899, 171);
            btnCreateBook.Name = "btnCreateBook";
            btnCreateBook.Size = new Size(211, 63);
            btnCreateBook.TabIndex = 5;
            btnCreateBook.Text = "Create Book";
            btnCreateBook.UseVisualStyleBackColor = false;
            btnCreateBook.Click += btnCreateBook_Click;
            // 
            // btnEditBook
            // 
            btnEditBook.Location = new Point(899, 240);
            btnEditBook.Name = "btnEditBook";
            btnEditBook.RightToLeft = RightToLeft.No;
            btnEditBook.Size = new Size(211, 58);
            btnEditBook.TabIndex = 6;
            btnEditBook.Text = "Edit Book";
            btnEditBook.UseVisualStyleBackColor = false;
            btnEditBook.Click += btnEditBook_Click;
            // 
            // cboCategory
            // 
            cboCategory.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cboCategory.FormattingEnabled = true;
            cboCategory.Location = new Point(528, 139);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(344, 45);
            cboCategory.TabIndex = 7;
            // 
            // btnFillCategory
            // 
            btnFillCategory.Location = new Point(899, 304);
            btnFillCategory.Name = "btnFillCategory";
            btnFillCategory.RightToLeft = RightToLeft.No;
            btnFillCategory.Size = new Size(211, 63);
            btnFillCategory.TabIndex = 8;
            btnFillCategory.Text = "Fill Category";
            btnFillCategory.UseVisualStyleBackColor = false;
            btnFillCategory.Click += btnFillCategory_Click;
            // 
            // btnShowCate
            // 
            btnShowCate.Location = new Point(899, 373);
            btnShowCate.Name = "btnShowCate";
            btnShowCate.RightToLeft = RightToLeft.No;
            btnShowCate.Size = new Size(211, 63);
            btnShowCate.TabIndex = 9;
            btnShowCate.Text = "Show Category";
            btnShowCate.UseVisualStyleBackColor = false;
            btnShowCate.Click += btnShowCate_Click;
            // 
            // BookListForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Chocolate;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1181, 578);
            Controls.Add(btnShowCate);
            Controls.Add(btnFillCategory);
            Controls.Add(cboCategory);
            Controls.Add(btnEditBook);
            Controls.Add(btnCreateBook);
            Controls.Add(btnLoadData);
            Controls.Add(lblBookList);
            Controls.Add(dgvBookList);
            Controls.Add(btnQuit);
            Controls.Add(btnAbout);
            Name = "BookListForm";
            Text = "Book List";
            Load += BookListForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBookList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAbout;
        private Button btnQuit;
        private DataGridView dgvBookList;
        private Label lblBookList;
        private Button btnLoadData;
        private Button btnCreateBook;
        private Button btnEditBook;
        private ComboBox cboCategory;
        private Button btnFillCategory;
        private Button btnShowCate;
    }
}
