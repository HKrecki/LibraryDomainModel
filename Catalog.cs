using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Implpementacja interfejsu manage

namespace LibraryDomainModel
{
    public class Catalog : IManage, ISearch
    {
        string catalogName;

        public Dictionary<string, Book_Item> bookItemCatalog = new Dictionary<string, Book_Item>();

        public Catalog() { }
        public Catalog(string _catalogName) { catalogName = _catalogName; }

        /*
         * Add bookitem to catalog
         * method from interface IManage
         */
        public void AddBookItem(Book_Item newBook)
        {
            // Add book to catalog -> method from Dictionary class
            bookItemCatalog.Add(newBook.ISBN, newBook);

            // test
            // Console.WriteLine(newBook.ISBN);
        }


        // Interfeace ISearch //

        // TODO: Search in library not in catalog, because library have only 1 catalog
        /* Check book of given ISBN exists in catalog
         * Method from interface ISearch
         */
        public void SearchByISBN(string _ISBN)
        {
            foreach (var item in bookItemCatalog)
            {
                if(item.Key == _ISBN)
                {
                    Console.WriteLine($"Found book of ISBN: {_ISBN}");
                }
            }
        }
        /* Check book of given name exists in library
         * 
         */
        public void SearchByBookName(string _bookName)
        {
            foreach (var item in bookItemCatalog)
            {
                if(item.Value.name == _bookName)
                {
                    Console.WriteLine($"Found book of name: {_bookName}");
                }
            }
        }





        /*
         * Get number of bookitems in catalog
         * debug method
         */
        public int GetNumberOfBookitems()
        {
            return bookItemCatalog.Count();
        }


    }
}
