using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDomainModel
{
    public class Patron
    {
        FullName name;
        Address address;

        Account patronAccount;


        public Patron(string _firstName, string _lastName, string _city, string _street, string _postalcode)
        {
            name.firstName = _firstName;
            name.lastName = _lastName;

            address.city = _city;
            address.street = _street;
            address.postalCode = _postalcode;
        }

        /* Patron creates account in given library
         */
        public void CreateAccount(Library _library)
        {
            patronAccount = new Account(_library);
        }

        public void SearchBook(Library _library ,string _bookName)
        {
            _library.libraryCatalog.SearchByBookName(_bookName);
        }

        public void Reserve(Library _library, string _bookName)
        {
            patronAccount.Reserve(_library ,_bookName);
        }


        public void Borrow(Library _library, string _bookName, int _timeInDays)
        {
            patronAccount.Borrow(_library, _bookName, _timeInDays);
        }
        

    }
}
