namespace _04Inheritance
{
	class Worker
	{
		public virtual void Print()
		{
			Console.WriteLine($"I'm a Worker. My work is to do some work.");
		}
	}
	class President : Worker
	{
		public override void Print()
		{
			Console.WriteLine($"I'm a President. My work is to rule country.");
		}
	}
	class Security : Worker
	{
		public override void Print()
		{
			Console.WriteLine($"I'm a Security. My work is to protect something.");
		}
	}
	class Manager : Worker
	{
		public override void Print()
		{
			Console.WriteLine($"I'm a Manager. My work is to manage workers.");
		}
	}
	class Engineer : Worker
	{
		public override void Print()
		{
			Console.WriteLine($"I'm a Engineer. My work is to create new objects.");
		}
	}
}
