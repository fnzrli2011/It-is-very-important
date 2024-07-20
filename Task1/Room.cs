using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task1
{
    public class Room
    {

        public static int _id=0;
        public int Id { get; private set;}
        public string Name {get; set;}
        public decimal Price {get; set;}
        public long PersonCapacity {get; set;}
        public bool IsAviable =true;

        public Room(string name, decimal price, long pc )
        {
            _id++;
            Id=_id;
            Name=name;
            Price=price;
            PersonCapacity=pc;
        }

        public string ShowInfo()
        {
            
            return $"Name : {Name}  Id :{Id} Capacity :{PersonCapacity} IsAviable : {IsAviable} Price : {Price}";
        }

        public override string ToString()
        {
            return ShowInfo();
        }

    }

}