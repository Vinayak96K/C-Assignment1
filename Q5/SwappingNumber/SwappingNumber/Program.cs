using System;

namespace SwappingNumber
{
    class MainClass
    {
		public static unsafe void SwapA(int *p,int *q)
		{
			int temp = 0;
			temp = *p;
			*p = *q;
			*q = temp;
		}


		public static void SwapR(ref int p , ref int q)
		{
			int temp =0;
			temp = p;
			p = q;
			q = temp;
            
            
		}

		public unsafe static void Main(string[] args)
        {
			int iNo1 = 0, iNo2 = 0;
			try
			{
				Console.WriteLine("Enter first number:");
				iNo1 = Convert.ToInt32(Console.ReadLine());
			}
			catch(FormatException)
			{
				Console.WriteLine("Incorrect input for first number!");
			}
			try
			{
				Console.WriteLine("Enter second number:");
				iNo2 = Convert.ToInt32(Console.ReadLine());
			}
			catch(FormatException)
			{
				Console.WriteLine("Incorrect input for second number!");				
			}
			Console.WriteLine("Value of iNo1: "+iNo1+" and iNo2 : "+iNo2+" before swapping");


			SwapR(ref iNo1,ref iNo2);
			Console.WriteLine("Value of iNo1: " + iNo1 + " and iNo2 : " + iNo2 + " after swapping by reference.");

			SwapA(&iNo1,&iNo2);
			Console.WriteLine("Value of iNo1: " + iNo1 + " and iNo2 : " + iNo2 + " after swapping by address");

		}
    }
}
