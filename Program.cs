using System;

namespace lab23
{
	internal class Program
	{
		static void Main(string[] args)
		{
			WorkerForBirds worker1= new WorkerForBirds();
			WorkerForMammals worker2= new WorkerForMammals();
			
			bird bird1 = new bird("Sam");
			bird bird2 = new bird("Bob");
			bird bird3 = new bird("Tom");
			bird bird4 = new bird("Dave");

			mammal mammal1 = new mammal("Oliver");
			mammal mammal2 = new mammal("Jack");
			mammal2.WannaEat = false;
			mammal mammal3 = new mammal("Jacob");

			Console.WriteLine("Кого вы хотите покормить?\n1.Млекопитающее\n2.Птицу\n3.Никого");
			int choose = int.Parse(Console.ReadLine());


			if(choose == 1)
			{
				Console.WriteLine("Какое животное вы хотите покормить?\n1.Oliver\n2.Jack\n3.Jacob");
				int choose2 = int.Parse(Console.ReadLine());
				switch(choose2)
				{
					case 1:
						{
							worker2.Feed(mammal1);
							break;
						}
					case 2:
						{
							worker2.Feed(mammal2);
							break;
						}
					case 3:
						{
							worker2.Feed(mammal3);
							break;
						}
				}
			}
			else if(choose == 2)
			{
				Console.WriteLine("Какую птицу вы хотите покормить?\n1.Sam\n2.Bob\n3.Tom\n4.Dave");
				int choose2 = int.Parse(Console.ReadLine());
				switch (choose2)
				{
					case 1:
						{
							worker1.Feed(bird1);
							break;
						}
					case 2:
						{
							worker1.Feed(bird2);
							break;
						}
					case 3:
						{
							worker1.Feed(bird3);
							break;
						}
					case 4:
						{
							worker1.Feed(bird4);
							break;
						}
				}
			}
			else if(choose == 3)
			{
				Console.WriteLine("Всего хорошего!");
			}
			else
			{
				Console.WriteLine("Введите правильный символ");
			}



		}
	}
}

