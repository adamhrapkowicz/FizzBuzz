namespace FizzBuzz
{
    public class Program
    {
        static void Main(string[] args)
        {
            var n = (int)GetInputFromUser();
            var FizzBuzzArray = GetFizzBuzzList(n);
            PrintFizzBuzzList(FizzBuzzArray);
        }

        private static void PrintFizzBuzzList(string[] fizzBuzzArray)
        {
            foreach (string number in fizzBuzzArray)
            {
                Console.WriteLine(number);
            }
        }

        public static object GetInputFromUser()
        {
            var validInput = false;
            var n = 0;
            while (!validInput)
            {
                Console.WriteLine("Please enter an intenger");
                var input = Console.ReadLine();

                validInput = int.TryParse(input, out n);
            }
            return n;
        }

        public static string[] GetFizzBuzzList(int number)
        {
            var list = new string[number];

            for (var i = 1; i <= number; i++)
            {
                if (i % 5 == 0 && i % 3 == 0)
                {
                    list[i-1] = "FizzBuzz";
                }
                else if (i % 5 == 0)
                {
                    list[i-1] = "Buzz";
                }
                else if (i % 3 == 0)
                {
                    list[i-1] = "Fizz";
                }
                else
                {
                    list[i-1] = i.ToString();
                }
            }
            return list;
        }
    }
}