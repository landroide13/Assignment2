using System;
using System.Collections.Generic;

namespace First
{
    class Program
    {

        static List<Customer> customers = new List<Customer>();

        static void LiDisplay(List<Customer> li)
        {
            foreach(Customer cus in li)
            {
                string name = cus.GetName();
                int rate = cus.GetRating();
                string add = cus.GetAddress();
                Console.WriteLine(name + ", " + "rating " + rate + " ,Address " + add);
            }
        }

        static void SortData(List<Customer> li)
        {
            int size = li.Count;

            for (int j = 0; j < size; j++)
            {
                for (int i = 1; i <= j; i++)
                {
                    if (li[i - 1].GetRating() > li[i].GetRating())
                    {
                        Customer temp = li[i - 1];
                        li[i - 1] = li[i];
                        li[i] = temp;
                    }
                }
            }
         }

         static void SortName(List<Customer> li)
         {
             int size = li.Count;

            for (int j = 0; j < size -1; j++)
            {
                for (int i = j + 1; i < size; i++)
                {
                    if (li[i - 1].GetName().CompareTo(li[i].GetName()) > 0)
                    {
                        Customer temp = li[i - 1];
                        li[i - 1] = li[i];
                        li[i] = temp;
                    }
                }
            }
         }


        static void SetList(List<Customer> li)
        {
            Customer c1 = new Customer("Tamara", 2, "Auckland");
            li.Add(c1);

            Customer c2 = new Customer("Amelia", 5, "Taranamki");
            li.Add(c2);

            Customer c3 = new Customer("Kaos", 3, "Hamilton");
            li.Add(c3);

            Customer c4 = new Customer("Karl", 4, "Papatoetoe");
            li.Add(c4);

            Customer c5 = new Customer("Carlos", 5, "Glenfield");
            li.Add(c5);

            Customer c6 = new Customer("Alice", 2, "Whangarei");
            li.Add(c6);

            Customer c7 = new Customer("Zion", 2, "Wellington");
            li.Add(c7);

            Customer c8 = new Customer("Sara", 3, "Auckland");
            li.Add(c8);

            Customer c9 = new Customer("Bob", 4, "Papakura");
            li.Add(c9);

            Customer c10 = new Customer("Wimeru", 5, "Auckland");
            li.Add(c10);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("########## Welcome Customer App ###########");
            Console.WriteLine("");

            SetList(customers);
            LiDisplay(customers);

            Console.WriteLine("");
            Console.WriteLine("########## The Data Sorted by Rating Is: ###########");
            Console.WriteLine("");

            SortData(customers);
            LiDisplay(customers);

            Console.WriteLine("");
            Console.WriteLine("########## The Data Sorted by Name Is: ###########");
            Console.WriteLine("");

            SortName(customers);
            LiDisplay(customers);

        }
    }
}
