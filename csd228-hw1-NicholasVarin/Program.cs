namespace Homework
{
    /*## Task
Change the code inside of the Main() method so that it does the following:
1. Greet the user with the message "Welcome to number stats! How many entries do you wish to enter?"
1. Prompt the user for a number
1. Show the user the number they entered in this message : "Expecting N numbers" where N is the number the user entered
1. Shows the user the following statistics about the numbers that they entered as shown below:
    * The sum of all numbers entered:sum
    * The average of all numbers entered:avg
    * The number of zeros entered:numZeros
    * The number of positive numbers entered:numPositive
    * The number of negative numbers entered:numNegatives
1. Print "Done!"

In each case, print the message as shown in step 4 followed by a single ':' and the calculated number. Keep in mind that the message should be exact
*/
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to number stats! How many entries do you wish to enter?");
            int numEntries = ReadPositiveInteger();

            Console.WriteLine("Expecting {0} numbers", numEntries);

            int sum = 0;
            int numZeros = 0;
            int numPositive = 0;
            int numNegatives = 0;

            for (int i = 0; i < numEntries; i++)
            {
                Console.Write("", i + 1);
                int num = ReadInteger();

                sum += num;

                if (num == 0)
                {
                    numZeros++;
                }
                else if (num > 0)
                {
                    numPositive++;
                }
                else
                {
                    numNegatives++;
                }
            }

            double avg = (double)sum / numEntries;

            Console.WriteLine("The sum of all numbers entered:{0}", sum);
            Console.WriteLine("The average of all numbers entered:{0}", avg);
            Console.WriteLine("The number of zeros entered:{0}", numZeros);
            Console.WriteLine("The number of positive numbers entered:{0}", numPositive);
            Console.WriteLine("The number of negative numbers entered:{0}", numNegatives);
            Console.WriteLine("Done!");
        }

        static int ReadPositiveInteger()
        {
            int num;
            while (true)
            {
                try
                {
                    num = int.Parse(Console.ReadLine());
                    if (num < 1)
                    {
                        Console.WriteLine("Please enter a positive integer");
                        continue;
                    }
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter a positive integer");
                }
            }
            return num;
        }

        static int ReadInteger()
        {
            int num;
            while (true)
            {
                try
                {
                    num = int.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter an integer");
                }
            }
            return num;
        }
    }
}


