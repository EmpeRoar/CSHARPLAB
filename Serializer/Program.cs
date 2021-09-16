using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Linq;

namespace Serializer
{
    public class Dog
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog()
            {
                ID = 1,
                Name = "Dog name"
            };
            string serializingDog = JsonConvert.SerializeObject(dog);
            JToken dogToken = JToken.Parse(serializingDog);

            Console.WriteLine($"{dogToken.Values().Count()}");
        }
    }
}
