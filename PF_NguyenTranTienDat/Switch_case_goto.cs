using System;

internal class switch_case_goto
{
	static void switch_case()
	{
		//case 1: non-int value; case 2: int not in given scope
		retry:
		do
		{
			int selection;
			string input_selection;
            Console.WriteLine("Press a number given below to choose language");
            Console.WriteLine("1. English");
            Console.WriteLine("2. Vietnamese");
            input_selection = Console.ReadLine();
			if (int.TryParse(input_selection, out selection))
			{
				switch (selection)
				{
					case 1:
						Console.WriteLine("Hi there, what can I help with?");
						break;

					case 2:
						Console.WriteLine("Chao ban, toi co the giup gi?");
						break;
					default:
						Console.WriteLine("We currently support 2 languages above");
						goto retry;
				}
				break;
			}
			else
			{
				Console.WriteLine("Please enter an integer");
			}
		}
		while (true);
    }
	
	//static void Main(string[] args)
	//{
	//	switch_case();
	//	Console.ReadKey();
	//}
}
