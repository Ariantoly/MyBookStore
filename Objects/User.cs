using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppCanvas.Objects
{
    public class User : Data
    {
        public string gender { get; set; }
        public User(Guid ID, string name, string gender) : base(ID, name)
        {
            this.gender = gender;
        }
        public void showUser()
        {
            base.showMajor();
            Console.WriteLine("Gender : " + this.gender);
        }
    }
}
