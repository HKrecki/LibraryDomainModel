using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDomainModel
{
    interface IManage
    {
        public void AddBookItem(Book_Item newBook);
    }
}
