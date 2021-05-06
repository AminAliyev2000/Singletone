using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
     public sealed class Singletone
    {
        static private Singletone instance;
        private Singletone()
        {

        }
        static public Singletone Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Singletone();

                }
                return instance;
            }
        }
        private  List<Persons> _persons { get; set; }
        public void Add(Persons person)
        {
            if (_persons == null)
            {
                _persons = new List<Persons>() { };
            }
            if (person != null)
            {
                _persons.Add(person);
            }
        }
        public void Show()
        {
            int i = 1;
            foreach(var item in _persons)
            {
                Console.WriteLine($"{i} : {item.Names}");
                i++;
            }
        }
     }
}
