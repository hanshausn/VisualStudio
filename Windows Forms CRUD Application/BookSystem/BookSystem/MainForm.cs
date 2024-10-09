using BookSystem.Classes;

namespace BookSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            FillGridView();
            AdjustGridView();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            NewBookForm formNewBook = new NewBookForm();
            formNewBook.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditBook();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteBook();
        }

        void EditBook()
        {
            int bookId;
            bookId = (int)datagridviewBooks.CurrentRow.Cells[0].Value;

            EditBookForm formEditBook = new EditBookForm(bookId);
            formEditBook.ShowDialog();
        }

        void DeleteBook()
        {
            int bookId;
            bookId = (int)datagridviewBooks.CurrentRow.Cells[0].Value;
            string? bookTitle = datagridviewBooks.CurrentRow.Cells[1].Value.ToString();

            string message = "Are you sure that you want to delete the book '" + bookTitle + "'?";
            DialogResult dr = MessageBox.Show(message, "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            { 
                Book book = new Book();
                book.DeleteBook(bookId);
                FillGridView();
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        void AdjustGridView()
        {
            datagridviewBooks.Columns[0].HeaderText = "BookId";
            datagridviewBooks.Columns[1].HeaderText = "Title";
            datagridviewBooks.Columns[2].HeaderText = "ISBN";
            datagridviewBooks.Columns[3].HeaderText = "Publisher";
            datagridviewBooks.Columns[4].HeaderText = "Author";
            datagridviewBooks.Columns[5].HeaderText = "Category";

            datagridviewBooks.Columns[0].Width = 50;
            datagridviewBooks.Columns[1].Width = 200;
            datagridviewBooks.Columns[2].Width = 90;
            datagridviewBooks.Columns[3].Width = 120;
            datagridviewBooks.Columns[4].Width = 120;
            datagridviewBooks.Columns[5].Width = 120;
        }

        void FillGridView()
        {
            List<Book> bookList = new List<Book>();
            Book book = new Book();
            bookList = book.GetBooks();

            datagridviewBooks.DataSource = bookList;
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            FillGridView();
        }

        private void datagridviewBooks_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EditBook();
        }
    }
}