using System;
using System.Collections.Generic;
using System.Text;

namespace HomTask
{
    class ILibraryManager_interface
    {
        public List<Book> Books;

        public ILibraryManager_interface()
        {
            Books = new List<Book>();
        }

        public List<Book> FindAllBooksByName(string val)
        {
          
            return Books.FindAll(b => b.Name.ToLower().Contains(val.ToLower().Trim()));
        }

        public void RemoveAllBookByName(string val)
        {
            Books.RemoveAll(b => b.Name.ToLower().Contains(val.ToLower().Trim()));
        }

        public List<Book> SearchBooks(string search) 
        {
            return Books.FindAll(b => b.Name.ToLower().Contains(search.ToLower().Trim()) ||
           b.AuthorName.ToLower().Contains(search.ToLower().Trim()) ||
           b.PageCount.ToString().Contains(search.ToString().Trim()));
         
        }
        public List<Book> FindAllBookByPageCountRang(int min, int max) 
        {
            return Books.FindAll(b => b.PageCount >= min && b.PageCount <= max);
        }

        public void RemoveByNo(string code)
        {
            Book book = Books.Find(b=>b.Code.ToLower() == code.ToLower().Trim());

            if (book != null)
            {
                Books.Remove(book);
                return;
            }

            Console.WriteLine("Daxil Edilen Code-da kitab Tapilmadi.");
               
        }


    }
}
