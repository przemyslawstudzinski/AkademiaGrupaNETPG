using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeLibrary
{
    public class BookToRead : Book, IComparable
    {
        public Priority PriorityToRead { get; set; }
        public BookToRead(string author, string title, string year, int numberOfPages, Priority priorityToRead) 
            : base(author, title, year, numberOfPages)
        {
            this.PriorityToRead = priorityToRead;
        }

        public int CompareTo(object otherBook)
        {
            BookToRead otherBookToRead = otherBook as BookToRead;
            if(otherBookToRead == null)
            {
                return -1;
            }
            if(this.PriorityToRead > otherBookToRead.PriorityToRead)
            {
                return 1;
            }
            else if(this.PriorityToRead < otherBookToRead.PriorityToRead)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

    }
}
