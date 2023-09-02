using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Car car = new Car("Ad", 100, 200);
            Car car1 = new Car("Soyad", 100, 200);
            Car car2 = new Car("Soyad23", 100, 200);



            Gallery gallery = new Gallery("Mashinlar");

            gallery.AddCar(car);
            gallery.AddCar(car1);
            gallery.AddCar(car2);

            gallery.GetGalleryCarShow();

            gallery.SumCar();

            gallery.RemoveCar(1);

            gallery.GetGalleryCarShow();
        }
    }
}
