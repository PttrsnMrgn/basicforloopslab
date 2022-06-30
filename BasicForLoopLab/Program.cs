string restart;
do
{
    Console.WriteLine("Enter a number:");
    int input = int.Parse(Console.ReadLine());
    int sum = 0;
    for (int i = 1; i <= input; i++)
    {
        sum = i + sum;
    }
    Console.WriteLine(sum);

    Console.WriteLine("Would you like to continue? (y/n)?");

    restart = Console.ReadLine().ToLower();
}
while (restart == "y");



Console.WriteLine("Goodbye!");

Thread.Sleep(5000);