using System;

namespace Construcktors__ÖDEV_
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer { ID = 1, Name = "Burak", SurName = "KAYA", City = "istanbul" };
            Customer customer2 = new Customer(2, "Can", "Kaya", "İstanbul");

            Console.WriteLine(customer.ID + " " + customer.Name + " " + customer.SurName + " " + customer.City);
            Console.WriteLine(customer.ID + " " + customer2.Name + " " + customer2.SurName + " " + customer2.City);
        }
    }
    class Customer
    {
        public Customer()
        {

        }
        //default Construcktor / eklemesen bile çalışır.
        public Customer(int id , string name, string surName , string city)
        {
            //Eğer eşitlemezsen hata verir ! 
            ID = id;
            Name = name;
            SurName = surName;
            City = city;
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string City { get; set; }
    }
}
