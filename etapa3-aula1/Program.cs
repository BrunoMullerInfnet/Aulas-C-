using System.Linq.Expressions;
using Biblioteca;

class Program
{

    static void Main(string[] args)
    {
        string nomeCompleto;
        DateTime dataNascimento;
        string opcao = string.Empty;

        try
        {
            OperacoesInterfaceGrafica operacoes = new();

            do
            {
                operacoes.Menu();
                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Console.WriteLine("Digite seu nome completo:");
                        nomeCompleto = Console.ReadLine();
                        Console.WriteLine($"Olá, {nomeCompleto}!");
                        Console.ReadKey();

                        break;

                    case "2":

                        Console.WriteLine("Digite sua data de nascimento:");
                        string auxDataNascimento = Console.ReadLine();
                        dataNascimento = Convert.ToDateTime(auxDataNascimento);
                        Console.WriteLine($"Você nasceu em {dataNascimento}");
                        Console.ReadKey();

                        break;
                    case "3":
                        Console.WriteLine("Saindo da aplicação...");
                        Console.ReadKey();

                        break;

                    default:
                        Console.WriteLine("Opção inválida");
                        Console.ReadKey();

                        break;
                }

                Console.Clear();
                //Console.WriteLine($" Olá, {nomeCompleto}, você nasceu em {dataNascimento}");
            }
            while (opcao != "3");
        }
        catch
        {
            Console.WriteLine("Erro na aplicação!!!");
        }
    }
}
