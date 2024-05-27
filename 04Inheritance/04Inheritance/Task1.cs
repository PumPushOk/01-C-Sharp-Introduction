namespace _04Inheritance
{
	class Money
	{
		int dollars;
		int cents;
		public Money(Money money)
		{
			dollars = money.dollars;
			cents = money.cents;
		}
		public Money(int dollars, int cents)
		{
			this.dollars = dollars;
			this.cents = cents % 100;
		}
		public override string ToString()
		{
			return dollars + "." + cents;
		}
		public void DecreaseDollars(int value)
		{
			dollars -= value;
			if (dollars < 0)
			{
				dollars = 0;
				cents = 0;
			}
		}
		public void DecreaseCents(int value)
		{
			cents -= value;
			if (cents < 0)
			{
				cents += 100;
				DecreaseDollars(1);
			}
		}
	}
	class Product : Money
	{
		public Product(Money money, string name) : base(money)
		{
			Name = name;
		}
		public Product(int dollars, int cents, string name) : base(dollars, cents)
		{
			Name = name;
		}
		public string Name { get; set; }
		public void DecreaseSum(double value)
		{
			DecreaseDollars((int)value);
			int num = (int)((value - (int)value) * 100);
			DecreaseCents(num);
		}
	}
}
