namespace _04Inheritance
{
	class Device
	{
		string name;
		string description;
		string sound;
		public Device(string name, string description, string sound)
		{
			this.name = name;
			this.description = description;
			this.sound = sound;
		}

		public void Show()
		{
			Console.Write(name);
		}
		public void Desc()
		{
			Console.Write(description);
		}
		public void Sound()
		{
			Console.Write(sound);
		}
	}
	class Kettle : Device
	{
		public Kettle(string name, string description, string sound) : base(name, description, sound) { }
	}
	class Microwave : Device
	{
		public Microwave(string name, string description, string sound) : base(name, description, sound) { }
	}
	class Auto : Device
	{
		public Auto(string name, string description, string sound) : base(name, description, sound) { }
	}
	class Ship : Device
	{
		public Ship(string name, string description, string sound) : base(name, description, sound) { }
	}
}
