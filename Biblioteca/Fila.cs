using System.Collections;

namespace Biblioteca
{
    public class Fila<Pessoa>
    {
        private ArrayList array;

        public Fila()
        {
            array = new ArrayList();
        }

        public void ColocarNaFila(Pessoa pessoa)
        {
            array.Add(pessoa);
        }

        public void RetirarDaFila()
        {
            if (array.Count > 0)
            {
                if (array[0] is PessoaJuridica)
                {
                    Console.WriteLine($"Será removido:{((PessoaJuridica)array[0]).Cnpj}");
                }
                else
                {
                    Console.WriteLine($"Será removido:{((PessoaFisica)array[0]).Cpf}");
                }

                array.RemoveAt(0);
            }
        }

        public void ImprimirFila()
        {
            Console.WriteLine("Estão na Fila:");
            foreach (var fila in array)
            {
               if (fila is PessoaJuridica)
                {
                    Console.WriteLine($"Cnpj: {((PessoaJuridica)fila).Cnpj}");
                    Console.WriteLine($"Razão social: {((PessoaJuridica)fila).Cnpj}");
                }
                else
                {
                    Console.WriteLine($"Cpf: {((PessoaFisica)fila).Cpf}");
                    Console.WriteLine($"Nome:b{((PessoaFisica)fila).Nome}");
                    Console.WriteLine($"Nome:b{((PessoaFisica)fila).DataNascimento}");

                }
            }
        }
    }
}
