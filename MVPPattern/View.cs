using System;
using System.Collections.Generic;
using System.Text;

namespace MVPPattern
{
	public class View : IView
	{
		public void ShowData (string name)
		{
			Console.WriteLine("My name is: {0}", name);
		}

	}
}
