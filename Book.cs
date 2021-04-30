using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDomainModel
{
    public class Book
    {
        public string ISBN = "default" ;
        public string name = "default" ;
        
        public string subject = "default";
        public string overview = "default";
        public string publisher = "default";
        public DateTime publicationDate;
        public string lang = "default";

        Author author;
    }
}
