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
        public DateTime borrowed;

        readonly public int loanPeriod = 0;
        readonly public DateTime dueDate;
        public bool isOverdue = false;
    }
}
