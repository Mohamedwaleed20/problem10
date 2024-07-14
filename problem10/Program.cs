// See https://aka.ms/new-console-template for more information
Console.Write("enter the num : ");
int num = int.Parse(Console.ReadLine());
string[] names = new string[num];
int[] ages = new int[num];
for (int i = 0; i < num; i++)
{
    Console.Write($"Enter name {i + 1}: ");
    names[i] = Console.ReadLine();

    Console.Write($"Enter age {i + 1}: ");
    ages[i] = int.Parse(Console.ReadLine());
}
Console.Write("Enter the num to get the name and the age : ");
int inputNum = int.Parse(Console.ReadLine());

for (int i = 0; i < (num) ; i++)
{
    if (i == inputNum)
    {
        Console.WriteLine($"The name of {inputNum} is {names[i]}");
        Console.WriteLine($"The age of {inputNum} is {ages[i]}");
        return;
    }
    else
    {

        Console.WriteLine($"No person found with the name {inputNum}");
        Console.WriteLine($"No person found with the age {inputNum}");
        return;
    }
}

Console.ReadLine();
    



