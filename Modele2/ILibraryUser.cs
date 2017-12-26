using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele2
{
    public interface ILibraryUser
    {
       
        void AddBook(string name, string author, int bookCounts);
        void RemoveBook(string name);
        void BookInfo(string name);
        void BookCount(string name);
        void ShoveAllBookInLib();
    }
}
