using BookSystem.Classes;

namespace BookSystem
{
    public partial class NewBookForm : Form
    {
        public NewBookForm()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            SaveBookData();
            GotoMainForm();
        }

        void SaveBookData()
        {
            Book book = new Book();

            book.Title = txtTitle.Text;
            book.Isbn = txtIsbn.Text;
            book.PublisherName = txtPublisher.Text;
            book.AuthorName = txtAuthor.Text;
            book.CategoryName = txtCategory.Text;

            book.CreateBook(book);
        }

        void GotoMainForm()
        {
            this.Close();
        }
    }
}
