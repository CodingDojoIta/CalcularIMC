namespace ConsoleApplication
{
    public class Imc
    {
        public float calculoImc(float peso, float altura)
        {
            return peso / (altura * altura); // calcula IMC
        }

        public string classificacao(float imc)
        {
            var mensagem = "";
            
            if (imc <= 18.5)
                mensagem="Abaixo do peso";

            else if ((imc > 18.5) && (imc < 25))
                mensagem="Peso ideal (Parabéns)";

            else if ((imc >= 25) && (imc < 30))
                mensagem="Levemente acima do peso";

            else if ((imc >= 30) && (imc < 35))
                mensagem="Obesidade grau I";

            else if ((imc >= 35) && (imc < 40))
                mensagem="Obesidade grau II (severa)";

            else if (imc >= 40)
                mensagem="Obesidade Grau III (mórbida)";

            return mensagem;
        }
        
    }
}
