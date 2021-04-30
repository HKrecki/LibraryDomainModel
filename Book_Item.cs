using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDomainModel
{
    public class Book_Item : Book
    {
        public string barcode = "default";
        public string tag = "default"; // RFID
        public string title = "default";
        public bool isReferenceOnly = false;
        public Language lang = Language.English;
        public int numberOfPages = 0;
        public Format format = Format.Paperback;
        
        public DateTime borrowed = new DateTime(2008, 5, 1, 8, 30, 52);
        public int loanPeriod = -1;
        public DateTime dueDate = new DateTime(2008, 5, 1, 8, 30, 52);
        public bool isOverdue = false;
    }
}
