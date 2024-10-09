using BookSystem.Classes;

namespace BookSystem
{
    public partial class EditBookForm : Form
    {
        int selectedBookId;

        public EditBookForm(int bookId)
        {
            InitializeComponent();
            selectedBookId = bookId;
            GetBookData();
        }


        private void btnOK_Click(object sender, EventArgs e)
        {
            EditBookData();
            GotoMainForm();
        }

        void GetBookData()
        {
            Book book = new Book();
            book = book.GetBookData(selectedBookId);

            txtTitle.Text = book.Title;
            txtIsbn.Text = book.Isbn;
            txtPublisher.Text = book.PublisherName;
            txtAuthor.Text = book.AuthorName;
            txtCategory.Text = book.CategoryName;
        }

        void EditBookData()
        {
            Book book = new Book();

            book.BookId = selectedBookId;
            book.Title = txtTitle.Text;
            book.Isbn = txtIsbn.Text;
            book.PublisherName = txtPublisher.Text;
            book.AuthorName = txtAuthor.Text;
            book.CategoryName = txtCategory.Text;

            book.EditBook(book);
        }

        void GotoMainForm()
        {
            this.Close();
        }
    }
}
