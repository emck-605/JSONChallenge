using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.FirstName = "Erin";
            person.LastName = "McKinney";
            person.DOB = new DateTime(1995, 10, 30);
            person.FavoriteIceCreamFlavors = new List<string> { "Vanilla", "Cookie Dough" };

            string json = JsonConvert.SerializeObject(person);

            Console.WriteLine(json);

            Console.ReadKey();
        }
    }
}
