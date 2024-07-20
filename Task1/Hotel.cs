using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Threading.Tasks;

namespace Task1
{
    public class Hotel 
    {
        public string Hotel_Name {get; set;}
         public Hotel(string hn)
         {
            Hotel_Name=hn;
         }
         private Room[] Rooms = new Room[0];


        public void AddRoom(Room room)
        {
            Array.Resize(ref Rooms,Rooms.Length+1);
            Rooms[Rooms.Length-1]=room;
        }
        public void MakeReservation(int? roomId)
        {
            if(roomId==null)
            {
                throw new NullReferenceException("room id yoxdur!!!");
            }
            else
            {
                foreach (Room item in Rooms)
                {
                    if(item.Id==roomId)
                    {
                        if(item.IsAviable==true)
                        {
                            item.IsAviable=false;
                            System.Console.WriteLine("Otaqi kiraye etdiniz!");
                        }
                        else
                        {
                            throw new NotAviableExepion("Otaq doludur");
                        }
                    }
                }
            }

        }
    }
}