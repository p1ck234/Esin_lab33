using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab23
{
	public class mammal
	{
		public string Name { get; set; }
		public bool WannaEat { get; set; } = true;

		public mammal(string name)
		{
			Name = name;
		}
	}
	
}
