using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppCanvas.Objects
{
    public abstract class Data
    {
        public Guid ID { get; set; }
        public string name { get; set; }
        public Data(Guid ID, string name)
        {
            this.ID = ID;
            this.name = name;
        }
        public void showMajor()
        {
            Console.WriteLine("> ID   : " + this.ID);
            Console.WriteLine("> Name : " + this.name);
        }
    }
}
