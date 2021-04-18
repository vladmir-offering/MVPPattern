namespace MVPPattern
{
	internal class Model : IModel
	{
		private string name;
		
		public void SetName (string input)
		{
			name = input;
		}
		public string GetName ()
		{
			return name;
		}

	}
}