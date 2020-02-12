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
        private readonly LibraryDbContext _context;
        public BookForm()
        {
            
            InitializeComponent();
            _context = new LibraryDbContext();
            FillBooks();
            Combo();
        }
        private void FillBooks()
        {
            var ShowBook = _context.Books.ToList();
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
         private void Combo()
        {
            var ComboBox = _context.Genres.ToList();
            foreach (var item in ComboBox)
            {
                CmbGenre.Items.Add(item.Name);
            }
        }

        private void BtnBookAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtBookName.Text) ||
             !string.IsNullOrEmpty(TxtAuthor.Text) ||
             //!string.IsNullOrEmpty(CmbGenre.Text) ||
             !string.IsNullOrEmpty(TxtRentalPrice.Text) ||
             !string.IsNullOrEmpty(TxtCount.Text))

            


            {
                //foreach (Genre item in genre)
                //{
                //    CmbGenre.Items.Add("Name");
                //}
                Book book = new Book//add book to database
                {
                    Name = TxtBookName.Text,
                    Author = TxtAuthor.Text,
                    //Genre = Combo(),
                    RentalPrice = Convert.ToDouble(TxtRentalPrice.Text),
                    Count = Convert.ToInt32(TxtCount.Text),


                };

                _context.Books.Add(book);
                _context.SaveChanges();
            }
            else
            {
                MessageBox.Show("Add,please");
            }
            DgvAddBooks.Rows.Clear();
            FillBooks();

        }//User create method

       
        //User search method

        private void BtnSearch_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtBookName.Text) &&
              string.IsNullOrEmpty(TxtAuthor.Text) &&
              //string.IsNullOrEmpty(CmbGenre.Text) &&
              string.IsNullOrEmpty(TxtRentalPrice.Text) &&
              string.IsNullOrEmpty(TxtCount.Text))



            {
                MessageBox.Show("Add Name, Author, RentalPrice or Count");
                return;
            }
            var book = _context.Books
                                    .Where(b => (TxtBookName.Text != string.Empty ? b.Name.Contains(TxtBookName.Text) : false) ||
                                                            (TxtAuthor.Text != string.Empty ? b.Author.Contains(TxtAuthor.Text) : false) 
                                                            //(CmbGenre.Text != string.Empty ? b.Genre.Contains(CmbGenre.Text) : false) ||
                                                            //(TxtBookName.Text != string.Empty ? b.Name.Contains(TxtBookName.Text) : false) ||


                                                            
                                   
 ).ToList();
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
        //public class ComboboxItem
        //{
        //    public string Text { get; set; }
        //    public int Value { get; set; }

        //    public override string ToString()
        //    {
        //        return Text;
        //    }
        //}




        private void BookForm_Load(object sender, EventArgs e)
            {
                List<Genre> genres = _context.Genres.ToList();
                CmbGenre.Items.AddRange(genres.ToArray());
            }

       
    }
    }
