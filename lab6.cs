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
		public  string Name
		{
			get{return name;}
			set{name=value;}
		}
		public  int Age
		{
			get{return age;}
			set{age=value;}
		}
		public  int Wheit
		{
			get{return wheit;}
			set{wheit=value;}
		}
		public  double Price
		{
			get{return price;}
			set{price=value;}
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
		private Pets [] pet = new Pets [100];
		const int food_price=10;
		private  static double feed_price=food_price;
		public Zooshop()
		{
			col=0;
			income=0;
			damages=0;	
			for(int i=0; i<col; i++)
			{
				pet[i]=new Pets ("no_name", 0,0,0);
			}
		}
		public Zooshop(int col, double income, double damages, Pets[] pet)
		{
			this.col=col;
			this.income=income;
			this.damages=damages;
			for(int i=0; i<col; i++)
			{this.pet[i]=pet[i];}
		}
		public Zooshop(int col, double income, double damages, Pets pet)
		{
			this.col=col;
			this.income=income;
			this.damages=damages;
			this.pet[0]=pet;
		}
		public int Col
		{
			get{return col;}
			set{col=value;}
		}
		public double Income
		{
			get{return income;}
			set{income=value;}
		}
		public double Damages
		{
			get{return damages;}
			set{damages=value;}
		}
		public double Feed_price
		{
			get{return feed_price;}
			set{feed_price=value;}
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
		static public void set_price_feed(double price)
		{
		feed_price=price;
		}
		static public double get_feed_price()
		{
			return feed_price;
		}
		public void output_shop()
		{
			Console.WriteLine("Numbers of pets - {0} ,store profit is {1}, damages is {2}, price of feed is {3}\n", col, income, damages, feed_price);
		}
		public Pets get_pet(int i)
		{
			return pet[i];
		}
		
		public void output_shopANDpets()
		{
			Console.WriteLine("Numbers of pets - {0} ,store profit is {1}, damages is {2}, price of feed is {3}\n", col, income, damages,feed_price );
			for(int i=0; i<col; i++)
			{
			Console.WriteLine("Pet's name - {0}, age - {1}, wheit - {2}, price - {3}\n", pet[i].Name, pet[i].Age, pet[i].Wheit, pet[i].Price);	
			}
		}
		public void feeding()
		{
			for(int i=0; i<col; i++)
			{
			pet[i].set_wheit(pet[i].Wheit+1);
			damages+=feed_price;
			}
		}
		public void sale()
		{
			for(int i=0; i<=col; i++)
			{
				income+=pet[i].get_price();
				col-=1;
			}
		}
		public void tax(out double taxa)
		{
			taxa = income*0.2;
		}
		public void profit(ref double profit)
		{
			profit=income-damages;
		}
		public static Zooshop operator+(Zooshop s1, int a)
		{
			Zooshop s2;
			s2=new Zooshop();
			s2.Col=s1.Col+a;
			return s2;
		}
		public static Zooshop operator++(Zooshop s)
		{
			++s.Feed_price;
			return s;
		}
		public void found_pets(String names)
		{
			int res=0;
		 for(int i=0; i<col; i++)
		 {
			 res=String.Compare(names,pet[i].Name);
			 if(res==0)
			 {
				 Console.WriteLine("Pet found\n");
				break; 
			 }
		 }
		 if(res!=0)
		 {
			 Console.WriteLine("Pet doesn't found\n");
		 }
		}
		//for 8 labaroty
		public static void compare(Zooshop s1, Zooshop s2)
		{
			if(s1.get_col()>s2.get_col())
			{
				Console.WriteLine("More animals in first shop\n");
			}
			else if(s2.get_col()>s1.get_col())
			{
				Console.WriteLine("More animals in second shop\n");
			}
			else Console.WriteLine("Store is equals\n");
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
		 Zooshop shop = new Zooshop(1,0,0,pet);
		 shop.output_shopANDpets();
		 Console.WriteLine("After feeding\n");
		 shop.feeding();
		 shop.output_shopANDpets();
		 Zooshop shoper = new Zooshop (1,0,0,pet);
		 shoper=shoper+5;
		 Console.WriteLine("Total numbers of pets in  shop {0}\n", shoper.Col);
		 Console.WriteLine("After sale\n");
		 shop.sale();
		 shop.output_shopANDpets();
		 double taxa;
		 shop.tax(out taxa);
		 Console.WriteLine("Tax is {0}\n", taxa);
		 double profit=0;
		 shop.profit(ref profit);
		 Console.WriteLine("Profit is {0}\n", profit);
		 Console.WriteLine("Prefix and Postfix\n");
		 shoper=shop++;
		 shoper.output_shop();
		 shoper=++shop;
		 shoper.output_shop();
		 
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
		Zooshop shop1 = new Zooshop(col,0,0,pet1);
		//8 lab
		Zooshop shop8 = new Zooshop(1,0,0,pet);
		Zooshop.compare(shop1,shop8);
		Zooshop.set_price_feed(15);
		Console.WriteLine("New feed prise {0}\n", Zooshop.get_feed_price());
		
		 shop1.output_shopANDpets();
		 Console.WriteLine("After feeding\n");
		 shop1.feeding();
		 shop1.output_shopANDpets();
		 Console.WriteLine("Input name \n");
		 string names=Console.ReadLine();
		 shop1.found_pets(names);
		 Console.WriteLine("After sale\n");
		 shop1.sale();
		 shop1.output_shopANDpets();
        }
    }
}