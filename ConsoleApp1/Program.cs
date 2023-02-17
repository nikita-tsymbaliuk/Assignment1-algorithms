// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");



string input = "22+3*(56-45)^5678";
string b = "";
string[] result = new String[50];
int index = 0;

foreach (var x in input)
{
    Console.WriteLine("|" + x + "|");
    if (Char.IsDigit(x) == true)
    {
        b += x;
    }
    else
    {
        if (!(x == ' '))
        {
            if (b.Length > 0)
            {
                result[index] = b;
                b = "";
                index += 1;
            }
            result[index] = x.ToString();
            // b = "";
            index += 1;
        }
    }
}
if (b.Length > 0)
{
    result[index] = b;
}
Console.WriteLine("<" + b + ">");   