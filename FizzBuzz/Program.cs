namespace FizzBuzz;
class Program
{
    static void Main(string[] args)
    {
        //for (int i = 0; i < 100; i++)
        //{
        //    Console.WriteLine($"{i}: {FizzBuzz(i)}");
        //}

        var exitVar = "y";
        var response = false;
        int number;

        do
        {
            do
            {
                Console.WriteLine("Enter a number");
                response = int.TryParse(Console.ReadLine(), out number);

            } while (!response);

            Console.WriteLine($"{number}: {FizzBuzzTernary(number)}");

            Console.WriteLine("Continue? Y or N?");
            exitVar = Console.ReadLine().ToLower();


        } while (exitVar == "y");
    }

    public static string FizzBuzz(int num)
    {
        var answer = "";

        if(num % 3 == 0)
        {
            answer += "Fizz";
        }

        if(num % 5 == 0)
        {
            answer += "Buzz";
        }

        return answer;
    }

    public static string FizzBuzzTernary(int num)
    {
        var answer = "";

        answer = (num % 3 == 0) ? answer += "Fizz" : answer += "";
        answer = (num % 5 == 0) ? answer += "Buzz" : answer += "";

        return answer;
    }
}

