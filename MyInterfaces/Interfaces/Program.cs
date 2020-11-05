using Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            // NO NO can't have instances of an abstract class or interface
            //AutoMobile auto = new AutoMobile();

            Console.WriteLine("car c");
            Car c = new Car(true);
            c.SteerLeft();

            Console.WriteLine("car car");
            Car car = new Car();
            Console.WriteLine(car.IsOn);
            car.Start();
            car.SteerLeft();
            Console.WriteLine(car.IsOn);

            // with private set doesn't work
            //car.IsOn = false;

            car.Stop();
            Console.WriteLine(car.IsOn);

            Console.WriteLine("motorbike moto");
            MotorBike moto = new MotorBike();
            moto.Start();
            moto.SteerLeft();
            Console.WriteLine(moto.IsOn);

            Console.WriteLine("motorbike moto2");
            MotorBike moto2 = new MotorBike(true);
            Console.WriteLine(moto2.IsOn);
            moto2.SteerLeft();
            moto2.Stop();
            Console.WriteLine(moto2.IsOn);

            Console.ReadLine();


            Console.WriteLine("-----------");
            Boat boat = new Boat();
            boat.Steer(true);
            boat.Steer(true);
            boat.Steer(false);
            Console.WriteLine(boat.Steers);

        }
    }
}
