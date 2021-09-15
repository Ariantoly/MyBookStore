using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppCanvas.Objects
{
    public class Book : Data
    {
        public string author { get; set; }
        public Book(Guid ID, string name, string author) : base(ID, name)
        {
            this.author = author;
        }
        public void showBook()
        {
            base.showMajor();
            Console.WriteLine("Author : " + this.author);
        }
    }
}
