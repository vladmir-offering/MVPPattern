using System;

namespace MVPPattern
{
	class Program : IView
	{

		IPresenter presenter;

		public Program ()
		{
			presenter = new Presenter();
        }

		static void Main (string[] args)
		{

			Program program = new Program();
			program.ShowData("Vladimir Stilnik");
			var name = string.Empty;
			
			while (name != "exit") {
                Console.WriteLine("enter a new name: ");
                name = Console.ReadLine();
				program.presenter.ChangeName(name);
			}

			Console.WriteLine("press any key to exit...");
			Console.ReadLine();


		}

		public void ShowData (string name)
		{
			Console.WriteLine("My name is: {0} ", name);
		}

	}
}
