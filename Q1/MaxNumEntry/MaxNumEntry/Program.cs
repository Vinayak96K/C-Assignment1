using System;

namespace MaxNumEntry
{
	class Numbers
	{
		int no1;
		int no2;
		int no3;

		public Numbers(int x, int y, int z)
		{
			no1 = x;
			no2 = y;
			no3 = z;
		}
        public int iMax()
		{
			int iMaxno = 0;

			if(no1>=no2 && no1>=no3)
			{
				iMaxno = no1;	
			}
			else if(no2>=no1 && no2>=no3)
			{
				iMaxno = no2;   				
			}
			else
			{
				iMaxno = no3;   
			}
			return iMaxno;
		}
	}
    class MainClass
    {
        public static void Main(string[] args)
        {
			int iNo1, iNo2, iNo3;

			Console.WriteLine("Enter first number.");
			iNo1 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter second number.");
            iNo2 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter third number.");
            iNo3 = Convert.ToInt32(Console.ReadLine());

			Numbers nObj = new Numbers(iNo1,iNo2,iNo3);

			int iMax = nObj.iMax();
			Console.WriteLine("Maximun number is "+iMax);
        }
    }
}
