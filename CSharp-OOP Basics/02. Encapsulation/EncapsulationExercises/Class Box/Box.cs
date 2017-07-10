using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Box
{
	class Box
	{
		private double length;
		private double width;
		private double height;

		public Box(double lenght, double width, double heigth)
		{
			this.Length = lenght;
			this.Width = width;
			this.Heigth = heigth;
		}


		public double Length {
			get { return this.length; }
			private set
			{
				if (value < 0)
				{
					throw new ArgumentException("Length cannot be zero or negative.");
				}
				this.length = value;
			}}

		public double Width
		{
			get { return this.width; }
			private set
			{
				if (value < 0)
				{
					throw new ArgumentException("Width cannot be zero or negative.");
				}
				this.width = value;
			}
		}

		public double Heigth
		{
			get { return this.height; }
			set
			{
				if (value < 0)
				{
					throw new ArgumentException("Height cannot be zero or negative.");
				}
				this.height = value;
			}
		}




		public double CalculateVolume()
		{
			return length * height * width;
		}

		public double CalculateLateralSurfaceArea()
		{
			return 2 * length * height + 2 * width * height;
		}

		public double CalculateSurfaceArea()
		{
			return 2 * length * width + 2 * length * height + 2 * width * height;
		}
	}
}
