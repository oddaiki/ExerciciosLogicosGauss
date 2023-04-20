using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogicosGauss
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome, endereco, confirmacao;
            int idade = 0;

            List<string> dados= new List<string>();

            Console.WriteLine(" Digite seu nome: ");
            nome = Console.ReadLine();

            Console.WriteLine(" Digite a sua idade: ");
            idade = Convert.ToInt32(Console.ReadLine());

            if (idade >= 18)
            {
                Console.WriteLine(" Você é maior de idade!");
            }
            else
            {
                Console.WriteLine(" Você não é maior de idade." + " Ainda faltam " + (18 - idade) + " anos para atingir a maioridade penal.");
                Console.ReadKey();
            }

            Console.WriteLine(" Digite o seu endereço: ");
            endereco=Console.ReadLine();

            Console.WriteLine(" Esse endereço esta certo? " + endereco);
            Console.WriteLine(" Digite Sim ou Não: ");
            confirmacao=Console.ReadLine();

            if(confirmacao != "Não")
            {
                Console.WriteLine(" Digite novamente o seu endereço: ");
                endereco = Console.ReadLine();
            }

            Console.WriteLine("-> Veja as sua informações e verifique se estão corretas: ");
            dados.Add("1 - " + nome);
            dados.Add("2 - "+endereco);
            dados.Add("3 - "+Convert.ToString(idade)+" anos"); 

            foreach(string dado in dados)
            {
                Console.WriteLine(dado);
            }

            Console.WriteLine(" Legal né?! Quer fazer novamente? Digite Sim ou Não: ");
            confirmacao = Console.ReadLine();

            if(confirmacao != "Não")
            {
                Console.WriteLine("Até a próxima!!  :)");
            }
            else
            {
                Console.WriteLine("Vamos lá !!");
            }

            


            Console.ReadKey();
         

        }
    }
}
