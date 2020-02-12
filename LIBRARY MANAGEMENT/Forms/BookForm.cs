using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LIBRARY_MANAGEMENT.Data;
using LIBRARY_MANAGEMENT.Models;



namespace LIBRARY_MANAGEMENT.Forms
{
    public partial class BookForm : Form
    {
        private int _id;
        private Book _book;
        private readonly LibraryDbContext _context;
        public BookForm()
        {
            
            InitializeComponent();
            _context = new LibraryDbContext();
            
            FillDataGenre();
        }
        //FillBooks
        private void FillBooks()
        {
            var ShowBook = _context.Books.ToList();
            DgvAddBooks.Rows.Clear();
            foreach (var item in ShowBook)
            {
                DgvAddBooks.Rows.Add(item.Id,
                                     item.Name,
                                     item.Author,
                                     item.Genre.Name,
                                     item.RentalPrice,
                                     item.Count);
            }
        }
         private void FillDataGenre()
        {
            List<Genre> genres = _context.Genres.ToList();
            foreach (Genre item in genres)
            {
                CmbCombobox combobox = new CmbCombobox
                {
                    Id = item.Id,
                    Name = item.Name
                };
                CmbGenre.Items.Add(combobox);
            }
        }
        #region 
        //Create and Read Method
        //private void BtnBookAdd_Click_1(object sender, EventArgs e)
        //{
        //    CmbCombobox select = CmbGenre.SelectedItem as CmbCombobox;
        //    if (!string.IsNullOrEmpty(TxtBookName.Text) ||
        //     !string.IsNullOrEmpty(TxtAuthor.Text) ||
        //     !string.IsNullOrEmpty(CmbGenre.Text) ||
        //     !string.IsNullOrEmpty(TxtRentalPrice.Text) ||
        //     !string.IsNullOrEmpty(TxtCount.Text))
        //    {

        //        Book book = new Book//add book to database
        //        {
        //            Name = TxtBookName.Text,
        //            Author = TxtAuthor.Text,
        //            GenreId = select.Id,
        //            RentalPrice = Convert.ToDouble(TxtRentalPrice.Text),
        //            Count = Convert.ToInt32(TxtCount.Text),
        //        };

        //        _context.Books.Add(book);
        //        _context.SaveChanges();
        //        Clear();


        //    }
        //    else
        //    {
        //        MessageBox.Show("Add,please");
        //    }
        //    FillBooks();

        //}
        private void Clear()
        {
            TxtBookName.Clear();
            TxtAuthor.Clear();
            TxtCount.Clear();
            TxtRentalPrice.Clear();
            CmbGenre.SelectedItem = null;
        }
        #endregion
        #region
        //Search Method
        //private void BtnSearch_Click_1(object sender, EventArgs e)
        //{
        //    CmbCombobox select = CmbGenre.SelectedItem as CmbCombobox;
        //    if (string.IsNullOrEmpty(TxtBookName.Text) &&
        //     string.IsNullOrEmpty(TxtAuthor.Text) &&
        //     CmbGenre.SelectedItem != null)
        //    {
        //        MessageBox.Show("Please fill at least one field");
        //        return;
        //    }
        //    var book = _context.Books
        //                            .Where(b => (TxtBookName.Text != string.Empty ? b.Name.Contains(TxtBookName.Text) : false))


        //                            .OrderBy(b => b.Name)
        //                            .ToList();

        //    DgvAddBooks.Rows.Clear();
        //    foreach (var item in book)
        //    {
        //        DgvAddBooks.Rows.Add(item.Id,
        //                             item.Name,
        //                             item.Author,
        //                             item.Genre.Name,
        //                             item.RentalPrice,
        //                             item.Count);
        //    }
            
        //}
        #endregion
        //private void BookForm_Load_1(object sender, EventArgs e)
        //{
        //    FillBooks();
        //}
        //Delete Method
        //private void BtnDelete_Click_1(object sender, EventArgs e)
        //{
        //    _context.Books.Remove(_book);
        //    _context.SaveChanges();
        //    FillBooks();
        //}    
        //Update
        //private void BtnUpdate_Click_1(object sender, EventArgs e)
        //{
        //    CmbCombobox select = CmbGenre.SelectedItem as CmbCombobox;
        //    Book book = _context.Books.Find(_book.Id);

