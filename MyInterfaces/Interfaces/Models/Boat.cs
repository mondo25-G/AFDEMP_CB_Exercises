using Interfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Models
{
    class Boat : AutoMobile, IAutoMobileActions, IBoatActions
    {
        
        private string _steer;

        public string Steers
        {
            get { return _steer; }
            set {_steer = value; }
        }






        public Boat()
        {

        }

        public Boat(bool IsOn)
        {
            this.IsOn = IsOn;
        }

        public void SteerLeft()
        {
            Console.WriteLine("Steering Left");
        }

        public void Reverse()
        {
            Console.WriteLine("The boat is reversing");
        }

        public void SteerRight()
        {
            Console.WriteLine("Steering right");
        }

        public void Steer(bool direction)
        {
            if (direction==true)
            {
                SteerLeft();
                _steer += " -Left- ";

            }
            else
            {
                SteerLeft();
                _steer += " -Right- ";
            }
        }
    }
}
