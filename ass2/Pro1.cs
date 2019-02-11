using System;

public class Pro1
{
        public static void Main()
		{
            int i,j;
            for(i=1;i<=5;i++)
            {
                for(j=5;j>=i;j--)
                {
			        Console.Write("@");
			       
			        
                }
                Console.WriteLine();
           }
            Console.ReadKey();
        }
}
