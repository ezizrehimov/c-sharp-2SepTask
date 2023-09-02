using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting
{
    internal class Car
    {
        public int Id;
        public static int Count=0;
        public string Name;
        public int Speed;
        public int Price;


        public Car(string name,int speed,int price)
        {
            Count++;
            Id = Count;
            Name = name;
            Speed = speed;
            Price = price;  
        }

        public void InfoCar()
        {
            Console.WriteLine($"{Id} {Name} {Speed} {Price}" 
              );}
    }
}
