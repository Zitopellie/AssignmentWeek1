using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace Milestone_project_4
{
    public class Library
    {
        string libraryName;
        List<Books> books;
        public Library()
        {
            libraryName = "";
            books = new List<Books>();
        }

        public Library(string LibraryName, List<Books> Books)
        {
            libraryName = LibraryName;
            books = Books;
        }

        public void AddToLibrary(Books bookToAdd)
        {
            books.Add(bookToAdd);
        }

        public int SearchByAuthor(string author)
        {
            
            foreach(var book  in books)
            {
                if(book.Author == author)
                {
                    Console.WriteLine("book was found at position" +books.IndexOf(book));
                    return books.IndexOf(book);
                }

                
            }
            return -1;
        }


        public int SearchBytitlestring(string title)
        {

            foreach (var book in books)
            {
                if (book.Title == title)
                {
                    Console.WriteLine("book was found at position" + books.IndexOf(book));
                    return books.IndexOf(book);
                }


            }
            return -1;
        }

        public void DeleteBook(string title)
        {
            foreach (var book in books)
            {
                if (book.Title == title)
                {
                     books.Remove(book);
                       
                }


            }
        }
    }
}
