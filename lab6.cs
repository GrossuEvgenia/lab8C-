using System;
 
namespace lab6App
{
	class Pets
	{	private string name;
		private int age;
		private int wheit;
		private double price;
		public Pets()
		{
			name="name";
			age=0;
			wheit=0;
			price=0;
		}
		public Pets(string name, int age, int wheit, double price)
		{
			this.name=name;
			this.age=age;
			this.wheit=wheit;
			this.price=price;
		}
		public void set_name(string name)
		{
			this.name=name;
		}
		public string get_name()
		{
			return name;
		}
		public void set_age(int age)
		{
			this.age=age;
		}
		public int get_age()
		{
			return age;
		}
		public void set_wheit(int wheit)
		{
			this.wheit=wheit;
		}
		public int get_wheit()
		{
				return wheit;
		}
		public void set_price(double price)
		{
			this.price=price;
		}
		public double get_price()
		{
			return price;
		}
		
		public void input()
		{
			Console.WriteLine("Enter pet's name:\n");
			name=Console.ReadLine();
			Console.WriteLine("Enter pet's age\n");
			age=Int32.Parse(Console.ReadLine());
			Console.WriteLine("Enter pet's wheit\n");
			wheit=Int32.Parse(Console.ReadLine());
			Console.WriteLine("Enter pet's price\n");
			price=Convert.ToDouble(Console.ReadLine());			
		}
		public void output_pets()
		{
			Console.WriteLine("Pet's name - {0}, age - {1}, wheit - {2}, price - {3}\n", name, age, wheit, price);
		}
		public double add_price(double sum)
		{
			sum+=price;
			return sum;
		}
		
	}
	
	
    class Zooshop
    {
		private int col;
		private double income;
		private double damages;
		private  double feed_price;
		private Pets [] pet = new Pets [100];
		const int food_price=10;
		public Zooshop()
		{
			col=0;
			income=0;
			damages=0;
			feed_price=food_price;	
		}
		public Zooshop(int col, double income, double damages, double feed_price, Pets[] pet)
		{
			this.col=col;
			this.income=income;
			this.damages=damages;
			this.feed_price=feed_price;	
			for(int i=0; i<col; i++)
			{this.pet[i]=pet[i];}
		}
		public Zooshop(int col, double income, double damages, double feed_price, Pets pet)
		{
			this.col=col;
			this.income=income;
			this.damages=damages;
			this.feed_price=feed_price;	
			this.pet[0]=pet;
		}
		public void set_col(int col)
		{
			this.col=col;
		}
		public int get_col()
		{
			return col;
		}
		public void set_income(double income)
		{
			this.income=income;
		}	
		public double get_income()
		{
			return income;
		}
		public void set_damages(double damages)
		{
			this.damages=damages;
			
		}
		public double get_damages()
		{
			return damages;
		}
		public void set_price_feed(double feed_price)
		{
			this.feed_price=feed_price;
		}
		public double get_feed_price()
		{
			return feed_price;
		}
		public void output_shop()
		{
			Console.WriteLine("Numbers of pets - {0} ,store profit is {1}, damages is {2}, price of feed is {3}\n", col, income, damages, feed_price);
		}
		
		public void output_shopANDpets()
		{
			Console.WriteLine("Numbers of pets - {0} ,store profit is {1}, damages is {2}, price of feed is {3}\n", col, income, damages,feed_price );
			for(int i=0; i<col; i++)
			{
			Console.WriteLine("Pet's name - {0}, age - {1}, wheit - {2}, price - {3}\n", pet[i].get_name(), pet[i].get_age(), pet[i].get_wheit(), pet[i].get_price());	
			}
		}
		public void feeding()
		{
			for(int i=0; i<col; i++)
			{
			pet[i].set_wheit(pet[i].get_wheit()+1);
			damages+=feed_price;
			}
		}
		public void sale()
		{
			for(int i=0; i<=col; i++)
			{
				income+=pet[i].get_price();
				damages-=feed_price;
				col-=1;
			}
		}
		
    }
    class Program
    {
        static void Main(string[] args)
        {
         int col;
		 double sum=0;
		 Console.WriteLine("Working with object\n");
		 Pets pet = new Pets("name", 0,0 ,0);
		 pet.input();
		 pet.add_price(sum);
		 Zooshop shop = new Zooshop(1,0,0,10, pet);
		 shop.output_shopANDpets();
		 Console.WriteLine("After feeding\n");
		 shop.feeding();
		 shop.output_shopANDpets();
		 Console.WriteLine("After sale\n");
		 shop.sale();
		 shop.output_shopANDpets();
		 
		Console.WriteLine("\nWorking with array's object\n");
		Console.WriteLine("Enter numbers of pets\n");
		col=Int32.Parse(Console.ReadLine());
		Pets[] pet1 = new Pets[col];
		for(int i=0; i<col; i++)
		{	
		pet1[i]=new Pets("name",0,0,0);
		pet1[i].input();
		sum=pet1[i].add_price(sum);
		 }
		Zooshop shop1 = new Zooshop(col,0,0,10, pet1);
		 shop1.output_shopANDpets();
		 Console.WriteLine("After feeding\n");
		 shop1.feeding();
		 shop1.output_shopANDpets();
		 Console.WriteLine("After sale\n");
		 shop1.sale();
		 shop1.output_shopANDpets();
        }
    }
}