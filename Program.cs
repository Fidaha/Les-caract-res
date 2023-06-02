namespace LesCaracteres;

class Program
{
    static void Main(string[] args)
    {
           for (int i = 97; i <= 122; i++)
        {
            char letter = (char)i;
            Console.WriteLine(letter + " = '" + letter + "'");
        }
    }
}
