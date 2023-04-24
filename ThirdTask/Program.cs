using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter the size of the List");
            num = Int32.Parse(Console.ReadLine());
            int n = 0;

            // Declare Library Array
            Library LibraryExample = new Library();


            // Loop Initialization Library Array 
            while (n < num)
            {
                LibraryExample.Put();
                n++;
            }

            while (true)
            {
                int UserChoice;
                Console.WriteLine("1. Add One Book");
                Console.WriteLine("2. Add Array of Books");
                Console.WriteLine("3. Add List of Books");
                Console.WriteLine("4. Show All Books");
                Console.WriteLine("5. Show At Index Book");
                Console.WriteLine("6. Remove At Index Book");
                Console.WriteLine("7. Change At Index Book");
                Console.WriteLine("8. Find by Parametres Book");
                Console.WriteLine("9. Add to First Book");
                Console.WriteLine("10. Add to Last Book");
                Console.WriteLine("11. Add to Index Book");
                Console.WriteLine("12. Remove First Book");
                Console.WriteLine("13. Remove Last Book");
                Console.WriteLine("14. Remove At Index Book");
                UserChoice = Int32.Parse(Console.ReadLine());
                switch (UserChoice)
                {
                    case 1:
                        LibraryExample.Put();
                        break;
                    case 2:
                        Console.WriteLine("Enter the size of the Array");
                        Book[] BookArray = new Book[1];
                        BookArray[0] = new Book("Hello", "World", "Svit", 2020);
                        LibraryExample.PutArray(BookArray);
                        break;
                    case 3:
                        Console.WriteLine("Enter the size of the List");
                        LinkedList<Book> BooksList = new LinkedList<Book>();
                        BooksList.AddLast(new Book("Hello", "World", "Svit", 2020));
                        LibraryExample.PutList(BooksList);
                        break;
                    case 4:
                        LibraryExample.Print();
                        break;
                    case 5:
                        Console.WriteLine("Enter Index");
                        int index;
                        index = Int32.Parse(Console.ReadLine());
                        LibraryExample.ShowAt(index);
                        break;
                    case 6:
                        Console.WriteLine("Enter Remove Index");
                        int Removeindex;
                        Removeindex = Int32.Parse(Console.ReadLine());
                        LibraryExample.RemoveAt(Removeindex);
                        break;
                    case 7:
                        Console.WriteLine("Enter Remove Index");
                        int ChangeIndex;
                        ChangeIndex = Int32.Parse(Console.ReadLine());
                        LibraryExample.ChangeAt(ChangeIndex);
                        break;
                    case 8:
                        LibraryExample.FindByParam();
                        break;
                    case 9:
                        LibraryExample.AddFirst();
                        break;
                    case 10:
                        LibraryExample.AddLast();
                        break;
                    case 11:
                        Console.WriteLine("Enter Add Index");
                        int AddIndex;
                        AddIndex = Int32.Parse(Console.ReadLine());
                        LibraryExample.AddAt(AddIndex);
                        break;
                    case 12:
                        LibraryExample.RemoveFirst();
                        break;
                    case 13:
                        LibraryExample.RemoveLast();
                        break;
                    case 14:
                        break;
                }
            }
        }
    }


    class Book
    {
        public string BookName_;
        public string AuthorName_;
        public string BookGenre_;
        public int BookYear;

        public Book(string bookName_, string authorName_, string bookGenre_, int bookYear)
        {
            BookName_ = bookName_;
            AuthorName_ = authorName_;
            BookGenre_ = bookGenre_;
            BookYear = bookYear;
        }

        public Book()
        {
            BookName_ = "";
            AuthorName_ = "";
            BookGenre_ = "";
            BookYear = 0;
        }


    }



    class Library
    {
        public LinkedList<Book> Books_ = new LinkedList<Book>();

        // Constructor by Parametres


        public Library()
        {

        }

        public void Put()
        {
            Book temp = new Book();

            Console.WriteLine("Name: ");
            temp.BookName_ = Console.ReadLine();

            Console.WriteLine("Author: ");
            temp.AuthorName_ = Console.ReadLine();

            Console.WriteLine("Genre: ");
            temp.BookGenre_ = Console.ReadLine();

            Console.WriteLine("Year: ");
            temp.BookYear = Int32.Parse(Console.ReadLine());

            Books_.AddLast(temp);
        }


        public void RemoveFirst()
        {
            Books_.RemoveFirst();
        }

        public void RemoveLast()
        {
            Books_.RemoveLast();
        }

        public void AddAt(int index)
        {
            if (index >= Books_.Count)
            {
                Console.WriteLine("Index out of List");
                return;
            }

            Book temp = new Book();

            Console.WriteLine("Name: ");
            temp.BookName_ = Console.ReadLine();

            Console.WriteLine("Author: ");
            temp.AuthorName_ = Console.ReadLine();

            Console.WriteLine("Genre: ");
            temp.BookGenre_ = Console.ReadLine();

            Console.WriteLine("Year: ");
            temp.BookYear = Int32.Parse(Console.ReadLine());

            Books_.AddAfter(FindBook(index), temp);
        }

        public LinkedListNode<Book> FindBook(int index)
        {
            LinkedListNode<Book> first = Books_.First;
            for (int i = 0; i < index; i++)
            {
                first = first.Next;
            }
            return first;
        }

        public void AddFirst()
        {
            Book temp = new Book();

            Console.WriteLine("Name: ");
            temp.BookName_ = Console.ReadLine();

            Console.WriteLine("Author: ");
            temp.AuthorName_ = Console.ReadLine();

            Console.WriteLine("Genre: ");
            temp.BookGenre_ = Console.ReadLine();

            Console.WriteLine("Year: ");
            temp.BookYear = Int32.Parse(Console.ReadLine());

            Books_.AddFirst(temp);
        }

        public void AddLast()
        {
            Book temp = new Book();

            Console.WriteLine("Name: ");
            temp.BookName_ = Console.ReadLine();

            Console.WriteLine("Author: ");
            temp.AuthorName_ = Console.ReadLine();

            Console.WriteLine("Genre: ");
            temp.BookGenre_ = Console.ReadLine();

            Console.WriteLine("Year: ");
            temp.BookYear = Int32.Parse(Console.ReadLine());

            Books_.AddLast(temp);
        }
        public void ShowAt(int index)
        {
            if (index >= Books_.Count)
            {
                Console.WriteLine("Index out of List");
                return;
            }
            Console.WriteLine("Name: ");
            Console.WriteLine(Books_.ElementAt(index).AuthorName_);
            Console.WriteLine("Book: ");
            Console.WriteLine(Books_.ElementAt(index).BookName_);
            Console.WriteLine("Genre: ");
            Console.WriteLine(Books_.ElementAt(index).BookGenre_);
            Console.WriteLine("Year: ");
            Console.WriteLine(Books_.ElementAt(index).BookYear);
        }

        public void FindByParam()
        {
            int index;
            Console.WriteLine("Enter index of Search field: ");
            Console.WriteLine("0. Name ");
            Console.WriteLine("1. Book ");
            Console.WriteLine("2. Genre ");
            Console.WriteLine("3. Year ");
            index = Int32.Parse(Console.ReadLine());
            switch (index)
            {
                case 0:
                    Console.WriteLine("Enter Name: ");
                    string tempName;
                    tempName = Console.ReadLine();
                    for (int i = 0; i < Books_.Count; i++)
                    {
                        if (String.Equals(tempName, Books_.ElementAt(i).AuthorName_))
                            Console.WriteLine($"Name: {tempName} At Index {i}.");
                    }
                    break;
                case 1:
                    Console.WriteLine("Enter Book: ");
                    string tempBook;
                    tempBook = Console.ReadLine();
                    for (int i = 0; i < Books_.Count; i++)
                    {
                        if (String.Equals(tempBook, Books_.ElementAt(i).BookName_))
                            Console.WriteLine($"Book: {tempBook} At Index {i}.");
                    }
                    break;
                case 2:
                    Console.WriteLine("Enter Genre: ");
                    string tempGenre;
                    tempGenre = Console.ReadLine();
                    for (int i = 0; i < Books_.Count; i++)
                    {
                        if (String.Equals(tempGenre, Books_.ElementAt(i).BookGenre_))
                            Console.WriteLine($"Genre: {tempGenre} At Index {i}.");
                    }
                    break;
                case 3:
                    Console.WriteLine("Enter Year: ");
                    int tempYear;
                    tempYear = Int32.Parse(Console.ReadLine());
                    for (int i = 0; i < Books_.Count; i++)
                    {
                        if (String.Equals(tempYear, Books_.ElementAt(i).BookYear))
                            Console.WriteLine($"Year: {tempYear} At Index {i}.");
                    }
                    break;
            }
        }
        public void RemoveAt(int index)
        {
            if (index >= Books_.Count)
            {
                Console.WriteLine("Index out of List");
                return;
            }
            LinkedListNode<Book> currentNode = Books_.First;
            for (int i = 0; i <= index && currentNode != null; i++)
            {
                if (i != index)
                {
                    currentNode = currentNode.Next;
                    continue;
                }

                Books_.Remove(currentNode);
            }
        }

        public void ChangeAt(int index)
        {
            if (index >= Books_.Count)
            {
                Console.WriteLine("Index out of List");
                return;
            }
            Console.WriteLine("Name: ");
            Books_.ElementAt(index).AuthorName_ = Console.ReadLine();
            Console.WriteLine("Book: ");
            Books_.ElementAt(index).BookName_ = Console.ReadLine();
            Console.WriteLine("Genre: ");
            Books_.ElementAt(index).BookGenre_ = Console.ReadLine();
            Console.WriteLine("Year: ");
            Books_.ElementAt(index).BookYear = Int32.Parse(Console.ReadLine());
        }
        public void PutArray(Book[] BookArray)
        {

            for (int i = 0; i < BookArray.Length; i++)
            {
                Books_.AddLast(BookArray[i]);
            }
        }

        public void PutList(LinkedList<Book> BookList)
        {
            for (int i = 0; i < BookList.Count; i++)
            {
                Books_.AddLast(BookList.ElementAt(i));
            }
        }

        // Index Operator
        public Book this[int index]
        {
            get
            {
                return FindBook(index).Value;
            }
            set
            {
                FindBook(index).Value = value;
            }
        }

        public static Library operator ++(Library list)
        {
            list.Put();
            return list;
        }

        public static Library operator --(Library list)
        {
            Console.WriteLine("Enter Index To Remove: ");
            int index;
            index = Int32.Parse(Console.ReadLine());
            list.RemoveAt(index);
            return list;
        }


        // Display City Fields 
        public void Print()
        {
            for (int i = 0; i < Books_.Count; i++)
            {
                Console.WriteLine("Name: ");
                Console.WriteLine(Books_.ElementAt(i).BookName_);
                Console.WriteLine("Author: ");
                Console.WriteLine(Books_.ElementAt(i).AuthorName_);
                Console.WriteLine("Genre: ");
                Console.WriteLine(Books_.ElementAt(i).BookGenre_);
                Console.WriteLine("Year: ");
                Console.WriteLine(Books_.ElementAt(i).BookYear);
            }
        }
    }
}

