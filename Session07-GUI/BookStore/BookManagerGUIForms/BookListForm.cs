using BookManager;
using BookManager.Entities;

namespace BookManagerGUIForms
{
    //form là cái class có sẵn trong .NET sdk
    //cung cấp cho dân dev cái cửa sổ để bày lên đó các object khác: nút nhấn ô nhập rodio button, check box
    //class này chứa các prop như class bình thường ngaofi ra còn có 1 đoạn code để giao tiếp với windows để render ra cái form
    //ta độ lại form gốc qua hình thức
    public partial class BookListForm : Form
    {
        public BookListForm()
        {
            InitializeComponent();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Wellcome to Book Store app. We come form class NET1805 - © 2024 soram", "About us", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("Do you want to quit?", "Quit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void BookListForm_Load(object sender, EventArgs e)
        {

        }


        private void btnLoadData_Click(object sender, EventArgs e)
        {
            BookStoreContext context = new();//cabinet đang chứa 3 list ứng với 3 table: book Category, UserAccount
            //đưa list sách vào data grid view
            dgvBookList.DataSource = context.Books.ToList();


        }

        private void btnCreateBook_Click(object sender, EventArgs e)
        {

            BookDetailForm bookDetailForm = new();
            //tạo form
            //show form
            bookDetailForm.ShowDialog();

        }

        private void btnEditBook_Click(object sender, EventArgs e)
        {
            //ta lấy 1 cuốn sách mà user chọn từ grid
            //khi user chọn 1 dòng trên dgvBookList có 1 property
            //của object này chứa cái dòng đã chọn chính là 1 book
            //ta lấy ra show

            Book selected = (Book)dgvBookList.SelectedRows[0].DataBoundItem;
            if (selected == null)
            {
                MessageBox.Show("Please select a book to edit", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //ngược lại có sách thì show ra màn hình khác
            //tạm thời show message
            MessageBox.Show($"You selected book: {selected.BookName} " +
                $"\n Book author: {selected.Author} ");
        }

        private void btnFillCategory_Click(object sender, EventArgs e)
        {
            BookStoreContext context = new();
            cboCategory.DataSource = context.BookCategories.ToList();
            cboCategory.DisplayMember = "BookGenreType";
            //cboCategory.SelectedItem = "BookCategoryId";
            cboCategory.ValueMember = "BookCategoryId";

        }

        private void btnShowCate_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("You selected category: " + cboCategory.SelectedIndex);
            MessageBox.Show("You selected category: " + cboCategory.SelectedValue);
        }
    }
}
