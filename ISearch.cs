using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDomainModel
{
    interface ISearch
    {
        public void SearchByISBN(string _ISBN);
        public void SearchByBookName(string _bookName);
    }
}
