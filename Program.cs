using ConsoleAppCanvas.Objects;
using System;
using System.Collections.Generic;

namespace ConsoleAppCanvas
{
    class Program
    {
        static List<Book> bookList = new List<Book>();
        static List<User> userList = new List<User>();
        static void Main(string[] args)
        {
            int choice = 9;
            while (true)
            {
                Console.Clear();
                menu();
                choice = int.Parse(Console.ReadLine());
                if (choice == 1) insertBook();
                if (choice == 2) viewBook();
                if (choice == 3) insertUser();
                if (choice == 4) viewUser();
                if (choice == 5) deleteBook();
                if (choice == 6) deleteUser();
                if (choice == 0) break;
            }
            Console.Clear();
        }
        static void menu()
        {
            Console.WriteLine("+++++++++++++++++");
            Console.WriteLine("+ My Book Store +");
            Console.WriteLine("+++++++++++++++++\n");
            Console.WriteLine("1. Insert Book\n2. View Book\n3. Insert User\n4. View User\n5. Delete Book\n6. Delete User\n0. Exit");
            Console.Write("-> ");
        }
        static void insertBook()
        {
            string name, author;
            Guid ID = Guid.NewGuid();
            Console.Write("Name : ");
            name = Console.ReadLine();
            Console.Write("Author : ");
            author = Console.ReadLine();
            bookList.Add(new Book(ID, name, author));
            Console.WriteLine("Book Added !");
            Console.WriteLine("\n\nPress Enter to continue . . .");
            Console.ReadKey();
        }
        static void insertUser()
        {
            string name, gender;
            Guid ID = Guid.NewGuid();
            Console.Write("Name : ");
            name = Console.ReadLine();
            Console.Write("Gender : ");
            gender = Console.ReadLine();
            userList.Add(new User(ID, name, gender));
            Console.WriteLine("User Added !");
            Console.WriteLine("\n\nPress Enter to continue . . .");
            Console.ReadKey();
        }
        static void viewBook()
        {
            foreach (var x in bookList)
            {
                x.showBook();
                Console.WriteLine();
            }
            Console.WriteLine("\n\nPress Enter to continue . . .");
            Console.ReadKey();
        }
        static void viewUser()
        {
            foreach (var x in userList)
            {
                x.showUser();
                Console.WriteLine();
            }
            Console.WriteLine("\n\nPress Enter to continue . . .");
            Console.ReadKey();
        }
        static bool deleteBook()
        {
            Console.WriteLine("Enter Book ID : ");
            Guid todel = Guid.Parse(Console.ReadLine());
            bool isDelete = false;
            foreach (var x in bookList)
            {
                if (x.ID == todel)
                {
                    bookList.Remove(x);
                    isDelete = true;
                    break;
                }
            }
            if (isDelete) { Console.WriteLine("Book Deleted!"); }
            else { Console.WriteLine("nothing happened"); }

            Console.WriteLine("\n\nPress Enter to continue . . .");
            Console.ReadKey();
            return isDelete;
        }
        static bool deleteUser()
        {
            Console.WriteLine("Enter User ID : ");
            Guid todel = Guid.Parse(Console.ReadLine());
            bool isDelete = false;
            foreach (var x in userList)
            {
                if (x.ID == todel)
                {
                    userList.Remove(x);
                    isDelete = true;
                    break;
                }
            }
            if (isDelete) { Console.WriteLine("User Deleted!"); }
            else { Console.WriteLine("nothing happened"); }

            Console.WriteLine("\n\nPress Enter to continue . . .");
            Console.ReadKey();
            return isDelete;
        }
    }
}
