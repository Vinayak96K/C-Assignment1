using System;

namespace Factorial
{
	class Factorial
	{
		int iNo, iCnt, iFact=1;
		public Factorial(int iNum)
		{
			iNo = iNum;
		}
        
		public int iFactorial()
		{
			for (iCnt = 1; iCnt <= iNo; iCnt++)
			{
				iFact = iFact * iCnt;
			}

			return iFact;
		}
	}

    class MainClass
    {
        public static void Main(string[] args)
        {
			int iVar = 0, iAns;

			Console.WriteLine("Enter a number:");
			iVar = Convert.ToInt32(Console.ReadLine());

			Factorial fObj = new Factorial(iVar);

			iAns=fObj.iFactorial();
			Console.WriteLine(""+iVar+"! is  "+iAns);
		}
    }
}
