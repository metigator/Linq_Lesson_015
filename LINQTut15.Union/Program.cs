using Shared;
using System;
using System.Linq;

namespace LINQTut15.Union
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var set1 = Repository.Meeting1.Participants;
            var set2 = Repository.Meeting2.Participants;

            set1.Print($"========= Meeting 1 Participants ({set1.Count()})");
            set2.Print($"========= Meeting 1 Participants ({set2.Count()})");

            var set3 = set1.Union(set2);
            set3.Print($"=========  set1.Union(set2)  Participants ({set3.Count()})");

            var set4 = set1.UnionBy(set2, x => x.EmployeeNo);
            set4.Print($"=========  set1.UnionBy(set2, x => x.EmployeeNo)  Participants ({set4.Count()})");


            Console.ReadKey();
        }
    }
}
