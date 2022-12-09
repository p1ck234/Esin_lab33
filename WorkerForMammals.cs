using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab23
{
	internal class WorkerForMammals
	{
		public void Feed(mammal mammal)
		{
			if(mammal.WannaEat == true)
			{
				Console.WriteLine("Работник покормил птицу "+ mammal.Name);
				mammal.WannaEat = false;
			}
			else
			{
				Console.WriteLine("Еще не время, животное не голодно");
			}
		}
	}
}
