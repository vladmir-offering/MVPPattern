using System;
using System.Collections.Generic;
using System.Text;

namespace MVPPattern
{
	public class Presenter : IPresenter
	{
		IView view;
		IModel model;

		public Presenter ()
		{
			view = new View();
			model = new Model();
		}

		void SetModel (string name)
		{
			model.SetName(name);
		}

		void UpdateView ()
		{
			view.ShowData(model.GetName());
		}

		public void ChangeName (string input)
		{
			SetModel(input);
			UpdateView();
		}

	}
}
