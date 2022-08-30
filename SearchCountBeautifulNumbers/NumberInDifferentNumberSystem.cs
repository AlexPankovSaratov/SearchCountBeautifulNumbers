using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchCountBeautifulNumbers
{
	public class NumberInDifferentNumberSystem
	{
		private int maxDischargeValue;
		private int[] arrayNnumbers;

		public int[] ArrayNnumbers { get { return arrayNnumbers; } }

		public NumberInDifferentNumberSystem(int numberSystem, int countDischarges)
		{
			maxDischargeValue = numberSystem - 1;
			arrayNnumbers = new int[countDischarges];
		}

		public void IncreaseNumberByOne()
		{
			for (int i = 0; i < arrayNnumbers.Length; i++)
			{
				if (ValueIsMaximum())
				{
					DischargesIsOverflow();
				}
				if (arrayNnumbers[i] == maxDischargeValue)
				{
					arrayNnumbers[i] = 0;
				}
				else
				{
					arrayNnumbers[i]++;
					return;
				}
			}
		}

		public bool ValueIsMaximum()
		{
			if (arrayNnumbers.Where(n => n == maxDischargeValue).Count() == arrayNnumbers.Length) return true;
			return false;
		}

		private void DischargesIsOverflow()
		{
			//Later can be implemented by increasing the number of discharges by 2 and transposing the values
			throw new OverflowException("Discharges is overflow");
		}	
	}
}
