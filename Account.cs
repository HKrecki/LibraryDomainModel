using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDomainModel
{
    public class Account
    {
        public int number;
        History history;
        DateTime opened;
        AccountState state;
        struct History
        {
            int numberOfAllBooks;
        } // TODO: delete or change, whtvr

        // Reserve 
        public void Reserve(Library _library, string _bookName)
        {
            foreach (var item in _library.libraryCatalog.bookItemCatalog)
            {
                if( item.Value.name == _bookName ) // TODO and if book status is free
                {
                    // Change book status to reserved
                }
                else
                {
                    // Show theres no books like this or all of this book are
                    // borrowed or reserved
                }
            }

        }

    }
}
