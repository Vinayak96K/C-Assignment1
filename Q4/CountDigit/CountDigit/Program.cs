using System;

namespace CountDigit
{
	class DigitCount
	{
		int iNo = 0;
		int iCnt = 0;

		public DigitCount(int iNum)
		{
			iNo = iNum;
		}

		public int iCount()
		{
			int iDno = iNo;

			while(iDno!=0)
			{
				iDno = iDno / 10;
				iCnt++;
			}

			return iCnt;
		}

	}

    class MainClass
    {
        public static void Main(string[] args)
        {
			int iVar = 0, iCount = 0;
			try
			{
				Console.WriteLine("Enter a number");
				iVar = Convert.ToInt32(Console.ReadLine());
			}
			catch(FormatException)
			{
				Console.WriteLine("Incorrect input!");
			}
			DigitCount dObj = new DigitCount(iVar);
			iCount=dObj.iCount();

			Console.WriteLine("Number of Digits in "+iVar+" : "+iCount);

        }
    }
}
