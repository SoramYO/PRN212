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
    }
}
