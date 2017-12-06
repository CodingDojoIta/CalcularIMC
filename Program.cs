using System;

namespace ConsoleApplication
{
    class Program
    {
        private static Imc _imc = new Imc();

        static void Main(string[] args)
        {
            float altura, peso, imc;

            Console.Write("Digite o seu peso: ");
            peso = float.Parse(Console.ReadLine()); // Solicita ao usuário que adicione o val

            Console.Write("Digite o seu altura: ");
            altura = float.Parse(Console.ReadLine().Replace('.', ',')); // Removo o ponto e adiciono a virgula, padrão brasileiro.

            imc = _imc.calculoImc(peso, altura); // Calculo o IMC de um metodo pertecente a classe Imc

            Console.WriteLine(
                "\r\n" +
                $"========================= Calcular IMC ========================= \r\n" +
                $"Seu IMC: {imc:F}\r\n" + // ':F' faz a limitação em duas casas decimais, e o \r\n pula uma linha no console.
                $"Sua Classificação: {_imc.classificacao(imc)}"); // Mostro a lista no console.

            Console.ReadKey(); // esse Método é apenas para evitar que o console feche após executar o programa.
        }

        
    }
}
