using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Assignmnt
{
    public class Book
    {
        private static string connectionString = "Data Source=AMIKZZ;Initial Catalog=project1;Integrated Security=True;Encrypt=False";
        SqlConnection connection = new SqlConnection(connectionString);

        private string bookTitle;
        private string bookAuthor;
        private int bookISBN;
        private bool bookAvailbility;
        static Library library = new Library();

        public Book()
        {
            // Default
        }

        public Book(string title, string author, int ISBN, bool availability)
        {
            bookTitle = title;
            bookAuthor = author;
            bookISBN = ISBN;
            bookAvailbility = availability;
        }

        public void setISBN(int ISBN)
        {
            bookISBN = ISBN;
        }

        public string BookTitle()
        {
            return bookTitle;
        }

        public int BookISBN()
        {
            return bookISBN;
        }   

        public void sqlInsert()
        {
            try
            {
                connection.Open();

                string querry = "select isbn from bookTable where isbn = '" + bookISBN + "'";
                SqlCommand command = new SqlCommand(querry, connection);
                SqlDataReader reader = command.ExecuteReader();


                if (reader.HasRows)
                {
                    MessageBox.Show("Book already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);    
                }
                else
                {
                    reader.Close();
                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.Connection = connection;
                    sqlCommand.CommandText = "INSERT INTO bookTable (title, author, isbn, available) VALUES ('" + bookTitle + "', '" + bookAuthor + "', " + bookISBN + ", " + Convert.ToByte(bookAvailbility) + ")";
                    sqlCommand.ExecuteNonQuery();

                    MessageBox.Show("Book added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Book book = new Book(bookTitle, bookAuthor, bookISBN, bookAvailbility);
                    library.addBook(book);
                }
            }
            catch(FormatException)
            {
                MessageBox.Show("Please enter valid details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception e)
            {
                MessageBox.Show($"{e}");
            }
            finally 
            {
                connection.Close(); 
            }
        }

        public void sqlDelete()
        {
            try
            {
                connection.Open();

                string querry = "select isbn from bookTable where isbn = '" + bookISBN + "'";
                SqlCommand command = new SqlCommand(querry, connection);
                SqlDataReader reader = command.ExecuteReader();


                if (reader.HasRows)
                {
                    reader.Close();

                    string querry2 = "select isbn from bookTable where isbn = '" + bookISBN + "' and available = '" + Convert.ToByte(false) + "'";
                    SqlCommand command2 = new SqlCommand(querry2, connection);
                    SqlDataReader reader2 = command2.ExecuteReader();

                    if (reader2.HasRows)
                    {
                        reader2.Close();
                        MessageBox.Show("Book is borrowed. Wait until it is returned to delete the book", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        reader2.Close();

                        SqlCommand sqlCommand = new SqlCommand();
                        sqlCommand.Connection = connection;
                        sqlCommand.CommandText = "delete from bookTable where isbn = " + bookISBN + "";
                        sqlCommand.ExecuteNonQuery();

                        MessageBox.Show("Book deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        library.removeBook(this);
                    }
                }
                else
                {
                    reader.Close();
                    MessageBox.Show("Book doesn't exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception e)
            {
                MessageBox.Show($"{e}");
            }
            finally
            {
                connection.Close();
            }
        }

        public void sqlBorrow(int memberID)
        {
            try
            {
                connection.Open();

                string querry = "select isbn from bookTable where isbn = '" + bookISBN + "'";
                SqlCommand command = new SqlCommand(querry, connection);
                SqlDataReader reader = command.ExecuteReader();


                if (reader.HasRows)
                {
                    reader.Close();

                    string querry2 = "select memberID from memberTable where memberID = '" + memberID + "'";
                    SqlCommand command2 = new SqlCommand(querry2, connection);
                    SqlDataReader reader2 = command2.ExecuteReader();

                    if (reader2.HasRows)
                    {
                        reader2.Close();

                        string querry3 = "select isbn from borrowTable where isbn = '" + bookISBN + "'";
                        SqlCommand command3 = new SqlCommand(querry3, connection);
                        SqlDataReader reader3 = command3.ExecuteReader();

                        if (reader3.HasRows)
                        {
                            reader3.Close();
                            MessageBox.Show("Book already borrowed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        else
                        {
                            reader3.Close();
                            SqlCommand sqlCommand = new SqlCommand();
                            sqlCommand.Connection = connection;
                            sqlCommand.CommandText = "update bookTable set available = 0 where isbn = " + bookISBN + "";
                            sqlCommand.ExecuteNonQuery();

                            sqlCommand.CommandText = "insert into borrowTable (isbn, memberID) values (" + bookISBN + ", " + memberID + ")";
                            sqlCommand.ExecuteNonQuery();

                            MessageBox.Show("Book borrowed successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            //Log Entry
                            string logEntry = "Borrowed";
                            sqlCommand.CommandText = "insert into logTable (date, description, isbn, memberId) values ('" + DateTime.Now.Date + "', '" + logEntry + "', '" + bookISBN + "', '" + memberID + "')";
                            sqlCommand.ExecuteNonQuery();

                        }
                    }
                    else
                    {
                        reader2.Close();
                        MessageBox.Show("Member doesn't exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                }
                else
                {
                    reader.Close();
                    MessageBox.Show("Book doesn't exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(FormatException)
            {
                MessageBox.Show("Please enter valid details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception e)
            {
                MessageBox.Show($"{e}");
            }
            finally
            {
                connection.Close();
            }
        }

        public void sqlReturn(int memberID)
        {
            try
            {
                connection.Open();

                string querry = "select isbn from borrowTable where isbn = '" + bookISBN + "' and memberID = '" + memberID + "'";
                SqlCommand command = new SqlCommand(querry, connection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Close();

                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.Connection = connection;
                    sqlCommand.CommandText = "update bookTable set available = 1 where isbn = " + bookISBN + "";
                    sqlCommand.ExecuteNonQuery();

                    sqlCommand.CommandText = "delete from borrowTable where isbn = " + bookISBN + " and memberID = " + memberID + "";
                    sqlCommand.ExecuteNonQuery();

                    MessageBox.Show("Book returned successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Log Entry
                    string logEntry = "Returned";
                    sqlCommand.CommandText = "insert into logTable (date, description, isbn, memberId) values ('" + DateTime.Now.Date + "', '" + logEntry + "', '" + bookISBN + "', '" + memberID + "')";
                    sqlCommand.ExecuteNonQuery();
                }
                else
                {
                    reader.Close();
                    MessageBox.Show("Book not borrowed by this member", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception e)
            {
                MessageBox.Show($"{e}");
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
