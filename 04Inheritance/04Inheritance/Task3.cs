namespace _04Inheritance
{
	class MusicInstrument
	{
		string name;
		string description;
		string sound;
		string history;
		public MusicInstrument(string name, string description, string sound, string history)
		{
			this.name = name;
			this.description = description;
			this.sound = sound;
			this.history = history;
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
		public void History()
		{
			Console.Write(history);
		}
	}
	class Violin : MusicInstrument
	{
		public Violin(string name, string description, string sound, string history) : base(name, description, sound, history) { }
	}
	class Trombone : MusicInstrument
	{
		public Trombone(string name, string description, string sound, string history) : base(name, description, sound, history) { }
	}
	class Ukulele : MusicInstrument
	{
		public Ukulele(string name, string description, string sound, string history) : base(name, description, sound, history) { }
	}
	class Violoncello : MusicInstrument
	{
		public Violoncello(string name, string description, string sound, string history) : base(name, description, sound, history) { }
	}
}
