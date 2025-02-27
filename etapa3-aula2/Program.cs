using System.Globalization;
using Biblioteca;

class Program
{
    static void Main(string[] args)
    {
        OperacoesDateTime op = new();

        CultureInfo culture = new CultureInfo("en-US");
        
        op.VerificaFeriado(DateTime.Now, culture);

        DateTime dataHoje = DateTime.Now;

        Console.WriteLine($"Hoje: {dataHoje} ");

        DateTime dataNascimento = new DateTime(1977, 09, 03);

        Console.WriteLine($"Data de Nascimento: {dataNascimento}");

        

        Console.WriteLine($" Idade: {op.CalcularIdade(dataNascimento)}");

        

        //formatando a data conforme culture

        

        Console.WriteLine($"{dataHoje.ToString("D", culture)}");

        culture = new CultureInfo("en-US");

        Console.WriteLine($"{dataHoje.ToString("D", culture)}");

        Console.ReadKey();
    }
}

