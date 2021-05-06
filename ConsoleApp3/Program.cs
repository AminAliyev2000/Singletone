using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Persons persons = new Persons() { Names="Amin"};
            Persons persons2 = new Persons() { Names = "Ali" };
            Persons persons3 = new Persons() { Names = "Akbar" };

            Singletone.Instance.Add(persons);
            Singletone.Instance.Add(persons2);
            Singletone.Instance.Add(persons3);
            Singletone.Instance.Show();
            Console.ReadLine();
        }
    }
}
