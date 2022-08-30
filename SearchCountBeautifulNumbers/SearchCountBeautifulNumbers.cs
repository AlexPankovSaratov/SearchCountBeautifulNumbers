using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchCountBeautifulNumbers
{
	internal static class SearchBeautifulNumbers
	{
		public static double GetCountBeautifulNumbers(int numberSystem, int countDischarge)
		{
			double result = 0;
			var maxDischargeValue = numberSystem - 1;
			var maxSumDischarges = (countDischarge - (countDischarge % 2)) / 2 * maxDischargeValue;
			for (int i = 0; i <= maxSumDischarges; i++)
			{
				result += GetCountBeautifulNumbersBySumDischarges(i, numberSystem, countDischarge);
			}
			return result;
		}
		private static double GetCountBeautifulNumbersBySumDischarges(int sumDischarges, int numberSystem, int countDischarge)
		{
			double result = 0;		
			var numbersIn13System = new NumberInDifferentNumberSystem(numberSystem, (countDischarge - (countDischarge % 2)) /2);
			while (!numbersIn13System.ValueIsMaximum())
			{
				if (numbersIn13System.ArrayNnumbers.Sum() == sumDischarges) result++;
				numbersIn13System.IncreaseNumberByOne();
			}
			if (numbersIn13System.ArrayNnumbers.Sum() == sumDischarges) result++;
			result = Math.Pow(result, 2);
			if (countDischarge % 2 > 0)
			{
				result *= countDischarge;
			}
			return result;
		}
	}
}