        //    book.Name = TxtBookName.Text;
        //    book.Author = TxtAuthor.Text;
        //    book.Count = Convert.ToInt32(TxtCount.Text);
        //    book.RentalPrice = Convert.ToDouble(TxtRentalPrice.Text);
        //    book.GenreId = select.Id;

        //    _context.SaveChanges();
        //    FillBooks();
        //}
        //private void DgvAddBooks_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        //{
        //    CmbCombobox select = CmbGenre.SelectedItem as CmbCombobox;

        //    TxtBookName.Text = _book.Name;
        //    TxtAuthor.Text = _book.Author;
        //    TxtCount.Text = _book.Count.ToString();
        //    TxtRentalPrice.Text = _book.RentalPrice.ToString();
        //    Genre genre = _context.Genres.Find(_book.GenreId);
        //    CmbGenre.SelectedItem = new CmbCombobox
        //    {
        //        Id = genre.Id,
        //        Name = genre.Name
        //    };

        //    CmbGenre.Text = genre.Name;
        //}

        private void DgvAddBooks_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            _id = (int)DgvAddBooks.Rows[e.RowIndex].Cells[0].Value;
            _book = _context.Books.Find(_id);
        }

        private void BtnBookAdd_Click(object sender, EventArgs e)
        {
            CmbCombobox select = CmbGenre.SelectedItem as CmbCombobox;
            if (!string.IsNullOrEmpty(TxtBookName.Text) ||
             !string.IsNullOrEmpty(TxtAuthor.Text) ||
             !string.IsNullOrEmpty(CmbGenre.Text) ||
             !string.IsNullOrEmpty(TxtRentalPrice.Text) ||
             !string.IsNullOrEmpty(TxtCount.Text))
            {

                Book book = new Book//add book to database
                {
                    Name = TxtBookName.Text,
                    Author = TxtAuthor.Text,
                    GenreId = select.Id,
                    RentalPrice = Convert.ToDouble(TxtRentalPrice.Text),
                    Count = Convert.ToInt32(TxtCount.Text),
                };

                _context.Books.Add(book);
                _context.SaveChanges();
                Clear();


            }
            else
            {
                MessageBox.Show("Add,please");
            }
            FillBooks();

        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            CmbCombobox select = CmbGenre.SelectedItem as CmbCombobox;
            if (string.IsNullOrEmpty(TxtBookName.Text) &&
             string.IsNullOrEmpty(TxtAuthor.Text) &&
             CmbGenre.SelectedItem != null)
            {
                MessageBox.Show("Please fill at least one field");
                return;
            }
            var book = _context.Books
                                    .Where(b => (TxtBookName.Text != string.Empty ? b.Name.Contains(TxtBookName.Text) : false))


                                    .OrderBy(b => b.Name)
                                    .ToList();

            DgvAddBooks.Rows.Clear();
            foreach (var item in book)
            {
                DgvAddBooks.Rows.Add(item.Id,
                                     item.Name,
                                     item.Author,
                                     item.Genre.Name,
                                     item.RentalPrice,
                                     item.Count);
            }

        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            CmbCombobox select = CmbGenre.SelectedItem as CmbCombobox;
            Book book = _context.Books.Find(_book.Id);

            book.Name = TxtBookName.Text;
            book.Author = TxtAuthor.Text;
            book.Count = Convert.ToInt32(TxtCount.Text);
            book.RentalPrice = Convert.ToDouble(TxtRentalPrice.Text);
            book.GenreId = select.Id;

            _context.SaveChanges();
            FillBooks();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            _context.Books.Remove(_book);
            _context.SaveChanges();
            FillBooks();
            Clear();
        }

        private void BookForm_Load(object sender, EventArgs e)
        {
            FillBooks();
        }

        private void DgvAddBooks_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            CmbCombobox select = CmbGenre.SelectedItem as CmbCombobox;

            TxtBookName.Text = _book.Name;
            TxtAuthor.Text = _book.Author;
            TxtCount.Text = _book.Count.ToString();
            TxtRentalPrice.Text = _book.RentalPrice.ToString();
            Genre genre = _context.Genres.Find(_book.GenreId);
            CmbGenre.SelectedItem = new CmbCombobox
            {
                Id = genre.Id,
                Name = genre.Name
            };

            CmbGenre.Text = genre.Name;
        }
    }
    }
