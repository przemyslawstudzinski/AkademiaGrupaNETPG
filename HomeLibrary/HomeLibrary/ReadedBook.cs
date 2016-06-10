using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeLibrary
{
    public class ReadedBook : Book, IComparable
    {
        public Mark MyMark { get; set; }
        public ReadedBook(string author, string title, string year, int numberOfPages, Mark myMark) 
            : base(author, title, year, numberOfPages)
        {
            this.MyMark = myMark;
        }

        public int CompareTo(object otherBook)
        {
            ReadedBook otherReadedBook = otherBook as ReadedBook;
            if(otherReadedBook == null)
            {
                return 1;
            }
            if (this.MyMark > otherReadedBook.MyMark)
            {
                return -1;
            }
            else if (this.MyMark < otherReadedBook.MyMark)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    
    }
}
