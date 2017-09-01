using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8._1
{
    class Program
    {
        struct Books
        {
            public string name;
            public string author;
            public int pages;
            public int id;
        }
        static void Main(string[] args)
        {
            Books book;

            //Task 8.1
            book.name = "To Kill a Mockingbird";
            book.author = "Harper Lee";
            book.pages = 400;
            book.id = 9785;

            /* Console.WriteLine("Book: " + book.name);
             Console.WriteLine("Author: " + book.author);
             Console.WriteLine("Amount of pages: " + book.pages);
             Console.WriteLine("ID: " + book.id);*/

            //Task 8.2

            Books[] books;
            books = new Books[4];

            books[0].name = "First book";
            books[0].author = "Petya";
            books[0].pages = 200;
            books[0].id = 1565;
            books[1].name = "Second book";
            books[1].author = "Vanya";
            books[1].pages = 560;
            books[1].id = 3548;
            books[2].name = "Third book";
            books[2].author = "Sasha";
            books[2].pages = 120;
            books[2].id = 3551;
            books[3].name = "Fourth book";
            books[3].author = "Nikolay";
            books[3].pages = 350;
            books[3].id = 1284;

            foreach (Books b in books)
            {
                Console.WriteLine("Name: " + b.name + "\nAuthor: " + b.author + "\nAmount of pages: " + b.pages + "\nID: " + b.id + "\n");
            }

            //Task 8.3
            int maxPages = 0;
            maxPages = books[0].pages;
            int count = 0;

            for (int i = 0; i < books.Length; i++)
            {
                if(books[i].pages > maxPages)
                {
                    maxPages = books[i].pages;
                    count = i;                   
                }              
            }
            Console.WriteLine("Book with max count of pages: " + maxPages + ", " + books[count].name);

            //Task 8.4
            int minID = 0;
            int maxID = 0;

            minID = books[0].id;
            maxID = books[0].id;

            for (int i = 0; i < books.Length; i++)
            {
                if (books[i].id < minID)
                {
                    minID = books[i].id;
                    count = i;
                }
                if(books[i].id > maxID)
                {
                    maxID = books[i].id;
                    count = i;
                }
            }
            Console.WriteLine("Min ID = {0}, Max ID = {1}", minID, maxID);

            //sorting
            Console.WriteLine("\nSorting by ID: ");
            for (int i = 0; i < books.Length; i++)
            {
                int a = i;
                minID = books[i].id;
                for(int j = i; j < books.Length; j++)
                {
                    if(books[j].id < minID)
                    {
                        minID = books[j].id;
                        a = j;
                    }
                }
                int b;
                b = books[i].id;
                books[i].id = books[a].id;
                books[a].id = b;

                Console.WriteLine(books[i].id);
            }
            
            Console.ReadLine();
        }
    }
}
