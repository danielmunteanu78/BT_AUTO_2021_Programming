using System;
using System.Collections.Generic;
using System.Text;

namespace BT_AUTO_2021_Programming
{
	class Light
	{
		Boolean onOff;
		float dim;
		const float MAX_DIM = 8;

		public Light(bool onOff, float dim)
		{
			this.onOff = onOff;
			this.dim = dim;
		}

		public Light()
		{
		}

		public void TurnOn()
		{
			onOff = true;
		}
		public void TurnOff()
		{

			onOff = false;
		}

		public void Dim()
		{
			if (dim > 0)
			{
				dim -= 1;
			}
			else
				Console.WriteLine(" The light it's off");
		}

		public void Brighten()
		{
			if (dim < MAX_DIM)
			{
				dim += 1;
			}
			else
				Console.WriteLine("The light it's at maximum intensity !");
		}

		public void Status()
		{
			if (onOff == true)
			{
				Console.WriteLine(" The light is on at intensity level: " + dim);
			}
			else
			{
				Console.WriteLine(" The light is off !");
			}

		}
	}
}
