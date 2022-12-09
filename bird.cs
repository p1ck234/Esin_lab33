using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab23
{
	public class bird
	{
		public string Name{ get;set;}
		public bool WannaEat { get; set; } = true;

		public bird(string name)
		{
			Name = name;
		}
	}
}
