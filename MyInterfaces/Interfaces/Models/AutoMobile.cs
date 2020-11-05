using Interfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Models
{
    class AutoMobile
    {
		// field - ALWAYS private
		private bool _isOn;

		// property - ALWAYS public except
		// set cause we have a method for this
		public bool IsOn
		{
			get { return _isOn; }
			private protected set { _isOn = value; }
		}

		public AutoMobile()
		{

		}

		public AutoMobile(bool IsOn)
		{
			this._isOn = IsOn;
		}

		public void Start()
		{
			this._isOn = true;
		}

		public void Stop()
		{
			this._isOn = false;
		}
	}
}
