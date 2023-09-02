using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting
{
    internal class Gallery
    {

        public string Name;

        public Car[] Cars;

        public Gallery(string name)
        {
            Name = name;
            Cars = new Car[0];
        }

        public void GetGalleryCarShow()
        {
            foreach (var car in Cars)
            {
                car.InfoCar();
            }
        }

        public void AddCar(Car car)
        {

            Array.Resize(ref Cars, Cars.Length + 1);
            Cars[Cars.Length - 1] = car;

        }

        public void SumCar()
        {
            int sum = 0;
            foreach (var car in Cars)
            {
                sum += car.Price;

            }
            Console.WriteLine(sum);
        }

        public void RemoveCar(int id)
        {
            int index = -1;
            for (int i = 0; i < Cars.Length; i++)
            {
                if (Cars[i].Id == id)
                {
                    index = i;
                    break;
                }
            }

            if (index != -1)
            {
                Cars[index] = null;
                Cars = Array.FindAll(Cars, car => car != null);
            }

        }
    }
}
