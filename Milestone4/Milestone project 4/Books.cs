using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milestone_project_4
{
    public class Books
    {
        string title, author, publisher;
        int yearOfPublishing, iSBN;

        public string Author
        { 
            get { return author; }
        }

        public string Title
        {
            get { return title; }   
        }
        public Books()
        {
            title = author = publisher = "";
            yearOfPublishing = iSBN = 0;    
        }

        public Books(string title, string author, string publisher, int yearOfPublishing, int iSBN)
        {
            this.title = title;
            this.author = author;
            this.publisher = publisher;
            this.yearOfPublishing = yearOfPublishing;
            this.iSBN = iSBN;
        }
    }

}
