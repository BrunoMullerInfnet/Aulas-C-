using Biblioteca;


class Program
{
    static void Main(string[] args)
    {
        string nomeCompleto = "Richard JesUS Almeida Barros";
        string sobreNome;

        OperacoesTexto opTxt = new OperacoesTexto();

        opTxt.ImprimirMaiusculo(nomeCompleto);

        opTxt.ImprimirMaiusculo(nomeCompleto);

        opTxt.ImprimirNomeSobreNome(nomeCompleto);
        

        Console.WriteLine("Trabalhando com substring - Pegando Sobrenome:");

        sobreNome = nomeCompleto.Substring(nomeCompleto.IndexOf(" "));

        Console.WriteLine("Sobrenome: " + sobreNome);

        //Console.WriteLine(nomeCompleto.Substring(nomeCompleto.IndexOf(" "), nomeCompleto.Length));

        opTxt.ImprimirArray(nomeCompleto);


        Console.ReadLine();
    }
}