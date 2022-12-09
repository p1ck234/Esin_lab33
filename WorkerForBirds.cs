using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab23
{
	internal class WorkerForBirds
	{
		public void Feed(bird bird)
		{
			if(bird.WannaEat == true)
			{
				Console.WriteLine("Работник покормил птицу "+bird.Name);
				bird.WannaEat = false;
			}
			else
			{
				Console.WriteLine("Еще не время, птица не голодна");
			}
		}
	}
}
