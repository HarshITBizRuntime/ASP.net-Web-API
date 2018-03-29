using System;
using System.Collections.Generic;


namespace JSObjectToWebApi.Models
{
    public class Persons
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
        interface IPersonsRepository
        {
            Persons Add(Persons item);
        }
        public class PersonsRepository : IPersonsRepository
        {
            private List<Persons> Personss = new List<Persons>();
            private int _nextId = 1;

            internal static object FirstOrDefault(Func<object, bool> p)
            {
                throw new NotImplementedException();
            }

            public PersonsRepository()
            {
                Add(new Persons { Name = "Computer", Category = "Electronics", Price = 23.54M });
                Add(new Persons { Name = "Laptop", Category = "Electronics", Price = 33.75M });
                Add(new Persons { Name = "iPhone4", Category = "Phone", Price = 16.99M });
            }
            public Persons Add(Persons item)
            {
                if (item == null)
                {
                    throw new ArgumentNullException("item");
                }
                item.Id = _nextId++;
                Personss.Add(item);
                return item;
            }
        }
    }
}