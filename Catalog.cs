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
        public Dictionary<string, Book_Item> bookItemCatalog = new Dictionary<string, Book_Item>();

        /*
         * Add bookitem to catalog
         * method from interface IManage
         */
        public void AddBookItem(Book_Item newBook)
        {
            // Add book to catalog -> method from Dictionary class
            bookItemCatalog.Add(newBook.ISBN, newBook);

            // test
            Console.WriteLine(newBook.ISBN);
        }

        /*
         * Check book of given ISBN exists in catalog
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
