using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            var hastable = new SuperHashTable<Person>(100);
            var persone = new Person() { Name = "Vasya", Age = 23, Gender = "Man"};
            hastable.Add(new Person() { Name = "Aravan", Age = 13, Gender = "Man" });
            hastable.Add(new Person() { Name = "Annush", Age = 25, Gender = "Woman" });
            hastable.Add(persone);
            Console.WriteLine(hastable.Search(new Person() { Name = "Annush", Age = 25, Gender = "Woman" }));
            Console.WriteLine(hastable.Search(persone));
            Console.ReadLine();
        }
    }
}
