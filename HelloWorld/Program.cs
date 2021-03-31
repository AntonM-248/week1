using sc = System.Console;



namespace Revature.Week1.HelloWorld
//namespace scope
{
    class Program
    //class scope
    {
        private int Rpa(int num)
        //method scope
        {
            var num1 = num;
            return num1;
        }

        private void UiPath()
        //another method scope
        {
            if (true)
            //block scope
            {

            }
        }

        public static void Main()
        {
            var name = sc.ReadLine();
            sc.WriteLine($"Hello {name}");
        }
    }
}