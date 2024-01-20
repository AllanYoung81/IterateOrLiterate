namespace IterateOrLiterate
{
	internal class Program
	{
		static void Main(string[] args)
		{
            Console.WriteLine("Greetings!!!");
            Thread.Sleep(500);
            Console.WriteLine();
            Thread.Sleep(250);
            Console.WriteLine();
            Thread.Sleep(250);
            Console.WriteLine("This");
            Thread.Sleep(250);
            Console.WriteLine("Is");
            Thread.Sleep(250);
            Console.WriteLine("An");
            Thread.Sleep(250);
            Console.WriteLine("Example");
            Thread.Sleep(250);
            Console.WriteLine("Of");
            Thread.Sleep(250);
            Console.WriteLine("An");
            Thread.Sleep(250);
            Console.WriteLine("Iteration");
            Thread.Sleep(250);
            Console.WriteLine("Loop..........");
            Thread.Sleep(250);
            Console.WriteLine();
            Thread.Sleep(250);
            Console.WriteLine();
            Thread.Sleep(250);


            for (int i = 10; i >= -10; i--) 
			{ 
				Console.WriteLine(i);
                Thread.Sleep(500);
                Console.WriteLine();
                Thread.Sleep(500);
                

                if (i == 0)
				{
                    //Console.WriteLine();
                    //Thread.Sleep(500);
                    Console.WriteLine();
                    Thread.Sleep(500);
                    Console.WriteLine("It just takes some time ");
                    Thread.Sleep(1500);
                    Console.WriteLine("Little girl, you're in the middle of a ride ");
					Thread.Sleep(1500);
					Console.WriteLine("Everything, everything'll be just fine ");
					Thread.Sleep(1500);
					Console.WriteLine("Everything'll, everything'll be alright, alright");
					Thread.Sleep(1500);
                    Console.WriteLine();
                    Thread.Sleep(500);
                    Console.WriteLine();
                    Thread.Sleep(500);
                    //continue;

                    //break;

                }

				
			}
		}
	}
}