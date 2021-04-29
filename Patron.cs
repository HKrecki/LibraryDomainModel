using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDomainModel
{
    /* Student not an account in library system. Patron(student) can create account and
     * borrow/reserve bookItems
     */
    public class Patron
    {
        FullName name;
        Address address;

        Account patronAccount;

        /* Patron creates account in given library
         * - this account is assigned to this patron
         * - Account is added to library accounts list
         */
        public void CreateAccount(Library _library)
        {
            patronAccount = new Account();
            
            // Write all of the info of account there, without number

            _library.AddAccountToLibrarySystem(patronAccount);
        }

        public void SearchBook(Library _library ,string _bookName)
        {
            _library.libraryCatalog.SearchByBookName(_bookName);
        }

        public void Reserve(Library _library, string _bookName)
        {
            patronAccount.Reserve(_library ,_bookName);
        }

    }
}
