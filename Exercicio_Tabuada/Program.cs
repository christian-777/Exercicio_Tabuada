internal class Program
{
    private static void Main(string[] args)
    {
        //exercicio tabuada

        int num;
        int mult;

        Console.WriteLine("digite um numero entre 1 e 9: ");
        num=int.Parse(Console.ReadLine());

        if(num>0 && num < 10)
        {
            for(int i = 0; i <= 10; i++)
            {
                mult = i * num;
                Console.WriteLine(num + " * " + i + " = " + mult);
            }
        }
    }
}