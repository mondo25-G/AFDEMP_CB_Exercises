using Interfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Models
{
    class Car : AutoMobile, IAutoMobileActions, ICarActions
    {
		public Car()
		{

		}

		public Car(bool IsOn)
		{
			this.IsOn = IsOn;
		}

		public void SteerLeft()
		{
			Console.WriteLine("The car is steering left");
		}

		public void Break()
		{
			Console.WriteLine("The car is breaking");
		}

		public void Reverse()
		{
			throw new NotImplementedException();
		}

		public void SteerRight()
		{
			throw new NotImplementedException();
		}

		public void Steer(bool steerLeft)
		{
			throw new NotImplementedException();
		}
	}
}
