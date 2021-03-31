namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            //allow the user to give upper & lower bound
            //allow user to set condition for multiples
            //print each num
            //if number % 3 = 0, print fizz
            //'          '5'          ' buzz
            //fizzbuzz if both true

            //my solution
            Program prog = new Program();
            //prog.fb(100);

            //Business acceptable
            prog.RunFizzBuzz(-100, 100, 4, 6, 10);
        }

        private void RunFizzBuzz(int start = 0, int end = 100, int num1 = 3, int num2 = 5, int inc = 1)
        {
            if (start > end)
            {
                System.Console.WriteLine("Your lower bound exceeds your upper bound, FizzBuzz will run for 0 loops");
            }
            for (var x = start; x <= end; x += inc)
            {
                PrintNumber(x, num1, num2);
            }
        }

        private void PrintNumber(int a, int div1, int div2, string fizzer = "Fizz", string buzzer = "Buzz ")
        {
            string message = null;
            if (a == 0)
            {
                WriteToConsole(a);
                return;
            }
            if (a % div1 == 0)
            {
                message += fizzer;
            }
            if (a % div2 == 0)
            {
                message += buzzer;
            }
            WriteToConsole(a, message);
        }

        private void WriteToConsole(int num, string message = "")
        {
            // print to screen
            System.Console.WriteLine($"{num} {message}");
        }

        private void fb(int num)
        {//this solution wasn't compartmentalized enough
         //failed to not fizzbuzz for 0
            string f = "Fizz", b = "Buzz", result = null;
            for (int i = 0; i <= num; i++)
            {
                if (i % 3 == 0)
                {
                    result += f;
                }
                if (i % 5 == 0)
                {
                    result += b;
                }
                System.Console.WriteLine($"{i} {result}");
                result = null;
            }
        }
    }
}