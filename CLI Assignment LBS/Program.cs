using CLI_Assignment_LBS;
using System;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;
using System.Transactions;


namespace Assignment
{
    class Program
    {
        public static Library library = new Library();
        public static string connectionString = "Data Source=AMIKZZ;Initial Catalog=project1;Integrated Security=True;Encrypt=False";
        public static SqlConnection connection = new SqlConnection(connectionString);

        static void Main(string[] args)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                string username;
                string passwd = "";
                bool loginSuccessful = false;
                bool cont = true;

                Console.WriteLine("----Library Management System----");
                Console.WriteLine();
                
                do
                {
                    Console.WriteLine("Enter Username: ");
                    username = Console.ReadLine();
                    Console.WriteLine("Enter Password: ");
                    passwd = Console.ReadLine();
                    Console.WriteLine();

                    string querry = "select userName,passwd from logInTable where userName = '" + username + "'";
                    SqlCommand command = new SqlCommand(querry, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read();
                        if (reader["passwd"].Equals(passwd))
                        {
                            loginSuccessful = true;
                            reader.Close();
                            Console.WriteLine("******* Login successfull ********");
                            Console.WriteLine();
                            do
                            {
                                Console.WriteLine("Select options \n" +
                                                  "1. Add books\n" +
                                                  "2. Remove books\n" +
                                                  "3. Add Members\n" +
                                                  "4. Remove Members\n" +
                                                  "5. Exit or (Just press Enter for Exit)");
                                Console.WriteLine("Enter the option number: ");
                                int n = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine();
                                if (n < 1 || n > 5)
                                {
                                    Console.WriteLine("Enter correct option number");
                                    Console.WriteLine("-----------------------------------------------------------");
                                    break;
                                }
                                else
                                {
                                    switch (n)
                                    {
                                        case 1:
                                            addBooksMain();
                                            cont = true;
                                            break;
                                        case 2:
                                            removeBookMain();
                                            cont = true;
                                            break;
                                        case 3:
                                            addMembersMain();
                                            cont = true;
                                            break;
                                        case 4:
                                            removeMembersMain();
                                            cont = true;
                                            break;
                                        case 5:
                                            cont = false;
                                            Environment.Exit(0);
                                            break;
                                    }
                                }
                            } while (cont == true);
                        }
                        else
                        {
                            Console.WriteLine("Wrong Password");
                            Console.WriteLine("-----------------------------------------------------------");
                            reader.Close();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Wrong Username");
                        Console.WriteLine("-----------------------------------------------------------");
                        reader.Close ();
                    }
                }
                while (!loginSuccessful);
            }
            catch (FormatException)
            {
                Console.WriteLine("Enter correct values");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex}");
            }
            finally
            {
                connection.Close();
            }
        }

        public static void addBooksMain()
        {
            char moreBooks;
            try
            {
                do
                {
                    Console.WriteLine("Enter book name: ");
                    string bookTitle = Console.ReadLine();
                    Console.WriteLine("Enter book author: ");
                    string author = Console.ReadLine();
                    Console.WriteLine("Enter book ISBN: ");
                    int isbn = Convert.ToInt32(Console.ReadLine());
                    Book book = new Book(bookTitle, author, isbn, true);
                    library.addBook(book);
                    Console.WriteLine();

                    try
                    {
                        if (connection.State == ConnectionState.Closed)
                        {
                            connection.Open();
                        }

                        string querry = "select isbn from bookTable where isbn = '" + isbn + "'";
                        SqlCommand command = new SqlCommand(querry, connection);
                        SqlDataReader reader = command.ExecuteReader();


                        if (reader.HasRows)
                        {
                            Console.WriteLine("Book already exists");
                            Console.WriteLine("-----------------------------------------------------------");
                            Console.WriteLine();
                            reader.Close();
                        }
                        else
                        {
                            reader.Close();
                            SqlCommand sqlCommand = new SqlCommand();
                            sqlCommand.Connection = connection;

                            sqlCommand.CommandText = "insert into bookTable (title,author,isbn,available) values ('" + bookTitle + "','" + author + "','" + isbn + "','" + true + "')";
                            sqlCommand.ExecuteNonQuery();

                            Console.WriteLine("Data saved successfully");
                            Console.WriteLine();
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine($"{e}");
                    }
                    finally { connection.Close(); }
                    Console.WriteLine("Do you want to add more books (Y or N): ");
                    moreBooks = Convert.ToChar(Console.ReadLine());
                    if (moreBooks == 'Y' || moreBooks == 'y')
                    {
                        continue;
                    }
                    else if (moreBooks == 'N' || moreBooks == 'n')
                    {
                        Console.WriteLine();
                        continue;
                    }
                    else
                    {
                        Console.WriteLine();
                        continue;
                    }
                }
                while (moreBooks == 'Y' || moreBooks == 'y');
            }
            catch (FormatException)
            {
                Console.WriteLine("Enter correct value");
                Console.WriteLine();
            }
            catch (Exception e)
            {
                Console.WriteLine($"{e}");
            }
        }

        public static void removeBookMain()
        {
            char moreBooks;
            try
            {
                do
                {
                    Console.WriteLine("Enter book name: ");
                    string bookTitle = Console.ReadLine();
                    Console.WriteLine("Enter book ISBN: ");
                    int isbn = Convert.ToInt32(Console.ReadLine());
                    Book book = new Book(bookTitle, isbn);

                    Console.WriteLine();
                    try
                    {
                        if (connection.State == ConnectionState.Closed)
                        {
                            connection.Open();
                        }

                        SqlCommand sqlCommand = new SqlCommand();
                        sqlCommand.Connection = connection;

                        string querry = "select isbn from bookTable where title = '" + bookTitle + "' and isbn = '" +isbn+ "'";
                        SqlCommand command = new SqlCommand(querry, connection);
                        SqlDataReader reader = command.ExecuteReader();

                        if (!reader.HasRows)
                        {
                            Console.WriteLine("Book does not exist");
                        }
                        else
                        {
                            reader.Close(); 
                            
                            sqlCommand.CommandText = "delete from bookTable where title = '" + bookTitle + "' and isbn = '" + isbn + "'";
                            sqlCommand.ExecuteNonQuery();

                            Console.WriteLine("Data deleted successfully");
                            library.removeBook(book);
                            Console.WriteLine();
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine($"{e}");
                    }
                    finally { connection.Close(); }

                    Console.WriteLine("Do you want to remove more books (Y or N): ");
                    moreBooks = Convert.ToChar(Console.ReadLine());

                    if (moreBooks == 'Y' || moreBooks == 'y')
                    {
                        continue;
                    }
                    else if (moreBooks == 'N' || moreBooks == 'n')
                    {
                        Console.WriteLine();
                        continue;
                    }
                    else
                    {
                        Console.WriteLine();
                        continue;
                    }
                }
                while (moreBooks == 'Y' || moreBooks == 'y');
            }
            catch (FormatException)
            {
                Console.WriteLine("Enter correct value");
                Console.WriteLine();
            }
            catch (Exception e)
            {
                Console.WriteLine($"{e}");
            }
        }

        public static void addMembersMain()
        {
            char moreMembers;
            try
            {
                do
                {
                    Console.WriteLine("Enter member name: ");
                    string memberName = Console.ReadLine();
                    Console.WriteLine("Enter member age: ");
                    int memberAge = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter member ID: ");
                    int memberId = Convert.ToInt32(Console.ReadLine());
                    Member member = new Member(memberName,memberAge ,memberId);
                    
                    Console.WriteLine();
                    try
                    {
                        if (connection.State == ConnectionState.Closed)
                        {
                            connection.Open();
                        }

                        string querry = "select memberId from memberTable where memberId = '" + memberId + "'";
                        SqlCommand command = new SqlCommand(querry, connection);
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.HasRows)
                        {
                            Console.WriteLine("Member already exists");
                            Console.WriteLine("-----------------------------------------------------------");
                            Console.WriteLine();
                            reader.Close();
                        }
                        else
                        {
                            reader.Close();
                            SqlCommand sqlCommand = new SqlCommand();
                            sqlCommand.Connection = connection;

                            sqlCommand.CommandText = "insert into memberTable (memberName,memberAge,memberID) values ('" + memberName + "','" + memberAge + "','" + memberId + "')";
                            sqlCommand.ExecuteNonQuery();

                            Console.WriteLine("Data saved successfully");
                            library.addMember(member);
                            Console.WriteLine();
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine($"{e}");
                    }
                    finally { connection.Close(); }

                    Console.WriteLine("Do you want to add more members (Y or N): ");
                    moreMembers = Convert.ToChar(Console.ReadLine());

                    if (moreMembers == 'Y' || moreMembers == 'y')
                    {
                        continue;
                    }
                    else if (moreMembers == 'N' || moreMembers == 'n')
                    {
                        Console.WriteLine();
                        continue;
                    }
                    else
                    {
                        Console.WriteLine();
                        continue;
                    }
                }
                while (moreMembers == 'Y' || moreMembers == 'y');
            }
            catch (FormatException)
            {
                Console.WriteLine("Enter correct values");
                Console.WriteLine();
            }
            catch (Exception e)
            {
                Console.WriteLine($"{e}");
            }
        }

        public static void removeMembersMain()
        {
            char moreMembers;
            try
            {
                do
                {
                    Console.WriteLine("Enter member name: ");
                    string memberName = Console.ReadLine();
                    Console.WriteLine("Enter member ID: ");
                    int memberId = Convert.ToInt32(Console.ReadLine());
                    Member member = new Member(memberName, memberId);
                    Console.WriteLine();

                    try
                    {
                        if (connection.State == ConnectionState.Closed)
                        {
                            connection.Open();
                        }

                        SqlCommand sqlCommand = new SqlCommand();
                        sqlCommand.Connection = connection;

                        string querry = "select memberId from memberTable where memberName = '" + memberName + "' and memberID = '" + memberId + "'";
                        SqlCommand command = new SqlCommand(querry, connection);
                        SqlDataReader reader = command.ExecuteReader();

                        if (!reader.HasRows)
                        {
                            reader.Close();
                            Console.WriteLine("Member does not exist");
                        }
                        else
                        {
                            reader.Close();

                            sqlCommand.CommandText = "delete from memberTable where memberName = '" + memberName + "' and memberID = '" + memberId + "'";
                            sqlCommand.ExecuteNonQuery();

                            Console.WriteLine("Data deleted successfully");
                            library.removeMember(member);
                            Console.WriteLine();
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine($"{e}");
                    }
                    finally { connection.Close(); }

                    Console.WriteLine("Do you want to remove more members (Y or N): ");
                    moreMembers = Convert.ToChar(Console.ReadLine());

                    if (moreMembers == 'Y' || moreMembers == 'y')
                    {
                        continue;
                    }
                    else if (moreMembers == 'N' || moreMembers == 'n')
                    {
                        Console.WriteLine();
                        continue;
                    }
                    else
                    {
                        Console.WriteLine();
                        continue;
                    }
                }
                while (moreMembers == 'Y' || moreMembers == 'y');
            }
            catch (FormatException)
            {
                Console.WriteLine("Enter correct values");
                Console.WriteLine();
            }
            catch (Exception e)
            {
                Console.WriteLine($"{e}");
            }
        }
    }
}