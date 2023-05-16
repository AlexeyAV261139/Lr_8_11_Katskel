using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace Lr_8_11_Katskel
{
    internal class Triangle
    {
		private double sideA;

		public double SideA
		{
			get { return sideA; }
			set { sideA = value; }
		}
		private double sideB;

		public double SideB
		{
			get { return sideB; }
			set { sideB = value; }

		}
		private double sideC;

		public double SideC
		{
			get { return sideC; }
			set { sideC = value; }
		}

		public Triangle(double sideA, double sideB, double sideC) 
		{
			
				if (sideA < sideB + sideC & sideB < sideA + sideC & sideC < sideA + sideB)
				{
					SideA = sideA; SideB = sideB; SideC = sideC;
				}
				else
				{ throw new Exception("Введены не корректные данные"); }
			
		}
		public double Square ()
		{
			double p = (sideA + sideB + sideC) / 2;
			return Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
		}

		public double Perimeter()
		{
			return sideA + sideB + sideC;
		}

		public void Median(out double medianA, out double medianB, out double medianC)
		{
			medianA = Math.Sqrt(2 * Math.Pow(sideB, 2) + Math.Pow(sideC, 2)) / 2;
			medianB = Math.Sqrt(2 * Math.Pow(sideA, 2) + Math.Pow(sideC, 2)) / 2;
			medianC = Math.Sqrt(2 * Math.Pow(sideA, 2) + Math.Pow(sideB, 2)) / 2;
		}
	}
}
