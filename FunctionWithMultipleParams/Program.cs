namespace FunctionWithMultipleParams
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringsPrinter("T1", "T2", "T3");
            NumberAdder(1, 2, 3, 4, 5, 6, 7, 8, 9);
        }

        static void StringsPrinter(params string[] strings) //Function which takes not specified number of strings
        {
            foreach (var item in strings)
            {
                Console.WriteLine(item);
            }
        }
        static void NumberAdder(params int[] numbers)
        {
            int solution = 0;
            foreach (var item in numbers)
            {
                solution+= item;
            }
            Console.WriteLine("All numbers added, give: {0}", solution);
        }

        // func(params type[] name)
    }
}