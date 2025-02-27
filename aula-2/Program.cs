

class program
{
    static void Main(string[] args)
    {

        try
        {
            throw new Exception("ERRO TANATOS");

            Console.Clear();

            int num1;
            int num2;

            Console.WriteLine("---Operação matemática de multiplicação---");
            Console.WriteLine("Digite o primeiro numero:");

            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Você Digitou o valor:  " + num1 + " para num1");

            Console.WriteLine("Digite o segundo numero:");

            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Você Digitou o valor:  " + num2 + " para num2");

            Console.WriteLine($"A soma dos números é:  {num1 + num2}");

            Console.ReadLine();
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Valor inválido infomado.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Houve um erro inesperado.");
        }
    }
}