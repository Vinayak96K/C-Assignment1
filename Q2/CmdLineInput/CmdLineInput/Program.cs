using System;

namespace CmdLineInput
{
    class MainClass
    {
        public static void Main(string[] args)
        {
			int i = 0;
			int iSum = 0;

			Console.WriteLine("Argument inputs are:");
			for (i = 0; i < args.Length;i++)
			{
				Console.WriteLine(""+args[i]);
			}

			for (i = 0; i < args.Length;i++)
			{
				iSum = iSum + Convert.ToInt32(args[i]);
			}

			Console.WriteLine("Addition:"+iSum);
        }
    }
}
