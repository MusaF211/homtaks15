using System;

namespace HomTask
{
    class Program
    {
        static void Main(string[] args)
        {
            ILibraryManager_interface libraryManager_Interface = new ILibraryManager_interface();
            libraryManager_Interface.Books.Add(new Book("CSharp", "Andres Helsber", 500));
            libraryManager_Interface.Books.Add(new Book("Sefiller", "Viktor Hugo", 500));
            libraryManager_Interface.Books.Add(new Book("Xemse", "Nizami Gencevi", 500));
            libraryManager_Interface.Books.Add(new Book("IskandarName", "Nizami Gencevi", 500));
            libraryManager_Interface.Books.Add(new Book("Himini", "Ehmed Cavad", 500));
            libraryManager_Interface.Books.Add(new Book("Musiqisi", "Uzeyr Hacibeyov", 500));
            libraryManager_Interface.Books.Add(new Book("CSharp", "Andres Helsber", 500));


            libraryManager_Interface.RemoveAllBookByName("IskandarName");



            foreach (var item in libraryManager_Interface.SearchBooks("Niz"))
            {
                Console.WriteLine(item);
            }
        }
    }
}
