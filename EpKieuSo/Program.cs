// See https://aka.ms/new-console-template for more information
int n;
while (true)
{
    Console.WriteLine("Nhập n>=0: ");
    string s = Console.ReadLine();

    // Validate input
    if (!int.TryParse(s, out n) || n < 0)
    {
        Console.WriteLine("ERROR, Phải nhập số nguyên >= 0"); // Error message for invalid input
    }
    else
    {
        // Input is valid, calculate factorial
        int gt = 1;
        for (int i = 1; i <= n; i++)
        {
            gt *= i;
        }
        Console.WriteLine($"{n}! = {gt}");
        break; // Exit loop after successful calculation
    }
}