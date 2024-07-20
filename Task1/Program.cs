using System;
using Task1;

class Program
{
    public static void Main(string[] args)
    {
      Room room1 = new Room("otaq 1",150,3);
    //   System.Console.WriteLine(room1.Id);(1 cixardi)
      Room room2 = new Room("otaq 2",200,4);
    //   System.Console.WriteLine(room2.Id);(2 cixardi)
      Hotel hotel = new Hotel("Genclik");
      hotel.AddRoom(room1);
      hotel.AddRoom(room2);
      try
      {
         hotel.MakeReservation(1);
      }
      catch (Exception ex)
      {
        System.Console.WriteLine(ex.Message); 
      }
      

    }
}
